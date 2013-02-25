using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GammaGUI
{
    public partial class FormGammaGUI_ArchiveSearch : Form
    {
        private Config mConfig = null;
        private Dictionary<string, HashSet<string>> mDetYear = null;

        public FormGammaGUI_ArchiveSearch(Config config, Dictionary<string, HashSet<string>> detyear)
        {
            InitializeComponent();
            mConfig = config;
            mDetYear = detyear;
        }

        private void FormGammaGUI_ArchiveSearch_Load(object sender, EventArgs e)
        {            
            statusLabel.Text = String.Empty;            

            cboxDetector.ComboBox.Items.Clear();
            cboxDetector.ComboBox.Items.Add("");
            foreach (string d in mDetYear.Keys)
                cboxDetector.ComboBox.Items.Add(d);

            cboxYear.ComboBox.Items.Clear();
            cboxYear.ComboBox.Items.Add("");
            foreach (string key in mDetYear.Keys)
                foreach (string year in mDetYear[key])
                {
                    if (!cboxYear.ComboBox.Items.Contains(year))
                        cboxYear.ComboBox.Items.Add(year);
                }

            cboxField.ComboBox.Items.Clear();
            cboxField.ComboBox.Items.Add("");
            cboxField.ComboBox.Items.Add("ID/Type");
            cboxField.ComboBox.Items.Add("Geometry");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (cboxField.Text.Trim() == String.Empty || txtToken.Text.Trim() == String.Empty)
            {
                statusLabel.Text = "One or more required fields are missing";
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public string Detector
        {
            get { return cboxDetector.Text.Trim(); }
        }

        public string Year
        {
            get { return cboxYear.Text.Trim(); }
        }

        public string Field
        {
            get { return cboxField.Text.Trim(); }
        }

        public string Token
        {
            get { return txtToken.Text.Trim(); }
        }        

        private void cboxDetector_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboxDetector.Text == String.Empty)
            {
                cboxYear.ComboBox.Items.Clear();
                cboxYear.ComboBox.Items.Add("");                
                foreach (string key in mDetYear.Keys)
                    foreach (string year in mDetYear[key])
                    {
                        if(!cboxYear.ComboBox.Items.Contains(year))
                            cboxYear.ComboBox.Items.Add(year);
                    }
                return;
            }

            if (mDetYear.ContainsKey(cboxDetector.Text))
            {
                cboxYear.ComboBox.Items.Clear();
                cboxYear.ComboBox.Items.Add("");
                foreach (string d in mDetYear[cboxDetector.Text])                
                    cboxYear.ComboBox.Items.Add(d);                                
            }
        }
    }
}
