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
    public partial class FormGammaGUI_Find : Form
    {
        public FormGammaGUI_Find()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
            Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (txtToken.Text.Trim() == String.Empty)
            {
                statusLabel.Text = "One or more required fields are empty";
                return;
            }

            DialogResult = System.Windows.Forms.DialogResult.OK;
            Close();
        }

        public string Token
        {
            get { return txtToken.Text; }
        }
    }
}
