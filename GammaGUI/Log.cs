using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace GammaGUI
{
    public class Log
    {
        private static RichTextBox tb = null;

        public static void initialize(ref RichTextBox rtb)
        {
            tb = rtb;
        }

        public static void addMessage(string message)
        {
            if (tb != null)
            {
                if (tb.Text.Length + message.Length + 12 >= tb.MaxLength)
                    tb.Text = "";

                tb.SelectionColor = Color.Green;                
                tb.AppendText(String.Format("{0:dd.MM.yyyy hh:mm}", DateTime.Now) + " [Message] ");
                tb.SelectionColor = Color.Black;
                tb.AppendText(message + "\n");

                scrollToEnd();
            }
        }

        public static void addWarning(string message)
        {
            if (tb != null)
            {
                if (tb.Text.Length + message.Length + 13 >= tb.MaxLength)
                    tb.Text = "";

                tb.SelectionColor = Color.DarkOrange;                
                tb.AppendText(String.Format("{0:dd.MM.yyyy hh:mm}", DateTime.Now) + " [Warning] ");
                tb.SelectionColor = Color.Black;
                tb.AppendText(message + "\n");

                scrollToEnd();
            }
        }

        public static void addError(string message)
        {
            if (tb != null)
            {
                if (tb.Text.Length + message.Length + 10 >= tb.MaxLength)
                    tb.Text = "";

                tb.SelectionColor = Color.Red;                
                tb.AppendText(String.Format("{0:dd.MM.yyyy hh:mm}", DateTime.Now) + " [Error] ");
                tb.SelectionColor = Color.Black;
                tb.AppendText(message + "\n");

                scrollToEnd();
            }
        }

        private static void scrollToEnd()
        {            
            tb.SelectionStart = tb.Text.Length;
            tb.ScrollToCaret();        
        }        

    }        
}
