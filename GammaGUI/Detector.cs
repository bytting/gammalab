using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Xml;

namespace GammaGUI
{
    public class CDetectorMap
    {        
        private Config mConfig = null;
        private Dictionary<string, CDetector> mDetectors = new Dictionary<string, CDetector>();

        public CDetectorMap(Config config)             
        {
            mConfig = config;            
        }        

        public CDetector this[String key]
        {
            get 
            {
                if (!mDetectors.ContainsKey(key))
                    throw new Exception("Detector " + key + " was not found");
                return mDetectors[key]; 
            }
            set { mDetectors[key] = value; }
        }

        public Dictionary<string, CDetector> map
        { 
            get { return mDetectors; } 
        }

        public bool LoadAll()
        {
            mDetectors.Clear();

            bool res = _LoadDetectorConfig(mConfig.DetectorConfigFile);
            if (!res)
                return false;
            return _LoadDetectorConfig(mConfig.DetectorDummyConfigFile);            
        }

        private bool _LoadDetectorConfig(string filename)
        {
            if (File.Exists(filename))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(filename);
                foreach (XmlElement d in doc.SelectNodes("root/detector"))
                {
                    string name = d.SelectSingleNode("name").InnerText;
                    string specsoft = d.SelectSingleNode("spectrum_software").InnerText;
                    string id = d.SelectSingleNode("id").InnerText;
                    string year = d.SelectSingleNode("year").InnerText;
                    string specnum = d.SelectSingleNode("specnum").InnerText;
                    string active = d.SelectSingleNode("active").InnerText;
                    string channels = d.SelectSingleNode("channels").InnerText;
                    string format = d.SelectSingleNode("format").InnerText;
                    string records = d.SelectSingleNode("records").InnerText;
                    string manufacturer = d.SelectSingleNode("manufacturer").InnerText;
                    string type = d.SelectSingleNode("method").InnerText;
                    string efficiency = d.SelectSingleNode("efficiency").InnerText;
                    string resolution = d.SelectSingleNode("resolution").InnerText;
                    string resolution_unit = d.SelectSingleNode("resolution_unit").InnerText;
                    string connected = d.SelectSingleNode("connected").InnerText;
                    string dummy = d.SelectSingleNode("dummy").InnerText;
                    string fwhmps = d.SelectSingleNode("fwhmps").InnerText;
                    string fwhman = d.SelectSingleNode("fwhman").InnerText;
                    string thresh = d.SelectSingleNode("thresh").InnerText;
                    string ica = d.SelectSingleNode("ica").InnerText;
                    string bstf = d.SelectSingleNode("bstf").InnerText;
                    string etol = d.SelectSingleNode("etol").InnerText;
                    string loch = d.SelectSingleNode("loch").InnerText;
                    string background_file = d.SelectSingleNode("background_file").InnerText;
                    string energy_file = d.SelectSingleNode("energy_file").InnerText;
                    string comment = d.SelectSingleNode("comment").InnerText;

                    CDetector newDet = new CDetector(
                        name, 
                        specsoft,
                        Convert.ToInt32(id),
                        Convert.ToInt32(year),
                        Convert.ToInt32(specnum),
                        String.IsNullOrEmpty(active) ? false : Convert.ToBoolean(active),
                        String.IsNullOrEmpty(channels) ? 0 : Convert.ToInt32(channels),
                        format,
                        String.IsNullOrEmpty(records) ? 0 : Convert.ToInt32(records),
                        manufacturer,
                        type,
                        efficiency,
                        String.IsNullOrEmpty(resolution) ? 0 : Convert.ToSingle(resolution),
                        resolution_unit,
                        String.IsNullOrEmpty(connected) ? false : Convert.ToBoolean(connected),
                        String.IsNullOrEmpty(dummy) ? false : Convert.ToBoolean(dummy),
                        String.IsNullOrEmpty(fwhmps) ? 0 : Convert.ToSingle(fwhmps),
                        String.IsNullOrEmpty(fwhman) ? 0 : Convert.ToSingle(fwhman),
                        String.IsNullOrEmpty(thresh) ? 0 : Convert.ToSingle(thresh),
                        String.IsNullOrEmpty(ica) ? 0 : Convert.ToInt32(ica),
                        String.IsNullOrEmpty(bstf) ? 0 : Convert.ToSingle(bstf),
                        String.IsNullOrEmpty(etol) ? 0 : Convert.ToSingle(etol),
                        String.IsNullOrEmpty(loch) ? 0 : Convert.ToSingle(loch),
                        background_file,
                        energy_file,
                        comment);

                    XmlNodeList nl = d.SelectNodes("beakers/beaker");
                    foreach (XmlElement b in nl)
                    {
                        string beaker_name = b.Attributes["name"].InnerText;
                        string beaker_value = b.Attributes["value"].InnerText;
                        newDet.Beakers.Add(beaker_name, beaker_value);
                    }

                    mDetectors.Add(name, newDet);
                }
            }
            else return false;
            return true;         
        }

        public bool Add(string id, string name, string spectrumSoftware)
        {
            bool isDummy = (spectrumSoftware == "Dummy");
            string filename = (isDummy ? mConfig.DetectorDummyConfigFile : mConfig.DetectorConfigFile);

            if (!File.Exists(filename))
            {
                MessageBox.Show("Detector configuration file was not found: " + filename);
                return false;
            }
            
            FormGammaGUI_AddDetector form = new FormGammaGUI_AddDetector(mConfig, mDetectors, id, name, spectrumSoftware);
            form.Text = (isDummy ? "Creating dummy detector: " + name : "New detector found: " + name);
            if (form.ShowDialog() != DialogResult.OK)
                return false;

            XmlNode node = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            XmlNode nodeRoot = doc.SelectSingleNode("root");

            XmlNode nodeDetector = doc.CreateNode(XmlNodeType.Element, "detector", null);
            
            node = doc.CreateNode(XmlNodeType.Element, "name", null);
            node.InnerText = form.Detector.Name;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "spectrum_software", null);
            node.InnerText = form.Detector.SpectrumSoftware;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "id", null);
            node.InnerText = form.Detector.ID.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "year", null);
            node.InnerText = form.Detector.Year.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "specnum", null);
            node.InnerText = form.Detector.SpectrumCounter.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "active", null);
            node.InnerText = form.Detector.Active.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "channels", null);
            node.InnerText = form.Detector.Channels.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "format", null);
            node.InnerText = form.Detector.Format;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "records", null);
            node.InnerText = form.Detector.BytesPerRecord.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "manufacturer", null);
            node.InnerText = form.Detector.ManufacturerString;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "method", null);
            node.InnerText = form.Detector.AnalysisMethod;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "efficiency", null);
            node.InnerText = form.Detector.Efficiency.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "resolution", null);
            node.InnerText = form.Detector.Resolution.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "resolution_unit", null);
            node.InnerText = form.Detector.ResolutionUnit;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "connected", null);
            node.InnerText = form.Detector.Connected.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "dummy", null);
            node.InnerText = form.Detector.Dummy.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "fwhmps", null);
            node.InnerText = form.Detector.FWHMPS.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "fwhman", null);
            node.InnerText = form.Detector.FWHMAN.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "thresh", null);
            node.InnerText = form.Detector.THRESH.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "ica", null);
            node.InnerText = form.Detector.ICA.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "bstf", null);
            node.InnerText = form.Detector.BSTF.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "etol", null);
            node.InnerText = form.Detector.ETOL.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "loch", null);
            node.InnerText = form.Detector.LOCH.ToString();
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "background_file", null);
            node.InnerText = form.Detector.DefaultBackgroundFile;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "energy_file", null);
            node.InnerText = form.Detector.DefaultEnergyCalibrationFile;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "comment", null);
            node.InnerText = form.Detector.Comment;
            nodeDetector.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "beakers", null);
            node.InnerText = "";
            nodeDetector.AppendChild(node);

            nodeRoot.AppendChild(nodeDetector);
            doc.Save(filename);

            return true;
        }

        public bool Save(string detectorName, bool isDummy)
        {
            string filename = (isDummy ? mConfig.DetectorDummyConfigFile : mConfig.DetectorConfigFile);

            if (!File.Exists(filename))
            {
                MessageBox.Show("Detector configuration file was not found: " + filename);
                return false;
            }

            if(!mDetectors.ContainsKey(detectorName))
            {
                MessageBox.Show("Detector " + detectorName + " was not found");
                return false;
            }

            CDetector d = mDetectors[detectorName];                        

            XmlNode node = null, n = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(filename);

            node = doc.SelectSingleNode("/root/detector[name='" + detectorName + "']");
            if(node == null)
            {
                MessageBox.Show("Selecting detector node " + detectorName + " failed");
                return false;
            }

            n = node.SelectSingleNode("spectrum_software");
            n.InnerText = d.SpectrumSoftware;
            n = node.SelectSingleNode("id");
            n.InnerText = d.ID.ToString();
            n = node.SelectSingleNode("year");
            n.InnerText = d.Year.ToString();
            n = node.SelectSingleNode("specnum");
            n.InnerText = d.SpectrumCounter.ToString();            
            n = node.SelectSingleNode("channels");
            n.InnerText = d.Channels.ToString();            
            n = node.SelectSingleNode("records");
            n.InnerText = d.BytesPerRecord.ToString();            
            n = node.SelectSingleNode("format");
            n.InnerText = d.Format;
            n = node.SelectSingleNode("method");
            n.InnerText = d.AnalysisMethod;
            n = node.SelectSingleNode("manufacturer");
            n.InnerText = d.ManufacturerString;
            n = node.SelectSingleNode("efficiency");
            n.InnerText = Utils.MakeFloat(d.Efficiency.ToString());
            n = node.SelectSingleNode("resolution");
            n.InnerText = Utils.MakeFloat(d.Resolution.ToString());
            n = node.SelectSingleNode("resolution_unit");
            n.InnerText = d.ResolutionUnit;
            n = node.SelectSingleNode("comment");
            n.InnerText = d.Comment;
            n = node.SelectSingleNode("fwhmps");
            n.InnerText = Utils.MakeFloat(d.FWHMPS.ToString());
            n = node.SelectSingleNode("fwhman");
            n.InnerText = Utils.MakeFloat(d.FWHMAN.ToString());
            n = node.SelectSingleNode("thresh");
            n.InnerText = Utils.MakeFloat(d.THRESH.ToString());
            n = node.SelectSingleNode("ica");
            n.InnerText = d.ICA.ToString();
            n = node.SelectSingleNode("bstf");
            n.InnerText = Utils.MakeFloat(d.BSTF.ToString());
            n = node.SelectSingleNode("etol");
            n.InnerText = Utils.MakeFloat(d.ETOL.ToString());
            n = node.SelectSingleNode("loch");
            n.InnerText = Utils.MakeFloat(d.LOCH.ToString());
            n = node.SelectSingleNode("background_file");
            n.InnerText = d.DefaultBackgroundFile;
            n = node.SelectSingleNode("energy_file");
            n.InnerText = d.DefaultEnergyCalibrationFile;
            n = node.SelectSingleNode("active");
            n.InnerText = d.Active.ToString();
            n = node.SelectSingleNode("connected");
            n.InnerText = d.Connected.ToString();
            n = node.SelectSingleNode("dummy");
            n.InnerText = d.Dummy.ToString();
            n = node.SelectSingleNode("beakers");
            n.RemoveAll();
            foreach (KeyValuePair<string, string> p in d.Beakers)
            {
                XmlNode newNode = doc.CreateNode(XmlNodeType.Element, "beaker", null);
                XmlAttribute a1 = doc.CreateAttribute("name");
                a1.Value = p.Key;
                XmlAttribute a2 = doc.CreateAttribute("value");
                a2.Value = p.Value;
                newNode.Attributes.Append(a1);
                newNode.Attributes.Append(a2);
                n.AppendChild(newNode);
            }

            doc.Save(filename);
            return true;
        }
    }    

    public class CDetector
    {        
        private string mName;
        private string mSpectrumSoftware;     
        private int mID;
        private int mYear;
        private int mSpectrumCounter;
        private bool mActive;
        private int mChannels;
        private string mFormat;
        private int mBytesPerRecord;
        private string mManufacturerString;
        private string mAnalysisMethod;
        private string mEfficiency;
        private float mResolution;
        private string mResolutionUnit;
        private bool mConnected;
        private bool mDummy;
        private float mFWHMPS;
        private float mFWHMAN;
        private float mTHRESH;
        private int mICA;
        private float mBSTF;
        private float mETOL;
        private float mLOCH;
        private string mDefaultBackgroundFile;
        private string mDefaultEnergyCalibrationFile;
        private string mComment;
        private Dictionary<string, string> mBeakers = new Dictionary<string,string>();

        public CDetector()
        {            
        }

        public CDetector(string name, string spectrumSoftware, int id, int year, int spectrumCounter, bool active, int channels, string format,
            int bytesPerRecord, string manufacturerString, string analysisMethod, string efficiency, float resolution,
            string resolutionUnit, bool connected, bool dummy, float fwhmps, float fwhman, float thresh,
            int ica, float bstf, float etol, float loch, string defaultBackgroundFile, string defaultEnergyCalibrationFile, string comment)
        {            
            mName = name;
            mSpectrumSoftware = spectrumSoftware;
            mID = id;
            mYear = year;            
            mSpectrumCounter = spectrumCounter;
            mActive = active;
            mChannels = channels;
            mFormat = format;
            mBytesPerRecord = bytesPerRecord;
            mManufacturerString = manufacturerString;
            mAnalysisMethod = analysisMethod;
            mEfficiency = efficiency;
            mResolution = resolution;
            mResolutionUnit = resolutionUnit;
            mConnected = connected;
            mDummy = dummy;
            mFWHMPS = fwhmps;
            mFWHMAN = fwhman;
            mTHRESH = thresh;
            mICA = ica;
            mBSTF = bstf;
            mETOL = etol;
            mLOCH = loch;
            mDefaultBackgroundFile = defaultBackgroundFile;
            mDefaultEnergyCalibrationFile = defaultEnergyCalibrationFile;
            mComment = comment;
        }
        
        public string Name 
        { 
            get { return mName; }
            set { mName = value; }
        }

        public string SpectrumSoftware
        {
            get { return mSpectrumSoftware; }
            set { mSpectrumSoftware = value; }
        }

        public int ID 
        { 
            get { return mID; }
            set { mID = value; }
        }

        public int Year 
        { 
            get { return mYear; }
            set { mYear = value; }
        }
        
        public int SpectrumCounter 
        { 
            get { return mSpectrumCounter; }
            set { mSpectrumCounter = value; }
        }

        public bool Active 
        { 
            get { return mActive; }
            set { mActive = value; }
        }

        public int Channels 
        { 
            get { return mChannels; }
            set { mChannels = value; }
        }

        public string Format 
        { 
            get { return mFormat; }
            set { mFormat = value; }
        }

        public int BytesPerRecord 
        { 
            get { return mBytesPerRecord; }
            set { mBytesPerRecord = value; }
        }

        public string ManufacturerString 
        { 
            get { return mManufacturerString; }
            set { mManufacturerString = value; }
        }

        public string AnalysisMethod 
        {
            get { return mAnalysisMethod; }
            set { mAnalysisMethod = value; }
        }

        public string Efficiency 
        { 
            get { return mEfficiency;  }
            set { mEfficiency = value; }
        }

        public float Resolution 
        { 
            get { return mResolution; }
            set { mResolution = value; }
        }

        public string ResolutionUnit 
        { 
            get { return mResolutionUnit; }
            set { mResolutionUnit = value; }
        }

        public bool Connected 
        { 
            get { return mConnected; }
            set { mConnected = value; }
        }

        public bool Dummy 
        { 
            get { return mDummy; }
            set { mDummy = value; }
        }

        public float FWHMPS 
        { 
            get { return mFWHMPS; }
            set { mFWHMPS = value; }
        }

        public float FWHMAN 
        { 
            get { return mFWHMAN; }
            set { mFWHMAN = value; }
        }

        public float THRESH 
        { 
            get { return mTHRESH; }
            set { mTHRESH = value; }
        }

        public int ICA 
        { 
            get { return mICA; }
            set { mICA = value; }
        }

        public float BSTF 
        { 
            get { return mBSTF; }
            set { mBSTF = value; }
        }

        public float ETOL 
        { 
            get { return mETOL; }
            set { mETOL = value; }
        }
            
        public float LOCH 
        { 
            get { return mLOCH; }
            set { mLOCH = value; }
        }
                    
        public string DefaultBackgroundFile 
        { 
            get { return mDefaultBackgroundFile; }
            set { mDefaultBackgroundFile = value; }
        }

        public string DefaultEnergyCalibrationFile 
        { 
            get { return mDefaultEnergyCalibrationFile; }
            set { mDefaultEnergyCalibrationFile = value; }
        }

        public string Comment 
        { 
            get { return mComment; }
            set { mComment = value; }
        }

        public Dictionary<string, string> Beakers
        {
            get { return mBeakers; }
            set { mBeakers = value; }
        }                    
    }
}
