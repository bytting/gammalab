using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using ZedGraph;

namespace GammaGUI
{
    public partial class FormGammaGUI_ShowSpec : Form
    {
        private string mFilename = null;
        private string mSpectrumName = null;
        CHN_Header chn = new CHN_Header();
        PointPairList list = new PointPairList();
        CultureInfo ciNO = new CultureInfo("nb-NO");                

        public FormGammaGUI_ShowSpec(string filename)
        {
            InitializeComponent();
            mFilename = filename;
            mSpectrumName = Path.GetFileNameWithoutExtension(mFilename);
            this.Text = mFilename;            
        }                

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormGammaGUI_ShowSpec_Load(object sender, EventArgs e)
        {            
            GraphPane pane = graph.GraphPane;                       

            pane.Title.Text = "Gamma spectrum " + mSpectrumName;
            pane.XAxis.Title.Text = "Channel";
            pane.YAxis.Title.Text = "Count (Log10)";

            chn.Read(mFilename, false);

            list.Clear();
            for (int i = 0; i < chn.NumberOfChannels; ++i)
                list.Add((double)i, chn.Spectrum[i] == 0.000f ? 0.001 : Math.Log10((double)chn.Spectrum[i]));
            double maxCount = Math.Log10(chn.MaxCount);

            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = 512;

            pane.YAxis.Scale.Min = 0;
            pane.YAxis.Scale.Max = maxCount + (maxCount / 10.0);

            pane.CurveList.Clear();
            LineItem curve = pane.AddCurve(mSpectrumName, list, Color.Red, SymbolType.None);            
            //curve.Line.Fill = new Fill(Color.White, Color.Red, 45F);                        
            pane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45F);
            pane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45F);

            labelRealTime.Text = "Realtime: " + String.Format("{0:g}", (int)chn.RealTimeSeconds);
            labelLiveTime.Text = "Livetime: " + String.Format("{0:g}", (int)chn.LiveTimeSeconds);
            labelDeadTime.Text = "Deadtime: " + String.Format("{0:g}", chn.DeadTime);
            labelNumChannels.Text = "Channels: " + chn.NumberOfChannels.ToString();            
            labelMeasurementDate.Text = "Measurement from " + chn.StartDate.ToString("G", ciNO) + " to " + chn.StopDate.ToString("G", ciNO);            
            
            graph.AxisChange();
        }                

        private void buttonZoomOutAll_Click(object sender, EventArgs e)
        {
            graph.ZoomOutAll(graph.GraphPane);            
        }                        
    }    
}
