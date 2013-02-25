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
    public partial class FormGammaGUI_SelectDetector : Form
    {
        private CDetector mDetector = null;

        public FormGammaGUI_SelectDetector(CDetector detector)
        {
            InitializeComponent();
            mDetector = detector;            
        }

        public string CHNFile { get { return dialogCHNFile.Text; } }
        public string DetectorName { get { return txtDetector.Text; } }
        public string Year { get { return txtYear.Text; } }        

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(dialogCHNFile.Text) 
                || String.IsNullOrEmpty(txtDetector.Text) 
                || String.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("One or more required fields are empty", "Message");
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        private void FormGammaGUI_SelectDetector_Load(object sender, EventArgs e)
        {                        
            txtDetector.Text = mDetector.Name;
            string year = DateTime.Now.Year.ToString();
            txtYear.Text = year.Substring(2, 2);
        }

        private void Integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;            
        }

        private void dialogCHNFile_ButtonClicked(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();            
            dialog.Title = "Select a CHN file";
            dialog.Filter = "CHN files (*.CHN)|*.CHN";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            if (dialog.ShowDialog() == DialogResult.OK)            
                dialogCHNFile.Text = dialog.FileName;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }
    }
}
