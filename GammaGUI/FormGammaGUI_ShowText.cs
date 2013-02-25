using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GammaGUI
{
    public partial class FormGammaGUI_ShowText : Form
    {
        private bool mUseDefaultPrinter = false;

        public FormGammaGUI_ShowText(bool useDefaultPrinter)
        {
            InitializeComponent();
            mUseDefaultPrinter = useDefaultPrinter;
        }
        
        public void setContent(string content)
        {            
            textBoxContent.Text = content.Replace((char)0, ' ');            
            textBoxContent.SelectionStart = 0;
            textBoxContent.SelectionLength = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                MultipadPrintDocument printDoc = new MultipadPrintDocument();
                if (mUseDefaultPrinter)
                {
                    if (!pd.PrinterSettings.IsValid)
                        if (pd.ShowDialog() != DialogResult.OK)
                            return;
                }
                else
                {
                    if (pd.ShowDialog() != DialogResult.OK)
                        return;
                }

                printDoc.PrinterSettings = pd.PrinterSettings;
                printDoc.Font = textBoxContent.Font;
                printDoc.Text = textBoxContent.Text;
                printDoc.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Printing failed. Make sure a printer is online and available", "Message");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FormGammaGUI_Find form = new FormGammaGUI_Find();
            if (form.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                return;

            try
            {                
                int pos, startPos;
                Point x = textBoxContent.GetPositionFromCharIndex(textBoxContent.SelectionStart);
                pos = textBoxContent.GetCharIndexFromPosition(x);
                             
                startPos = textBoxContent.Text.IndexOf(form.Token, pos, StringComparison.OrdinalIgnoreCase);
                
                if (!(startPos > 0))
                {
                    MessageBox.Show("Search text: '" + form.Token + "' could not be found", "Text Not Found", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else
                {
                    textBoxContent.Select(startPos, form.Token.Length);                    
                    textBoxContent.ScrollToCaret();                    
                    textBoxContent.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search Error");
            }
        }        
    }
}
