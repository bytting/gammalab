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
    public partial class FormGammaGUI_AddBeaker : Form
    {
        Config mConfig = null;
        Dictionary<string, CBeaker> mBeakers;
        CBeaker mBeaker = new CBeaker();

        public FormGammaGUI_AddBeaker(Config config, Dictionary<string, CBeaker> beakers)
        {
            InitializeComponent();
            mConfig = config;
            mBeakers = beakers;
        }

        private void FormGammaGUI_AddBeaker_Load(object sender, EventArgs e)
        {
            statusLabel.Text = String.Empty;
            txtName.Text = String.Empty;
            txtRadius.Text = String.Empty;
            txtHeight.Text = String.Empty;
            cbMarinelli.Checked = false;
            txtInnerRadius.Text = String.Empty;
            txtInnerHeight.Text = String.Empty;
            txtInnerRadius.Enabled = false;
            txtInnerHeight.Enabled = false;
            txtMinFillHeight.Text = String.Empty;
            txtMaxFillHeight.Text = String.Empty;
            txtManufacturer.Text = String.Empty;
            txtComment.Text = String.Empty;
        }

        public CBeaker Beaker
        {
            get { return mBeaker; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            txtComment.Focus();

            if (String.IsNullOrEmpty(txtName.Text)
                || String.IsNullOrEmpty(txtRadius.Text)
                || String.IsNullOrEmpty(txtHeight.Text)
                || String.IsNullOrEmpty(txtMinFillHeight.Text)
                || String.IsNullOrEmpty(txtMaxFillHeight.Text)
                || String.IsNullOrEmpty(txtManufacturer.Text))
            {
                statusLabel.Text = "One or more fields are missing";
                return;
            }

            if (cbMarinelli.Checked)
            {
                if (String.IsNullOrEmpty(txtInnerRadius.Text) || String.IsNullOrEmpty(txtInnerHeight.Text))
                {
                    statusLabel.Text = "One or more Marinelli fields are missing";
                    return;
                }
            }

            if (txtName.Text.Length != 2)
            {
                statusLabel.Text = "You must choose a two letter name";
                return;
            }

            try
            {
                mBeaker.Name = txtName.Text;
                mBeaker.Radius = Convert.ToSingle(txtRadius.Text);
                mBeaker.Height = Convert.ToSingle(txtHeight.Text);
                mBeaker.Marinelli = cbMarinelli.Checked;
                if (mBeaker.Marinelli)
                {
                    mBeaker.InnerRadius = Convert.ToSingle(txtInnerRadius.Text);
                    mBeaker.InnerHeight = Convert.ToSingle(txtInnerHeight.Text);
                }
                mBeaker.MinFillHeight = Convert.ToSingle(txtMinFillHeight.Text);
                mBeaker.MaxFillHeight = Convert.ToSingle(txtMaxFillHeight.Text);
                mBeaker.Manufacturer = txtManufacturer.Text;
                mBeaker.InUse = true;
                mBeaker.Comment = txtComment.Text;
            }
            catch
            {
                statusLabel.Text = "One or more fields contains invalid values";
                return;
            }

            foreach (string s in mBeakers.Keys)
            {
                if (mBeaker.Name.ToUpper() == s.ToUpper())
                {
                    statusLabel.Text = "Beaker name already exists";
                    return;
                }
            }                        

            if (mBeaker.MaxFillHeight > mBeaker.Height)
            {
                statusLabel.Text = "Max fill height can not be bigger than height";
                return;
            }

            if (mBeaker.MinFillHeight > mBeaker.MaxFillHeight)
            {
                statusLabel.Text = "Min fill height can not be bigger than max fill height";
                return;
            }

            if (mBeaker.MinFillHeight < 0.0f)
            {
                statusLabel.Text = "Min fill height can not be less than zero";
                return;
            }

            if (mBeaker.Marinelli)
            {
                if (mBeaker.InnerRadius >= mBeaker.Radius)
                {
                    statusLabel.Text = "Inner radius can not be bigger or equal to radius";
                    return;
                }

                if (mBeaker.InnerHeight >= mBeaker.Height)
                {
                    statusLabel.Text = "Inner height can not be bigger or equal to height";
                    return;
                }
            }

            DialogResult = DialogResult.OK;            
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

        private void cbMarinelli_CheckedChanged(object sender, EventArgs e)
        {
            txtInnerRadius.Text = String.Empty;
            txtInnerHeight.Text = String.Empty;
            if (cbMarinelli.Checked)
            {
                txtInnerRadius.Enabled = true;
                txtInnerHeight.Enabled = true;
            }
            else
            {
                txtInnerRadius.Enabled = false;
                txtInnerHeight.Enabled = false;
            }
        }        
    }
}
