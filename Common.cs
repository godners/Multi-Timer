using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Drawing;
using System.Data;

namespace Multi_Timer
{
    public class MainStyle
    {
        static public WinStyle Style;

        static public void InitPnt()
        {
            InitPntLblID();
            InitPntLblAlm();
            InitPntLblDst();
            InitPtnBtnSet();
            InitPntBtnON();
            InitPntBtnClr();
            InitPntLblTag();
        }        

        static private readonly Point PntNull = new Point();
        static public readonly Point PntLblNow = new Point(13, 13);
        static public readonly Point PntLblTitleID = new Point(13, 52);
        static public Point[] PntLblID;
        static private void InitPntLblID()
        {
            PntLblID = new Point[8];
            for (int i = 0; i < PntLblID.Length; i++)
            {
                PntLblID[i] = new Point(13, 86 + 34 * i);
            }
        }
        static public readonly Point PntLblTitleAlm = new Point(39, 52);
        static public Point[] PntLblAlm;
        static private void InitPntLblAlm()
        {
            PntLblAlm = new Point[8];
            for (int i = 0; i < PntLblAlm.Length; i++)
            {
                PntLblAlm[i] = new Point(39, 86 + 34 * i);
            }
        }
        static public readonly Point PntLblTitleDst = new Point(135, 52);
        static public Point[] PntLblDst;
        static private void InitPntLblDst()
        {
            PntLblDst = new Point[8];
            for (int i = 0; i < PntLblAlm.Length; i++)
            {
                PntLblDst[i] = new Point(135, 86 + 34 * i);
            }
        }
        static public readonly Point PntBtnAllON = new Point(231, 48);
        static public readonly Point PntBtnAllOFF = new Point(291, 48);
        static public Point[] PntBtnSet;
        static private void InitPtnBtnSet()
        {
            PntBtnSet = new Point[8];
            for (int i = 0; i < PntBtnSet.Length; i++)
            {
                PntBtnSet[i] = new Point(231, 82 + 34 * i);
            }
        }
        static public Point[] PntBtnON;
        static private void InitPntBtnON()
        {
            PntBtnON = new Point[8];
            for (int i = 0; i < PntBtnON.Length; i++)
            {
                PntBtnON[i] = new Point(291, 82 + 34 * i);
            }
        }
        static public readonly Point PntBtnAllClr = new Point(351, 48);
        static public Point[] PntBtnClr;
        static private void InitPntBtnClr()
        {
            PntBtnClr = new Point[8];
            for (int i = 0; i < PntBtnClr.Length; i++)
            {
                PntBtnClr[i] = new Point(351, 82 + 34 * i);
            }
        }
        static public readonly Point PntLblNote = new Point(436, 52);
        static private Point[] PntLblTag_WithList;
        static private void InitPntLblTag_WithList()
        {
            PntLblTag_WithList = new Point[8];
            for (int i = 0; i < PntLblTag_WithList.Length; i++)
            {
                PntLblTag_WithList[i] = new Point(451 + 26 * i, 318);
            }
        }
        static private Point[] PntLblTag_OnlyClock;
        static private void InitPntLblTag_OnlyClock()
        {
            PntLblTag_OnlyClock = new Point[8];
            for (int i = 0; i < PntLblTag_OnlyClock.Length; i++)
            {
                PntLblTag_OnlyClock[i] = new Point(25 + 26 * i, 318);
            }
        }
        static private void InitPntLblTag()
        {
            InitPntLblTag_WithList();
            InitPntLblTag_OnlyClock();
        }
        static public Point PntLblTag(int i)
        {
            switch (Style)
            {
                case WinStyle.WithList:
                    return PntLblTag_WithList[i];
                case WinStyle.OnlyClock:
                    return PntLblTag_OnlyClock[i];
                default:
                    return PntNull;
            }            
        }
        static private readonly Point PntBtnLoad_WithList = new Point(439, 13);
        static private readonly Point PntBtnLoad_OnlyClock = new Point(13, 13);
        static public Point PntBtnLoad
        {
            get
            {
                switch (Style)
                {
                    case WinStyle.WithList:
                        return PntBtnLoad_WithList;
                    case WinStyle.OnlyClock:
                        return PntBtnLoad_OnlyClock;
                    default:
                        return PntNull;
                }
            }
        }
        static private readonly Point PntBtnSave_WithList = new Point(511, 13);
        static private readonly Point PntBtnSave_OnlyClock = new Point(85, 13);
        static public Point PntBtnSave
        {
            get
            {
                switch (Style)
                {
                    case WinStyle.WithList:
                        return PntBtnSave_WithList;
                    case WinStyle.OnlyClock:
                        return PntBtnSave_OnlyClock;
                    default:
                        return PntNull;
                }
            }
        }
        static private readonly Point PntBtnAuthor_WithList = new Point(583, 13);
        static private readonly Point PntBtnAuthor_OnlyClock = new Point(157, 13);
        static public Point PntBtnAuthor
        {
            get
            {
                switch (Style)
                {
                    case WinStyle.WithList:
                        return PntBtnAuthor_WithList;
                    case WinStyle.OnlyClock:
                        return PntBtnAuthor_OnlyClock;
                    default:
                        return PntNull;
                }
            }
        }


    }
    public class Common
    {
        static public readonly int intPrecision = 20;
        static private readonly CultureInfo culEnUs = CultureInfo.CreateSpecificCulture("en-US");
        static public readonly string strDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        static public readonly string strTempFile = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + "\\Multi Timer.xml";

        static public readonly TimeSpan tsZero = new TimeSpan(0);
        static public readonly TimeSpan tsOneDay = new TimeSpan(864000000000);
        static public readonly TimeSpan tsActive = tsOneDay - (new TimeSpan(60 * (long)10000000));
        static public readonly DateTime dtToday = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
        static public string NowString(DateTime inp)
        {
            return inp.ToString("yyyy-MM-dd HH:mm:ss.fff (ddd)", culEnUs).ToUpper();
        }
        static public readonly string NoDefine = "--:--:--";
        static public string LblString(DateTime inp)
        {
            return inp.ToString("HH:mm:ss", culEnUs);
        }
        static public string LblString(TimeSpan inp)
        {
            return inp.ToString(@"hh\:mm\:ss", culEnUs);
        }
        static public readonly Font fntConfiged = new Font("Courier New", 12, FontStyle.Bold);
        static public readonly Font fntUnconfig = new Font("Courier New", 12, FontStyle.Regular);
    }
    public class Clock
    {
        static public readonly SolidBrush brsBlack = new SolidBrush(Color.Black);
        static public readonly SolidBrush brsBackColor = new SolidBrush(WinMain.DefaultBackColor);
        static public readonly Pen penCenter = new Pen(Color.Black, 3);
        static public readonly Pen penCircle = new Pen(Color.Black, 2); 
        static public readonly Pen penHour = new Pen(Color.Black, 5);
        static public readonly Pen penMinute = new Pen(Color.Black, 3);
        static public readonly Pen penSecond = new Pen(Color.Black, 1);

        static private readonly int intRadius_PinFill = 3;
        static private readonly int intRadius_PinCircle = 103;
        static private readonly int intRadius_CenterOut = 8;
        static private readonly int intRadius_CenterIn = 5;
        static private readonly int intRadius_Hour = 57;
        static private readonly int intRadius_Minute = 68;
        static private readonly int intRadius_Second = 91;
        static private readonly int intRadius_Circle = 114;

        static private readonly Point pntNull = new Point(); 
        static private readonly Point pntCenter_WithList = new Point(553, 196);
        static private readonly Point pntCenter_OnlyClock = new Point(127, 196);

        static public Point PntCenter
        {
            get
            {
                switch (MainStyle.Style)
                {
                    case WinStyle.WithList:
                        return pntCenter_WithList;
                    case WinStyle.OnlyClock:
                        return pntCenter_OnlyClock;
                    default:
                        return pntNull;
                }
            }
        }
        static public Point PntHour(DateTime inp)
        {
            double alpha = Math.PI / 6 * ((inp.Hour % 12) + (double)(inp.Minute) / 60 + (double)(inp.Second) / 3600);
            return new Point((int)(PntCenter.X + intRadius_Hour * Math.Sin(alpha)),
                (int)(PntCenter.Y - intRadius_Hour *  Math.Cos(alpha)));
        }
        static public Point PntMinute(DateTime inp)
        {
            double alpha = Math.PI / 30 * (inp.Minute + (double)(inp.Second) / 60);
            return new Point((int)(PntCenter.X + intRadius_Minute * Math.Sin(alpha)),
                (int)(PntCenter.Y - intRadius_Minute * Math.Cos(alpha)));
        }
        static public Point PntSecond(DateTime inp)
        {
            double alpha = Math.PI / 30 * inp.Second;
            return new Point((int)(PntCenter.X + intRadius_Second * Math.Sin(alpha)),
                (int)(PntCenter.Y - intRadius_Second * Math.Cos(alpha)));
        }
        static private readonly Rectangle rtgNull = new Rectangle();
        static private readonly Rectangle rtgCenterOut_WithList = new Rectangle(
            pntCenter_WithList.X - intRadius_CenterOut,
            pntCenter_WithList.Y - intRadius_CenterOut,
            intRadius_CenterOut * 2, intRadius_CenterOut * 2);
        static private readonly Rectangle rtgCenterOut_OnlyClock = new Rectangle(
            pntCenter_OnlyClock.X - intRadius_CenterOut,
            pntCenter_OnlyClock.Y - intRadius_CenterOut,
            intRadius_CenterOut * 2, intRadius_CenterOut * 2);
        static public Rectangle RtgCenterOut
        {
            get
            {
                switch (MainStyle.Style)
                {
                    case WinStyle.WithList:
                        return rtgCenterOut_WithList;
                    case WinStyle.OnlyClock:
                        return rtgCenterOut_OnlyClock;
                    default:
                        return rtgNull;
                }
            }
        }
        static private readonly Rectangle rtgCenterIn_WithList = new Rectangle(    
            pntCenter_WithList.X - intRadius_CenterIn,
            pntCenter_WithList.Y - intRadius_CenterIn,
            intRadius_CenterIn * 2, intRadius_CenterIn * 2);
        static private readonly Rectangle rtgCenterIn_OnlyClock = new Rectangle(
            pntCenter_OnlyClock.X - intRadius_CenterIn,
            pntCenter_OnlyClock.Y - intRadius_CenterIn,
            intRadius_CenterIn * 2, intRadius_CenterIn * 2);
        static public Rectangle RtgCenterIn
        {
            get
            {
                switch (MainStyle.Style)
                {
                    case WinStyle.WithList:
                        return rtgCenterIn_WithList;
                    case WinStyle.OnlyClock:
                        return rtgCenterIn_OnlyClock;
                    default:
                        return rtgNull;
                }
            }
        }
        static private readonly Rectangle rtgFull_WithList = new Rectangle(0, 0, 680, 359);
        static private readonly Rectangle rtgFull_OnlyClock = new Rectangle(0, 0, 254, 359);
        static public Rectangle RtgFull
        {
            get
            {
                switch (MainStyle.Style)
                {
                    case WinStyle.WithList:
                        return rtgFull_WithList;
                    case WinStyle.OnlyClock:
                        return rtgFull_OnlyClock;
                    default:
                        return rtgNull;
                }
            }
        }
        static private readonly Rectangle rtgCircle_WithList = new Rectangle(
            pntCenter_WithList.X - intRadius_Circle,
            pntCenter_WithList.Y - intRadius_Circle,
            intRadius_Circle * 2, intRadius_Circle * 2);
        static private readonly Rectangle rtgCircle_OnlyClock = new Rectangle(
            pntCenter_OnlyClock.X - intRadius_Circle,
            pntCenter_OnlyClock.Y - intRadius_Circle,
            intRadius_Circle * 2, intRadius_Circle * 2);
        static public Rectangle RtgCircle
        {
            get
            {
                switch (MainStyle.Style)
                {
                    case WinStyle.WithList:
                        return rtgCircle_WithList;
                    case WinStyle.OnlyClock:
                        return rtgCircle_OnlyClock;
                    default:
                        return rtgNull;
                }
            }
        }
        static public Rectangle[] rtgPin;
        static public void InitPntPin()
        {
            rtgPin = new Rectangle[12];
            for (int i = 0; i < rtgPin.Length; i++)
            {
                double alpha = Math.PI / 6 * i;
                rtgPin[i] = new Rectangle(
                    (int)(PntCenter.X + intRadius_PinCircle * Math.Sin(alpha) - intRadius_PinFill),
                    (int)(PntCenter.Y - intRadius_PinCircle * Math.Cos(alpha) - intRadius_PinFill),
                    intRadius_PinFill * 2, intRadius_PinFill * 2);
            }
        }
    }
    public class Alarm
    {
        private AlarmType TypeValue;
        public AlarmType Type
        {
            get
            {
                return TypeValue;
            }
        }
        private AlarmStatus StatusValue;
        public AlarmStatus Status
        {
            get
            {
                return StatusValue;
            }
            set
            {
                StatusValue = value;
                if (value == AlarmStatus.ON)
                {
                    StartAt = DateTime.Now;                    
                }
            }
        }
        public AlarmConfiged Configed;
        private TimeSpan DistanceValue;
        public DateTime StartAt;
        public TimeSpan Distance
        {
            get
            {
                switch (Configed)
                {
                    case AlarmConfiged.Configed:
                        switch (Type)
                        {
                            case AlarmType.Alarming:
                                return AlarmingValue - DateTime.Now;
                            case AlarmType.Distance:
                                switch (Status)
                                {
                                    case AlarmStatus.ON:
                                        return StartAt + DistanceValue - DateTime.Now;
                                    case AlarmStatus.OFF:
                                    case AlarmStatus.Active:
                                    default:
                                        return DistanceValue;
                                }                                
                            default:
                                return Common.tsZero;
                        }                        
                    case AlarmConfiged.Unconfiged:
                    default:
                        return Common.tsZero;
                }
            }
            set
            {
                Configed = AlarmConfiged.Configed;
                TypeValue = AlarmType.Distance;
                DistanceValue = value;
            }
        }
        private DateTime AlarmingValue;
        public DateTime Alarming
        {
            get
            {
                switch (Configed)
                {
                    case AlarmConfiged.Configed:
                        switch (Type)
                        {
                            case AlarmType.Alarming:
                                return AlarmingValue;
                            case AlarmType.Distance:
                                return DateTime.Now + Distance;
                            default:
                                return DateTime.Now;
                        }
                    case AlarmConfiged.Unconfiged:
                    default:
                        return DateTime.Now;
                }                                
            }
            set
            {
                Configed = AlarmConfiged.Configed;
                TypeValue = AlarmType.Alarming;
                AlarmingValue = value;
            }
        }
        public void Clear()
        {
            DistanceValue = Common.tsZero;
            AlarmingValue = Common.dtToday;
            StartAt = Common.dtToday;
            TypeValue = AlarmType.Alarming;
            Status = AlarmStatus.OFF;
            Configed = AlarmConfiged.Unconfiged;            
        }
    }
    public class XML
    {
        static public void Load(string fn)
        {
            DataTable dt = new DataTable();
            Save(Common.strTempFile);
            try
            {
                dt.ReadXml(fn);
                dt.AcceptChanges();
                foreach (DataRow dr in dt.Rows)
                {
                    int i = (int)dr["ID"];
                    switch ((AlarmConfiged)dr["Configed"])
                    {
                        case AlarmConfiged.Configed:
                            WinMain.almMain[i].Clear();
                            WinMain.almMain[i].Configed = AlarmConfiged.Configed;
                            switch ((AlarmType)dr["Type"])
                            {
                                case AlarmType.Alarming:
                                    WinMain.almMain[i].Alarming = (DateTime)dr["Alarming"];
                                    break;
                                case AlarmType.Distance:
                                    WinMain.almMain[i].Distance = (TimeSpan)dr["Distance"];
                                    break;
                                default:
                                    WinMain.almMain[i].Clear();
                                    break;
                            }
                            switch ((AlarmStatus)dr["Status"])
                            {
                                case AlarmStatus.ON:
                                    WinMain.almMain[i].Status = AlarmStatus.ON;
                                    break;
                                case AlarmStatus.OFF:
                                case AlarmStatus.Active:
                                default:
                                    WinMain.almMain[i].Status = AlarmStatus.OFF;
                                    break;
                            }
                            break;
                        case AlarmConfiged.Unconfiged:
                        default:
                            WinMain.almMain[i].Clear();
                            break;                        
                    }
                }
                dt.Dispose();
            }
            catch 
            {
                dt.Dispose();
                System.Windows.Forms.MessageBox.Show(
                    "Can NOT load Settings file:\r\n" + fn, "Error - Multi Timer", 
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error);
            }            
        }
        static public void Save(string fn)
        {
            DataTable dt = new DataTable("Multi Timer");
            AddColumns(dt);
            for (int i = 0; i < WinMain.almMain.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = i;
                dr["Configed"] = WinMain.almMain[i].Configed;
                switch (WinMain.almMain[i].Configed)
                {
                    case AlarmConfiged.Configed:
                        dr["Type"] = WinMain.almMain[i].Type;
                        switch (WinMain.almMain[i].Type)
                        {
                            case AlarmType.Alarming:
                                dr["Alarming"] = WinMain.almMain[i].Alarming;
                                dr["Distance"] = Common.tsZero;
                                break;
                            case AlarmType.Distance:
                                dr["Alarming"] = Common.dtToday;
                                dr["Distance"] = WinMain.almMain[i].Distance;
                                break;
                            default:
                                dr["Alarming"] = Common.dtToday;
                                dr["Distance"] = Common.tsZero;
                                break;
                        }
                        switch (WinMain.almMain[i].Status)
                        {
                            case AlarmStatus.ON:
                                dr["Status"] = AlarmStatus.ON;
                                break;
                            case AlarmStatus.OFF:
                            case AlarmStatus.Active:
                            default:
                                dr["Status"] = AlarmStatus.OFF;
                                break;
                        }
                        break;
                    case AlarmConfiged.Unconfiged:
                    default:
                        dr["Alarming"] = Common.dtToday;
                        dr["Distance"] = Common.tsZero;
                        dr["Status"] = AlarmStatus.OFF;
                        break;
                }
                dt.Rows.Add(dr);
            }
            dt.WriteXml(fn, XmlWriteMode.WriteSchema);
            dt.Dispose();
        }
        static private void AddColumns(DataTable dt)
        {
            dt.Columns.Add("ID", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Configed", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Type", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Status", System.Type.GetType("System.Int32"));
            dt.Columns.Add("Alarming", System.Type.GetType("System.DateTime"));
            dt.Columns.Add("Distance", System.Type.GetType("System.TimeSpan"));
        }
    }
    public enum AlarmConfiged
    {
        Unknown = 0,
        Configed = 1,
        Unconfiged = 2,
    }
    public enum AlarmStatus
    {
        Unknown = 0,
        OFF = 1,
        ON = 2,
        Active = 3
    }
    public enum AlarmType
    {
        Unknown = 0,
        Alarming = 1,
        Distance = 2
    }    
    public enum WinStyle
    {
        Unknown = 0,
        WithList = 1,
        OnlyClock = 2,
        None = 3
    }
}
