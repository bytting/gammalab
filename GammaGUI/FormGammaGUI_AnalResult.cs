using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GammaGUI
{
    public partial class FormGammaGUI_AnalResult : Form
    {
        private bool mPrintPlot = true;
        private bool mReject = false;
        private string mFilename = String.Empty;        

        public FormGammaGUI_AnalResult(string filename)
        {
            InitializeComponent();
            mFilename = filename;            
        }

        public void SetGammaContent(string gammaOut)
        {
            txtGammaOutput.Text = gammaOut;
            txtGammaOutput.SelectionStart = 0;
            txtGammaOutput.SelectionLength = 0;            
        }

        public void SetLISContent(string LISout)
        {            
            txtLISOutput.Text = LISout.Replace((char)0, ' ');
            txtLISOutput.SelectionStart = 0;
            txtLISOutput.SelectionLength = 0;        
        }

        public void SetINPContent(string INPout)
        {
            txtINPOutput.Text = INPout.Replace((char)0, ' ');
            txtINPOutput.SelectionStart = 0;
            txtINPOutput.SelectionLength = 0;
        }

        public void SetGammaExitCode(int exitCode)
        {
            if (exitCode == 0)
            {
                tabControl.SelectedTab = pageLisOutput;
                cbReject.Checked = false;
                cbReject.Enabled = true;
                cbPlot.Checked = true;
                cbPlot.Enabled = true;
            }
            else
            {
                tabControl.SelectedTab = pageGammaOutput;
                cbReject.Checked = true;
                cbReject.Enabled = false;
                cbPlot.Checked = false;
                cbPlot.Enabled = false;
            }
        }

        public void SetRequireReject()
        {
            cbReject.Checked = true;
            cbReject.Enabled = false;
            cbPlot.Enabled = true;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {                    
            mPrintPlot = cbPlot.Checked;
            mReject = cbReject.Checked;
            Close();        
        }

        public bool PrintPlot
        {
            get { return mPrintPlot; }
        }

        public bool Rejected
        {
            get { return mReject; }
        }

        private void cbReject_CheckedChanged(object sender, EventArgs e)
        {
            if (cbReject.Checked)
            {
                cbPlot.Checked = false;
                cbPlot.Enabled = false;
            }
            else
            {
                cbPlot.Checked = true;
                cbPlot.Enabled = true;
            }
        }

        private void buttonShowSpectrum_Click(object sender, EventArgs e)
        {
            if (File.Exists(mFilename))
            {
                FormGammaGUI_ShowSpec form = new FormGammaGUI_ShowSpec(mFilename);
                form.ShowDialog();
            }
        }
    }        
}
