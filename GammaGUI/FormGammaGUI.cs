using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.Configuration;
using System.Globalization;
using Ionic.Zip;
using System.Drawing.Printing;
using pdf = iTextSharp.text.pdf;
using txt = iTextSharp.text;

namespace GammaGUI
{    
    public partial class FormGammaGUI : Form
    {
        private const int LINES_IN_INP = 68;
        private const int IMAGE_INDEX_DETECTOR = 0;
        private const int IMAGE_INDEX_ARCHIVE = 1;
        private const int IMAGE_INDEX_BEAKER = 2;

        private Config config = null;
        private CDetectorMap detectors = null;
        private CBeakerMap beakers = null;
        private CDetector selectedDetector = null;
        private bool loaded_ok = false;
        private bool useDefaultPrinter = false;

        Dictionary<string, HashSet<string>> treemap = new Dictionary<string, HashSet<string>>();

        public FormGammaGUI()
        {
            InitializeComponent();

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;                        

            Log.initialize(ref textBoxMessages);
                        
            buttonMenuDetectors.Tag = (TabPage)pageSelDet;
            buttonMenuArchive.Tag = (TabPage)pageAnalArchive;            

            wizardMain.HideTabs = true;            
        }        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGammaGUI_Load(object sender, EventArgs e)
        {                        
            config = new Config();
            if (!config.LoadEnvironment())
                return;

            this.Text += " - " + config.Version;            

            useDefaultPrinter = Convert.ToBoolean(config.Settings["UseDefaultPrinter"]);

            labelAdminMaestroExecutable.Text = "Maestro executable: " + config.Settings["MaestroExecutable"];
            labelAdminMaestroConfig.Text = "Maestro configuration file: " + config.Settings["MaestroPickListFile"];
            labelAdminGenieFolder.Text = "Genie installation directorory: " + config.Settings["GenieFolder"];
            labelAdminGenieConfig.Text = "Genie configuration file: " + config.Settings["GeniePickListFile"];

            detectors = new CDetectorMap(config);
            beakers = new CBeakerMap(config);            

            if (!detectors.LoadAll())
            {
                MessageBox.Show("Loading detector information failed");
                return;
            }

            foreach (CDetector d in detectors.map.Values)
            {
                string nowYear = DateTime.Now.Year.ToString();
                int year = Convert.ToInt32(nowYear.Substring(2, 2));
                if (d.Year < year)
                {                    
                    d.Year = year;
                    d.SpectrumCounter = 0;
                    detectors.Save(d.Name, d.Dummy);
                }
            }

            displayDetectors();
            
            if (!beakers.LoadAll())
            {
                MessageBox.Show("Loading beaker information failed");
                return;
            }

            displayBeakers();

            cboxAdminDetChannels.ComboBox.Items.Add("");
            cboxReAnalSampChannels.ComboBox.Items.Add("");
            foreach (string s in config.ChannelCountList)
            {
                cboxAdminDetChannels.ComboBox.Items.Add(s);
                cboxReAnalSampChannels.ComboBox.Items.Add(s);
            }

            cboxAdminDetRecords.ComboBox.Items.Add("");
            foreach (string s in config.RecordLengthList)
                cboxAdminDetRecords.ComboBox.Items.Add(s);

            cboxAdminDetSpecFmt.ComboBox.Items.Add("");
            foreach (string s in config.SpectrumFormatList)
                cboxAdminDetSpecFmt.ComboBox.Items.Add(s);

            cboxAnalSampQuantUnit.ComboBox.Items.Add("");
            cboxReAnalSampQuantUnit.ComboBox.Items.Add("");
            foreach (string s in config.QuantityUnitList)
            {
                cboxAnalSampQuantUnit.ComboBox.Items.Add(s);
                cboxReAnalSampQuantUnit.ComboBox.Items.Add(s);
            }

            cboxReAnalSampMethod.ComboBox.Items.Add("");
            foreach (string s in config.AnalysisMethodList)
                cboxReAnalSampMethod.ComboBox.Items.Add(s);            

            dialogAdminDefNuclLib.Text = config.Settings.ContainsKey("DefaultNuclideLibrary") ? config.Settings["DefaultNuclideLibrary"] : "";            
            if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))
            {
                if (!File.Exists(config.SystemPathBin + dialogAdminDefNuclLib.Text))                
                    MessageBox.Show("The default nuclide library does not appear to exist." + Environment.NewLine + config.SystemPathBin + dialogAdminDefNuclLib.Text + Environment.NewLine + " Please make sure this value references the full path to an existsing file", "Warning");                
            }

            dialogAdminDefDetLib.Text = config.Settings.ContainsKey("DefaultDetectionLimitLibrary") ? config.Settings["DefaultDetectionLimitLibrary"] : "";            
            if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))
            {
                if (!File.Exists(config.SystemPathBin + dialogAdminDefDetLib.Text))                
                    MessageBox.Show("The default detection limit library does not appear to exist." + Environment.NewLine + config.SystemPathBin + dialogAdminDefDetLib.Text + Environment.NewLine + " Please make sure this value references the full path to an existsing file", "Warning");                
            }

            cbAdminEmulateFixCHN.Checked = config.Settings.ContainsKey("EmulateFixCHN") ? Convert.ToBoolean(config.Settings["EmulateFixCHN"]) : false;
            cbAdminUseDafaultPrinter.Checked = config.Settings.ContainsKey("UseDefaultPrinter") ? Convert.ToBoolean(config.Settings["UseDefaultPrinter"]) : true;            

            string str = null;
            foreach (string pef in config.PefFileList)
            {
                str = pef.Substring(0, pef.Length - 4) + ".TEF";
                if (!config.TefFileList.Contains(str))
                    Log.addWarning("Pef file " + pef + " does not appear to have a corresponding Tef file");
            }
            foreach (string tef in config.TefFileList)
            {
                str = tef.Substring(0, tef.Length - 4) + ".PEF";
                if (!config.PefFileList.Contains(str))
                    Log.addWarning("Tef file " + tef + " does not appear to have a corresponding Pef file");
            }

            labelReAnalPath.Text = String.Empty;
            statusLabel.Text = String.Empty;
            labelAdminDetDetector.Text = String.Empty;
            labelAdminBeaBeaker.Text = String.Empty;

            txtAdminScriptsStart.Text = config.Settings["MaestroScriptStart"].Trim();
            txtAdminScriptsStop.Text = config.Settings["MaestroScriptStop"].Trim();
            txtAdminScriptsBuffer.Text = config.Settings["MaestroScriptBuffer"].Trim();

            wizardMain_Resize(sender, null);                        

            Application.Idle += new EventHandler(Application_Idle);
            Activate();

            loaded_ok = true;
        }

        private void FormGammaGUI_Paint(object sender, PaintEventArgs e)
        {
            if (!loaded_ok)
                Close();
        }        

        protected void Application_Idle(object sender, EventArgs e)
        {                 
            if (wizardMain.SelectedTab == pageAnal)
            {
                if (selectedDetector != null)
                {
                    if (selectedDetector.Active)
                    {
                        if (!buttonAnalStop.Visible)
                            buttonAnalStop.Visible = true;
                        if (!buttonAnalBuffer.Visible)
                            buttonAnalBuffer.Visible = true;
                        if (buttonAnalStart.Visible)
                            buttonAnalStart.Visible = false;
                    }
                    else
                    {
                        if (buttonAnalStop.Visible)
                            buttonAnalStop.Visible = false;
                        if (buttonAnalBuffer.Visible)
                            buttonAnalBuffer.Visible = false;
                        if (!buttonAnalStart.Visible)
                            buttonAnalStart.Visible = true;
                    }
                }
            }
            else if (wizardMain.SelectedTab == pageAdmin)
            {
                if (tabControlAdmin.SelectedTab == pageAdminDetectors)
                {                                        
                    if (!buttonAdminAddDummyDetector.Visible)
                        buttonAdminAddDummyDetector.Visible = true;                    
                }
                else
                {                                        
                    if (buttonAdminAddDummyDetector.Visible)
                        buttonAdminAddDummyDetector.Visible = false;                    
                }

                if (tabControlAdmin.SelectedTab == pageAdminBeaker)
                {
                    if (!buttonAdminAddBeaker.Visible)
                        buttonAdminAddBeaker.Visible = true;
                }
                else
                {
                    if (buttonAdminAddBeaker.Visible)
                        buttonAdminAddBeaker.Visible = false;
                }
            }
            else if (wizardMain.SelectedTab == pageAnalArchive)
            {
                if ((treeArchive.SelectedNode == null || treeArchive.SelectedNode.Level != 1) && buttonCreateJournal.Enabled)
                    buttonCreateJournal.Enabled = false;
                else if(treeArchive.SelectedNode != null && treeArchive.SelectedNode.Level == 1 && !buttonCreateJournal.Enabled)
                    buttonCreateJournal.Enabled = true;
            }
        }                

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process help = new Process();
            help.StartInfo.FileName = config.SpecExecutablePath + "docs\\Spek10.doc";
            help.Start();
        }

        private void wizardMain_Resize(object sender, EventArgs e)
        {            
            flowMenu.Left = (wizardMain.Width / 2) - (flowMenu.Width / 2);
            flowMenu.Top = (wizardMain.Height / 2) - (flowMenu.Height / 2);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            wizardMain.SelectedTab = pageMenu;
        }

        private void buttonStartStopViewBack_Click(object sender, EventArgs e)
        {
            wizardMain.SelectedTab = pageSelDet;
        }        

        private void FillDefaultAnalParametersWithSelectedDetector()
        {
            if(selectedDetector == null)
            {
                MessageBox.Show("No detector was selected", "Error");
                return;
            }

            EmptyAnalFields();

            if (selectedDetector.Active)
            {
                int newSpecNum = selectedDetector.SpectrumCounter + 1;
                string inp_file = config.SystemPathBinWork + selectedDetector.Name + selectedDetector.Year.ToString() + String.Format("{0:0000}", newSpecNum) + ".INP";
                if (!File.Exists(inp_file))
                {
                    MessageBox.Show("The input file " + inp_file + " was not found. You must fill in the input parameters manually", "Message");
                    txtAnalDetector.Text = selectedDetector.Name;
                    txtAnalYear.Text = String.Format("{0:00}", selectedDetector.Year);                    
                    txtAnalSpecNum.Text = String.Format("{0:0000}", newSpecNum);
                    txtAnalQuantityUncertainty.Text = "0.0";
                    txtAnalFWHMPS.Text = Utils.MakeFloat(selectedDetector.FWHMPS.ToString());
                    txtAnalFWHMAN.Text = Utils.MakeFloat(selectedDetector.FWHMAN.ToString());
                    txtAnalTHRESH.Text = Utils.MakeFloat(selectedDetector.THRESH.ToString());
                    txtAnalBSTF.Text = Utils.MakeFloat(selectedDetector.BSTF.ToString());
                    txtAnalETOL.Text = Utils.MakeFloat(selectedDetector.ETOL.ToString());
                    txtAnalLOCH.Text = Utils.MakeFloat(selectedDetector.LOCH.ToString());
                    cbAnalICA.Checked = (selectedDetector.ICA == 0 ? false : true);
                    dialogAnalBackgroundFile.Text = selectedDetector.DefaultBackgroundFile;
                    dialogAnalEnergyFile.Text = selectedDetector.DefaultEnergyCalibrationFile;
                    if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))                    
                        dialogAnalNuclLib.Text = Path.GetFileName(dialogAdminDefNuclLib.Text);                    
                    if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))                    
                        dialogAnalDetLimLib.Text = Path.GetFileName(dialogAdminDefDetLib.Text);                    
                }
                else
                {
                    string line;
                    List<string> lines = new List<string>();
                    StreamReader reader = new StreamReader(inp_file, Encoding.GetEncoding(865));
                    while ((line = reader.ReadLine()) != null)
                        lines.Add(line);
                    reader.Close();

                    if (lines.Count < LINES_IN_INP)
                    {
                        MessageBox.Show("The file " + inp_file + " contains too few lines. You must fill in the input parameters manually", "Message");
                        File.Delete(inp_file);
                        txtAnalDetector.Text = selectedDetector.Name;
                        txtAnalYear.Text = String.Format("{0:00}", selectedDetector.Year);
                        txtAnalSpecNum.Text = String.Format("{0:0000}", newSpecNum);
                        txtAnalQuantityUncertainty.Text = "0.0";
                        txtAnalFWHMPS.Text = Utils.MakeFloat(selectedDetector.FWHMPS.ToString());
                        txtAnalFWHMAN.Text = Utils.MakeFloat(selectedDetector.FWHMAN.ToString());
                        txtAnalTHRESH.Text = Utils.MakeFloat(selectedDetector.THRESH.ToString());
                        txtAnalBSTF.Text = Utils.MakeFloat(selectedDetector.BSTF.ToString());
                        txtAnalETOL.Text = Utils.MakeFloat(selectedDetector.ETOL.ToString());
                        txtAnalLOCH.Text = Utils.MakeFloat(selectedDetector.LOCH.ToString());
                        cbAnalICA.Checked = (selectedDetector.ICA == 0 ? false : true); 
                        dialogAnalBackgroundFile.Text = selectedDetector.DefaultBackgroundFile;
                        dialogAnalEnergyFile.Text = selectedDetector.DefaultEnergyCalibrationFile;
                        if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))
                            dialogAnalNuclLib.Text = Path.GetFileName(dialogAdminDefNuclLib.Text);
                        if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))
                            dialogAnalDetLimLib.Text = Path.GetFileName(dialogAdminDefDetLib.Text);
                    }
                    else
                    {
                        txtAnalSpecNum.Text = lines[0];
                        txtAnalSampleId.Text = lines[1];
                        //txtAnalProject.Text = lines[2];
                        txtAnalSamplePlace.Text = lines[3];
                        //txtAnalLatitude.Text = lines[4];
                        //txtAnalLatitudeDir.Text = lines[5];
                        //txtAnalLongitude.Text = lines[6];
                        //txtAnalLongitudeDir.Text = lines[7];
                        txtAnalHeight.Text = Utils.MakeFloat(lines[8]);
                        txtAnalWeight.Text = Utils.MakeFloat(lines[9]);
                        txtAnalDensity.Text = Utils.MakeFloat(lines[10]);
                        txtAnalVolume.Text = Utils.MakeFloat(lines[11]);
                        txtAnalQuantity.Text = Utils.MakeFloat(lines[12]);
                        txtAnalQuantityUncertainty.Text = Utils.MakeFloat(lines[13]);
                        cboxAnalSampQuantUnit.ComboBox.SelectedIndex = cboxReAnalSampQuantUnit.ComboBox.FindString(lines[14]);
                        txtAnalDetector.Text = lines[15];
                        txtAnalYear.Text = lines[16];
                        cboxAnalSampBeaker.ComboBox.SelectedIndex = cboxReAnalSampBeaker.ComboBox.FindString(lines[17]);
                        txtAnalSamplingStart.Text = lines[18];
                        txtAnalSamplingStop.Text = lines[19];
                        txtAnalReferenceTime.Text = lines[20];
                        //txtAnalMeasurementStart.Text = lines[21];
                        //txtReAnalMeasurementStop.Text = lines[22];
                        //txtReAnalRealtime.Text = lines[23];
                        //txtReAnalLivetime.Text = lines[24];
                        //txtAnalMeasurementTime.Text = lines[25];
                        //txtAnalDeadtime.Text = Utils.MakeFloat(lines[26]);
                        dialogAnalNuclLib.Text = lines[27];
                        dialogAnalDetLimLib.Text = lines[28];
                        //cboxAnalSampChannels.ComboBox.SelectedIndex = cboxReAnalSampChannels.ComboBox.FindStringExact(lines[29]);
                        //txtAnalFormat.Text = lines[30];
                        //txtAnalRecLen.Text = lines[31];
                        txtAnalFWHMPS.Text = Utils.MakeFloat(lines[32]);
                        txtAnalFWHMAN.Text = Utils.MakeFloat(lines[33]);
                        txtAnalTHRESH.Text = Utils.MakeFloat(lines[34]);
                        txtAnalBSTF.Text = Utils.MakeFloat(lines[35]);
                        txtAnalETOL.Text = Utils.MakeFloat(lines[36]);
                        txtAnalLOCH.Text = Utils.MakeFloat(lines[37]);
                        cbAnalICA.Checked = (lines[38] == "0" ? false : true);
                        dialogAnalEnergyFile.Text = lines[39];
                        dialogAnalPEFFile.Text = lines[40];
                        dialogAnalTEFFile.Text = lines[41];
                        dialogAnalBackgroundFile.Text = lines[42];
                    }
                }
            }
            else
            {
                txtAnalDetector.Text = selectedDetector.Name;
                txtAnalYear.Text = String.Format("{0:00}", selectedDetector.Year);
                int newSpecNum = selectedDetector.SpectrumCounter + 1;
                txtAnalSpecNum.Text = String.Format("{0:0000}", newSpecNum);
                txtAnalQuantityUncertainty.Text = "0.0";
                txtAnalFWHMPS.Text = Utils.MakeFloat(selectedDetector.FWHMPS.ToString());
                txtAnalFWHMAN.Text = Utils.MakeFloat(selectedDetector.FWHMAN.ToString());
                txtAnalTHRESH.Text = Utils.MakeFloat(selectedDetector.THRESH.ToString());
                txtAnalBSTF.Text = Utils.MakeFloat(selectedDetector.BSTF.ToString());
                txtAnalETOL.Text = Utils.MakeFloat(selectedDetector.ETOL.ToString());
                txtAnalLOCH.Text = Utils.MakeFloat(selectedDetector.LOCH.ToString());
                cbAnalICA.Checked = (selectedDetector.ICA == 0 ? false : true);
                dialogAnalBackgroundFile.Text = selectedDetector.DefaultBackgroundFile;
                dialogAnalEnergyFile.Text = selectedDetector.DefaultEnergyCalibrationFile;
                if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))                
                    dialogAnalNuclLib.Text = Path.GetFileName(dialogAdminDefNuclLib.Text);                
                if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))                
                    dialogAnalDetLimLib.Text = Path.GetFileName(dialogAdminDefDetLib.Text);                                
            }                        
        }

        private void FillDefaultReAnalParametersWithSelectedDetector()
        {
            if (selectedDetector == null)
            {
                MessageBox.Show("No detector is selected", "Error");
                return;
            }

            EmptyReAnalFields();

            string specfile = Path.GetFileNameWithoutExtension(labelReAnalPath.Text);
            string detname = specfile.Substring(0, 2);
            string year = specfile.Substring(2, 2);
            string specnr = specfile.Substring(4, 4);
            CDetector detector = selectedDetector;            
            CHN_Header header = new CHN_Header();
            header.Read(labelReAnalPath.Text, true); 
           
            txtReAnalDetector.Text = detname;
            txtReAnalYear.Text = year;
            txtReAnalSpecnum.Text = specnr;
            txtReAnalQuantityUncertainty.Text = "0.0";
            txtReAnalMeasurementStart.Text = header.MeasurementStart;
            txtReAnalMeasurementStop.Text = header.MeasurementStop;
            txtReAnalMeasurementTime.Text = "0";
            txtReAnalRealtime.Text = Convert.ToInt32(header.RealTimeSeconds).ToString();
            txtReAnalLivetime.Text = Convert.ToInt32(header.LiveTimeSeconds).ToString();
            txtReAnalDeadtime.Text = String.Format("{0:0.0}", header.DeadTime);
            txtReAnalFWHMPS.Text = Utils.MakeFloat(detector.FWHMPS.ToString());
            txtReAnalFWHMAN.Text = Utils.MakeFloat(detector.FWHMAN.ToString());
            txtReAnalTHRESH.Text = Utils.MakeFloat(detector.THRESH.ToString());
            txtReAnalBSTF.Text = Utils.MakeFloat(detector.BSTF.ToString());
            txtReAnalETOL.Text = Utils.MakeFloat(detector.ETOL.ToString());
            txtReAnalLOCH.Text = Utils.MakeFloat(detector.LOCH.ToString());
            cbReAnalICA.Checked = (detector.ICA == 0 ? false : true);
            cboxReAnalSampMethod.ComboBox.SelectedIndex = cboxReAnalSampMethod.ComboBox.FindStringExact(detector.AnalysisMethod);
            cboxReAnalSampChannels.ComboBox.SelectedIndex = cboxReAnalSampChannels.ComboBox.FindStringExact(detector.Channels.ToString());
            txtReAnalRecLen.Text = detector.BytesPerRecord.ToString();
            dialogReAnalBackgroundFile.Text = detector.DefaultBackgroundFile;
            dialogReAnalEnergyFile.Text = detector.DefaultEnergyCalibrationFile;
            txtReAnalFormat.Text = detector.Format;
            if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))
                dialogReAnalNuclLib.Text = Path.GetFileName(dialogAdminDefNuclLib.Text);
            if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))
                dialogReAnalDetLimLib.Text = Path.GetFileName(dialogAdminDefDetLib.Text);                    
        }

        private void buttonAnalStart_Click(object sender, EventArgs e)
        {
            cboxAnalSampBeaker.Focus();                                    

            if (selectedDetector == null)
            {
                MessageBox.Show("No detector is selected", "Error");
                return;
            }

            string specsoft = selectedDetector.SpectrumSoftware.Trim();

            if (specsoft == "Maestro" && !config.MaestroExists())            
            {
                MessageBox.Show("Maestro executable was not found. Please run Maestro setup before continuing", "Error");
                return;
            }
            else if (specsoft == "Genie" && !config.GenieExists())
            {
                MessageBox.Show("Genie executable was not found. Please run Genie setup before continuing", "Error");
                return;
            }                        

            if (!ValidateAnalFields())
                return;

            CBeaker beaker = beakers[cboxAnalSampBeaker.Text];

            float height = Convert.ToSingle(txtAnalHeight.Text);
            if (height > beaker.MaxFillHeight)
            {
                MessageBox.Show("Max fill height for beaker " + beaker.Name + " is " + beaker.MaxFillHeight.ToString(), "Message");
                return;
            }
            else if (height < beaker.MinFillHeight)
            {
                MessageBox.Show("Min fill height for beaker " + beaker.Name + " is " + beaker.MinFillHeight.ToString(), "Message");
                return;
            }

            string iobuff_file = String.Empty, job_file = String.Empty;
            
            try
            {
                iobuff_file = config.SystemPathBinWork + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + ".INP";
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);

                StreamWriter writer = new StreamWriter(iobuff_file, false, Encoding.GetEncoding(865));
                writer.WriteLine(txtAnalSpecNum.Text);
                writer.WriteLine(txtAnalSampleId.Text);
                writer.WriteLine(""); // project
                writer.WriteLine(txtAnalSamplePlace.Text);
                writer.WriteLine("0.00000000000000e+000"); // latitude
                writer.WriteLine("N"); // latitude_unit
                writer.WriteLine("0.00000000000000e+000"); // longitude
                writer.WriteLine("E"); // longitude_unit
                writer.WriteLine(txtAnalHeight.Text);
                writer.WriteLine(txtAnalWeight.Text);
                writer.WriteLine(txtAnalDensity.Text);
                writer.WriteLine(txtAnalVolume.Text);                
                writer.WriteLine(txtAnalQuantity.Text);
                writer.WriteLine(txtAnalQuantityUncertainty.Text);
                writer.WriteLine(cboxAnalSampQuantUnit.Text);
                writer.WriteLine(txtAnalDetector.Text);
                writer.WriteLine(txtAnalYear.Text);
                writer.WriteLine(cboxAnalSampBeaker.Text);
                writer.WriteLine(txtAnalSamplingStart.Text);
                writer.WriteLine(txtAnalSamplingStop.Text);
                writer.WriteLine(txtAnalReferenceTime.Text);
                writer.WriteLine(); // measurement start
                writer.WriteLine(); // measurement stop
                writer.WriteLine(); // realtime
                writer.WriteLine(); // livetime
                writer.WriteLine("0"); // measurement time
                writer.WriteLine(); // deadtime
                writer.WriteLine(dialogAnalNuclLib.Text);
                writer.WriteLine(dialogAnalDetLimLib.Text.Trim());
                writer.WriteLine(selectedDetector.Channels.ToString());
                writer.WriteLine(selectedDetector.Format);
                writer.WriteLine(selectedDetector.BytesPerRecord.ToString()); 
                writer.WriteLine(txtAnalFWHMPS.Text);
                writer.WriteLine(txtAnalFWHMAN.Text);
                writer.WriteLine(txtAnalTHRESH.Text);
                writer.WriteLine(txtAnalBSTF.Text);
                writer.WriteLine(txtAnalETOL.Text);
                writer.WriteLine(txtAnalLOCH.Text);
                writer.WriteLine(cbAnalICA.Checked ? "1" : "0");
                writer.WriteLine(dialogAnalEnergyFile.Text);
                writer.WriteLine(dialogAnalPEFFile.Text);
                writer.WriteLine(dialogAnalTEFFile.Text);
                writer.WriteLine(dialogAnalBackgroundFile.Text);
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("1");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");                
                writer.Close();

                if (specsoft == "Maestro")
                {
                    job_file = config.SystemPathBin + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + "_start.job";
                    StreamWriter jwriter = new StreamWriter(job_file);
                    string[] delimiters = { Environment.NewLine };
                    string[] lines = txtAdminScriptsStart.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string scriptLine = "";
                    foreach (string l in lines)
                    {
                        scriptLine = l.Replace("@DID", selectedDetector.ID.ToString());
                        scriptLine = scriptLine.Replace("@SAVE_FILE", config.SystemPathBin + "SP_BUFF");
                        scriptLine = scriptLine.Replace("@BUFFER_FILE", config.SystemPathBin + "SP_BUFF_TEMP");
                        jwriter.WriteLine(scriptLine);
                    }
                    jwriter.Close();
                }

                Process p = new Process();
                if (specsoft == "Maestro")
                {
                    p.StartInfo.FileName = config.Settings["MaestroExecutable"];
                    p.StartInfo.Arguments = job_file;
                }
                else if (specsoft == "Genie")
                {
                    p.StartInfo.FileName = config.Settings["GenieFolder"] + "\\EXEFILES\\startmca.exe";
                    p.StartInfo.Arguments = "Det:" + selectedDetector.Name + " /LIVEPRESET=0 /REALPRESET=0";
                }
                p.StartInfo.WorkingDirectory = config.SystemPathBin;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                statusLabel.Text = "Running " + specsoft + ". Please wait...";
                splitterNewAnal.Enabled = false;
                Application.DoEvents();

                p.Start();
                p.WaitForExit();                

                if (p.ExitCode != 0)
                {
                    statusLabel.Text = specsoft + " failed while running script";
                    return;
                }
                else statusLabel.Text = specsoft + " finished successfully";

                selectedDetector.Active = true;
                detectors.Save(selectedDetector.Name, selectedDetector.Dummy);
                displayDetectors();                

                Log.addMessage(specsoft + " was started successfully for spectrum " + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                Log.addError(ex.Message);
            }
            finally
            {
                splitterNewAnal.Enabled = true;
                if (!String.IsNullOrEmpty(job_file) && File.Exists(job_file))
                    File.Delete(job_file);
            }
        }

        private void buttonAnalStop_Click(object sender, EventArgs e)
        {
            cboxAnalSampBeaker.Focus();            

            if (selectedDetector == null)
            {
                MessageBox.Show("No detector is selected", "Error");
                return;
            }

            string specsoft = selectedDetector.SpectrumSoftware.Trim();

            if (specsoft == "Maestro" && !config.MaestroExists())
            {
                MessageBox.Show("Maestro executable was not found. Please run Maestro setup before continuing", "Error");
                return;
            }
            else if (specsoft == "Genie" && !config.GenieExists())
            {
                MessageBox.Show("Genie executable was not found. Please run Genie setup before continuing", "Error");
                return;
            }            

            if (!ValidateAnalFields())
                return;

            CBeaker beaker = beakers[cboxAnalSampBeaker.Text];

            float height = Convert.ToSingle(txtAnalHeight.Text);
            if (height > beaker.MaxFillHeight)
            {
                MessageBox.Show("Max fill height for beaker " + beaker.Name + " is " + beaker.MaxFillHeight.ToString(), "Message");
                return;
            }
            else if (height < beaker.MinFillHeight)
            {
                MessageBox.Show("Min fill height for beaker " + beaker.Name + " is " + beaker.MinFillHeight.ToString(), "Message");
                return;
            }            

            if (specsoft == "Maestro" && !config.DetectorIdExists(selectedDetector.ID))
            {
                MessageBox.Show("The detector ID " + selectedDetector.ID.ToString() + " is not defined by Maestro", "Error");                
                return;
            }

            if (!Directory.Exists(config.SystemPathSpec + txtAnalYear.Text))
                Directory.CreateDirectory(config.SystemPathSpec + txtAnalYear.Text);                

            string job_file = String.Empty;
            string res_file = txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + ".LIS";
            string res_path_file = config.SystemPathSpec + txtAnalYear.Text + "\\" + res_file;

            try
            {
                if (File.Exists(config.SystemPathBin + "SP_BUFF.$$$"))
                    File.Delete(config.SystemPathBin + "SP_BUFF.$$$");

                if (specsoft == "Maestro")
                {
                    job_file = config.SystemPathBin + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + "_stop.job";
                    StreamWriter jwriter = new StreamWriter(job_file);
                    string[] delimiters = { Environment.NewLine };
                    string[] lines = txtAdminScriptsStop.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string scriptLine = "";
                    foreach (string l in lines)
                    {
                        scriptLine = l.Replace("@DID", selectedDetector.ID.ToString());
                        scriptLine = scriptLine.Replace("@SAVE_FILE", config.SystemPathBin + "SP_BUFF");
                        scriptLine = scriptLine.Replace("@BUFFER_FILE", config.SystemPathBin + "SP_BUFF_TEMP");
                        jwriter.WriteLine(scriptLine);
                    }
                    jwriter.Close();
                }

                Process p = new Process();
                if (specsoft == "Maestro")
                {
                    p.StartInfo.FileName = config.Settings["MaestroExecutable"];
                    p.StartInfo.Arguments = job_file;
                }
                else if (specsoft == "Genie")
                {
                    p.StartInfo.FileName = config.Settings["GenieFolder"] + "\\EXEFILES\\stopmca.exe";
                    p.StartInfo.Arguments = "Det:" + selectedDetector.Name;
                }
                p.StartInfo.WorkingDirectory = config.SystemPathBin;
                p.StartInfo.UseShellExecute = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;                

                statusLabel.Text = "Running " + specsoft + ". Please wait...";
                splitterNewAnal.Enabled = false;
                Application.DoEvents();

                p.Start();
                p.WaitForExit();                

                if (p.ExitCode == 0)
                    statusLabel.Text = specsoft + " finished sucessfully";
                else
                {
                    statusLabel.Text = specsoft + " failed with exit code " + p.ExitCode.ToString();
                    Log.addError(specsoft + " failed with exit code " + p.ExitCode.ToString());
                    return;
                }

                if (specsoft == "Maestro")
                {
                    File.Copy(config.SystemPathBin + "SP_BUFF.Chn", config.SystemPathBin + "SP_BUFF.$$$", true);
                }
                else if (specsoft == "Genie")
                {
                    p = new Process();
                    p.StartInfo.FileName = config.Settings["GenieFolder"] + "\\EXEFILES\\Analyze.exe";
                    p.StartInfo.Arguments = "Det:" + selectedDetector.Name + " /SEQ=" + config.Settings["GenieFolder"] + "\\CTLFILES\\Spek10rap.ASF";
                    p.StartInfo.WorkingDirectory = config.SystemPathBin;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    statusLabel.Text = "Running Genie (Analyze.exe). Please wait...";
                    Application.DoEvents();

                    p.Start();
                    p.WaitForExit();

                    if (p.ExitCode == 0)
                        statusLabel.Text = "Genie (Analyze.exe) finished sucessfully";
                    else
                    {
                        statusLabel.Text = "Genie (Analyze.exe) failed. Exit code " + p.ExitCode.ToString();
                        Log.addError("Genie (Analyze.exe) failed. Exit code " + p.ExitCode.ToString());
                        return;
                    }

                    File.Copy(config.Settings["GenieFolder"] + "\\REPFILES\\" + selectedDetector.Name + ".RPT", config.SystemPathBin + "CAN_REP.$$$", true);

                    // CAN_REP.$$$ -> SP_BUFF.$$$
                    p = new Process();
                    p.StartInfo.FileName = config.SystemPathBin + "cancon.exe";
                    p.StartInfo.WorkingDirectory = config.SystemPathBin;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    statusLabel.Text = "Running cancon.exe. Please wait...";
                    Application.DoEvents();

                    p.Start();
                    p.WaitForExit();

                    if (p.ExitCode == 0)
                        statusLabel.Text = "cancon.exe finished sucessfully";
                    else
                    {
                        statusLabel.Text = "cancon.exe failed. Exit code " + p.ExitCode.ToString();
                        Log.addError("cancon.exe failed. Exit code " + p.ExitCode.ToString());
                        return;
                    }
                }

                File.Copy(config.SystemPathBin + "SP_BUFF.$$$", res_path_file.Substring(0, res_path_file.Length - 4) + ".CHN", true);                

                selectedDetector.Active = false;
                detectors.Save(selectedDetector.Name, selectedDetector.Dummy);
                displayDetectors();

                UpdateHistory(res_path_file.Substring(0, res_path_file.Length - 4) + ".CHN", txtAnalDetector.Text, txtAnalYear.Text, txtAnalSpecNum.Text, txtAnalSampleId.Text);

                Log.addMessage(specsoft + " was stopped successfully for spectrum " + res_file.Substring(0, res_file.Length - 4));
            }
            catch (Exception ex)
            {
                splitterNewAnal.Enabled = true;
                MessageBox.Show(ex.Message, "Exception");
                Log.addError(ex.Message);
                return;
            }
            finally
            {
                if (specsoft == "Maestro")
                {
                    if (!String.IsNullOrEmpty(job_file) && File.Exists(job_file))
                        File.Delete(job_file);
                    if (File.Exists(config.SystemPathBin + "SP_BUFF.Chn"))
                        File.Delete(config.SystemPathBin + "SP_BUFF.Chn");
                }
                else if (specsoft == "Genie")
                {
                    if (File.Exists(config.SystemPathBin + "CAN_REP.$$$"))
                        File.Delete(config.SystemPathBin + "CAN_REP.$$$");
                    if (File.Exists(config.SystemPathBin + "BUFFER.TXT"))
                        File.Delete(config.SystemPathBin + "BUFFER.TXT");
                    if (File.Exists(config.SystemPathBin + "DUMMY.DAT"))
                        File.Delete(config.SystemPathBin + "DUMMY.DAT");
                }
            }

            string iobuff_file = String.Empty;            

            try
            {                
                CHN_Header header = new CHN_Header();
                header.Read(config.SystemPathBin + "SP_BUFF.$$$", true);

                iobuff_file = config.SystemPathBin + "IO_BUFF.$$$";
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);

                StreamWriter writer = new StreamWriter(iobuff_file, false, Encoding.GetEncoding(865));
                writer.WriteLine(txtAnalSpecNum.Text);
                writer.WriteLine(txtAnalSampleId.Text);
                writer.WriteLine(""); // project
                writer.WriteLine(txtAnalSamplePlace.Text);
                writer.WriteLine("0.00000000000000e+000"); // latitude
                writer.WriteLine("N"); // latitude_unit
                writer.WriteLine("0.00000000000000e+000"); // longitude
                writer.WriteLine("E"); // longitude_unit
                writer.WriteLine(txtAnalHeight.Text);
                writer.WriteLine(txtAnalWeight.Text);
                writer.WriteLine(txtAnalDensity.Text);
                writer.WriteLine(txtAnalVolume.Text);                
                writer.WriteLine(txtAnalQuantity.Text);
                writer.WriteLine(txtAnalQuantityUncertainty.Text);
                writer.WriteLine(cboxAnalSampQuantUnit.Text);
                writer.WriteLine(txtAnalDetector.Text);
                writer.WriteLine(txtAnalYear.Text);
                writer.WriteLine(cboxAnalSampBeaker.Text);
                writer.WriteLine(txtAnalSamplingStart.Text);
                writer.WriteLine(txtAnalSamplingStop.Text);
                writer.WriteLine(txtAnalReferenceTime.Text);
                writer.WriteLine(header.MeasurementStart); // txtAnalMeasurementStart.Text
                writer.WriteLine(header.MeasurementStop); // txtAnalMeasurementStop.Text
                writer.WriteLine(((int)header.RealTimeSeconds).ToString()); // txtAnalRealtime.Text
                writer.WriteLine(((int)header.LiveTimeSeconds).ToString()); // txtAnalLivetime.Text
                writer.WriteLine("0"); // txtAnalMeasurementTime.Text
                writer.WriteLine(header.DeadTime.ToString()); // txtAnalDeadtime.Text
                writer.WriteLine(dialogAnalNuclLib.Text);
                writer.WriteLine(dialogAnalDetLimLib.Text.Trim());
                writer.WriteLine(selectedDetector.Channels.ToString());
                writer.WriteLine(selectedDetector.Format);
                writer.WriteLine(selectedDetector.BytesPerRecord.ToString());
                writer.WriteLine(txtAnalFWHMPS.Text);
                writer.WriteLine(txtAnalFWHMAN.Text);
                writer.WriteLine(txtAnalTHRESH.Text);
                writer.WriteLine(txtAnalBSTF.Text);
                writer.WriteLine(txtAnalETOL.Text);
                writer.WriteLine(txtAnalLOCH.Text);
                writer.WriteLine(cbAnalICA.Checked ? "1" : "0");
                writer.WriteLine(dialogAnalEnergyFile.Text);
                writer.WriteLine(dialogAnalPEFFile.Text);
                writer.WriteLine(dialogAnalTEFFile.Text);
                writer.WriteLine(dialogAnalBackgroundFile.Text);
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("1");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");                                
                writer.Close();

                if (File.Exists(iobuff_file))
                    File.Copy(iobuff_file, res_path_file.Substring(0, res_path_file.Length - 4) + ".INP", true);                

                if (File.Exists(config.SystemPathBin + "PLOT-1.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-1.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-2.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-2.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-3.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-3.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-4.HPL");

                Process pg = new Process();
                pg.StartInfo.FileName = config.GammaExecutableFile;
                pg.StartInfo.WorkingDirectory = Path.GetDirectoryName(config.GammaExecutableFile);
                pg.StartInfo.CreateNoWindow = true;
                pg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pg.StartInfo.UseShellExecute = false;
                pg.StartInfo.RedirectStandardOutput = true;
                pg.StartInfo.RedirectStandardError = true;                

                string gamma_exe = Path.GetFileName(config.GammaExecutableFile);

                statusLabel.Text = "Running " + gamma_exe + ". Please wait...";
                splitterNewAnal.Enabled = false;
                Application.DoEvents();
                
                pg.Start();

                string cout = pg.StandardOutput.ReadToEnd();
                string cerr = pg.StandardError.ReadToEnd();

                pg.WaitForExit();

                if (pg.ExitCode == 0)
                    repairLIS(config.SystemPathBin + res_file, dialogAnalDetLimLib.Text.Trim());

                statusLabel.Text = (pg.ExitCode == 0 ? gamma_exe + " finished successfully" : gamma_exe + " failed with exit code " + pg.ExitCode.ToString());

                FormGammaGUI_AnalResult form = new FormGammaGUI_AnalResult(res_path_file.Substring(0, res_path_file.Length - 4) + ".CHN");
                form.Text = "Analysis results from " + gamma_exe;
                form.SetGammaContent("Exit code: " + pg.ExitCode.ToString() + Environment.NewLine + Environment.NewLine
                    + "Standard output: " + Environment.NewLine + cout + Environment.NewLine + Environment.NewLine
                    + "Standard error: " + Environment.NewLine + cerr);
                if (File.Exists(config.SystemPathBin + res_file))
                    form.SetLISContent(File.ReadAllText(config.SystemPathBin + res_file, Encoding.GetEncoding(865)));
                if (File.Exists(iobuff_file))
                    form.SetINPContent(File.ReadAllText(iobuff_file, Encoding.GetEncoding(865)));
                form.SetGammaExitCode(pg.ExitCode);
                form.ShowDialog();

                if (pg.ExitCode == 0)
                {
                    // analysing was successfull, store results...
                    if (!form.Rejected)
                    {
                        if (File.Exists(config.SystemPathBin + res_file))
                            File.Copy(config.SystemPathBin + res_file, res_path_file, true);

                        if (File.Exists(config.SystemPathBin + "PLOT-1.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-2.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-3.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                        {
                            ZipFile zip = new ZipFile();
                            zip.AddFile(config.SystemPathBin + "PLOT-1.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-2.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-3.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-4.HPL", "");
                            zip.Save(res_path_file.Substring(0, res_path_file.Length - 4) + ".ZIP");
                        }
                    }

                    if (form.PrintPlot)
                    {
                        if (File.Exists(config.SystemPathBin + "PLOT-1.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-2.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-3.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                        {                            
                            statusLabel.Text = "Printing analysis...";
                            Application.DoEvents();

                            string lis_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".LIS";
                            string plot_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_2 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_3 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_4 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";

                            File.Copy(config.SystemPathBin + res_file, lis_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-1.HPL", plot_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-2.HPL", plot_file_2, true);
                            File.Copy(config.SystemPathBin + "PLOT-3.HPL", plot_file_3, true);
                            File.Copy(config.SystemPathBin + "PLOT-4.HPL", plot_file_4, true);
                                                        
                            try
                            {                                
                                if (!Utils.PrintReport(lis_file_1, plot_file_1, plot_file_2, plot_file_3, plot_file_4, useDefaultPrinter))                            
                                    MessageBox.Show("Printing failed. Make sure a printer is online and available", "Message");                                                                
                            }
                            finally
                            {
                                splitterNewAnal.Enabled = true;
                                statusLabel.Text = "Done printing";
                                Application.DoEvents();                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("No plot files found. Can not print", "Error");                            
                        }
                    }                    

                    Log.addMessage("Running " + gamma_exe + " on spectrum " + res_file.Substring(0, res_file.Length - 4) + " was a success");
                }
                else
                {
                    Log.addError("Running " + gamma_exe + " on spectrum " + res_file.Substring(0, res_file.Length - 4) + " failed");
                }

                if (form.Rejected)
                {
                    DialogResult result = MessageBox.Show("Do you want to delete the spectrum from the archive?", "Message", MessageBoxButtons.YesNo);
                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        selectedDetector.SpectrumCounter++;
                        detectors.Save(selectedDetector.Name, selectedDetector.Dummy);
                        displayDetectors();
                    }
                    else
                    {
                        File.Delete(res_path_file.Substring(0, res_path_file.Length - 4) + ".CHN");
                    }
                }
                else
                {
                    selectedDetector.SpectrumCounter++;
                    detectors.Save(selectedDetector.Name, selectedDetector.Dummy);
                    displayDetectors();
                }

                wizardMain.SelectedTab = pageSelDet;                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message, "Exception");
                Log.addError(ex.Message);
            }
            finally
            {
                splitterNewAnal.Enabled = true;
                if (File.Exists(config.SystemPathBinWork + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + ".INP"))
                    File.Delete(config.SystemPathBinWork + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + ".INP");
                if (!String.IsNullOrEmpty(res_file) && File.Exists(config.SystemPathBin + res_file))
                    File.Delete(config.SystemPathBin + res_file);
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);
                if (File.Exists(config.SystemPathBin + "SP_BUFF.$$$"))
                    File.Delete(config.SystemPathBin + "SP_BUFF.$$$");                
            }
        }

        private void UpdateHistory(string chn_file, string detector, string year, string specnr, string id_type)
        {
            string hist_file = config.SystemPathLog + "HISTORY.TXT";

            if (!File.Exists(hist_file))
            {
                TextWriter w = new StreamWriter(hist_file, false, Encoding.GetEncoding(865));            
                w.Close();
            }

            CHN_Header header = new CHN_Header();
            header.Read(chn_file, true);            

            string desc = id_type.PadRight(40, ' ');
            string line = detector + " " + year + " " + specnr + "  " + desc + "  "
                + header.MeasurementStart.Substring(0, 4) + " "
                + header.MeasurementStart.Substring(4, 2) + " "
                + header.MeasurementStart.Substring(6, 2) + " "
                + header.MeasurementStart.Substring(8, 2)
                + header.MeasurementStart.Substring(10, 2) + "  "
                + header.MeasurementStop.Substring(0, 4) + " "
                + header.MeasurementStop.Substring(4, 2) + " "
                + header.MeasurementStop.Substring(6, 2) + " "
                + header.MeasurementStop.Substring(8, 2)
                + header.MeasurementStop.Substring(10, 2);

            TextWriter writer = new StreamWriter(hist_file, true, Encoding.GetEncoding(865));            
            writer.WriteLine(line);
            writer.Close();            
        }

        private void menuItemAdmin_Click(object sender, EventArgs e)
        {
            wizardMain.SelectedTab = pageAdmin;
        }

        private bool ValidateAnalFields()
        {
            if (String.IsNullOrEmpty(txtAnalDetector.Text)
                || String.IsNullOrEmpty(txtAnalYear.Text)
                || String.IsNullOrEmpty(txtAnalSpecNum.Text)
                || String.IsNullOrEmpty(txtAnalSampleId.Text)
                //|| String.IsNullOrEmpty(txtAnalSamplePlace.Text)
                || String.IsNullOrEmpty(cboxAnalSampBeaker.Text)
                || String.IsNullOrEmpty(txtAnalHeight.Text)
                || String.IsNullOrEmpty(txtAnalWeight.Text)
                //|| String.IsNullOrEmpty(txtAnalDensity.Text)
                //|| String.IsNullOrEmpty(txtAnalVolume.Text)
                || String.IsNullOrEmpty(txtAnalQuantity.Text)
                || String.IsNullOrEmpty(txtAnalQuantityUncertainty.Text)
                //|| String.IsNullOrEmpty(cboxAnalSampQuantUnit.Text)
                //|| String.IsNullOrEmpty(txtAnalSamplingStart.Text) 
                //|| String.IsNullOrEmpty(txtAnalSamplingStop.Text) 
                || String.IsNullOrEmpty(txtAnalReferenceTime.Text)                
                || String.IsNullOrEmpty(dialogAnalNuclLib.Text)
                || String.IsNullOrEmpty(dialogAnalDetLimLib.Text)
                || String.IsNullOrEmpty(txtAnalFWHMPS.Text)
                || String.IsNullOrEmpty(txtAnalFWHMAN.Text)
                || String.IsNullOrEmpty(txtAnalTHRESH.Text)
                || String.IsNullOrEmpty(txtAnalBSTF.Text)
                || String.IsNullOrEmpty(txtAnalETOL.Text)
                || String.IsNullOrEmpty(txtAnalLOCH.Text)                
                || String.IsNullOrEmpty(dialogAnalBackgroundFile.Text)
                || String.IsNullOrEmpty(dialogAnalEnergyFile.Text)
                || String.IsNullOrEmpty(dialogAnalPEFFile.Text)
                || String.IsNullOrEmpty(dialogAnalTEFFile.Text))
            {
                MessageBox.Show("One or more required fields are empty", "Message");
                return false;
            }

            if (!String.IsNullOrEmpty(txtAnalSamplingStart.Text) && !Utils.ValidateGammaDate(txtAnalSamplingStart.Text))
            {
                MessageBox.Show("The sampling start date is invalid", "Error");
                return false;
            }

            if (!String.IsNullOrEmpty(txtAnalSamplingStop.Text) && !Utils.ValidateGammaDate(txtAnalSamplingStop.Text))
            {
                MessageBox.Show("The sampling stop date is invalid", "Error");
                return false;
            }

            if (!Utils.ValidateGammaDate(txtAnalReferenceTime.Text))
            {
                MessageBox.Show("The reference time is invalid", "Error");
                return false;
            }

            if (String.IsNullOrEmpty(txtAnalDensity.Text) && !String.IsNullOrEmpty(txtAnalVolume.Text))
            {
                MessageBox.Show("The field density are missing", "Error");
                return false;
            }

            if (!String.IsNullOrEmpty(txtAnalDensity.Text) && String.IsNullOrEmpty(txtAnalVolume.Text))
            {
                MessageBox.Show("The field volume are missing", "Error");
                return false;
            }                        

            if (String.IsNullOrEmpty(txtAnalDensity.Text) && String.IsNullOrEmpty(txtAnalVolume.Text))
            {
                buttonAnalRecalculate_Click(null, null);
            }            

            if (String.IsNullOrEmpty(txtAnalDensity.Text) || String.IsNullOrEmpty(txtAnalVolume.Text))
            {
                MessageBox.Show("One or more fields are missing", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalNuclLib.Text))
            {
                MessageBox.Show("The file " + dialogReAnalNuclLib.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalDetLimLib.Text))
            {
                MessageBox.Show("The file " + dialogReAnalDetLimLib.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalBackgroundFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalBackgroundFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalEnergyFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalEnergyFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalPEFFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalPefFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogAnalTEFFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalTefFile.Text + " was not found", "Error");
                return false;
            }

            if (!beakers.map.ContainsKey(cboxAnalSampBeaker.Text))
            {
                MessageBox.Show("The beaker " + cboxAnalSampBeaker.Text + " was not found", "Error");
                return false;
            }

            return true;
        }

        private bool ValidateReAnalFields()
        {
            if (String.IsNullOrEmpty(txtReAnalDetector.Text)
                || String.IsNullOrEmpty(txtReAnalYear.Text)
                || String.IsNullOrEmpty(txtReAnalSpecnum.Text)
                || String.IsNullOrEmpty(txtReAnalSampleId.Text)
                //|| String.IsNullOrEmpty(txtReAnalSamplePlace.Text)
                || String.IsNullOrEmpty(cboxReAnalSampBeaker.Text)
                || String.IsNullOrEmpty(txtReAnalSampleHeight.Text)
                || String.IsNullOrEmpty(txtReAnalSampleWeight.Text)
                //|| String.IsNullOrEmpty(txtReAnalDensity.Text)
                //|| String.IsNullOrEmpty(txtReAnalVolume.Text)
                || String.IsNullOrEmpty(txtReAnalQuantity.Text)
                || String.IsNullOrEmpty(txtReAnalQuantityUncertainty.Text)
                //|| String.IsNullOrEmpty(cboxReAnalSampQuantUnit.Text)
                //|| String.IsNullOrEmpty(txtReAnalSampleStart.Text)
                //|| String.IsNullOrEmpty(txtReAnalSampleStop.Text)
                || String.IsNullOrEmpty(txtReAnalReferenceTime.Text)
                || String.IsNullOrEmpty(dialogReAnalNuclLib.Text)
                || String.IsNullOrEmpty(dialogReAnalDetLimLib.Text.Trim())
                || String.IsNullOrEmpty(txtReAnalMeasurementStart.Text)
                || String.IsNullOrEmpty(txtReAnalMeasurementStop.Text)
                || String.IsNullOrEmpty(txtReAnalMeasurementTime.Text)
                || String.IsNullOrEmpty(txtReAnalLivetime.Text)
                || String.IsNullOrEmpty(txtReAnalRealtime.Text)
                || String.IsNullOrEmpty(txtReAnalDeadtime.Text)
                || String.IsNullOrEmpty(cboxReAnalSampChannels.Text)                
                //|| String.IsNullOrEmpty(cboxReAnalSampMethod.Text)
                || String.IsNullOrEmpty(txtReAnalRecLen.Text)
                || String.IsNullOrEmpty(txtReAnalFWHMPS.Text)
                || String.IsNullOrEmpty(txtReAnalFWHMAN.Text)
                || String.IsNullOrEmpty(txtReAnalTHRESH.Text)
                || String.IsNullOrEmpty(txtReAnalBSTF.Text)
                || String.IsNullOrEmpty(txtReAnalETOL.Text)
                || String.IsNullOrEmpty(txtReAnalLOCH.Text)                
                || String.IsNullOrEmpty(dialogReAnalBackgroundFile.Text)
                || String.IsNullOrEmpty(dialogReAnalEnergyFile.Text)
                || String.IsNullOrEmpty(txtReAnalFormat.Text)
                || String.IsNullOrEmpty(dialogReAnalPefFile.Text)
                || String.IsNullOrEmpty(dialogReAnalTefFile.Text))
            {
                MessageBox.Show("One or more required fields are missing", "Message");
                return false;
            }

            if (!String.IsNullOrEmpty(txtReAnalSampleStart.Text) && !Utils.ValidateGammaDate(txtReAnalSampleStart.Text))
            {
                MessageBox.Show("The sampling start date is invalid", "Error");
                return false;
            }

            if (!String.IsNullOrEmpty(txtReAnalSampleStop.Text) && !Utils.ValidateGammaDate(txtReAnalSampleStop.Text))
            {
                MessageBox.Show("The sampling stop date is invalid", "Error");
                return false;
            }

            if (!Utils.ValidateGammaDate(txtReAnalReferenceTime.Text))
            {
                MessageBox.Show("The reference time is invalid", "Error");
                return false;
            }

            if (!Utils.ValidateGammaDate(txtReAnalMeasurementStart.Text))
            {
                MessageBox.Show("The measurement start date is invalid", "Error");
                return false;
            }

            if (!Utils.ValidateGammaDate(txtReAnalMeasurementStop.Text))
            {
                MessageBox.Show("The measurement stop date is invalid", "Error");
                return false;
            }

            if (!Utils.SanityCheckGammaDates(txtReAnalMeasurementStart.Text, txtReAnalMeasurementStop.Text))
            {
                MessageBox.Show("Measurement stop cannot be earlier than measurement start", "Error");
                return false;
            }

            if (String.IsNullOrEmpty(txtReAnalDensity.Text) && !String.IsNullOrEmpty(txtReAnalVolume.Text))
            {
                MessageBox.Show("The field density are missing", "Error");
                return false;
            }

            if (!String.IsNullOrEmpty(txtReAnalDensity.Text) && String.IsNullOrEmpty(txtReAnalVolume.Text))
            {
                MessageBox.Show("The field volume are missing", "Error");
                return false;
            }

            if (String.IsNullOrEmpty(txtReAnalDensity.Text) && String.IsNullOrEmpty(txtReAnalVolume.Text))
            {
                buttonReAnalRecalculate_Click(null, null);
            }

            if (String.IsNullOrEmpty(txtReAnalDensity.Text) || String.IsNullOrEmpty(txtReAnalVolume.Text))
            {
                MessageBox.Show("One or more fields are missing", "Error");
                return false;
            }

            float realtime = Convert.ToSingle(txtReAnalRealtime.Text);
            float livetime = Convert.ToSingle(txtReAnalLivetime.Text);
            if (livetime > realtime)
            {
                MessageBox.Show("Livetime can not be bigger than realtime", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalNuclLib.Text))
            {
                MessageBox.Show("The file " + dialogReAnalNuclLib.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalDetLimLib.Text))
            {
                MessageBox.Show("The file " + dialogReAnalDetLimLib.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalBackgroundFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalBackgroundFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalEnergyFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalEnergyFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalPefFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalPefFile.Text + " was not found", "Error");
                return false;
            }

            if (!File.Exists(config.SystemPathBin + dialogReAnalTefFile.Text))
            {
                MessageBox.Show("The file " + dialogReAnalTefFile.Text + " was not found", "Error");
                return false;
            }

            if (!beakers.map.ContainsKey(cboxReAnalSampBeaker.Text))
            {
                MessageBox.Show("The beaker " + cboxReAnalSampBeaker.Text + " was not found", "Error");
                return false;
            }

            return true;
        }

        /*private void EmptyAdminDetectorFields()
        {
            cboxAdminDetEngFiles.ComboBox.Items.Clear();
            cboxAdminDetBkgFiles.ComboBox.Items.Clear();
            cboxAdminDetBeakers.ComboBox.Items.Clear();
            cboxAdminDetPefTef.ComboBox.Items.Clear();
            labelAdminDetDetector.Text = String.Empty;
            txtAdminDetID.Text = cboxAdminDetRecords.Text = cboxAdminDetChannels.Text = txtAdminDetComment.Text = cboxAdminDetSpecFmt.Text = String.Empty;
            txtAdminDetFWHMPS.Text = txtAdminDetFWHMAN.Text = txtAdminDetLOCH.Text = txtAdminDetETOL.Text = txtAdminDetTHRESH.Text = txtAdminDetBSTF.Text = String.Empty;
            cboxAdminDetEngFiles.Text = cboxAdminDetBkgFiles.Text = cboxAdminDetBeakers.Text = cboxAdminDetPefTef.Text = String.Empty;
            cbAdminICA.Checked = true;         
        }*/

        private void EmptyAnalFields()
        {
            txtAnalDetector.Text = String.Empty;
            txtAnalYear.Text = String.Empty;
            txtAnalSpecNum.Text = String.Empty;
            txtAnalSampleId.Text = String.Empty;
            txtAnalSamplePlace.Text = String.Empty;
            txtAnalHeight.Text = String.Empty;
            txtAnalWeight.Text = String.Empty;
            cboxAnalSampBeaker.Text = String.Empty;
            txtAnalDensity.Text = String.Empty;
            txtAnalVolume.Text = String.Empty;
            txtAnalQuantity.Text = String.Empty;
            txtAnalQuantityUncertainty.Text = String.Empty;
            cboxAnalSampQuantUnit.Text = String.Empty;
            txtAnalSamplingStart.Text = String.Empty;
            txtAnalSamplingStop.Text = String.Empty;
            cboxAnalSignature.Text = String.Empty;
            txtAnalReferenceTime.Text = String.Empty;
            dialogAnalNuclLib.Text = String.Empty;
            dialogAnalDetLimLib.Text = String.Empty;
            txtAnalFWHMPS.Text = String.Empty;
            txtAnalFWHMAN.Text = String.Empty;
            txtAnalTHRESH.Text = String.Empty;
            txtAnalBSTF.Text = String.Empty;
            txtAnalETOL.Text = String.Empty;
            txtAnalLOCH.Text = String.Empty;
            cbAnalICA.Checked = true;
            dialogAnalBackgroundFile.Text = String.Empty;
            dialogAnalEnergyFile.Text = String.Empty;
            dialogAnalPEFFile.Text = String.Empty;
            dialogAnalTEFFile.Text = String.Empty;
        }

        private void EmptyReAnalFields()
        {
            txtReAnalDetector.Text = String.Empty;
            txtReAnalYear.Text = String.Empty;
            txtReAnalSpecnum.Text = String.Empty;
            txtReAnalSampleId.Text = String.Empty;
            txtReAnalSamplePlace.Text = String.Empty;
            txtReAnalSampleHeight.Text = String.Empty;
            txtReAnalSampleWeight.Text = String.Empty;
            cboxReAnalSampBeaker.Text = String.Empty;
            txtReAnalDensity.Text = String.Empty;
            txtReAnalVolume.Text = String.Empty;
            txtReAnalQuantity.Text = String.Empty;
            txtReAnalQuantityUncertainty.Text = String.Empty;
            cboxReAnalSampQuantUnit.Text = String.Empty;
            txtReAnalSampleStart.Text = String.Empty;
            txtReAnalSampleStop.Text = String.Empty;
            cboxReAnalSignature.Text = String.Empty;
            txtReAnalReferenceTime.Text = String.Empty;
            dialogReAnalNuclLib.Text = String.Empty;
            dialogReAnalDetLimLib.Text = String.Empty;
            txtReAnalFWHMPS.Text = String.Empty;
            txtReAnalFWHMAN.Text = String.Empty;
            txtReAnalTHRESH.Text = String.Empty;
            txtReAnalBSTF.Text = String.Empty;
            txtReAnalETOL.Text = String.Empty;
            txtReAnalLOCH.Text = String.Empty;
            cbReAnalICA.Checked = true;
            dialogReAnalBackgroundFile.Text = String.Empty;
            dialogReAnalEnergyFile.Text = String.Empty;
            dialogReAnalPefFile.Text = String.Empty;
            dialogReAnalTefFile.Text = String.Empty;
        }

        private void displayDetectors()
        {            
            listViewAdminDetectors.Items.Clear();
            flowMenuDetectors.Controls.Clear();

            ListViewItem item = null;
            foreach (CDetector d in detectors.map.Values)
            {
                if (d.Connected)
                {                    
                    string caption = d.Name + " " + d.SpectrumSoftware;                    
                    Button btn = new Button();
                    btn.Size = new Size(90, 105);
                    if(File.Exists(config.SpecExecutablePath + "images\\detector64.png"))
                        btn.Image = new Bitmap(config.SpecExecutablePath + "images\\detector64.png");
                    btn.ImageAlign = ContentAlignment.TopCenter;                    
                    btn.Text = caption;                    
                    btn.ForeColor = (!d.Dummy && d.Active) ? Color.Red : Color.Black;                                            
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    //btn.Font = new Font(btn.Font, btn.Font.Style | FontStyle.Bold);                    
                    btn.Font = new Font("Arial", 8, FontStyle.Bold);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
                    btn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
                    btn.Tag = (CDetector)d;
                    btn.Click += new EventHandler(flowMenuDetectors_Click);
                    flowMenuDetectors.Controls.Add(btn);
                }

                string[] items = { d.Name, d.SpectrumSoftware == "Dummy" ? "" : d.SpectrumSoftware, d.AnalysisMethod, d.Active ? "Yes" : "No", d.Connected ? "Yes" : "No" };
                item = new ListViewItem(items, IMAGE_INDEX_DETECTOR);
                item.Tag = (CDetector)d; 
                listViewAdminDetectors.Items.Add(item);
            }
        }        

        private void hideDetectors()
        {            
            flowMenuDetectors.Controls.Clear();
            listViewAdminDetectors.Items.Clear();            
        }

        private void displayBeakers()
        {
            lvAdmBeakers.Items.Clear();            

            ListViewItem item = null;
            foreach (CBeaker b in beakers.map.Values)
            {
                string[] items = { b.Name, b.Marinelli ? "Marinelli" : "Regular", b.Radius.ToString(), b.Height.ToString(), 
                                     b.Marinelli ? b.InnerRadius.ToString() : "", b.Marinelli ? b.InnerHeight.ToString() : "", 
                                     b.MinFillHeight.ToString(), b.MaxFillHeight.ToString() };
                item = new ListViewItem(items, IMAGE_INDEX_BEAKER);
                item.Tag = (CBeaker)b; 
                lvAdmBeakers.Items.Add(item);
            }
            /*
            cboxAnalSampBeaker.ComboBox.Items.Clear();
            cboxReAnalSampBeaker.ComboBox.Items.Clear();

            cboxAnalSampBeaker.ComboBox.Items.Add("");
            cboxReAnalSampBeaker.ComboBox.Items.Add("");
            foreach (string s in beakers.map.Keys)
            {
                if (beakers.map[s].InUse)
                {
                    cboxAnalSampBeaker.ComboBox.Items.Add(s);
                    cboxReAnalSampBeaker.ComboBox.Items.Add(s);
                }
            }
             * */
        }

        private void DisableArchiveItemButtons()
        {
            buttonArchiveShowINP.Enabled = menuArchiveFilesShowINP.Enabled = false;
            buttonArchiveShowLIS.Enabled = buttonArchiveCreateBackground.Enabled = menuArchiveFilesShowLIS.Enabled = menuArchiveCreateBackground.Enabled = false;
            buttonArchivePrintAnalyse.Enabled = menuArchiveFilesPrintAnalyse.Enabled = false;
            toolButtonReAnalyse.Enabled = false;
            buttonArchiveShowSpec.Enabled = false;
        }

        private void populateAnalArchive()
        {            
            treeArchive.Nodes.Clear();         
            listViewArchive.Items.Clear();
            DisableArchiveItemButtons();
            HashSet<string> fileset = new HashSet<string>();            
            treemap.Clear();

            statusProgress.Minimum = 0;
            statusProgress.Value = 0;
            statusProgress.Step = 1;
            statusProgress.Maximum = 4;
            statusProgress.Visible = true;
            Application.DoEvents();
            statusProgress.PerformStep();            

            DirectoryInfo dir = new DirectoryInfo(config.SystemPathSpec);
            FileInfo[] files = dir.GetFiles("*.CHN", SearchOption.AllDirectories);
            labelArchiveFileCount.Text = files.Length.ToString() + " files";
            foreach (FileInfo file in files)            
                fileset.Add(file.Name.Substring(0, 4).ToUpper());            

            statusProgress.PerformStep();            

            string det, year;
            foreach (string s in fileset)
            {
                det = s.Substring(0, 2);                
                year = s.Substring(2);
                if (!treemap.ContainsKey(det))
                    treemap.Add(det, new HashSet<string>());
                treemap[det].Add(year);
            }

            statusProgress.PerformStep();

            TreeNode root = null, tnode = null;
            foreach (KeyValuePair<string, HashSet<string>> p in treemap)
            {
                root = treeArchive.Nodes.Add(p.Key);                
                foreach (string s in p.Value)
                {
                    tnode = root.Nodes.Add(s);
                    tnode.SelectedImageIndex = 1;
                }
            }

            statusProgress.PerformStep();            
            statusProgress.Visible = false;
        }        

        private void wizardMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (wizardMain.SelectedTab == pageAnalArchive)            
                populateAnalArchive();            

            statusLabel.Text = String.Empty;            
        }        

        private void menuItemLog_Click(object sender, EventArgs e)
        {
            wizardMain.SelectedTab = pageLog;
        }

        private void buttonAnalToggleAdvanced_Click(object sender, EventArgs e)
        {
            splitterNewAnal.Panel2Collapsed = !splitterNewAnal.Panel2Collapsed;
        }

        private void buttonReAnalToggleAdvanced_Click(object sender, EventArgs e)
        {
            splitterEditAnal.Panel2Collapsed = !splitterEditAnal.Panel2Collapsed;
        }

        private void toolButtonReAnalyse_Click(object sender, EventArgs e)
        {
            if (listViewArchive.SelectedIndices.Count == 0)
                return;

            EmptyReAnalFields();

            cboxReAnalSampBeaker.ComboBox.Items.Clear();
            cboxReAnalSampBeaker.ComboBox.Items.Add("");
            foreach (string s in beakers.map.Keys)
                if (beakers.map[s].InUse)
                    cboxReAnalSampBeaker.ComboBox.Items.Add(s);                        

            ListViewItem selitem = listViewArchive.SelectedItems[0];
            string chn_file = selitem.SubItems[7].Text;            
            string lis_file = chn_file.Substring(0, chn_file.Length - 4) + ".LIS";            
            string inp_file = chn_file.Substring(0, chn_file.Length - 4) + ".INP";
            labelReAnalPath.Text = chn_file;
            if (File.Exists(inp_file))
            {
                string line;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(inp_file, Encoding.GetEncoding(865));
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
                reader.Close();                

                if (lines.Count < LINES_IN_INP)
                {
                    MessageBox.Show("The file " + inp_file + " contains too few lines", "Error");
                    return;
                }
                
                if (detectors.map.ContainsKey(lines[15]))
                {            
                    CDetector detector = detectors.map[lines[15]];
                    cboxReAnalSampBeaker.ComboBox.Items.Clear();
                    cboxReAnalSampBeaker.ComboBox.Items.Add("");
                    foreach (string s in detector.Beakers.Keys)
                        if (beakers.map[s].InUse)
                            cboxReAnalSampBeaker.ComboBox.Items.Add(s);                        
                }                

                txtReAnalSpecnum.Text = lines[0];
                txtReAnalSampleId.Text = lines[1];
                //txtReAnalProject.Text = lines[2];
                txtReAnalSamplePlace.Text = lines[3];
                //txtReAnalLatitude.Text = lines[4];
                //txtReAnalLatitudeDir.Text = lines[5];
                //txtReAnalLongitude.Text = lines[6];
                //txtReAnalLongitudeDir.Text = lines[7];
                txtReAnalSampleHeight.Text = Utils.MakeFloat(lines[8]);
                //float val = Convert.ToSingle(lines[8]);
                //txtReAnalSampleHeight.Text = String.Format("{0:0.0###}", val);            
                txtReAnalSampleWeight.Text = Utils.MakeFloat(lines[9]);
                txtReAnalDensity.Text = Utils.MakeFloat(lines[10]);
                txtReAnalVolume.Text = Utils.MakeFloat(lines[11]);
                txtReAnalQuantity.Text = Utils.MakeFloat(lines[12]);
                txtReAnalQuantityUncertainty.Text = Utils.MakeFloat(lines[13]);
                cboxReAnalSampQuantUnit.ComboBox.SelectedIndex = cboxReAnalSampQuantUnit.ComboBox.FindString(lines[14]);
                txtReAnalDetector.Text = lines[15];
                txtReAnalYear.Text = lines[16];
                cboxReAnalSampBeaker.ComboBox.SelectedIndex = cboxReAnalSampBeaker.ComboBox.FindString(lines[17]);
                txtReAnalSampleStart.Text = lines[18];
                txtReAnalSampleStop.Text = lines[19];
                txtReAnalReferenceTime.Text = lines[20];
                txtReAnalMeasurementStart.Text = lines[21];
                txtReAnalMeasurementStop.Text = lines[22];
                txtReAnalRealtime.Text = lines[23];
                txtReAnalLivetime.Text = lines[24];
                txtReAnalMeasurementTime.Text = lines[25];
                txtReAnalDeadtime.Text = Utils.MakeFloat(lines[26]);
                dialogReAnalNuclLib.Text = lines[27];
                dialogReAnalDetLimLib.Text = lines[28];
                cboxReAnalSampChannels.ComboBox.SelectedIndex = cboxReAnalSampChannels.ComboBox.FindStringExact(lines[29]);                
                //cboxReAnalSampMethod.ComboBox.SelectedIndex = cboxReAnalSampMethod.ComboBox.FindStringExact(detectors[txtReAnalDetector.Text].AnalysisMethod);
                txtReAnalFormat.Text = lines[30];
                txtReAnalRecLen.Text = lines[31];
                txtReAnalFWHMPS.Text = Utils.MakeFloat(lines[32]);
                txtReAnalFWHMAN.Text = Utils.MakeFloat(lines[33]);
                txtReAnalTHRESH.Text = Utils.MakeFloat(lines[34]);
                txtReAnalBSTF.Text = Utils.MakeFloat(lines[35]);
                txtReAnalETOL.Text = Utils.MakeFloat(lines[36]);
                txtReAnalLOCH.Text = Utils.MakeFloat(lines[37]);
                cbReAnalICA.Checked = (lines[38] == "0" ? false : true);
                dialogReAnalEnergyFile.Text = lines[39];
                dialogReAnalPefFile.Text = lines[40];
                dialogReAnalTefFile.Text = lines[41];
                dialogReAnalBackgroundFile.Text = lines[42];
            }
            else
            {
                string specname = Path.GetFileNameWithoutExtension(chn_file);
                if (specname.Length != 8)
                {
                    MessageBox.Show("The filename " + chn_file + " does not appear to be valid, can not continue", "Error");
                    return;
                }
                string detname = specname.Substring(0, 2);
                string year = specname.Substring(2, 2);
                string specnum = specname.Substring(4, 4);
                if (!detectors.map.ContainsKey(detname))
                {
                    MessageBox.Show("Detector " + detname + " was not found, can not continue", "Error");
                    return;
                }
                CDetector detector = detectors[detname];                
                CHN_Header header = new CHN_Header();
                header.Read(chn_file, true);

                txtReAnalDetector.Text = detector.Name;
                txtReAnalYear.Text = year;
                txtReAnalSpecnum.Text = specnum;
                txtReAnalQuantityUncertainty.Text = "0.0";
                txtReAnalMeasurementStart.Text = header.MeasurementStart;
                txtReAnalMeasurementStop.Text = header.MeasurementStop;
                txtReAnalMeasurementTime.Text = "0";
                txtReAnalRealtime.Text = Convert.ToInt32(header.RealTimeSeconds).ToString();
                txtReAnalLivetime.Text = Convert.ToInt32(header.LiveTimeSeconds).ToString();
                txtReAnalDeadtime.Text = String.Format("{0:0.0}", header.DeadTime);
                txtReAnalFWHMPS.Text = Utils.MakeFloat(detector.FWHMPS.ToString());
                txtReAnalFWHMAN.Text = Utils.MakeFloat(detector.FWHMAN.ToString());
                txtReAnalTHRESH.Text = Utils.MakeFloat(detector.THRESH.ToString());
                txtReAnalBSTF.Text = Utils.MakeFloat(detector.BSTF.ToString());
                txtReAnalETOL.Text = Utils.MakeFloat(detector.ETOL.ToString());
                txtReAnalLOCH.Text = Utils.MakeFloat(detector.LOCH.ToString());
                cbReAnalICA.Checked = (detector.ICA == 0 ? false : true);
                cboxReAnalSampMethod.ComboBox.SelectedIndex = cboxReAnalSampMethod.ComboBox.FindStringExact(detector.AnalysisMethod);
                cboxReAnalSampChannels.ComboBox.SelectedIndex = cboxReAnalSampChannels.ComboBox.FindStringExact(detector.Channels.ToString());
                txtReAnalRecLen.Text = detector.BytesPerRecord.ToString();
                dialogReAnalBackgroundFile.Text = detector.DefaultBackgroundFile;
                dialogReAnalEnergyFile.Text = detector.DefaultEnergyCalibrationFile;
                txtReAnalFormat.Text = detector.Format;
                if (!String.IsNullOrEmpty(dialogAdminDefNuclLib.Text))
                    dialogReAnalNuclLib.Text = Path.GetFileName(dialogAdminDefNuclLib.Text);
                if (!String.IsNullOrEmpty(dialogAdminDefDetLib.Text))
                    dialogReAnalDetLimLib.Text = Path.GetFileName(dialogAdminDefDetLib.Text);                                    
            }            
            
            splitterEditAnal.Panel2Collapsed = true;
            wizardMain.SelectedTab = pageReAnal;
        }

        private void buttonArchiveShowLIS_Click(object sender, EventArgs e)
        {
            if (listViewArchive.SelectedIndices.Count == 0)
                return;
            
            ListViewItem selitem = listViewArchive.SelectedItems[0];            
            string filename = selitem.SubItems[7].Text;
            filename = filename.Substring(0, filename.Length - 4) + ".LIS";
            if (!File.Exists(filename))
            {
                MessageBox.Show("The file " + filename + " was not found", "Error");
                return;
            }

            FormGammaGUI_ShowText form = new FormGammaGUI_ShowText(useDefaultPrinter);
            form.Text = filename;
            form.setContent(File.ReadAllText(filename, Encoding.GetEncoding(865))); 
            form.ShowDialog();
        }

        private void buttonArchiveShowINP_Click(object sender, EventArgs e)
        {
            if (listViewArchive.SelectedIndices.Count == 0)
                return;
            
            ListViewItem selitem = listViewArchive.SelectedItems[0];            
            string filename = selitem.SubItems[7].Text;
            filename = filename.Substring(0, filename.Length - 4) + ".INP";

            if (File.Exists(filename))
            {
                FormGammaGUI_ShowText form = new FormGammaGUI_ShowText(useDefaultPrinter);
                form.Text = filename;
                form.setContent(File.ReadAllText(filename, Encoding.GetEncoding(865)).Replace("\n", Environment.NewLine));                 
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("The file " + filename + " was not found", "Message");
                return;
            }
        }                

        private void listViewAdminDetectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAdminDetectors.SelectedIndices.Count == 0)
            {
                labelAdminDetDetector.Text = String.Empty;
                txtAdminDetID.Text = String.Empty;
                cboxAdminDetChannels.ComboBox.SelectedIndex = -1;
                cboxAdminDetRecords.ComboBox.SelectedIndex = -1;
                cboxAdminDetSpecFmt.ComboBox.SelectedIndex = -1;
                txtAdminDetComment.Text = String.Empty;
                txtAdminDetFWHMPS.Text = String.Empty;
                txtAdminDetFWHMAN.Text = String.Empty;
                txtAdminDetTHRESH.Text = String.Empty;
                cbAdminICA.Checked = false;
                txtAdminDetBSTF.Text = String.Empty;
                txtAdminDetETOL.Text = String.Empty;
                txtAdminDetLOCH.Text = String.Empty;
                //cboxAdminDetBkgFiles.ComboBox.SelectedIndex = -1;
                //cboxAdminDetEngFiles.ComboBox.SelectedIndex = -1;
                cbAdminDetActive.Checked = false;
                cbAdminDetConnected.Checked = false;
                cbAdminDetDummy.Checked = false;
                cboxAdminDetEngFiles.ComboBox.Items.Clear();
                cboxAdminDetBkgFiles.ComboBox.Items.Clear();
                cboxAdminDetBeakers.ComboBox.Items.Clear();
                cboxAdminDetPefTef.ComboBox.Items.Clear();
                return;
            }
            
            ListViewItem selitem = listViewAdminDetectors.SelectedItems[0];
            string detector_name = selitem.SubItems[0].Text;
            if (!detectors.map.ContainsKey(detector_name))
            {
                MessageBox.Show("Detector name " + detector_name + " was not found", "Error");
                return;
            }

            CDetector detector = detectors[detector_name];

            labelAdminDetDetector.Text = detector_name;
            txtAdminDetID.Text = detector.ID.ToString();
            cboxAdminDetChannels.ComboBox.SelectedIndex = cboxAdminDetChannels.ComboBox.FindStringExact(detector.Channels.ToString());
            cboxAdminDetRecords.ComboBox.SelectedIndex = cboxAdminDetRecords.ComboBox.FindStringExact(detector.BytesPerRecord.ToString());
            cboxAdminDetSpecFmt.ComboBox.SelectedIndex = cboxAdminDetSpecFmt.ComboBox.FindStringExact(detector.Format);
            txtAdminDetComment.Text = detector.Comment;
            txtAdminDetFWHMPS.Text = Utils.MakeFloat(detector.FWHMPS.ToString());
            txtAdminDetFWHMAN.Text = Utils.MakeFloat(detector.FWHMAN.ToString());
            txtAdminDetTHRESH.Text = Utils.MakeFloat(detector.THRESH.ToString());
            cbAdminICA.Checked = (detector.ICA == 0 ? false : true);
            txtAdminDetBSTF.Text = Utils.MakeFloat(detector.BSTF.ToString());
            txtAdminDetETOL.Text = Utils.MakeFloat(detector.ETOL.ToString());
            txtAdminDetLOCH.Text = Utils.MakeFloat(detector.LOCH.ToString());            
            cbAdminDetActive.Checked = detector.Active;
            cbAdminDetConnected.Checked = detector.Connected;
            cbAdminDetDummy.Checked = detector.Dummy;

            cboxAdminDetEngFiles.ComboBox.Items.Clear();
            cboxAdminDetEngFiles.ComboBox.Items.Add("");
            foreach (string s in config.EnergyFileList)
                if(s.StartsWith(detector_name))
                    cboxAdminDetEngFiles.ComboBox.Items.Add(s);

            cboxAdminDetBkgFiles.ComboBox.Items.Clear();
            cboxAdminDetBkgFiles.ComboBox.Items.Add("");
            foreach (string s in config.BackgroundFileList)
                if (s.StartsWith(detector_name))
                    cboxAdminDetBkgFiles.ComboBox.Items.Add(s);

            cboxAdminDetBkgFiles.ComboBox.SelectedIndex = cboxAdminDetBkgFiles.ComboBox.FindStringExact(detector.DefaultBackgroundFile);
            cboxAdminDetEngFiles.ComboBox.SelectedIndex = cboxAdminDetEngFiles.ComboBox.FindStringExact(detector.DefaultEnergyCalibrationFile);

            cboxAdminDetBeakers.ComboBox.Items.Clear();
            cboxAdminDetBeakers.ComboBox.Items.Add("");
            foreach (string s in beakers.map.Keys)            
                if (beakers.map[s].InUse)            
                    cboxAdminDetBeakers.ComboBox.Items.Add(s);

            cbAdminDetConnected.Enabled = detector.Dummy;         
        }

        private void buttonAdminSaveDetector_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelAdminDetDetector.Text))
            {
                MessageBox.Show("Please select a detector first", "Message");
                return;
            }
            
            string detector_name = labelAdminDetDetector.Text;
            if (!detectors.map.ContainsKey(detector_name))
            {
                MessageBox.Show("Detector name " + detector_name + " was not found", "Error");
                return;
            }

            CDetector detector = detectors[detector_name];

            foreach (CDetector d in detectors.map.Values)
            {
                if ((d.Name.ToUpper() != detector_name.ToUpper()) && d.ID > 0)
                {
                    if (d.ID.ToString() == txtAdminDetID.Text.Trim() && d.Connected)
                    {
                        MessageBox.Show("The Maestro ID " + txtAdminDetID.Text + " is already in use by detector " + d.Name);
                        return;
                    }
                }
            }            

            if (String.IsNullOrEmpty(cboxAdminDetChannels.ComboBox.Text)
                || String.IsNullOrEmpty(txtAdminDetID.Text)
                || String.IsNullOrEmpty(cboxAdminDetRecords.ComboBox.Text)
                || String.IsNullOrEmpty(cboxAdminDetSpecFmt.ComboBox.Text)
                || String.IsNullOrEmpty(txtAdminDetFWHMPS.Text)
                || String.IsNullOrEmpty(txtAdminDetFWHMAN.Text)
                || String.IsNullOrEmpty(txtAdminDetTHRESH.Text)                
                || String.IsNullOrEmpty(txtAdminDetBSTF.Text)
                || String.IsNullOrEmpty(txtAdminDetETOL.Text)
                || String.IsNullOrEmpty(txtAdminDetLOCH.Text)
                || String.IsNullOrEmpty(cboxAdminDetBkgFiles.ComboBox.Text)
                || String.IsNullOrEmpty(cboxAdminDetEngFiles.ComboBox.Text))
            {
                MessageBox.Show("One or more required fields are missing", "Message");
                return;
            }

            detector.ID = Convert.ToInt32(txtAdminDetID.Text);
            detector.Channels = Convert.ToInt32(cboxAdminDetChannels.ComboBox.Text);            
            detector.BytesPerRecord = Convert.ToInt32(cboxAdminDetRecords.ComboBox.Text);            
            detector.Format = cboxAdminDetSpecFmt.ComboBox.Text;            
            detector.Comment = txtAdminDetComment.Text;            
            detector.FWHMPS = Convert.ToSingle(txtAdminDetFWHMPS.Text);            
            detector.FWHMAN = Convert.ToSingle(txtAdminDetFWHMAN.Text);            
            detector.THRESH = Convert.ToSingle(txtAdminDetTHRESH.Text);
            detector.ICA = (cbAdminICA.Checked ? 1 : 0);
            detector.BSTF = Convert.ToSingle(txtAdminDetBSTF.Text);            
            detector.ETOL = Convert.ToSingle(txtAdminDetETOL.Text);            
            detector.LOCH = Convert.ToSingle(txtAdminDetLOCH.Text);            
            detector.DefaultBackgroundFile = cboxAdminDetBkgFiles.ComboBox.Text;            
            detector.DefaultEnergyCalibrationFile = cboxAdminDetEngFiles.ComboBox.Text;            
            detector.Active = cbAdminDetActive.Checked;            
            detector.Connected = cbAdminDetConnected.Checked;            
            detector.Dummy = cbAdminDetDummy.Checked;
            if (!String.IsNullOrEmpty(cboxAdminDetBeakers.Text) && !String.IsNullOrEmpty(cboxAdminDetPefTef.Text))
            {
                if (!detector.Beakers.ContainsKey(cboxAdminDetBeakers.Text))
                    detector.Beakers.Add(cboxAdminDetBeakers.Text, cboxAdminDetPefTef.Text);
                else detector.Beakers[cboxAdminDetBeakers.Text] = cboxAdminDetPefTef.Text;
            }

            if (detectors.Save(detector_name, detector.Dummy))
            {
                displayDetectors();
                statusLabel.Text = "Detector " + detector_name + " was saved";
                Log.addMessage("Detector " + detector_name + " was saved");
            }
            else statusLabel.Text = "Saving detector " + detector_name + " failed";
        }

        private void buttonAdminAddBeaker_Click(object sender, EventArgs e)
        {
            if (!beakers.Add())            
                return;            

            if (!beakers.LoadAll())
            {
                MessageBox.Show("Loading beaker information failed");
                return;
            }

            cboxAdminDetBeakers.ComboBox.Items.Clear();
            cboxAdminDetBeakers.ComboBox.Items.Add("");
            foreach (string s in beakers.map.Keys)
                if (beakers.map[s].InUse)
                    cboxAdminDetBeakers.ComboBox.Items.Add(s);

            displayBeakers();
            Log.addMessage("Beaker added successfully");
        }

        private void lvAdmBeakers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdmBeakers.SelectedIndices.Count == 0)
            {
                labelAdminBeaBeaker.Text = String.Empty;
                txtAdminBeakerName.Text = String.Empty;
                txtAdminBeakerRadius.Text = String.Empty;
                txtAdminBeakerHeight.Text = String.Empty;
                cbAdminBeakerMarinelli.Checked = false;
                txtAdminBeakerInnerRadius.Text = String.Empty;
                txtAdminBeakerInnerHeight.Text = String.Empty;
                txtAdminBeakerInnerRadius.Enabled = false;
                txtAdminBeakerInnerHeight.Enabled = false;
                txtAdminBeakerMinFillHeight.Text = String.Empty;
                txtAdminBeakerMaxFillHeight.Text = String.Empty;
                cbAdminBeakerInUse.Checked = false;
                txtAdminBeakerManufacturer.Text = String.Empty;
                txtAdminBeakerComment.Text = String.Empty;
                return;
            }

            ListViewItem selitem = lvAdmBeakers.SelectedItems[0];
            string beaker_name = selitem.SubItems[0].Text;
            if (!beakers.map.ContainsKey(beaker_name))
            {
                MessageBox.Show("Beaker name " + beaker_name + " was not found", "Error");
                return;
            }

            CBeaker beaker = beakers[beaker_name];

            labelAdminBeaBeaker.Text = beaker_name;
            txtAdminBeakerName.Text = beaker.Name;
            txtAdminBeakerRadius.Text = beaker.Radius.ToString();
            txtAdminBeakerHeight.Text = beaker.Height.ToString();
            cbAdminBeakerMarinelli.Checked = beaker.Marinelli;
            if (beaker.Marinelli)
            {
                txtAdminBeakerInnerRadius.Text = beaker.InnerRadius.ToString();
                txtAdminBeakerInnerHeight.Text = beaker.InnerHeight.ToString();
            }
            else
            {
                txtAdminBeakerInnerRadius.Text = String.Empty;
                txtAdminBeakerInnerHeight.Text = String.Empty;
                txtAdminBeakerInnerRadius.Enabled = false;
                txtAdminBeakerInnerHeight.Enabled = false;
            }
            txtAdminBeakerMinFillHeight.Text = beaker.MinFillHeight.ToString();
            txtAdminBeakerMaxFillHeight.Text = beaker.MaxFillHeight.ToString();
            cbAdminBeakerInUse.Checked = beaker.InUse;
            txtAdminBeakerManufacturer.Text = beaker.Manufacturer;
            txtAdminBeakerComment.Text = beaker.Comment;
        }

        private void buttonAdminSaveBeaker_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelAdminBeaBeaker.Text))
            {
                MessageBox.Show("Please select a beaker first", "Message");
                return;
            }

            string beaker_name = labelAdminBeaBeaker.Text;
            if (!beakers.map.ContainsKey(beaker_name))
            {
                MessageBox.Show("Beaker name " + beaker_name + " was not found", "Error");
                return;
            }

            CBeaker beaker = beakers[beaker_name];            

            if (String.IsNullOrEmpty(txtAdminBeakerName.Text)
                || String.IsNullOrEmpty(txtAdminBeakerRadius.Text)
                || String.IsNullOrEmpty(txtAdminBeakerHeight.Text)
                || String.IsNullOrEmpty(txtAdminBeakerMinFillHeight.Text)
                || String.IsNullOrEmpty(txtAdminBeakerMaxFillHeight.Text)
                || String.IsNullOrEmpty(txtAdminBeakerManufacturer.Text))
            {
                MessageBox.Show("One or more required fields are missing", "Message");
                return;
            }

            if (cbAdminBeakerMarinelli.Checked)
            {
                if (String.IsNullOrEmpty(txtAdminBeakerInnerRadius.Text.Trim()) || String.IsNullOrEmpty(txtAdminBeakerInnerHeight.Text.Trim()))
                {
                    MessageBox.Show("One or more required Marinelli fields are missing", "Message");
                    return;
                }
            }

            try
            {
                beaker.Radius = Convert.ToSingle(txtAdminBeakerRadius.Text);
                beaker.Height = Convert.ToSingle(txtAdminBeakerHeight.Text);
                beaker.Marinelli = cbAdminBeakerMarinelli.Checked;
                if (beaker.Marinelli)
                {
                    beaker.InnerRadius = Convert.ToSingle(txtAdminBeakerInnerRadius.Text.Trim());
                    beaker.InnerHeight = Convert.ToSingle(txtAdminBeakerInnerHeight.Text.Trim());
                }
                else
                {
                    beaker.InnerRadius = 0.0f;
                    beaker.InnerHeight = 0.0f;
                }
                beaker.MinFillHeight = Convert.ToSingle(txtAdminBeakerMinFillHeight.Text);
                beaker.MaxFillHeight = Convert.ToSingle(txtAdminBeakerMaxFillHeight.Text);
                beaker.Manufacturer = txtAdminBeakerManufacturer.Text;
                beaker.InUse = cbAdminBeakerInUse.Checked;
                beaker.Comment = txtAdminBeakerComment.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("One or more fields contains invalid values", "Message");
                return;
            }

            if(beaker.MaxFillHeight > beaker.Height)
            {
                MessageBox.Show("Max fill height can not be bigger than height", "Message");
                return;
            }

            if (beaker.MinFillHeight > beaker.MaxFillHeight)
            {
                MessageBox.Show("Min fill height can not be bigger than max fill height", "Message");
                return;
            }

            if (beaker.MinFillHeight < 0.0f)
            {
                MessageBox.Show("Min fill height can not be less than zero", "Message");
                return;
            }

            if (beaker.Marinelli)
            {
                if (beaker.InnerRadius >= beaker.Radius)
                {
                    MessageBox.Show("Inner radius can not be bigger or equal to radius", "Message");
                    return;
                }

                if (beaker.InnerHeight >= beaker.Height)
                {
                    MessageBox.Show("Inner height can not be bigger or equal to height", "Message");
                    return;
                }
            }

            if (beakers.Save(beaker_name))
            {
                displayBeakers();
                statusLabel.Text = "Beaker " + beaker_name + " was saved";
                Log.addMessage("Beaker " + beaker_name + " was saved");
            }
            else statusLabel.Text = "Saving beaker " + beaker_name + " failed";
        }

        private bool GetGammaLibraryFile(string title, string filter, ref VintageControls.LabeledFileDialog dest)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = config.SystemPathBin;
            dialog.AddExtension = false;
            dialog.Title = title;
            dialog.Filter = filter;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
                if (Path.GetDirectoryName(dialog.FileName).ToUpper() != Path.GetDirectoryName(config.SystemPathBin).ToUpper())
                {                    
                    MessageBox.Show("You must select a file in the " + config.SystemPathBin + " directory", "Message");
                }
                else
                {
                    dest.Text = Path.GetFileName(dialog.FileName).ToUpper();
                    return true;
                }
            }
            return false;
        }

        private void dialogAdminDefNuclLib_ButtonClicked(object sender, EventArgs e)
        {
            if (GetGammaLibraryFile("Select the default nuclide library", "NUCL*.LIB files (NUCL*.LIB)|NUCL*.LIB", ref dialogAdminDefNuclLib))
                Log.addMessage("New defult nuclide library selected: " + dialogAdminDefNuclLib.Text);
        }

        private void dialogAdminDefDetLib_ButtonClicked(object sender, EventArgs e)
        {
            if(GetGammaLibraryFile("Select the default detection limit library", "MDA*.LIB files (MDA*.LIB)|MDA*.LIB", ref dialogAdminDefDetLib))
                Log.addMessage("New defult detection limit library selected: " + dialogAdminDefDetLib.Text);
        }

        private void dialogAnalBackgroundFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a background file", "BGR files (" + txtAnalDetector.Text + "*.BGR)|" + txtAnalDetector.Text + "*.BGR", ref dialogAnalBackgroundFile);            
        }

        private void dialogAnalEnergyFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a energy file", "ENG files (" + txtAnalDetector.Text + "*.ENG)|" + txtAnalDetector.Text + "*.ENG", ref dialogAnalEnergyFile);
        }

        private void dialogAnalPEFFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a PEF file", "PEF files (" + txtAnalDetector.Text + cboxAnalSampBeaker.Text + "*.PEF)|" + txtAnalDetector.Text + cboxAnalSampBeaker.Text + "*.PEF", ref dialogAnalPEFFile);            
        }

        private void dialogAnalTEFFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a TEF file", "TEF files (" + txtAnalDetector.Text + "*.TEF)|" + txtAnalDetector.Text + "*.TEF", ref dialogAnalTEFFile);                        
        }

        private void dialogAnalNuclLib_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a nuclide library file", "NUCL*.LIB files (NUCL*.LIB)|NUCL*.LIB", ref dialogAnalNuclLib);                                    
        }

        private void dialogAnalDetLimLib_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a detection limit library file", "MDA*.LIB files (MDA*.LIB)|MDA*.LIB", ref dialogAnalDetLimLib);
        }

        private void dialogReAnalNuclLib_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a nuclide library file", "NUCL*.LIB files (NUCL*.LIB)|NUCL*.LIB", ref dialogReAnalNuclLib);            
        }

        private void dialogReAnalDetLimLib_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a detection limit library file", "MDA*.LIB files (MDA*.LIB)|MDA*.LIB", ref dialogReAnalDetLimLib);                        
        }

        private void dialogReAnalBackgroundFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a background file", "BGR files (" + txtReAnalDetector.Text + "*.BGR)|" + txtReAnalDetector.Text + "*.BGR", ref dialogReAnalBackgroundFile);
        }

        private void dialogReAnalEnergyFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a energy file", "ENG files (" + txtReAnalDetector.Text + "*.ENG)|" + txtReAnalDetector.Text + "*.ENG", ref dialogReAnalEnergyFile);            
        }

        private void dialogReAnalPefFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a PEF file", "PEF files (" + txtReAnalDetector.Text + cboxReAnalSampBeaker.Text + "*.PEF)|" + txtReAnalDetector.Text + cboxReAnalSampBeaker.Text + "*.PEF", ref dialogReAnalPefFile);                        
        }

        private void dialogReAnalTefFile_ButtonClicked(object sender, EventArgs e)
        {
            GetGammaLibraryFile("Select a TEF file", "TEF files (" + txtReAnalDetector.Text + cboxReAnalSampBeaker.Text + "*.TEF)|" + txtReAnalDetector.Text + cboxReAnalSampBeaker.Text + "*.TEF", ref dialogReAnalTefFile);                                    
        }

        private void dialogAdminDefNuclLib_FileSelected(object sender, EventArgs e)
        {
            config.SaveSetting("DefaultNuclideLibrary", dialogAdminDefNuclLib.Text);            
        }

        private void dialogAdminDefDetLib_FileSelected(object sender, EventArgs e)
        {
            config.SaveSetting("DefaultDetectionLimitLibrary", dialogAdminDefDetLib.Text);                        
        }

        private void cboxAdminDetBeakers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(labelAdminDetDetector.Text))
                return;

            string detector_name = labelAdminDetDetector.Text;
            string beaker_name = cboxAdminDetBeakers.ComboBox.SelectedItem.ToString();
            cboxAdminDetPefTef.ComboBox.Items.Clear();
            cboxAdminDetPefTef.ComboBox.Items.Add("");
            foreach (string s in config.PefFileList)
            {
                if (s.StartsWith(detector_name + beaker_name))
                    cboxAdminDetPefTef.ComboBox.Items.Add(s.Substring(0, s.Length - 4));
            }

            if (detectors.map[detector_name].Beakers.ContainsKey(beaker_name))
                cboxAdminDetPefTef.ComboBox.SelectedIndex = cboxAdminDetPefTef.ComboBox.FindStringExact(detectors.map[detector_name].Beakers[beaker_name]);
            else cboxAdminDetPefTef.ComboBox.SelectedIndex = -1;
        }

        private void cboxAnalSampBeaker_SelectedValueChanged(object sender, EventArgs e)
        {
            if(selectedDetector == null)
                return;

            string detector_name = selectedDetector.Name;
            string beaker_name = cboxAnalSampBeaker.ComboBox.SelectedItem.ToString();
            if (selectedDetector.Beakers.ContainsKey(beaker_name))
            {
                dialogAnalPEFFile.Text = selectedDetector.Beakers[beaker_name] + ".PEF";
                dialogAnalTEFFile.Text = selectedDetector.Beakers[beaker_name] + ".TEF";
            }
            else
            {
                dialogAnalPEFFile.Text = String.Empty;
                dialogAnalTEFFile.Text = String.Empty;
            }
        }

        private void tabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
            //if (tabControlAdmin.SelectedTab == pageAdminDetectors)            
              //  EmptyAdminDetectorFields();            
        }

        private void cboxReAnalSampBeaker_SelectedValueChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReAnalDetector.Text))
                return;            

            if (!detectors.map.ContainsKey(txtReAnalDetector.Text))
                return;

            selectedDetector = detectors.map[txtReAnalDetector.Text]; 

            string beaker_name = cboxReAnalSampBeaker.ComboBox.SelectedItem.ToString();
            if (selectedDetector.Beakers.ContainsKey(beaker_name))
            {
                dialogReAnalPefFile.Text = selectedDetector.Beakers[beaker_name] + ".PEF";
                dialogReAnalTefFile.Text = selectedDetector.Beakers[beaker_name] + ".TEF";
            }
            else
            {
                dialogReAnalPefFile.Text = String.Empty;
                dialogReAnalTefFile.Text = String.Empty;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGammaGUI_About formAbout = new FormGammaGUI_About();
            formAbout.ShowDialog();
        }

        private void buttonArchiveExpand_Click(object sender, EventArgs e)
        {
            treeArchive.ExpandAll();
            treeArchive.SelectedNode = null;
            listViewArchive.Items.Clear();
            DisableArchiveItemButtons();
            statusLabel.Text = String.Empty;
        }

        private void buttonArchiveCollapse_Click(object sender, EventArgs e)
        {
            treeArchive.CollapseAll();
            treeArchive.SelectedNode = null;
            listViewArchive.Items.Clear();
            DisableArchiveItemButtons();
            statusLabel.Text = String.Empty;
        }

        private void ResizeListView(ref ListView view)
        {
            foreach (ColumnHeader h in view.Columns)
                h.Width = ((view.Width - 25) / view.Columns.Count) - 1;            
        }

        private void listViewArchive_Resize(object sender, EventArgs e)
        {
            //ResizeListView(ref listViewArchive);            
            float width = (float)listViewArchive.Width - 26f;
            listViewArchive.Columns[0].Width = (int)(width * 0.15);
            listViewArchive.Columns[1].Width = (int)(width * 0.09);
            listViewArchive.Columns[2].Width = (int)(width * 0.07);
            listViewArchive.Columns[3].Width = (int)(width * 0.12);
            listViewArchive.Columns[4].Width = (int)(width * 0.07);
            listViewArchive.Columns[5].Width = (int)(width * 0.07);
            listViewArchive.Columns[6].Width = (int)(width * 0.07);
            listViewArchive.Columns[7].Width = (int)(width * 0.36);
        }

        private void listViewAdminDetectors_Resize(object sender, EventArgs e)
        {
            ResizeListView(ref listViewAdminDetectors);                        
        }

        private void lvAdmBeakers_Resize(object sender, EventArgs e)
        {
            ResizeListView(ref lvAdmBeakers);                                    
        }

        private void buttonArchivePlotSpec_Click(object sender, EventArgs e)
        {
            if (listViewArchive.SelectedIndices.Count == 0)
                return;

            ListViewItem selitem = listViewArchive.SelectedItems[0];
            string filename = selitem.SubItems[7].Text;            

            if (!File.Exists(filename))
            {
                MessageBox.Show("No spectrum data was found for this spectrum", "Message");
                return;
            }
            
            FormGammaGUI_ShowSpec form = new FormGammaGUI_ShowSpec(filename);
            form.ShowDialog();
        }

        private void buttonAnalRecalculate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxAnalSampBeaker.Text)
                && !String.IsNullOrEmpty(txtAnalHeight.Text)
                && !String.IsNullOrEmpty(txtAnalWeight.Text))
            {
                CBeaker beaker = beakers[cboxAnalSampBeaker.Text];
                float rad = beaker.Radius / 10.0f;
                float iheight = Convert.ToSingle(txtAnalHeight.Text);
                float height = iheight / 10.0f;
                float weight = Convert.ToSingle(txtAnalWeight.Text);

                float volume = 0.0f;
                float density = 0.0f;
                if (beaker.Marinelli)
                {
                    volume = (((float)Math.PI) * (beaker.Radius * beaker.Radius) * (iheight + beaker.InnerHeight)) / 1000.0f;
                    volume -= (((float)Math.PI) * (beaker.InnerRadius * beaker.InnerRadius) * beaker.InnerHeight) / 1000.0f;
                    density = weight / volume;
                }
                else
                {
                    volume = ((float)Math.PI) * (rad * rad) * height;
                    density = weight / volume;
                }

                volume = (float)Math.Round((double)volume, 1);
                density = (float)Math.Round((double)density, 1);

                txtAnalDensity.Text = String.Format("{0:0.0}", density);
                txtAnalVolume.Text = String.Format("{0:0.0}", volume);
            }
        }

        private void buttonReAnalRecalculate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboxReAnalSampBeaker.Text)
                && !String.IsNullOrEmpty(txtReAnalSampleHeight.Text)
                && !String.IsNullOrEmpty(txtReAnalSampleWeight.Text))
            {
                CBeaker beaker = beakers[cboxReAnalSampBeaker.Text];
                float rad = beaker.Radius / 10.0f;
                float iheight = Convert.ToSingle(txtReAnalSampleHeight.Text);
                float height = iheight / 10.0f;
                float weight = Convert.ToSingle(txtReAnalSampleWeight.Text);

                float volume = 0.0f;
                float density = 0.0f;
                if (beaker.Marinelli)
                {
                    volume = (((float)Math.PI) * (beaker.Radius * beaker.Radius) * (iheight + beaker.InnerHeight)) / 1000.0f;
                    volume -= (((float)Math.PI) * (beaker.InnerRadius * beaker.InnerRadius) * beaker.InnerHeight) / 1000.0f;
                    density = weight / volume;
                }
                else
                {
                    volume = ((float)Math.PI) * (rad * rad) * height;
                    density = weight / volume;
                }

                volume = (float)Math.Round((double)volume, 1);
                density = (float)Math.Round((double)density, 1);
                
                txtReAnalDensity.Text = String.Format("{0:0.0}", density);
                txtReAnalVolume.Text = String.Format("{0:0.0}", volume);
            }
        }

        private void buttonReAnal_Click(object sender, EventArgs e)
        {            
            cboxReAnalSampBeaker.Focus();
            
            if (String.IsNullOrEmpty(labelReAnalPath.Text))
            {
                MessageBox.Show("No path was specified", "Error");
                return;
            }

            if (!ValidateReAnalFields())
                return;

            CBeaker beaker = beakers[cboxReAnalSampBeaker.Text];            

            string spec_file = labelReAnalPath.Text;            
            if (!File.Exists(spec_file))
            {
                MessageBox.Show("Unable to locate spectrum file: " + spec_file, "Error");
                return;
            }

            float h = Convert.ToSingle(txtReAnalSampleHeight.Text);
            if (h < beaker.MinFillHeight)
            {
                MessageBox.Show("Height is less than " + beaker.MinFillHeight.ToString() + " which is minimum for beaker " + beaker.Name, "Error");
                return;
            }
            else if (h > beaker.MaxFillHeight)
            {
                MessageBox.Show("Height is bigger than " + beaker.MaxFillHeight.ToString() + " which is maximum for beaker " + beaker.Name, "Error");
                return;
            }

            string res_file = String.Empty, iobuff_file = String.Empty;            

            try
            {                
                iobuff_file = config.SystemPathBin + "IO_BUFF.$$$";
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);            

                StreamWriter writer = new StreamWriter(iobuff_file, false, Encoding.GetEncoding(865));
                writer.WriteLine(txtReAnalSpecnum.Text);
                writer.WriteLine(txtReAnalSampleId.Text);
                writer.WriteLine(""); // project
                writer.WriteLine(txtReAnalSamplePlace.Text);
                writer.WriteLine("0.00000000000000e+000"); // latitude
                writer.WriteLine("N"); // latitude_unit
                writer.WriteLine("0.00000000000000e+000"); // longitude
                writer.WriteLine("E"); // longitude_unit
                writer.WriteLine(txtReAnalSampleHeight.Text);
                writer.WriteLine(txtReAnalSampleWeight.Text);
                writer.WriteLine(txtReAnalDensity.Text);
                writer.WriteLine(txtReAnalVolume.Text);                
                writer.WriteLine(txtReAnalQuantity.Text);
                writer.WriteLine(txtReAnalQuantityUncertainty.Text);
                writer.WriteLine(cboxReAnalSampQuantUnit.Text);
                writer.WriteLine(txtReAnalDetector.Text);
                writer.WriteLine(txtReAnalYear.Text);
                writer.WriteLine(cboxReAnalSampBeaker.Text);
                writer.WriteLine(txtReAnalSampleStart.Text);
                writer.WriteLine(txtReAnalSampleStop.Text);
                writer.WriteLine(txtReAnalReferenceTime.Text);
                writer.WriteLine(txtReAnalMeasurementStart.Text);
                writer.WriteLine(txtReAnalMeasurementStop.Text);
                writer.WriteLine(txtReAnalRealtime.Text);
                writer.WriteLine(txtReAnalLivetime.Text);
                writer.WriteLine(txtReAnalMeasurementTime.Text);
                writer.WriteLine(txtReAnalDeadtime.Text);
                writer.WriteLine(dialogReAnalNuclLib.Text);
                writer.WriteLine(dialogReAnalDetLimLib.Text.Trim());
                writer.WriteLine(cboxReAnalSampChannels.Text);
                writer.WriteLine(txtReAnalFormat.Text);
                writer.WriteLine(txtReAnalRecLen.Text);
                writer.WriteLine(txtReAnalFWHMPS.Text);
                writer.WriteLine(txtReAnalFWHMAN.Text);
                writer.WriteLine(txtReAnalTHRESH.Text);
                writer.WriteLine(txtReAnalBSTF.Text);
                writer.WriteLine(txtReAnalETOL.Text);
                writer.WriteLine(txtReAnalLOCH.Text);
                writer.WriteLine(cbReAnalICA.Checked ? "1" : "0");
                writer.WriteLine(dialogReAnalEnergyFile.Text);
                writer.WriteLine(dialogReAnalPefFile.Text);
                writer.WriteLine(dialogReAnalTefFile.Text);
                writer.WriteLine(dialogReAnalBackgroundFile.Text);
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("1");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.Close();                

                File.Copy(spec_file, config.SystemPathBin + "SP_BUFF.$$$", true);                

                if (File.Exists(config.SystemPathBin + "PLOT-1.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-1.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-2.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-2.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-3.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-3.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-4.HPL");                

                Process p = new Process();
                p.StartInfo.FileName = config.GammaExecutableFile;
                p.StartInfo.WorkingDirectory = Path.GetDirectoryName(config.GammaExecutableFile);
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.RedirectStandardError = true;
                p.StartInfo.CreateNoWindow = true;

                string gamma_exe = Path.GetFileName(config.GammaExecutableFile);
                statusLabel.Text = "Running " + gamma_exe + ". Please wait...";                                
                Application.DoEvents();

                p.Start();

                string cout = p.StandardOutput.ReadToEnd();
                string cerr = p.StandardError.ReadToEnd();

                p.WaitForExit();                

                statusLabel.Text = (p.ExitCode == 0 ? gamma_exe + " finished successfully" : gamma_exe + " failed with exit code " + p.ExitCode.ToString());

                res_file = Path.GetFileNameWithoutExtension(spec_file) + ".LIS";                

                if (p.ExitCode == 0)
                    repairLIS(config.SystemPathBin + res_file, dialogReAnalDetLimLib.Text.Trim());                

                FormGammaGUI_AnalResult form = new FormGammaGUI_AnalResult(spec_file);
                form.Text = "Analysis results from " + gamma_exe;
                form.SetGammaContent("Exit code: " + p.ExitCode.ToString() + Environment.NewLine + Environment.NewLine
                    + "Standard output: " + Environment.NewLine + cout + Environment.NewLine + Environment.NewLine
                    + "Standard error: " + Environment.NewLine + cerr);
                if (File.Exists(config.SystemPathBin + res_file))
                    form.SetLISContent(File.ReadAllText(config.SystemPathBin + res_file, Encoding.GetEncoding(865)));
                if (File.Exists(iobuff_file))
                    form.SetINPContent(File.ReadAllText(iobuff_file, Encoding.GetEncoding(865)));
                form.SetGammaExitCode(p.ExitCode);
                form.ShowDialog();                

                if (p.ExitCode == 0)
                {
                    // analysing was successfull, store results...
                    if (!form.Rejected)
                    {
                        if (File.Exists(config.SystemPathBin + res_file))
                            File.Copy(config.SystemPathBin + res_file, Path.GetDirectoryName(spec_file) + "\\" + res_file, true);

                        if (File.Exists(iobuff_file))
                            File.Copy(iobuff_file, spec_file.Substring(0, spec_file.Length - 4) + ".INP", true);

                        if (File.Exists(config.SystemPathBin + "PLOT-1.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-2.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-3.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                        {
                            ZipFile zip = new ZipFile();
                            zip.AddFile(config.SystemPathBin + "PLOT-1.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-2.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-3.HPL", "");
                            zip.AddFile(config.SystemPathBin + "PLOT-4.HPL", "");
                            zip.Save(spec_file.Substring(0, spec_file.Length - 4) + ".ZIP");
                        }
                    }

                    if (form.PrintPlot)
                    {
                        if (File.Exists(config.SystemPathBin + "PLOT-1.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-2.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-3.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                        {
                            splitterEditAnal.Enabled = false;
                            statusLabel.Text = "Printing analysis...";
                            Application.DoEvents();

                            string lis_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".LIS";
                            string plot_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_2 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_3 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_4 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";

                            File.Copy(Path.GetDirectoryName(spec_file) + "\\" + res_file, lis_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-1.HPL", plot_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-2.HPL", plot_file_2, true);
                            File.Copy(config.SystemPathBin + "PLOT-3.HPL", plot_file_3, true);
                            File.Copy(config.SystemPathBin + "PLOT-4.HPL", plot_file_4, true);
                            
                            try
                            {
                                if(!Utils.PrintReport(lis_file_1, plot_file_1, plot_file_2, plot_file_3, plot_file_4, useDefaultPrinter))
                                    MessageBox.Show("Printing failed. Make sure a printer is online and available", "Message");                                
                            }
                            finally
                            {                                
                                statusLabel.Text = "Done printing";
                                Application.DoEvents();
                                splitterEditAnal.Enabled = true;
                            }
                        }
                    }
                    Log.addMessage("Running " + gamma_exe + " on spectrum " + Path.GetFileNameWithoutExtension(spec_file) + " was a success");
                }
                else
                {
                    Log.addError("Running " + gamma_exe + " on spectrum " + Path.GetFileNameWithoutExtension(spec_file) + " failed");
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                Log.addError(ex.Message);
            }
            finally
            {
                if (!String.IsNullOrEmpty(res_file) && File.Exists(config.SystemPathBin + res_file))
                    File.Delete(config.SystemPathBin + res_file);
                if (!String.IsNullOrEmpty(iobuff_file) && File.Exists(iobuff_file))
                    File.Delete(iobuff_file);
                if (File.Exists(config.SystemPathBin + "SP_BUFF.$$$"))
                    File.Delete(config.SystemPathBin + "SP_BUFF.$$$");                                
            }            
        }

        private void buttonReAnalCancel_Click(object sender, EventArgs e)
        {            
            wizardMain.SelectedTab = pageAnalArchive;
        }

        private void Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != '.')            
                e.Handled = true;                            
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))            
                e.Handled = true;            
        }

        private void Numeric_Leave(object sender, EventArgs e)
        {
            VintageControls.LabeledTextBox tb = (VintageControls.LabeledTextBox)sender;
            int periods = 0;
            foreach (char c in tb.Text)
            {
                if (c == '.')
                    ++periods;
                if (!Char.IsNumber(c) && c != '.')
                {
                    tb.Text = String.Empty;
                    MessageBox.Show("Decimal numbers must contain only numbers and a period (.)", "Message");
                    return;
                }
            }

            if (tb.Text.Length > 0 && periods != 1)            
                tb.Text += ".0";            
        }

        private void Datum_Leave(object sender, EventArgs e)
        {            
            VintageControls.LabeledTextBox tb = (VintageControls.LabeledTextBox)sender;
            if (String.IsNullOrEmpty(tb.Text))
                return;
            if (tb.Text.Length != 12)
            {
                MessageBox.Show("Date fields must contain exactly 12 numbers. Format: YYYYMMDDhhmm", "Message");
                tb.Text = String.Empty;
            }
        }        

        private void cbAdminEmulateFixCHN_CheckedChanged(object sender, EventArgs e)
        {
            config.SaveSetting("EmulateFixCHN", cbAdminEmulateFixCHN.Checked.ToString());            
        }

        private void cbAdminUseDafaultPrinter_CheckedChanged(object sender, EventArgs e)
        {
            config.SaveSetting("UseDefaultPrinter", cbAdminUseDafaultPrinter.Checked.ToString());                        
        }

        private void listViewArchive_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                bool hasINP = (e.Item.SubItems[4].Text == "Yes" ? true : false);
                bool hasLIS = (e.Item.SubItems[5].Text == "Yes" ? true : false);
                bool hasPlot = (e.Item.SubItems[6].Text == "Yes" ? true : false);

                buttonArchiveShowINP.Enabled = menuArchiveFilesShowINP.Enabled = hasINP;
                buttonArchiveShowLIS.Enabled = buttonArchiveCreateBackground.Enabled = menuArchiveFilesShowLIS.Enabled = menuArchiveCreateBackground.Enabled = hasLIS;
                buttonArchivePrintAnalyse.Enabled = menuArchiveFilesPrintAnalyse.Enabled = (hasLIS && hasPlot);

                toolButtonReAnalyse.Enabled = true;
                buttonArchiveShowSpec.Enabled = true;
            }
            else
            {
                DisableArchiveItemButtons();
            }
        }        

        private void buttonArchivePrintAnalyse_Click(object sender, EventArgs e)
        {            
            if (listViewArchive.SelectedIndices.Count == 0)
                return;                        

            if (File.Exists(config.SystemPathBinWork + "PLOT-1.HPL"))
                File.Delete(config.SystemPathBinWork + "PLOT-1.HPL");
            if (File.Exists(config.SystemPathBinWork + "PLOT-2.HPL"))
                File.Delete(config.SystemPathBinWork + "PLOT-2.HPL");
            if (File.Exists(config.SystemPathBinWork + "PLOT-3.HPL"))
                File.Delete(config.SystemPathBinWork + "PLOT-3.HPL");
            if (File.Exists(config.SystemPathBinWork + "PLOT-4.HPL"))
                File.Delete(config.SystemPathBinWork + "PLOT-4.HPL");

            ListViewItem selitem = listViewArchive.SelectedItems[0];
            string chn_file = selitem.SubItems[7].Text;
            string lis_file = chn_file.Substring(0, chn_file.Length - 4) + ".LIS";            
            string plot_file = chn_file.Substring(0, chn_file.Length - 4) + ".ZIP";            
            ZipFile zip = new ZipFile(plot_file);
            zip.ExtractAll(config.SystemPathBinWork);

            if (File.Exists(config.SystemPathBinWork + "PLOT-1.HPL")
                && File.Exists(config.SystemPathBinWork + "PLOT-2.HPL")
                && File.Exists(config.SystemPathBinWork + "PLOT-3.HPL")
                && File.Exists(config.SystemPathBinWork + "PLOT-4.HPL"))
            {
                string lis_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".LIS";
                string plot_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                string plot_file_2 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                string plot_file_3 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                string plot_file_4 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";

                File.Copy(lis_file, lis_file_1, true);
                File.Copy(config.SystemPathBinWork + "PLOT-1.HPL", plot_file_1, true);
                File.Copy(config.SystemPathBinWork + "PLOT-2.HPL", plot_file_2, true);
                File.Copy(config.SystemPathBinWork + "PLOT-3.HPL", plot_file_3, true);
                File.Copy(config.SystemPathBinWork + "PLOT-4.HPL", plot_file_4, true);
                
                try
                {
                    panelArchive.Enabled = false;
                    statusLabel.Text = "Printing analysis...";
                    Application.DoEvents();                                                        

                    if(!Utils.PrintReport(lis_file_1, plot_file_1, plot_file_2, plot_file_3, plot_file_4, useDefaultPrinter))
                        MessageBox.Show("Printing failed. Make sure a printer is online and available", "Message");                                
                }
                finally
                {                    
                    panelArchive.Enabled = true;
                    statusLabel.Text = "Done printing";
                    Application.DoEvents();                    
                }                                
            }
            else
            {
                MessageBox.Show("One or more plot files is missing, can not continue", "Error");
            }
        }                        

        private void splitterNewAnal_Resize(object sender, EventArgs e)
        {
            panelAnalTopLeft.Width = panelAnalTopRight.Width = splitterNewAnal.Width / 3;
            panelAnalBottomLeft.Width = panelAnalBottomRight.Width = splitterNewAnal.Width / 3;            
        }

        private void splitterEditAnal_Resize(object sender, EventArgs e)
        {
            panelReAnalTopLeft.Width = panelReAnalTopRight.Width = splitterEditAnal.Width / 3;
            panelReAnalBottomLeft.Width = panelReAnalBottomRight.Width = splitterEditAnal.Width / 3;            
        }

        private void buttonAdminScriptsSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAdminScriptsStart.Text)
                || String.IsNullOrEmpty(txtAdminScriptsStop.Text)
                || String.IsNullOrEmpty(txtAdminScriptsBuffer.Text))
            {
                MessageBox.Show("Scripts and parameters can not be empty", "Error");
                return;
            }

            config.SaveSetting("MaestroScriptStart", txtAdminScriptsStart.Text);
            config.SaveSetting("MaestroScriptStop", txtAdminScriptsStop.Text);
            config.SaveSetting("MaestroScriptBuffer", txtAdminScriptsBuffer.Text);

            statusLabel.Text = "Maestro scripts saved";
        }

        private void buttonAdminAddDummyDetector_Click(object sender, EventArgs e)
        {
            if (detectors.Add("0", "", "Dummy"))
            {
                if(!detectors.LoadAll())
                {
                    MessageBox.Show("Loading detector information failed");
                    return;
                }
                config.LoadAssetsBin();
                displayDetectors();
            }
        }

        private void flowMenuDetectors_Click(object sender, EventArgs e)
        {
            selectedDetector = (CDetector)((Button)sender).Tag;

            cboxAnalSampBeaker.ComboBox.Items.Clear();
            cboxReAnalSampBeaker.ComboBox.Items.Clear();
            cboxAnalSampBeaker.ComboBox.Items.Add("");
            cboxReAnalSampBeaker.ComboBox.Items.Add("");
            foreach (string s in selectedDetector.Beakers.Keys)
            {
                if (beakers.map[s].InUse)
                {
                    cboxAnalSampBeaker.ComboBox.Items.Add(s);
                    cboxReAnalSampBeaker.ComboBox.Items.Add(s);
                }
            }

            if (selectedDetector.Dummy)
            {
                FormGammaGUI_SelectDetector form = new FormGammaGUI_SelectDetector(selectedDetector);
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EmptyReAnalFields();                    
                    cboxReAnalSampBeaker.ComboBox.Items.Clear();                    
                    cboxReAnalSampBeaker.ComboBox.Items.Add("");
                    foreach (string s in selectedDetector.Beakers.Keys)                    
                        if (beakers.map[s].InUse)                    
                            cboxReAnalSampBeaker.ComboBox.Items.Add(s);                        
                    int nextSpecCnt = selectedDetector.SpectrumCounter + 1;
                    string specname = form.DetectorName + form.Year + String.Format("{0:0000}", nextSpecCnt);
                    if (!Directory.Exists(config.SystemPathSpec + form.Year))
                        Directory.CreateDirectory(config.SystemPathSpec + form.Year);
                    labelReAnalPath.Text = config.SystemPathSpec + form.Year + "\\" + specname + ".CHN";
                    File.Copy(form.CHNFile, labelReAnalPath.Text, true);
                    selectedDetector.SpectrumCounter++;
                    if (detectors.Save(selectedDetector.Name, selectedDetector.Dummy))
                    {                        
                        FillDefaultReAnalParametersWithSelectedDetector();
                        splitterEditAnal.Panel2Collapsed = true;
                        wizardMain.SelectedTab = pageReAnal;
                    }
                }
            }
            else
            {
                cboxAnalSampBeaker.ComboBox.Items.Clear();
                cboxAnalSampBeaker.ComboBox.Items.Add("");
                foreach (string s in selectedDetector.Beakers.Keys)
                    if (beakers.map[s].InUse)
                        cboxAnalSampBeaker.ComboBox.Items.Add(s);                        
                wizardMain.SelectedTab = pageAnal;
                splitterNewAnal.Panel2Collapsed = true;
                labelStartStopView.Text = selectedDetector.Name;
                FillDefaultAnalParametersWithSelectedDetector();
            }
        }

        private void flowMenu_Click(object sender, EventArgs e)
        {
            wizardMain.SelectedTab = (TabPage)((Button)sender).Tag;
        }

        private void treeArchive_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DisableArchiveItemButtons();

            if (e.Node.Level < 1)
            {
                listViewArchive.Items.Clear();
                statusLabel.Text = String.Empty;                
                e.Node.Toggle();                
                return;
            }
            
            int filesFound = 0;
            statusLabel.Text = String.Empty;

            statusProgress.Minimum = 0;
            statusProgress.Value = 0;
            statusProgress.Step = 1;
            statusProgress.Maximum = 3;
            statusProgress.Visible = true;
            Application.DoEvents();

            listViewArchive.Items.Clear();

            statusProgress.PerformStep();

            DirectoryInfo dir = new DirectoryInfo(config.SystemPathSpec);
            string detector = e.Node.Parent.Text;
            string year = e.Node.Text;
            FileInfo[] files = dir.GetFiles(detector + year + "*.CHN", SearchOption.AllDirectories);

            statusProgress.PerformStep();

            foreach (FileInfo fi in files)
            {
                string spec = fi.Name.Substring(4, 4);
                string spath = Path.GetDirectoryName(fi.FullName);
                string fname = Path.GetFileNameWithoutExtension(fi.FullName);
                string lisfile = spath + "\\" + fname + ".LIS";
                string inpfile = spath + "\\" + fname + ".INP";
                string plotfile = spath + "\\" + fname + ".ZIP";
                string lis = (File.Exists(lisfile) ? "Yes" : "No");
                string inp = (File.Exists(inpfile) ? "Yes" : "No");
                string plot = (File.Exists(plotfile) ? "Yes" : "No");
                string[] titles = { fi.Name, detector, year, spec, inp, lis, plot, fi.FullName };
                ListViewItem item = new ListViewItem(titles, "detector");
                listViewArchive.Items.Add(item);
                ++filesFound;
            }

            statusProgress.PerformStep();
            statusProgress.Visible = false;
            statusLabel.Text = "Showing " + filesFound.ToString() + " files";
        }

        private void buttonAnalBuffer_Click(object sender, EventArgs e)
        {
            cboxAnalSampBeaker.Focus();            

            if (selectedDetector == null)
            {
                MessageBox.Show("No detector is selected", "Error");
                return;
            }

            string specsoft = selectedDetector.SpectrumSoftware.Trim();

            if (specsoft == "Maestro" && !config.MaestroExists())
            {
                MessageBox.Show("Maestro executable was not found. Please run Maestro setup before continuing", "Error");
                return;
            }
            else if (specsoft == "Genie" && !config.GenieExists())
            {
                MessageBox.Show("Genie executable was not found. Please run Genie setup before continuing", "Error");
                return;
            }            

            if (!ValidateAnalFields())
                return;

            CBeaker beaker = beakers[cboxAnalSampBeaker.Text];

            float height = Convert.ToSingle(txtAnalHeight.Text);
            if (height > beaker.MaxFillHeight)
            {
                MessageBox.Show("Max fill height for beaker " + beaker.Name + " is " + beaker.MaxFillHeight.ToString(), "Message");
                return;
            }
            else if (height < beaker.MinFillHeight)
            {
                MessageBox.Show("Min fill height for beaker " + beaker.Name + " is " + beaker.MinFillHeight.ToString(), "Message");
                return;
            }            

            if (specsoft == "Maestro" && !config.DetectorIdExists(selectedDetector.ID))
            {
                MessageBox.Show("The detector ID " + selectedDetector.ID.ToString() + " is not defined by Maestro", "Error");                
                return;
            }            

            string job_file = String.Empty;
            string res_file = txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + ".LIS";
            string res_path_file = config.SystemPathBin + res_file;

            try
            {
                if (File.Exists(config.SystemPathBin + "SP_BUFF.$$$"))
                    File.Delete(config.SystemPathBin + "SP_BUFF.$$$");

                if (specsoft == "Maestro")
                {
                    job_file = config.SystemPathBin + txtAnalDetector.Text + txtAnalYear.Text + txtAnalSpecNum.Text + "_peek.job";
                    StreamWriter jwriter = new StreamWriter(job_file);
                    string[] delimiters = { Environment.NewLine };
                    string[] lines = txtAdminScriptsBuffer.Text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                    string scriptLine = "";
                    foreach (string l in lines)
                    {
                        scriptLine = l.Replace("@DID", selectedDetector.ID.ToString());
                        scriptLine = scriptLine.Replace("@SAVE_FILE", config.SystemPathBin + "SP_BUFF");
                        scriptLine = scriptLine.Replace("@BUFFER_FILE", config.SystemPathBin + "SP_BUFF_TEMP");
                        jwriter.WriteLine(scriptLine);
                    }
                    jwriter.Close();

                    Process p = new Process();
                    p.StartInfo.FileName = config.Settings["MaestroExecutable"];
                    p.StartInfo.Arguments = job_file;
                    p.StartInfo.WorkingDirectory = config.SystemPathBin;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    statusLabel.Text = "Running Maestro. Please wait...";
                    splitterNewAnal.Enabled = false;
                    Application.DoEvents();

                    p.Start();
                    p.WaitForExit();

                    if (p.ExitCode == 0)
                        statusLabel.Text = "Maestro finished sucessfully";
                    else
                    {
                        statusLabel.Text = "Maestro failed with exit code " + p.ExitCode.ToString();                        
                        return;
                    }

                    File.Copy(config.SystemPathBin + "SP_BUFF_TEMP.Chn", config.SystemPathBin + "SP_BUFF.$$$", true);
                }
                else if (specsoft == "Genie")
                {
                    Process p = new Process();
                    p.StartInfo.FileName = config.Settings["GenieFolder"] + "\\EXEFILES\\analyze.exe";
                    p.StartInfo.Arguments = "Det:" + selectedDetector.Name + " /SEQ=" + config.Settings["GenieFolder"] + "\\CTLFILES\\Spek10rap.ASF";
                    p.StartInfo.WorkingDirectory = config.SystemPathBin;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    statusLabel.Text = "Running Genie (Analyze.exe). Please wait...";
                    Application.DoEvents();

                    p.Start();
                    p.WaitForExit();

                    if (p.ExitCode == 0)
                        statusLabel.Text = "Genie (Analyze.exe) finished sucessfully";
                    else
                    {
                        statusLabel.Text = "Genie (Analyze.exe) failed. Exit code " + p.ExitCode.ToString();                        
                        return;
                    }

                    File.Copy(config.Settings["GenieFolder"] + "\\REPFILES\\" + selectedDetector.Name + ".RPT", config.SystemPathBin + "CAN_REP.$$$", true);

                    p = new Process();
                    p.StartInfo.FileName = config.SystemPathBin + "cancon.exe";
                    p.StartInfo.WorkingDirectory = config.SystemPathBin;
                    p.StartInfo.UseShellExecute = true;
                    p.StartInfo.CreateNoWindow = true;
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                    statusLabel.Text = "Running cancon.exe. Please wait...";
                    Application.DoEvents();

                    p.Start();
                    p.WaitForExit();

                    if (p.ExitCode == 0)
                        statusLabel.Text = "cancon.exe finished sucessfully";
                    else
                    {
                        statusLabel.Text = "cancon.exe failed. Exit code " + p.ExitCode.ToString();                        
                        return;
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");                
                return;
            }
            finally
            {
                splitterNewAnal.Enabled = true;
                if (!String.IsNullOrEmpty(job_file) && File.Exists(job_file))
                    File.Delete(job_file);
                if (File.Exists(config.SystemPathBin + "SP_BUFF_TEMP.Chn"))
                    File.Delete(config.SystemPathBin + "SP_BUFF_TEMP.Chn");
                if (File.Exists(config.SystemPathBin + "CAN_REP.$$$"))
                    File.Delete(config.SystemPathBin + "CAN_REP.$$$");
                if (File.Exists(config.SystemPathBin + "BUFFER.TXT"))
                    File.Delete(config.SystemPathBin + "BUFFER.TXT");
                if (File.Exists(config.SystemPathBin + "DUMMY.DAT"))
                    File.Delete(config.SystemPathBin + "DUMMY.DAT");
            }

            string iobuff_file = String.Empty;

            try
            {
                CHN_Header header = new CHN_Header();
                header.Read(config.SystemPathBin + "SP_BUFF.$$$", true);

                iobuff_file = config.SystemPathBin + "IO_BUFF.$$$";
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);

                StreamWriter writer = new StreamWriter(iobuff_file, false, Encoding.GetEncoding(865));
                writer.WriteLine(txtAnalSpecNum.Text);
                writer.WriteLine(txtAnalSampleId.Text);
                writer.WriteLine(""); // project
                writer.WriteLine(txtAnalSamplePlace.Text);
                writer.WriteLine("0.00000000000000e+000"); // latitude
                writer.WriteLine("N"); // latitude_unit
                writer.WriteLine("0.00000000000000e+000"); // longitude
                writer.WriteLine("E"); // longitude_unit
                writer.WriteLine(txtAnalHeight.Text);
                writer.WriteLine(txtAnalWeight.Text);
                writer.WriteLine(txtAnalDensity.Text);
                writer.WriteLine(txtAnalVolume.Text);
                writer.WriteLine(txtAnalQuantity.Text);
                writer.WriteLine(txtAnalQuantityUncertainty.Text);
                writer.WriteLine(cboxAnalSampQuantUnit.Text);
                writer.WriteLine(txtAnalDetector.Text);
                writer.WriteLine(txtAnalYear.Text);
                writer.WriteLine(cboxAnalSampBeaker.Text);
                writer.WriteLine(txtAnalSamplingStart.Text);
                writer.WriteLine(txtAnalSamplingStop.Text);
                writer.WriteLine(txtAnalReferenceTime.Text);
                writer.WriteLine(header.MeasurementStart); // txtAnalMeasurementStart.Text
                writer.WriteLine(header.MeasurementStop); // txtAnalMeasurementStop.Text
                writer.WriteLine(((int)header.RealTimeSeconds).ToString()); // txtAnalRealtime.Text
                writer.WriteLine(((int)header.LiveTimeSeconds).ToString()); // txtAnalLivetime.Text
                writer.WriteLine("0"); // txtAnalMeasurementTime.Text
                writer.WriteLine(header.DeadTime.ToString()); // txtAnalDeadtime.Text
                writer.WriteLine(dialogAnalNuclLib.Text);
                writer.WriteLine(dialogAnalDetLimLib.Text.Trim());
                writer.WriteLine(selectedDetector.Channels.ToString());
                writer.WriteLine(selectedDetector.Format);
                writer.WriteLine(selectedDetector.BytesPerRecord.ToString());
                writer.WriteLine(txtAnalFWHMPS.Text);
                writer.WriteLine(txtAnalFWHMAN.Text);
                writer.WriteLine(txtAnalTHRESH.Text);
                writer.WriteLine(txtAnalBSTF.Text);
                writer.WriteLine(txtAnalETOL.Text);
                writer.WriteLine(txtAnalLOCH.Text);
                writer.WriteLine(cbAnalICA.Checked ? "1" : "0");
                writer.WriteLine(dialogAnalEnergyFile.Text);
                writer.WriteLine(dialogAnalPEFFile.Text);
                writer.WriteLine(dialogAnalTEFFile.Text);
                writer.WriteLine(dialogAnalBackgroundFile.Text);
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("1");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.WriteLine("0");
                writer.Close();                                

                if (File.Exists(config.SystemPathBin + "PLOT-1.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-1.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-2.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-2.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-3.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-3.HPL");
                if (File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                    File.Delete(config.SystemPathBin + "PLOT-4.HPL");

                Process pg = new Process();
                pg.StartInfo.FileName = config.GammaExecutableFile;
                pg.StartInfo.WorkingDirectory = Path.GetDirectoryName(config.GammaExecutableFile);
                pg.StartInfo.CreateNoWindow = true;
                pg.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                pg.StartInfo.UseShellExecute = false;
                pg.StartInfo.RedirectStandardOutput = true;
                pg.StartInfo.RedirectStandardError = true;

                string gamma_exe = Path.GetFileName(config.GammaExecutableFile);

                statusLabel.Text = "Running " + gamma_exe + ". Please wait...";
                splitterNewAnal.Enabled = false;
                Application.DoEvents();
                
                pg.Start();

                string cout = pg.StandardOutput.ReadToEnd();
                string cerr = pg.StandardError.ReadToEnd();

                pg.WaitForExit();

                if (pg.ExitCode == 0)
                    repairLIS(res_path_file, dialogAnalDetLimLib.Text.Trim());

                statusLabel.Text = (pg.ExitCode == 0 ? gamma_exe + " finished successfully" : gamma_exe + " failed with exit code " + pg.ExitCode.ToString());

                FormGammaGUI_AnalResult form = new FormGammaGUI_AnalResult(config.SystemPathBin + "SP_BUFF.$$$");
                form.Text = "Analysis results from " + gamma_exe;
                form.SetGammaContent("Exit code: " + pg.ExitCode.ToString() + Environment.NewLine + Environment.NewLine
                    + "Standard output: " + Environment.NewLine + cout + Environment.NewLine + Environment.NewLine
                    + "Standard error: " + Environment.NewLine + cerr);
                if (File.Exists(res_path_file))
                    form.SetLISContent(File.ReadAllText(res_path_file, Encoding.GetEncoding(865)));
                if (File.Exists(iobuff_file))
                    form.SetINPContent(File.ReadAllText(iobuff_file, Encoding.GetEncoding(865)));
                form.SetGammaExitCode(pg.ExitCode);
                form.SetRequireReject();
                form.ShowDialog();

                if (pg.ExitCode == 0)
                {                    
                    if (form.PrintPlot)
                    {
                        if (File.Exists(config.SystemPathBin + "PLOT-1.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-2.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-3.HPL")
                            && File.Exists(config.SystemPathBin + "PLOT-4.HPL"))
                        {
                            string lis_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".LIS";
                            string plot_file_1 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_2 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_3 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";
                            string plot_file_4 = config.SystemPathBinWork + Guid.NewGuid().ToString() + ".HPL";

                            File.Copy(res_path_file, lis_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-1.HPL", plot_file_1, true);
                            File.Copy(config.SystemPathBin + "PLOT-2.HPL", plot_file_2, true);
                            File.Copy(config.SystemPathBin + "PLOT-3.HPL", plot_file_3, true);
                            File.Copy(config.SystemPathBin + "PLOT-4.HPL", plot_file_4, true);

                            splitterNewAnal.Enabled = false;
                            statusLabel.Text = "Printing analysis...";
                            Application.DoEvents();
                            
                            try
                            {                                
                                if(!Utils.PrintReport(lis_file_1, plot_file_1, plot_file_2, plot_file_3, plot_file_4, useDefaultPrinter))
                                    MessageBox.Show("Printing failed. Make sure a printer is online and available", "Message");                                
                            }
                            finally
                            {
                                splitterNewAnal.Enabled = true;
                                statusLabel.Text = "Done printing";
                                Application.DoEvents();                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("No plot files found. Can not print", "Error");
                        }
                    }

                    Log.addMessage("Running " + gamma_exe + " on spectrum " + res_file.Substring(0, res_file.Length - 4) + " was a success");
                }
                else
                {
                    Log.addError("Running " + gamma_exe + " on spectrum " + res_file.Substring(0, res_file.Length - 4) + " failed");
                }                                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
                Log.addError(ex.Message);
            }
            finally
            {
                splitterNewAnal.Enabled = true;                
                if (!String.IsNullOrEmpty(res_path_file) && File.Exists(res_path_file))
                    File.Delete(res_path_file);
                if (File.Exists(iobuff_file))
                    File.Delete(iobuff_file);
                if (File.Exists(config.SystemPathBin + "SP_BUFF.$$$"))
                    File.Delete(config.SystemPathBin + "SP_BUFF.$$$");
            }
        }

        private void buttonArchiveShowHistory_Click(object sender, EventArgs e)
        {
            string hist_file = config.SystemPathLog + "HISTORY.TXT";
            if (!File.Exists(hist_file))
            {
                MessageBox.Show("The file " + hist_file + " was not found", "Message");
                return;
            }

            FormGammaGUI_ShowText form = new FormGammaGUI_ShowText(Convert.ToBoolean(config.Settings["UseDefaultPrinter"]));
            form.Text = hist_file;
            form.setContent(File.ReadAllText(hist_file, Encoding.GetEncoding(865)));
            form.ShowDialog();
        }

        private void buttonArchiveSearch_Click(object sender, EventArgs e)
        {
            int filesFound = 0;
            FormGammaGUI_ArchiveSearch form = new FormGammaGUI_ArchiveSearch(config, treemap);
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            statusLabel.Text = String.Empty;
            listViewArchive.Items.Clear();
            DisableArchiveItemButtons();
            treeArchive.CollapseAll();
            treeArchive.SelectedNode = null;

            statusProgress.Minimum = 0;
            statusProgress.Value = 0;
            statusProgress.Step = 1;
            statusProgress.Maximum = 3;
            statusProgress.Visible = true;                        

            statusProgress.PerformStep();
            panelArchive.Enabled = false;
            Application.DoEvents();

            DirectoryInfo dir = new DirectoryInfo(config.SystemPathSpec);
            string wild = (form.Detector == String.Empty && form.Year != String.Empty) ? "*" : form.Detector;
            FileInfo[] files = dir.GetFiles(wild + form.Year + "*.CHN", SearchOption.AllDirectories);

            statusProgress.PerformStep();

            foreach (FileInfo fi in files)
            {
                string inp_file = fi.FullName.Substring(0, fi.FullName.Length - 4) + ".INP";

                if (!File.Exists(inp_file))
                    continue;

                if (HasToken(inp_file, form.Field, form.Token))
                {
                    string spec = fi.Name.Substring(4, 4);
                    string spath = Path.GetDirectoryName(fi.FullName);
                    string fname = Path.GetFileNameWithoutExtension(fi.FullName);
                    string lisfile = spath + "\\" + fname + ".LIS";
                    string inpfile = spath + "\\" + fname + ".INP";
                    string plotfile = spath + "\\" + fname + ".ZIP";
                    string lis = (File.Exists(lisfile) ? "Yes" : "No");
                    string inp = (File.Exists(inpfile) ? "Yes" : "No");
                    string plot = (File.Exists(plotfile) ? "Yes" : "No");
                    string[] titles = { fi.Name, fi.Name.Substring(0, 2), fi.Name.Substring(2, 2), spec, inp, lis, plot, fi.FullName };
                    ListViewItem item = new ListViewItem(titles, "detector");
                    listViewArchive.Items.Add(item);
                    ++filesFound;
                }
            }

            statusProgress.PerformStep();
            statusProgress.Visible = false;
            panelArchive.Enabled = true;
            statusLabel.Text = filesFound.ToString() + " files found";
        }

        private bool HasToken(string filename, string field, string token)
        {
            bool returnValue = false;
            string line;
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(filename);
                if (reader.EndOfStream) return false;
                switch (field)
                {
                    case "ID/Type":
                        reader.ReadLine();
                        if (reader.EndOfStream) return false;
                        break;
                    case "Geometry":
                        for (int i = 0; i < 17; i++)
                        {
                            reader.ReadLine();
                            if (reader.EndOfStream) return false;
                        }
                        break;
                    default:
                        MessageBox.Show("Unknown field: " + field, "Error");
                        return false;                        
                }

                line = reader.ReadLine();
                if (line.ToUpper().Contains(token.ToUpper()))
                    returnValue = true;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                if(reader != null)
                    reader.Close();
            }
            return returnValue;
        }

        private void buttonCreateJournal_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            dialog.AddExtension = true;
            dialog.Title = "Save journal for " + treeArchive.SelectedNode.FullPath.Replace("\\", " ") + " as ...";
            dialog.Filter = "PDF files (*.PDF)|*.PDF";
            dialog.FileName = treeArchive.SelectedNode.FullPath.Replace("\\", "") + "_" 
                + String.Format("{0:00}", DateTime.Now.Day) 
                + String.Format("{0:00}", DateTime.Now.Month) 
                + String.Format("{0:0000}", DateTime.Now.Year);

            string filename = String.Empty;
            if (dialog.ShowDialog() == DialogResult.OK)            
                filename = dialog.FileName;            
            else return;

            List<string> invalid_items = new List<string>();
            List<string> missing_items = new List<string>();

            txt.Document doc = null;

            try
            {
                doc = new txt.Document();
                pdf.PdfWriter writer = pdf.PdfWriter.GetInstance(doc, new FileStream(filename, FileMode.Create));
                doc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("The document " + filename + " is busy. Try again later", "Message");
                return;
            }

            pdf.BaseFont bfTimes = pdf.BaseFont.CreateFont(pdf.BaseFont.TIMES_ROMAN, pdf.BaseFont.CP1252, true);
            txt.Font times_big = new txt.Font(bfTimes, 28, txt.Font.BOLD);
            txt.Font times_somewhat_big = new txt.Font(bfTimes, 22, txt.Font.BOLD);
            txt.Font times_medium = new txt.Font(bfTimes, 12, txt.Font.BOLD);
            txt.Font times_small = new txt.Font(bfTimes, 8, txt.Font.NORMAL);

            txt.Paragraph label_empty = new txt.Paragraph(" ", times_big);

            doc.Add(label_empty);
            txt.Paragraph label = new txt.Paragraph("HPGe detektorjournal", times_big);
            label.Alignment = txt.Element.ALIGN_CENTER;
            doc.Add(label);
            doc.Add(label_empty);
            doc.Add(label_empty);
            label = new txt.Paragraph(treeArchive.SelectedNode.FullPath.Replace("\\", " "), times_somewhat_big);
            label.Alignment = txt.Element.ALIGN_CENTER;
            doc.Add(label);
            doc.Add(label_empty);
            doc.Add(label_empty);
            label = new txt.Paragraph(String.Format("{0:00}", DateTime.Now.Day) + "." + String.Format("{0:00}", DateTime.Now.Month) + "." + String.Format("{0:0000}", DateTime.Now.Year), times_medium);
            label.Alignment = txt.Element.ALIGN_CENTER;
            doc.Add(label);

            doc.NewPage();
            int nTables = 0;

            foreach (ListViewItem item in listViewArchive.Items)
            {
                string chn_file = item.SubItems[7].Text;
                string inp_file = chn_file.Substring(0, chn_file.Length - 4) + ".INP";
                if (!File.Exists(inp_file))
                {
                    missing_items.Add(inp_file);
                    continue;
                }

                string line;
                List<string> lines = new List<string>();
                StreamReader reader = new StreamReader(inp_file, Encoding.GetEncoding(865));
                while ((line = reader.ReadLine()) != null)
                    lines.Add(line);
                reader.Close();

                if (lines.Count < LINES_IN_INP)
                {
                    invalid_items.Add(inp_file);
                    continue;
                }
                    
                pdf.PdfPTable table = new pdf.PdfPTable(2);                    
                table.SpacingAfter = 14f;
                table.AddCell(new txt.Phrase("ID: " + lines[1], times_small));
                table.AddCell(new txt.Phrase("Spectrum: " + lines[15] + " " + lines[16] + " " + lines[0], times_small));                
                table.AddCell(new txt.Phrase("Place: " + lines[3], times_small));
                table.AddCell(new txt.Phrase("Geometry: " + lines[17], times_small));                
                table.AddCell(new txt.Phrase("Ref. date: " + Utils.FormatGammaDate(lines[20]), times_small));
                table.AddCell(new txt.Phrase("Height: " + Utils.MakeFloat(lines[8]) + " mm", times_small));                
                table.AddCell(new txt.Phrase("Start: " + Utils.FormatGammaDate(lines[21]), times_small));
                table.AddCell(new txt.Phrase("Weight: " + Utils.MakeFloat(lines[9]) + " g", times_small));                
                table.AddCell(new txt.Phrase("Stop: " + Utils.FormatGammaDate(lines[22]), times_small));
                table.AddCell(new txt.Phrase("Volume: " + Utils.MakeFloat(lines[11]) + " cm3", times_small));                    
                table.AddCell(new txt.Phrase("Density: " + Utils.MakeFloat(lines[10]) + " g/cm3", times_small));                
                table.AddCell(new txt.Phrase("Quantity: " + Utils.MakeFloat(lines[12]) + " " + lines[14] + " ± " + Utils.MakeFloat(lines[13]) + " %", times_small));                                    
                doc.Add(table);                    

                if (++nTables > 8)
                {
                    nTables = 0;
                    doc.NewPage();
                }
            }

            if (invalid_items.Count > 0)
            {
                doc.NewPage();

                label = new txt.Paragraph("The following input files is invalid", times_medium);
                label.Alignment = txt.Element.ALIGN_CENTER;
                doc.Add(label);

                pdf.PdfPTable table_invalid = new pdf.PdfPTable(1);
                table_invalid.SpacingBefore = 14f;
                foreach (string s in invalid_items)
                    table_invalid.AddCell(new txt.Phrase(s, times_small));
                doc.Add(table_invalid);
                doc.Add(label_empty);
            }

            if (missing_items.Count > 0)
            {
                doc.NewPage();

                label = new txt.Paragraph("The following input files is missing", times_medium);
                label.Alignment = txt.Element.ALIGN_CENTER;
                doc.Add(label);

                pdf.PdfPTable table_missing = new pdf.PdfPTable(1);
                table_missing.SpacingBefore = 14f;
                foreach (string s in missing_items)
                    table_missing.AddCell(new txt.Phrase(s, times_small));
                doc.Add(table_missing);
            }

            doc.Close();
        }

        private void buttonLogSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = config.SystemPathLog;
            dialog.AddExtension = true;
            dialog.Title = "Save log as ...";
            dialog.Filter = "RTF files (*.RTF)|*.RTF";
            dialog.FileName = "Spek10-log-"
                + String.Format("{0:00}", DateTime.Now.Day)
                + String.Format("{0:00}", DateTime.Now.Month)
                + String.Format("{0:0000}", DateTime.Now.Year)
                + "_"
                + String.Format("{0:00}", DateTime.Now.Hour)
                + String.Format("{0:00}", DateTime.Now.Minute)
                + String.Format("{0:00}", DateTime.Now.Second)
                + ".RTF";

            string filename = String.Empty;
            if (dialog.ShowDialog() == DialogResult.OK)
                filename = dialog.FileName;
            else return;

            textBoxMessages.SaveFile(filename);
        }

        private void buttonArchiveCreateBackground_Click(object sender, EventArgs e)
        {
            if (listViewArchive.SelectedIndices.Count == 0)
                return;

            ListViewItem selitem = listViewArchive.SelectedItems[0];
            string filename = selitem.SubItems[7].Text;
            filename = filename.Substring(0, filename.Length - 4) + ".LIS";
            if (!File.Exists(filename))
            {
                MessageBox.Show("The file " + filename + " was not found", "Error");
                return;
            }

            List<string> out_lines = new List<string>();

            string detector = "DD";
            string beaker = "BB";
            string year = "YY";
            int imonth = 1;
            char[] separators = { ' ', '\t' };
            bool interpret = false;
            int skipLines = 0;
            string line = String.Empty;
            StreamReader reader = new StreamReader(filename, Encoding.GetEncoding(865));
            while ((line = reader.ReadLine()) != null)
            {
                if (interpret && skipLines > 0)
                {
                    skipLines--;
                    continue;
                }
                
                if(!interpret && line.Trim().StartsWith("THE FOLLOWING PEAKS WERE NOT IDENTIFIED"))
                {
                    interpret = true;
                    skipLines = 4;
                    continue;
                }

                if(!interpret && line.Trim().StartsWith("DETECTOR NO"))
                {
                    string[] items = line.Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    detector = items[items.Length - 1];
                    continue;
                }

                if(!interpret && line.Trim().StartsWith("BEAKER NO"))
                {
                    string[] items = line.Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    beaker = items[items.Length - 1];
                    continue;
                }

                if(!interpret && line.Trim().StartsWith("MEASUREMENT START"))
                {
                    string[] items = line.Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if(items.Length >= 5)
                        year = items[items.Length - 5].Substring(2, 2);
                    if (items.Length >= 4)
                    {
                        try
                        {
                            imonth = Convert.ToInt32(items[items.Length - 4]);
                        }
                        catch (Exception ex)
                        {
                            imonth = 1;
                        }
                        if (imonth > 12)
                            imonth = 12;
                    }
                    continue;
                }

                if (interpret)
                {
                    if (line == String.Empty || line.Trim().StartsWith("***"))
                        break;

                    if (line.Length >= 72)
                    {
                        string energy = line.Substring(5, 8);
                        string cpm = line.Substring(53, 12);
                        string cpmunc = line.Substring(69, 2);
                        out_lines.Add(energy.Trim() + " " + cpm.Trim() + " " + cpmunc.Trim());
                    }
                }
            }
            reader.Close();

            if (!interpret)
            {
                MessageBox.Show("No relevant data was found in " + filename, "Message");
                return;
            }

            string[] monthMap = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "O", "N", "D" };

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.InitialDirectory = config.SystemPathBin;
            dialog.AddExtension = true;
            dialog.Title = "Save background as ...";
            dialog.Filter = "BGR files (*.BGR)|*.BGR";
            dialog.FileName = detector + beaker + "-" + year + monthMap[imonth - 1] + ".BGR";

            string outfile = String.Empty;
            if (dialog.ShowDialog() == DialogResult.OK)
                outfile = dialog.FileName;
            else return;            

            StreamWriter writer = new StreamWriter(outfile, false, Encoding.GetEncoding(865));
            writer.WriteLine(out_lines.Count.ToString());
            foreach (string s in out_lines)            
                writer.WriteLine(s);
            writer.Close();            
        }

        private void repairLIS(string lis_filename, string detlimlib)
        {
            StringBuilder newFile = new StringBuilder();
            string temp = "";
            string[] file = File.ReadAllLines(lis_filename, Encoding.GetEncoding(865));

            foreach (string line in file)
            {
                if (line.Contains("DETECTION LIMIT LIB"))
                {
                    temp = "     DETECTION LIMIT LIB        : " + detlimlib;
                    newFile.Append(temp + Environment.NewLine);
                    continue;
                }
                newFile.Append(line + Environment.NewLine);
            }

            File.WriteAllText(lis_filename, newFile.ToString(), Encoding.GetEncoding(865));
        }

        private void buttonAdminMaestroSetup_Click(object sender, EventArgs e)
        {
            string lookupFilename = Environment.OSVersion.Version.Major > 5 
                ? Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\VirtualStore\\Windows\\M32MCA.CFG"
                : Environment.GetFolderPath(Environment.SpecialFolder.Windows) + "\\M32MCA.CFG";

            if(String.IsNullOrEmpty(lookupFilename))
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select Maestro detector pick list file (M32MCA.CFG)";
                dialog.Filter = "CFG files (*.CFG)|*.CFG";
                if (dialog.ShowDialog() == DialogResult.OK)
                    config.SaveSetting("MaestroPickListFile", dialog.FileName);
                else return;
            }
            else config.SaveSetting("MaestroPickListFile", lookupFilename);                        

            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Maestro\\Mca32.exe"))
            {
                config.SaveSetting("MaestroExecutable", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Maestro\\Mca32.exe");
            }
            else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Maestro\\Mca32.exe"))
            {
                config.SaveSetting("MaestroExecutable", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Maestro\\Mca32.exe");
            }
            else
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Title = "Select Maestro executable (Mca32.exe)";
                dialog.Filter = "EXE files (*.EXE)|*.EXE";
                dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
                if (dialog.ShowDialog() == DialogResult.OK)
                    config.SaveSetting("MaestroExecutable", dialog.FileName);
                else return;
            }

            labelAdminMaestroExecutable.Text = "Maestro executable: " + config.Settings["MaestroExecutable"];
            labelAdminMaestroConfig.Text = "Maestro configuration file: " + config.Settings["MaestroPickListFile"];

            config.LoadMaestroPickList();
                        
            foreach (string p in config.MaestroPickMap.Keys)
            {
                if (detectors.map.ContainsKey(p))
                {
                    if (!detectors.map[p].Connected)
                    {
                        detectors.map[p].Connected = true;
                        detectors.Save(p, false);
                    }
                    Log.addMessage("Maestro detector " + p + " was recognized");
                }
                else if (p.Length == 2)
                {
                    detectors.Add(config.MaestroPickMap[p], p, "Maestro");                    
                    Log.addMessage("Maestro detector " + p + " was added");                    
                }                
            }

            foreach (CDetector d in detectors.map.Values)
            {
                if (d.SpectrumSoftware != "Maestro")
                    continue;

                if (!config.MaestroPickMap.ContainsKey(d.Name))
                {
                    if (d.Connected)
                    {
                        d.Connected = false;
                        detectors.Save(d.Name, false);
                    }
                }                
            }            

            detectors.LoadAll();
            config.LoadAssetsBin();
            displayDetectors();

            statusLabel.Text = "Maestro was confiugured sucessfully";
        }

        private void buttonAdminGenieSetup_Click(object sender, EventArgs e)
        {
            string genieFolder = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
            genieFolder = Path.GetPathRoot(genieFolder) + "GENIE2K";
            if (Directory.Exists(genieFolder))
            {
                config.SaveSetting("GenieFolder", genieFolder);
            }
            else
            {
                folderDialog.Description = "Select the Genie installation folder (GENIE2K)";
                if (folderDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (!Directory.Exists(folderDialog.SelectedPath + "\\EXEFILES")
                        || !Directory.Exists(folderDialog.SelectedPath + "\\CTLFILES")
                        || !File.Exists(folderDialog.SelectedPath + "\\EXEFILES\\startmca.exe")
                        || !File.Exists(folderDialog.SelectedPath + "\\EXEFILES\\stopmca.exe")
                        || !File.Exists(folderDialog.SelectedPath + "\\EXEFILES\\analyze.exe"))
                    {
                        MessageBox.Show("The Genie installation seems to be incomplete. Cannot continue", "Error");
                        return;
                    }

                    genieFolder = folderDialog.SelectedPath;
                    config.SaveSetting("GenieFolder", genieFolder);
                }
                else return;
            }

            if (!File.Exists(genieFolder + "\\CTLFILES\\Spek10rap.ASF"))
                File.Copy(config.SpecExecutablePath + "templates\\template_Spek10rap.ASF", genieFolder + "\\CTLFILES\\Spek10rap.ASF", true);
            if (!File.Exists(genieFolder + "\\CTLFILES\\Spek10rap.tpl"))
                File.Copy(config.SpecExecutablePath + "templates\\template_Spek10rap.tpl", genieFolder + "\\CTLFILES\\Spek10rap.tpl", true);                                            

            string genieConfig = genieFolder + "\\MIDFILES\\" + Environment.MachineName + ".WSP";
            if (!File.Exists(genieConfig))
            {
                MessageBox.Show("The Genie detector configuration is missing." + Environment.NewLine + "Please configure any connected detectors in Genie and try again", "Error");
                return;
            }

            config.SaveSetting("GeniePickListFile", genieConfig);

            labelAdminGenieFolder.Text = "Genie installation directorory: " + config.Settings["GenieFolder"];
            labelAdminGenieConfig.Text = "Genie configuration file: " + config.Settings["GeniePickListFile"];

            config.LoadGeniePickList();

            foreach (string p in config.GeniePickMap.Keys)
            {
                if (detectors.map.ContainsKey(p))
                {
                    if (!detectors.map[p].Connected)
                    {
                        detectors.map[p].Connected = true;
                        detectors.Save(p, false);
                    }
                    Log.addMessage("Genie detector " + p + " was recognized");
                }
                else if (p.Length == 2)
                {
                    detectors.Add("0", p, "Genie");
                    Log.addMessage("Genie detector " + p + " was added");
                }
            }

            foreach (CDetector d in detectors.map.Values)
            {
                if (d.SpectrumSoftware != "Genie")
                    continue;

                if (!config.GeniePickMap.ContainsKey(d.Name))
                {
                    if (d.Connected)
                    {
                        d.Connected = false;
                        detectors.Save(d.Name, false);
                    }
                }
            }

            detectors.LoadAll();
            config.LoadAssetsBin();
            displayDetectors();

            statusLabel.Text = "Genie was confiugured sucessfully";
        }

        private void cbAdminBeakerMarinelli_CheckedChanged(object sender, EventArgs e)
        {
            txtAdminBeakerInnerRadius.Text = String.Empty;
            txtAdminBeakerInnerHeight.Text = String.Empty;
            if (cbAdminBeakerMarinelli.Checked)
            {                
                txtAdminBeakerInnerRadius.Enabled = true;
                txtAdminBeakerInnerHeight.Enabled = true;
            }
            else
            {
                txtAdminBeakerInnerRadius.Enabled = false;
                txtAdminBeakerInnerHeight.Enabled = false;
            }
        }
    }    
}
