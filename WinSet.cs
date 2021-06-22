using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multi_Timer
{
    public partial class WinSet : Form
    {
        static public int intID;
        private Alarm almSet;
        private bool bolIniting;
        private int intH, intM, intS;
        public WinSet()
        {
            InitializeComponent();
        }
        private void WinSet_Shown(object sender, EventArgs e)
        {
            InitAlarm();
        }
        private void WinSet_Closed(object sender, FormClosedEventArgs e)
        {
            WinMain.bolSetting = false;
            this.Owner.Enabled = true;
            this.Owner.Activate();
            tmrSet.Enabled = false;
        }
        private void InitAlarm()
        {
            bolIniting = true;
            this.Text = "Alarmer " + intID.ToString() + " - Multi Timer";
            almSet = WinMain.almMain[intID];
            switch (almSet.Configed)
            {
                case AlarmConfiged.Configed:
                    ChangeInit();
                    break;
                case AlarmConfiged.Unconfiged:
                default:
                    NewInit();
                    break;
            }
            nudH.Focus();
            tmrSet.Enabled = true;
            FlushNote();
            bolIniting = false;
        }
        private void ChangeInit()
        {
            switch (almSet.Type)
            {
                case AlarmType.Alarming:
                    rdbAlm.Checked = true;
                    nudH.Value = almSet.Alarming.Hour;
                    nudM.Value = almSet.Alarming.Minute;
                    nudS.Value = almSet.Alarming.Second;
                    break;
                case AlarmType.Distance:
                    rdbDst.Checked = true;
                    nudH.Value = almSet.Distance.Hours;
                    nudM.Value = almSet.Distance.Minutes;
                    nudS.Value = almSet.Distance.Seconds;
                    break;
                default:
                    NewInit();
                    break;
            }
            switch (almSet.Status)
            {
                case AlarmStatus.ON:
                    btnON.Text = "OFF";
                    break;
                case AlarmStatus.OFF:
                case AlarmStatus.Active:
                    btnON.Text = "ON";
                    break;
                default:
                    NewInit();
                    break;
            }
            btnClr.Enabled = true;
        }
        private void NewInit()
        {
            rdbAlm.Checked = true;            
            DateTime dt = DateTime.Now;
            almSet.Alarming = dt;
            nudH.Value = dt.Hour;
            nudM.Value = dt.Minute;
            nudS.Value = dt.Second;
            btnClr.Enabled = false;
        }
        public void FlushNote()
        {
            DateTime dtNow = DateTime.Now;
            DateTime dtSet;
            TimeSpan ts;
            switch (almSet.Type)
            {
                case AlarmType.Alarming:
                    dtSet = new DateTime(dtNow.Year, dtNow.Month, dtNow.Day, (int)nudH.Value, (int)nudM.Value, (int)nudS.Value);
                    ts = dtSet - dtNow;
                    if (ts.CompareTo(new TimeSpan(0)) < 0)
                    {
                        ts += new TimeSpan(1, 0, 0, 0);
                    }
                    intH = ts.Hours; intM = ts.Minutes; intS = ts.Seconds;
                    lblType.Text = "Alarming: ";
                    break;
                case AlarmType.Distance:
                    ts = new TimeSpan((int)nudH.Value, (int)nudM.Value, (int)nudS.Value);
                    dtSet = dtNow + ts;
                    intH = dtSet.Hour; intM = dtSet.Minute; intS = dtSet.Second;
                    lblType.Text = "Distance: ";
                    break;
                default:
                    intH = 0; intM = 0; intS = 0;
                    lblType.Text = "Unknown:  ";
                    break;
            }
            lblTime.Text = intH.ToString().PadLeft(2, (char)48) + ":" + intM.ToString().PadLeft(2, (char)48) + ":" + intS.ToString().PadLeft(2, (char)48);
        }
        private void tmrSet_Tick(object sender, EventArgs e)
        {
            if (WinMain.bolSetting)
            {
                FlushNote();
            }
        }
        private void rdbAlm_CheckedChanged(object sender, EventArgs e)
        {
            if (!bolIniting)
            {
                DateTime dt = DateTime.Now;
                almSet.Alarming = new DateTime(dt.Year, dt.Month, dt.Day) +
                    new TimeSpan(intH, intM, intS);
                InitAlarm();
            }            
        }
        private void rdbDst_CheckedChanged(object sender, EventArgs e)
        {
            if (!bolIniting)
            {
                TimeSpan ts = new TimeSpan(intH, intM, intS);
                almSet.Distance = ts;
                InitAlarm();
            }            
        }
        private void nud_GotFocus(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.Select(0, 2);
        }
    }
}
