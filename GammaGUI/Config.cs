using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using Ini;

namespace GammaGUI
{
    public class Config
    {        
        private const string ENVIRONMENT_ROOT = "SPEC_SYSTEM2";
        private const string DETECTOR_CONFIG_FILENAME = "detector.xml";
        private const string DETECTOR_DUMMY_CONFIG_FILENAME = "detector_dummy.xml";
        private const string BEAKER_CONFIG_FILENAME = "beaker.xml";

        private string mSystemPath, mGammaExecutableFile, mCanconExecutableFile, mSpecExecutablePath;
        private string mDetectorConfigFile, mDetectorDummyConfigFile, mBeakerConfigFile;        
        private string mApplicationSettings;

        private bool mGammaExecutableFileFound = false, mCanconExecutableFileFound = false;

        public List<string> ChannelCountList = new List<string>();
        public List<string> AnalysisMethodList = new List<string>();
        public List<string> QuantityUnitList = new List<string>();
        public List<string> RecordLengthList = new List<string>();
        public List<string> ResolutionUnitList = new List<string>();
        public List<string> SpectrumFormatList = new List<string>();        

        public List<string> BackgroundFileList = new List<string>();
        public List<string> EnergyFileList = new List<string>();
        public List<string> NucLibFileList = new List<string>();
        public List<string> PefFileList = new List<string>();
        public List<string> TefFileList = new List<string>();
        public List<string> UnknownFileList = new List<string>();

        public Dictionary<string, string> Settings = new Dictionary<string, string>();        
        public Dictionary<string, string> MaestroPickMap = new Dictionary<string, string>();
        public Dictionary<string, string> GeniePickMap = new Dictionary<string, string>();

        public Config()
        {            
        }

        public string Version
        {
            get { return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString(); }            
        }

        public string SystemPath
        {
            get { return mSystemPath; }
        }

        public string SystemPathBin
        {
            get { return mSystemPath + "\\BIN\\"; }
        }

        public string SystemPathBinWork
        {
            get { return mSystemPath + "\\BIN\\WORK\\"; }
        }

        public string SystemPathCfg
        {
            get { return mSystemPath + "\\CFG\\"; }
        }

        public string SystemPathSpec
        {
            get { return mSystemPath + "\\SPEC\\"; }
        }

        public string SystemPathLog
        {
            get { return mSystemPath + "\\LOG\\"; }
        }

        public string ApplicationSettings
        {
            get { return mApplicationSettings; }
        }

        public string SpecExecutablePath
        {
            get { return mSpecExecutablePath; }
        }

        public string GammaExecutableFile
        {
            get { return mGammaExecutableFile; }
        }

        public string CanconExecutableFile
        {
            get { return mCanconExecutableFile; }
        }

        public string DetectorConfigFile
        {
            get { return mDetectorConfigFile; }
        }

        public string DetectorDummyConfigFile
        {
            get { return mDetectorDummyConfigFile; }
        }

        public string BeakerConfigFile
        {
            get { return mBeakerConfigFile; }
        }                
        
        public bool LoadEnvironment()
        {
            Log.addMessage("Starting " + DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString());            

            mSpecExecutablePath = Path.GetDirectoryName(Application.ExecutablePath) + "\\";

            mSystemPath = Environment.GetEnvironmentVariable(ENVIRONMENT_ROOT, EnvironmentVariableTarget.User);
            if (String.IsNullOrEmpty(mSystemPath))
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Select the Spek10 root folder (GAMMALAB2)";
                if(dialog.ShowDialog() != DialogResult.OK)
                    return false;
                Environment.SetEnvironmentVariable(ENVIRONMENT_ROOT, dialog.SelectedPath, EnvironmentVariableTarget.User);
                mSystemPath = dialog.SelectedPath;                
            }

            if (!Directory.Exists(mSystemPath))            
                Directory.CreateDirectory(mSystemPath);            

            if (!Directory.Exists(SystemPathBin))
                Directory.CreateDirectory(SystemPathBin);            

            if (!Directory.Exists(SystemPathCfg))            
                Directory.CreateDirectory(SystemPathCfg);                        

            if (!Directory.Exists(SystemPathSpec))            
                Directory.CreateDirectory(SystemPathSpec);                                    

            if (!Directory.Exists(SystemPathLog))
                Directory.CreateDirectory(SystemPathLog);                                                
            
            if (!Directory.Exists(SystemPathBinWork))            
                Directory.CreateDirectory(SystemPathBinWork);

            if (!File.Exists(SystemPathCfg + DETECTOR_CONFIG_FILENAME))
                File.Copy(mSpecExecutablePath + "\\templates\\template_detector.xml", SystemPathCfg + DETECTOR_CONFIG_FILENAME);
            mDetectorConfigFile = SystemPathCfg + DETECTOR_CONFIG_FILENAME;

            if (!File.Exists(SystemPathCfg + DETECTOR_DUMMY_CONFIG_FILENAME))
                File.Copy(mSpecExecutablePath + "\\templates\\template_detector_dummy.xml", SystemPathCfg + DETECTOR_DUMMY_CONFIG_FILENAME);
            mDetectorDummyConfigFile = SystemPathCfg + DETECTOR_DUMMY_CONFIG_FILENAME;

            if (!File.Exists(SystemPathCfg + BEAKER_CONFIG_FILENAME))
                File.Copy(mSpecExecutablePath + "\\templates\\template_beaker.xml", SystemPathCfg + BEAKER_CONFIG_FILENAME);
            mBeakerConfigFile = SystemPathCfg + BEAKER_CONFIG_FILENAME;

            if (!File.Exists(SystemPathCfg + "application_settings.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_application_settings.xml", SystemPathCfg + "application_settings.xml");
            mApplicationSettings = SystemPathCfg + "application_settings.xml";
            LoadApplicationSettings();

            if (!File.Exists(SystemPathCfg + "channel_count.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_channel_count.xml", SystemPathCfg + "channel_count.xml");

            if (!File.Exists(SystemPathCfg + "analysis_method.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_analysis_method.xml", SystemPathCfg + "analysis_method.xml");

            if (!File.Exists(SystemPathCfg + "quantity_unit.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_quantity_unit.xml", SystemPathCfg + "quantity_unit.xml");

            if (!File.Exists(SystemPathCfg + "record_length.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_record_length.xml", SystemPathCfg + "record_length.xml");

            if (!File.Exists(SystemPathCfg + "resolution_unit.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_resolution_unit.xml", SystemPathCfg + "resolution_unit.xml");

            if (!File.Exists(SystemPathCfg + "spectrum_format.xml"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_spectrum_format.xml", SystemPathCfg + "spectrum_format.xml");            

            if (!File.Exists(SystemPathBin + "Labinfo.$$$"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_Labinfo.$$$", SystemPathBin + "Labinfo.$$$");
            
            LoadAssetsBin();            

            if (!mGammaExecutableFileFound)
            {
                File.Copy(mSpecExecutablePath + "\\templates\\template_gamma.exe", SystemPathBin + "gamma.exe");
                mGammaExecutableFile = SystemPathBin + "gamma.exe";
            }

            if (!mCanconExecutableFileFound)
            {
                File.Copy(mSpecExecutablePath + "\\templates\\template_cancon.exe", SystemPathBin + "cancon.exe");
                mCanconExecutableFile = SystemPathBin + "cancon.exe";
            }

            if (!File.Exists(SystemPathBin + "dat2inp.exe"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_dat2inp.exe", SystemPathBin + "dat2inp.exe");

            if (!File.Exists(SystemPathBin + "fixchn.exe"))
                File.Copy(mSpecExecutablePath + "\\templates\\template_fixchn.exe", SystemPathBin + "fixchn.exe");            

            LoadList(SystemPathCfg + "channel_count.xml", "channel_count", ref ChannelCountList);
            LoadList(SystemPathCfg + "analysis_method.xml", "analysis_method", ref AnalysisMethodList);
            LoadList(SystemPathCfg + "quantity_unit.xml", "quantity_unit", ref QuantityUnitList);
            LoadList(SystemPathCfg + "record_length.xml", "record_length", ref RecordLengthList);
            LoadList(SystemPathCfg + "resolution_unit.xml", "resolution_unit", ref ResolutionUnitList);
            LoadList(SystemPathCfg + "spectrum_format.xml", "spectrum_format", ref SpectrumFormatList);            

            DirectoryInfo di = new DirectoryInfo(SystemPathBinWork);
            FileInfo[] hplFiles = di.GetFiles("*.HPL", SearchOption.TopDirectoryOnly);
            foreach (FileInfo fi in hplFiles)            
                File.Delete(fi.FullName);
            FileInfo[] lisFiles = di.GetFiles("*.LIS", SearchOption.TopDirectoryOnly);
            foreach (FileInfo fi in lisFiles)
                File.Delete(fi.FullName);

            LoadMaestroPickList();
            LoadGeniePickList();            

            string msg = "";
            foreach (string s in NucLibFileList)            
                msg += s + " ";            
            Log.addMessage("Nuclide library files found: " + msg.Trim());

            msg = "";
            foreach (string s in BackgroundFileList)
                msg += s + " ";
            Log.addMessage("Background files found: " + msg.Trim());

            msg = "";
            foreach (string s in EnergyFileList)
                msg += s + " ";
            Log.addMessage("Energy files found: " + msg.Trim());

            msg = "";
            foreach (string s in PefFileList)
                msg += s + " ";
            Log.addMessage("PEF files found: " + msg.Trim());

            msg = "";
            foreach (string s in TefFileList)
                msg += s + " ";
            Log.addMessage("TEF files found: " + msg.Trim());

            msg = "";
            foreach (string s in UnknownFileList)
                msg += s + " ";
            Log.addMessage("Unrecognized files found: " + msg.Trim());            

            return true;
        }

        public void LoadMaestroPickList()
        {
            if (File.Exists(Settings["MaestroPickListFile"]))
            {
                IniFile iniFile = new IniFile(Settings["MaestroPickListFile"]);
                string maxDets = iniFile.IniReadValue("DETS", "MAX");
                int nDets = Convert.ToInt32(maxDets);
                char[] separators = { ' ', '\t' };
                for (int i = 1; i <= nDets; i++)
                {
                    string name = iniFile.IniReadValue("DETS", "NAME" + String.Format("{0:000}", i));
                    string addr = iniFile.IniReadValue("DETS", "ADDR" + String.Format("{0:000}", i));
                    string[] names = name.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    string[] addrs = addr.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    if (names.Length >= 2 && addrs.Length >= 1)
                    {
                        string dname = "";
                        for (int j = 1; j < names.Length; j++)
                            dname += names[j] + " ";
                        if (!MaestroPickMap.ContainsKey(dname.Trim()))
                            MaestroPickMap.Add(dname.Trim(), names[0]);
                    }
                }
            }
        }

        public void LoadGeniePickList()
        {
            if (File.Exists(Settings["GeniePickListFile"]))
            {
                string line;
                StreamReader reader = new StreamReader(Settings["GeniePickListFile"]);
                while ((line = reader.ReadLine()) != null)
                {
                    if (!GeniePickMap.ContainsKey(line.Trim()))
                        GeniePickMap.Add(line.Trim(), line.Trim());
                }
                reader.Close();
            }
        }        

        private void LoadList(string filename, string nodename, ref List<string> list)
        {
            list.Clear();

            XmlDocument doc = new XmlDocument();
            doc.Load(filename);
            foreach (XmlElement e in doc.SelectNodes("root/" + nodename))
                list.Add(e.InnerText);            
        }

        public void LoadAssetsBin()
        {
            NucLibFileList.Clear();
            BackgroundFileList.Clear();
            EnergyFileList.Clear();
            PefFileList.Clear();
            TefFileList.Clear();
            UnknownFileList.Clear();

            DirectoryInfo di = new DirectoryInfo(SystemPathBin);
            FileInfo[] binFiles = di.GetFiles("*", SearchOption.TopDirectoryOnly);
            foreach (FileInfo fi in binFiles)
            {
                switch (fi.Extension.ToUpper())
                {
                    case ".EXE":
                        if (fi.Name.ToUpper() == "GAMMA.EXE")
                        {
                            mGammaExecutableFile = fi.FullName;
                            mGammaExecutableFileFound = true;
                        }
                        else if (fi.Name.ToUpper() == "CANCON.EXE")
                        {
                            mCanconExecutableFile = fi.FullName;
                            mCanconExecutableFileFound = true;
                        }                        
                        break;
                    case ".LIB":                        
                        NucLibFileList.Add(fi.Name.ToUpper());
                        break;
                    case ".BGR":                        
                        BackgroundFileList.Add(fi.Name.ToUpper());
                        break;
                    case ".ENG":                        
                        EnergyFileList.Add(fi.Name.ToUpper());
                        break;
                    case ".PEF":                        
                        PefFileList.Add(fi.Name.ToUpper());
                        break;
                    case ".TEF":                        
                        TefFileList.Add(fi.Name.ToUpper());
                        break;
                    case ".$$$":                        
                        break;
                    default:
                        UnknownFileList.Add(fi.Name);                        
                        break;
                }
            }
        }

        private void LoadApplicationSettings()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(mApplicationSettings);
            foreach (XmlElement e in doc.SelectNodes("root/*"))            
                Settings[e.Name] = e.InnerText;                            
        }

        public void SaveSetting(string name, string value)
        {
            if (!File.Exists(mApplicationSettings))
                return;

            XmlDocument doc = new XmlDocument();
            doc.Load(mApplicationSettings);

            XmlNode node = doc.SelectSingleNode("root/" + name);
            if (node == null)
            {
                XmlNode root = doc.SelectSingleNode("root");
                node = doc.CreateNode(XmlNodeType.Element, name, null);
                node.InnerText = value;
                root.AppendChild(node);
            }
            else node.InnerText = value;

            if (!Settings.ContainsKey(name))
                Settings.Add(name, value);
            else Settings[name] = value;            

            doc.Save(mApplicationSettings);
        }

        public bool DetectorIdExists(int id)
        {            
            foreach (string p in MaestroPickMap.Values)            
                if (p.Trim() == id.ToString().Trim())            
                    return true;                                                
            return false;
        }

        public bool MaestroExists()
        {
            if (String.IsNullOrEmpty(Settings["MaestroExecutable"]) || !File.Exists(Settings["MaestroExecutable"]))            
                return false;
            if (String.IsNullOrEmpty(Settings["MaestroPickListFile"]) || !File.Exists(Settings["MaestroPickListFile"]))
                return false;
            if (String.IsNullOrEmpty(Settings["MaestroScriptStart"]) || String.IsNullOrEmpty(Settings["MaestroScriptStop"]) || String.IsNullOrEmpty(Settings["MaestroScriptBuffer"]))
                return false;
            return true;
        }

        public bool GenieExists()
        {
            if (String.IsNullOrEmpty(Settings["GenieFolder"]))
                return false;

            if (!Directory.Exists(Settings["GenieFolder"] + "\\EXEFILES") || 
                !File.Exists(Settings["GenieFolder"] + "\\EXEFILES\\startmca.exe") || 
                !File.Exists(Settings["GenieFolder"] + "\\EXEFILES\\stopmca.exe") || 
                !File.Exists(Settings["GenieFolder"] + "\\EXEFILES\\analyze.exe") || 
                !Directory.Exists(Settings["GenieFolder"] + "\\CTLFILES") || 
                !File.Exists(Settings["GenieFolder"] + "\\CTLFILES\\Spek10rap.ASF") || 
                !File.Exists(Settings["GenieFolder"] + "\\CTLFILES\\Spek10rap.tpl"))
                return false;                        
            return true;
        }
    }        
}
