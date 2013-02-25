using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace GammaGUI
{
    public partial class FormGammaGUI_AddDetector : Form
    {
        Config mConfig = null;
        Dictionary<string, CDetector> mDetectors;
        CDetector mDetector = new CDetector();
        string mSpectrumSoftware;
        bool mIsDummy;

        public FormGammaGUI_AddDetector(Config config, Dictionary<string, CDetector> detectors, string id, string name, string spectrumSoftware)
        {            
            InitializeComponent();
            mSpectrumSoftware = spectrumSoftware;
            mIsDummy = (mSpectrumSoftware == "Dummy");
            mConfig = config;
            mDetectors = detectors;
            textBoxID.Text = id;
            textBoxID.Enabled = false;
            textBoxName.Text = name;
            textBoxName.Enabled = mIsDummy;            
        }

        private void FormGammaGUI_AddDetector_Load(object sender, EventArgs e)
        {
            //textBoxName.Text = String.Empty;
            //textBoxID.Text = String.Empty;
            textBoxManufacturer.Text = String.Empty;
            textBoxEfficiency.Text = String.Empty;
            textBoxResolution.Text = String.Empty;
            textBoxFWHMPS.Text = String.Empty;
            textBoxFWHMAN.Text = String.Empty;
            textBoxTHRESH.Text = String.Empty;
            cbICA.Checked = false;
            textBoxBSTF.Text = String.Empty;
            textBoxETOL.Text = String.Empty;
            textBoxLOCH.Text = String.Empty;
            dialogBackgroundFile.Text = String.Empty;
            dialogEnergyCalFile.Text = String.Empty;

            cboxBytesPerRecord.ComboBox.Items.Clear();
            cboxChannels.ComboBox.Items.Clear();
            cboxFormat.ComboBox.Items.Clear();
            cboxMethod.ComboBox.Items.Clear();
            cboxResolutionUnit.ComboBox.Items.Clear();

            foreach (string s in mConfig.RecordLengthList)
                cboxBytesPerRecord.ComboBox.Items.Add(s);

            foreach (string s in mConfig.ChannelCountList)
                cboxChannels.ComboBox.Items.Add(s);

            foreach (string s in mConfig.SpectrumFormatList)
                cboxFormat.ComboBox.Items.Add(s);

            foreach (string s in mConfig.AnalysisMethodList)
                cboxMethod.ComboBox.Items.Add(s);

            foreach (string s in mConfig.ResolutionUnitList)
                cboxResolutionUnit.ComboBox.Items.Add(s);

            cboxSpectrumSoftware.ComboBox.Items.Add("Maestro");
            cboxSpectrumSoftware.ComboBox.Items.Add("Genie");
            cboxSpectrumSoftware.ComboBox.Items.Add("Dummy");

            cboxSpectrumSoftware.ComboBox.SelectedIndex = cboxSpectrumSoftware.ComboBox.FindStringExact(mSpectrumSoftware);
            cboxSpectrumSoftware.Enabled = false;            
        }

        public CDetector Detector
        {
            get { return mDetector; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            textBoxComment.Focus();

            if (String.IsNullOrEmpty(textBoxName.Text)
                || String.IsNullOrEmpty(cboxSpectrumSoftware.Text)
                || String.IsNullOrEmpty(textBoxID.Text)
                || String.IsNullOrEmpty(textBoxManufacturer.Text)
                || String.IsNullOrEmpty(cboxMethod.Text)
                || String.IsNullOrEmpty(textBoxEfficiency.Text)
                || String.IsNullOrEmpty(textBoxResolution.Text)
                || String.IsNullOrEmpty(textBoxFWHMPS.Text)
                || String.IsNullOrEmpty(textBoxFWHMAN.Text)
                || String.IsNullOrEmpty(textBoxTHRESH.Text)                
                || String.IsNullOrEmpty(textBoxBSTF.Text)
                || String.IsNullOrEmpty(textBoxETOL.Text)
                || String.IsNullOrEmpty(textBoxLOCH.Text)
                || String.IsNullOrEmpty(dialogBackgroundFile.Text)
                || String.IsNullOrEmpty(dialogEnergyCalFile.Text))
            {
                statusLabel.Text = "One or more fields are missing";
                return;
            }

            if (textBoxName.Text.Length != 2)
            {
                statusLabel.Text = "You must choose a two letter detector name";
                return;
            }            

            try
            {
                mDetector.Name = textBoxName.Text;
                mDetector.SpectrumSoftware = cboxSpectrumSoftware.Text;
                mDetector.ID = Convert.ToInt32(textBoxID.Text);
                string y = DateTime.Now.Year.ToString();
                mDetector.Year = Convert.ToInt32(y.Substring(2, 2));
                mDetector.SpectrumCounter = 0;
                mDetector.Active = false;
                mDetector.Channels = Convert.ToInt32(cboxChannels.Text);
                mDetector.Format = cboxFormat.Text;
                mDetector.BytesPerRecord = Convert.ToInt32(cboxBytesPerRecord.Text);
                mDetector.ManufacturerString = textBoxManufacturer.Text;
                mDetector.AnalysisMethod = cboxMethod.Text;
                mDetector.Efficiency = textBoxEfficiency.Text;
                mDetector.Resolution = Convert.ToSingle(textBoxResolution.Text);
                mDetector.ResolutionUnit = cboxResolutionUnit.Text;
                mDetector.Connected = true;
                mDetector.Dummy = mIsDummy;
                mDetector.FWHMPS = Convert.ToSingle(textBoxFWHMPS.Text);
                mDetector.FWHMAN = Convert.ToSingle(textBoxFWHMAN.Text);
                mDetector.THRESH = Convert.ToSingle(textBoxTHRESH.Text);
                mDetector.ICA = cbICA.Checked ? 1 : 0;
                mDetector.BSTF = Convert.ToSingle(textBoxBSTF.Text);
                mDetector.ETOL = Convert.ToSingle(textBoxETOL.Text);
                mDetector.LOCH = Convert.ToSingle(textBoxLOCH.Text);
                mDetector.DefaultBackgroundFile = Path.GetFileName(dialogBackgroundFile.Text);
                mDetector.DefaultEnergyCalibrationFile = Path.GetFileName(dialogEnergyCalFile.Text);
                mDetector.Comment = textBoxComment.Text;
            }
            catch
            {
                statusLabel.Text = "One or more fields contains invalid values";                
                return;
            }                        

            foreach(string s in mDetectors.Keys)
            {
                if(mDetector.Name.ToUpper() == s.ToUpper())
                {
                    statusLabel.Text = "Detector name already exists";
                    return;
                }
            }            
            
            DialogResult = DialogResult.OK;            
        }        

        private void dialogBackgroundFile_ButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = mConfig.SystemPathBin;
            dialog.Filter = "Background files (" + textBoxName.Text + "*.BGR)|" + textBoxName.Text + "*.BGR";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
                if (Path.GetDirectoryName(dialog.FileName).ToUpper() != Path.GetDirectoryName(mConfig.SystemPathBin).ToUpper())                
                    statusLabel.Text = "You must select a file in the " + mConfig.SystemPathBin + " directory";                
                else
                    dialogBackgroundFile.Text = dialog.FileName;
            }
        }

        private void dialogEnergyCalFile_ButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = mConfig.SystemPathBin;
            dialog.Filter = "Energy files (" + textBoxName.Text + "*.ENG)|" + textBoxName.Text + "*.ENG";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Application.DoEvents();
                if (Path.GetDirectoryName(dialog.FileName).ToUpper() != Path.GetDirectoryName(mConfig.SystemPathBin).ToUpper())
                    statusLabel.Text = "You must select a file in the " + mConfig.SystemPathBin + " directory";
                else
                    dialogEnergyCalFile.Text = dialog.FileName;
            }
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

        private void cboxSpectrumSoftware_SelectedValueChanged(object sender, EventArgs e)
        {
            textBoxID.Enabled = cboxSpectrumSoftware.Text == "Maestro";
            if (!textBoxID.Enabled)
                textBoxID.Text = "0";
        }        
    }
}
