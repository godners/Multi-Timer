using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Drawing;

namespace Multi_Timer
{
    public class Common
    {
        static private readonly CultureInfo culEnUs = CultureInfo.CreateSpecificCulture("en-US");
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
        static public ClockStyle Style;

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
                switch (Style)
                {
                    case ClockStyle.WithList:
                        return pntCenter_WithList;
                    case ClockStyle.OnlyClock:
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
                switch (Style)
                {
                    case ClockStyle.WithList:
                        return rtgCenterOut_WithList;
                    case ClockStyle.OnlyClock:
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
                switch (Style)
                {
                    case ClockStyle.WithList:
                        return rtgCenterIn_WithList;
                    case ClockStyle.OnlyClock:
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
                switch (Style)
                {
                    case ClockStyle.WithList:
                        return rtgFull_WithList;
                    case ClockStyle.OnlyClock:
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
                switch (Style)
                {
                    case ClockStyle.WithList:
                        return rtgCircle_WithList;
                    case ClockStyle.OnlyClock:
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
    public enum ClockStyle
    {
        Unknown = 0,
        WithList = 1,
        OnlyClock = 2,
        None = 3
    }
}
