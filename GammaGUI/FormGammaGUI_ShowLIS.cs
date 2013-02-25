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
    public partial class FormGammaGUI_ShowLIS : Form
    {
        public FormGammaGUI_ShowLIS()
        {
            InitializeComponent();
        }

        public void setContent(string content)
        {
            textBoxContent.Text = content;            
            textBoxContent.SelectionStart = 0;
            textBoxContent.SelectionLength = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            MultipadPrintDocument printDoc = new MultipadPrintDocument();
            printDoc.Font = textBoxContent.Font;
            printDoc.Text = textBoxContent.Text;
            printDoc.Print();            
        }
    }
}
