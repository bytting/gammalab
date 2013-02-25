using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.Threading;

namespace GammaGUI
{
    public class Utils
    {
        public static string MakeFloat(string str)
        {
            float val = Convert.ToSingle(str);
            return String.Format("{0:0.0#####}", val);
        }

        public static bool ValidateGammaDate(string gdate)
        {
            if (gdate.Length != 12)
                return false;

            bool returnValue = true;
            try
            {            
                int year = Convert.ToInt32(gdate.Substring(0, 4));
                int month = Convert.ToInt32(gdate.Substring(4, 2));
                int day = Convert.ToInt32(gdate.Substring(6, 2));
                int hour = Convert.ToInt32(gdate.Substring(8, 2));
                int minute = Convert.ToInt32(gdate.Substring(10, 2));

                if (year < 1980 || year > 2099)
                    returnValue = false;
                if (month < 1 || month > 12)
                    returnValue = false;
                if (day < 1 || day > 31)
                    returnValue = false;
                if (hour > 24)
                    returnValue = false;
                if (minute > 60)
                    returnValue = false;
            }
            catch (Exception ex)
            {
                returnValue = false;
            }            

            return returnValue;
        }

        public static bool SanityCheckGammaDates(string gdateStart, string gdateStop)
        {
            if (!ValidateGammaDate(gdateStart) || !ValidateGammaDate(gdateStop))
                return false;

            bool returnValue = true;                                        

            int year = Convert.ToInt32(gdateStart.Substring(0, 4));
            int month = Convert.ToInt32(gdateStart.Substring(4, 2));
            int day = Convert.ToInt32(gdateStart.Substring(6, 2));
            int hour = Convert.ToInt32(gdateStart.Substring(8, 2));
            int minute = Convert.ToInt32(gdateStart.Substring(10, 2));
            DateTime start = new DateTime(year, month, day, hour, minute, 0);

            year = Convert.ToInt32(gdateStop.Substring(0, 4));
            month = Convert.ToInt32(gdateStop.Substring(4, 2));
            day = Convert.ToInt32(gdateStop.Substring(6, 2));
            hour = Convert.ToInt32(gdateStop.Substring(8, 2));
            minute = Convert.ToInt32(gdateStop.Substring(10, 2));
            DateTime stop = new DateTime(year, month, day, hour, minute, 0);

            if (DateTime.Compare(start, stop) > 0)
                returnValue = false;

            return returnValue;
        }

        public static string FormatGammaDate(string gdate)
        {
            if (gdate.Length != 12)
                return gdate + "*";
            return gdate.Substring(6, 2) + "." + gdate.Substring(4, 2) + "." + gdate.Substring(0, 4) + " " + gdate.Substring(8, 2) + ":" + gdate.Substring(10, 2);
        }

        public static bool PrintReport(string lisFile, string plotfile1, string plotfile2, string plotfile3, string plotfile4, bool useDefaultPrinter)
        {
            bool returnValue = false;

            SetPlotColors(plotfile1);
            SetPlotColors(plotfile2);
            SetPlotColors(plotfile3);
            SetPlotColors(plotfile4);

            try
            {
                PrintDialog pd = new PrintDialog();
                pd.PrinterSettings = new PrinterSettings();
                MultipadPrintDocument printDoc = new MultipadPrintDocument();

                if (useDefaultPrinter)
                {
                    if (!pd.PrinterSettings.IsValid)
                        if (pd.ShowDialog() != DialogResult.OK)
                            return true;
                }
                else
                {
                    if (pd.ShowDialog() != DialogResult.OK)
                        return true;
                }

                printDoc.PrinterSettings = pd.PrinterSettings;
                printDoc.Font = new Font("Courier New", 8, FontStyle.Regular);
                printDoc.Text = File.ReadAllText(lisFile, Encoding.GetEncoding(865));
                printDoc.Print();
                Thread.Sleep(100);
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, plotfile1);
                Thread.Sleep(100);
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, plotfile2);
                Thread.Sleep(100);
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, plotfile3);
                Thread.Sleep(100);
                RawPrinterHelper.SendFileToPrinter(pd.PrinterSettings.PrinterName, plotfile4);
                returnValue = true;
            }
            catch (Exception ex)
            {
            }

            return returnValue;
        }

        private static void SetPlotColors(string plot_file)
        {
            // SP1 = Black
            // SP2 = Red
            // SP3 = Green
            // SP4 = Yellow
            // SP5 = Blue
            // SP6 = Violet
            // SP7 = Cyan
            string content = File.ReadAllText(plot_file, Encoding.GetEncoding(865));
            content = content.Replace("SP1", "SP5");
            content = content.Replace("SP2", "SP1");
            File.WriteAllText(plot_file, content, Encoding.GetEncoding(865));
        }
    }

    class CHN_Header
    {
        private Int16 mSignature;
        private Int16 mDetectorNumber;
        private Int16 mSegment;
        private char[] mSecondsStart = { ' ', ' ' };
        private Int32 mRealTime;
        private float mRealTimeSeconds;
        private Int32 mLiveTime;
        private float mLiveTimeSeconds;
        private float mDeadTime;
        private char[] mStartDate = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        private char[] mStartTime = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        private Int16 mChannelOffset;
        private Int16 mNumberOfChannels;
        private string mMeasurementStart, mMeasurementStop;
        private DateTime mStart, mStop;

        public Int16 Signature { get { return mSignature; } }
        public Int16 DetectorNumber { get { return mDetectorNumber; } }
        public Int16 Segment { get { return mSegment; } }
        public string SecondsStart { get { return mSecondsStart.ToString(); } }
        public Int32 RealTime { get { return mRealTime; } }
        public float RealTimeSeconds { get { return mRealTimeSeconds; } }
        public Int32 LiveTime { get { return mLiveTime; } }
        public float LiveTimeSeconds { get { return mLiveTimeSeconds; } }
        public float DeadTime { get { return mDeadTime; } }
        public string CStartDate { get { return mStartDate.ToString(); } }
        public string CStartTime { get { return mStartTime.ToString(); } }
        public DateTime StartDate { get { return mStart; } }
        public DateTime StopDate { get { return mStop; } }
        public Int16 ChannelOffset { get { return mChannelOffset; } }
        public Int16 NumberOfChannels { get { return mNumberOfChannels; } }
        public string MeasurementStart { get { return mMeasurementStart; } }
        public string MeasurementStop { get { return mMeasurementStop; } }        

        private string mFilename;
        private double mMaxCount;
        private Dictionary<string, string> mMonthMap = new Dictionary<string, string>();
        private float[] mSpectrum = null;

        public double MaxCount { get { return mMaxCount; } }        
        public float[] Spectrum { get { return mSpectrum; } }

        public CHN_Header()
        {
            mMonthMap["JAN"] = "01";
            mMonthMap["FEB"] = "02";
            mMonthMap["MAR"] = "03";
            mMonthMap["APR"] = "04";
            mMonthMap["MAY"] = "05";
            mMonthMap["JUN"] = "06";
            mMonthMap["JUL"] = "07";
            mMonthMap["AUG"] = "08";
            mMonthMap["SEP"] = "09";
            mMonthMap["OCT"] = "10";
            mMonthMap["NOV"] = "11";
            mMonthMap["DEC"] = "12";
        }

        public void Read(string chn_file, bool headerOnly)
        {
            mFilename = chn_file;
            BinaryReader reader = new BinaryReader(File.Open(mFilename, FileMode.Open));
            if (reader == null)
                throw new Exception("Failed to open spectrum file " + mFilename);

            if (!ReadHeader(reader))            
                throw new Exception("Failed to read header from " + mFilename);

            if (!headerOnly)
            {
                if(!ReadSpectrum(reader))
                    throw new Exception("Failed to read spectrum from " + mFilename);
            }
            reader.Close();            
        }

        private bool ReadHeader(BinaryReader reader)
        {                                                
            mSignature = reader.ReadInt16();
            if (mSignature != -1)            
                throw new Exception("Invalid signature in spectrum file " + mFilename);            

            mDetectorNumber = reader.ReadInt16();
            mSegment = reader.ReadInt16();
            mSecondsStart = reader.ReadChars(2);
            mRealTime = reader.ReadInt32();
            mLiveTime = reader.ReadInt32();
            mStartDate = reader.ReadChars(8);
            mStartTime = reader.ReadChars(4);
            mChannelOffset = reader.ReadInt16();
            mNumberOfChannels = reader.ReadInt16();
            
            int year = Convert.ToInt32(new string(mStartDate, 5, 2));
            /*if (emulateFixCHN)            
                year += (year <= 80) ? 2000 : 1900;            
            else */
                year += (mStartDate[7] == '1') ? 2000 : 1900;            

            string month = new string(mStartDate, 2, 3);
            mMeasurementStart = year.ToString() + mMonthMap[month.ToUpper()] + new string(mStartDate, 0, 2);
            mMeasurementStart += new string(mStartTime, 0, 4);

            DateTime dtStart = new DateTime(
                year,
                Convert.ToInt32(mMonthMap[month.ToUpper()]),
                Convert.ToInt32(new string(mStartDate, 0, 2)),
                Convert.ToInt32(new string(mStartTime, 0, 2)),
                Convert.ToInt32(new string(mStartTime, 2, 2)),
                0);

            mRealTimeSeconds = (float)mRealTime / 50.0f;
            mLiveTimeSeconds = (float)mLiveTime / 50.0f;
            mDeadTime = 100.0f * ((mRealTimeSeconds - mLiveTimeSeconds) / mLiveTimeSeconds);

            DateTime dtStop = dtStart.Add(new TimeSpan((long)(mRealTimeSeconds * 10000000.0f)));
            mMeasurementStop = String.Format("{0:0000}", dtStop.Year)
                + String.Format("{0:00}", dtStop.Month)
                + String.Format("{0:00}", dtStop.Day)
                + String.Format("{0:00}", dtStop.Hour)
                + String.Format("{0:00}", dtStop.Minute);

            mStart = dtStart;
            mStop = dtStop;

            return true;
        }

        private bool ReadSpectrum(BinaryReader reader)
        {            
            mSpectrum = new float[mNumberOfChannels];

            float count = 0.0f;
            mMaxCount = 0.0;            
            for (int i = 0; i < mNumberOfChannels; ++i)
            {
                count = (float)reader.ReadInt32();
                if (count > mMaxCount)
                    mMaxCount = count;                
                mSpectrum[i] = count;                
            }

            return true;
        }
    }                 
}
