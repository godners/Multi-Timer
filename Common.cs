using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Drawing;

namespace Multi_Timer
{
    public class Common
    {
        static private CultureInfo culEnUs = CultureInfo.CreateSpecificCulture("en-US");
        static public string NowString(DateTime inp)
        {
            return inp.ToString("yyyy-MM-dd HH:mm:ss.fff (ddd)", culEnUs).ToUpper();
        }
        static public string NoDefine = "--:--:--";
        static public string LblString(DateTime inp)
        {
            return inp.ToString("HH:mm:ss", culEnUs);
        }
        static public string LblString(TimeSpan inp)
        {
            return inp.ToString("HH:mm:ss", culEnUs);
        }
        static public Font fntConfiged = new Font("Courier New", 12, FontStyle.Bold);
        static public Font fntUnconfig = new Font("Courier New", 12, FontStyle.Regular);
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
        public AlarmStatus Status;
        public AlarmConfiged Configed;
        private TimeSpan DistanceValue;
        public TimeSpan Distance
        {
            get
            {
                if (Configed == AlarmConfiged.Unconfiged)
                {
                    return new TimeSpan(0);
                }
                else
                {
                    if (Type == AlarmType.Distance)
                    {
                        return DistanceValue;
                    }
                    else
                    {
                        if (Status == AlarmStatus.ON)
                        {
                            return DistanceValue;
                        }
                        else
                        {
                            return AlarmingValue - DateTime.Now;
                        }
                    }
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
                if (Configed == AlarmConfiged.Unconfiged)
                {
                    return DateTime.Now;
                }
                else
                {
                    if (Type == AlarmType.Alarming)
                    {
                        return AlarmingValue;
                    }
                    else
                    {
                        if (Status == AlarmStatus.ON)
                        {
                            return AlarmingValue;
                        }
                        else
                        {
                            return DateTime.Now.Add(DistanceValue);
                        }
                    }
                }                
            }
            set
            {
                Configed = AlarmConfiged.Configed;
                TypeValue = AlarmType.Alarming;
                AlarmingValue = new DateTime(
                    DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                    value.Hour, value.Minute, value.Second);
            }
        }
        public void Clear()
        {
            DistanceValue = new TimeSpan(0);
            AlarmingValue = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);
            TypeValue = AlarmType.Unknown;
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
}
