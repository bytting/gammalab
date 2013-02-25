using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace GammaGUI
{
    public class CBeakerMap
    {
        private Config mConfig = null;
        private Dictionary<string, CBeaker> mBeakers = null;

        public CBeakerMap(Config config)             
        {
            mConfig = config;
            mBeakers = new Dictionary<string, CBeaker>();
        }

        public CBeaker this[String key]
        {
            get { return mBeakers[key]; }
            set { mBeakers[key] = value; }
        }

        public Dictionary<string, CBeaker> map
        {
            get { return mBeakers; }
        }

        public bool LoadAll()
        {
            mBeakers.Clear();

            if (File.Exists(mConfig.BeakerConfigFile))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(mConfig.BeakerConfigFile);
                foreach (XmlElement b in doc.SelectNodes("root/beaker"))
                {
                    string name = b.SelectSingleNode("name").InnerText;
                    string radius = b.SelectSingleNode("radius").InnerText;
                    string height = b.SelectSingleNode("height").InnerText;
                    string marinelli = b.SelectSingleNode("marinelli").InnerText;
                    string inner_radius = b.SelectSingleNode("inner_radius").InnerText;
                    string inner_height = b.SelectSingleNode("inner_height").InnerText;
                    string min_fill_height = b.SelectSingleNode("min_fill_height").InnerText;
                    string max_fill_height = b.SelectSingleNode("max_fill_height").InnerText;
                    string manufacturer = b.SelectSingleNode("manufacturer").InnerText;
                    string in_use = b.SelectSingleNode("in_use").InnerText;
                    string comment = b.SelectSingleNode("comment").InnerText;                    

                    mBeakers.Add(name,
                        new CBeaker(name,
                            String.IsNullOrEmpty(radius) ? 0 : Convert.ToSingle(radius), 
                            String.IsNullOrEmpty(height) ? 0 : Convert.ToSingle(height),
                            String.IsNullOrEmpty(marinelli) ? false : Convert.ToBoolean(marinelli),
                            String.IsNullOrEmpty(inner_radius) ? 0 : Convert.ToSingle(inner_radius),
                            String.IsNullOrEmpty(inner_height) ? 0 : Convert.ToSingle(inner_height), 
                            String.IsNullOrEmpty(min_fill_height) ? 0 : Convert.ToSingle(min_fill_height), 
                            String.IsNullOrEmpty(max_fill_height) ? 0 : Convert.ToSingle(max_fill_height), 
                            manufacturer,
                            String.IsNullOrEmpty(in_use) ? false : Convert.ToBoolean(in_use),
                            comment));
                }
            }
            else return false;
            return true;
        }

        public bool Add()
        {
            if (!File.Exists(mConfig.BeakerConfigFile))
            {
                MessageBox.Show("Beaker configuration file was not found: " + mConfig.BeakerConfigFile);
                return false;
            }

            FormGammaGUI_AddBeaker form = new FormGammaGUI_AddBeaker(mConfig, mBeakers);
            if (form.ShowDialog() != DialogResult.OK)
                return false;

            XmlNode node = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(mConfig.BeakerConfigFile);

            XmlNode nodeRoot = doc.SelectSingleNode("root");

            XmlNode nodeBeaker = doc.CreateNode(XmlNodeType.Element, "beaker", null);

            node = doc.CreateNode(XmlNodeType.Element, "name", null);
            node.InnerText = form.Beaker.Name;
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "radius", null);
            node.InnerText = form.Beaker.Radius.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "height", null);
            node.InnerText = form.Beaker.Height.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "marinelli", null);
            node.InnerText = form.Beaker.Marinelli.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "inner_radius", null);
            node.InnerText = form.Beaker.InnerRadius.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "inner_height", null);
            node.InnerText = form.Beaker.InnerHeight.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "min_fill_height", null);
            node.InnerText = form.Beaker.MinFillHeight.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "max_fill_height", null);
            node.InnerText = form.Beaker.MaxFillHeight.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "manufacturer", null);
            node.InnerText = form.Beaker.Manufacturer;
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "in_use", null);
            node.InnerText = form.Beaker.InUse.ToString();
            nodeBeaker.AppendChild(node);

            node = doc.CreateNode(XmlNodeType.Element, "comment", null);
            node.InnerText = form.Beaker.Comment;
            nodeBeaker.AppendChild(node);            

            nodeRoot.AppendChild(nodeBeaker);
            doc.Save(mConfig.BeakerConfigFile);

            return true;
        }

        public bool Save(string beakerName)
        {
            if (!File.Exists(mConfig.BeakerConfigFile))
            {
                MessageBox.Show("Beaker configuration file was not found: " + mConfig.BeakerConfigFile);
                return false;
            }

            if (!mBeakers.ContainsKey(beakerName))
            {
                MessageBox.Show("Beaker " + beakerName + " was not found");
                return false;
            }

            CBeaker b = mBeakers[beakerName];

            XmlNode node = null, n = null;
            XmlDocument doc = new XmlDocument();
            doc.Load(mConfig.BeakerConfigFile);

            node = doc.SelectSingleNode("/root/beaker[name='" + beakerName + "']");
            if (node == null)
            {
                MessageBox.Show("Selecting beaker node " + beakerName + " failed");
                return false;
            }

            n = node.SelectSingleNode("radius");
            n.InnerText = b.Radius.ToString();
            n = node.SelectSingleNode("height");
            n.InnerText = b.Height.ToString();
            n = node.SelectSingleNode("marinelli");
            n.InnerText = b.Marinelli.ToString();
            n = node.SelectSingleNode("inner_radius");
            n.InnerText = b.InnerRadius.ToString();
            n = node.SelectSingleNode("inner_height");
            n.InnerText = b.InnerHeight.ToString();
            n = node.SelectSingleNode("min_fill_height");
            n.InnerText = b.MinFillHeight.ToString();
            n = node.SelectSingleNode("max_fill_height");
            n.InnerText = b.MaxFillHeight.ToString();
            n = node.SelectSingleNode("manufacturer");
            n.InnerText = b.Manufacturer;
            n = node.SelectSingleNode("in_use");
            n.InnerText = b.InUse.ToString();
            n = node.SelectSingleNode("comment");
            n.InnerText = b.Comment;            

            doc.Save(mConfig.BeakerConfigFile);
            return true;
        }
    }

    public class CBeaker
    {
        private string mName;
        private float mRadius;
        private float mHeight;
        private bool mMarinelli;
        private float mInnerRadius;
        private float mInnerHeight;
        private float mMinFillHeight;
        private float mMaxFillHeight;
        private string mManufacturer;
        private bool mInUse;
        private string mComment;

        public CBeaker() { }

        public CBeaker(string name, float radius, float height, bool marinelli, float innerRadius, float innerHeight, float minFillHeight, float maxFillHeight, 
            string manufacturer, bool in_use, string comment)
        {
            mName = name;
            mRadius = radius;
            mHeight = height;
            mMarinelli = marinelli;
            mInnerRadius = innerRadius;
            mInnerHeight = innerHeight;
            mMinFillHeight = minFillHeight;
            mMaxFillHeight = maxFillHeight;
            mManufacturer = manufacturer;
            mInUse = in_use;
            mComment = comment;
        }

        public string Name 
        { 
            get { return mName; }
            set { mName = value; }
        }

        public float Radius 
        { 
            get { return mRadius; }
            set { mRadius = value; }
        }

        public float Height 
        { 
            get { return mHeight; }
            set { mHeight = value; }
        }

        public bool Marinelli
        {
            get { return mMarinelli; }
            set { mMarinelli = value; }
        }

        public float InnerRadius
        {
            get { return mInnerRadius; }
            set { mInnerRadius = value; }
        }

        public float InnerHeight
        {
            get { return mInnerHeight; }
            set { mInnerHeight = value; }
        }

        public float MinFillHeight 
        { 
            get { return mMinFillHeight; }
            set { mMinFillHeight = value; }        
        }

        public float MaxFillHeight 
        { 
            get { return mMaxFillHeight; }
            set { mMaxFillHeight = value; }
        }

        public string Manufacturer 
        { 
            get { return mManufacturer; }
            set { mManufacturer = value; }
        }

        public bool InUse 
        { 
            get { return mInUse; }
            set { mInUse = value; }
        }

        public string Comment 
        { 
            get { return mComment; }
            set { mComment = value; }
        }
        
    }
}
