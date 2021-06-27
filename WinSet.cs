using System;
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
            tmrSet.Enabled = true;
            FlushNote();
            nudH.Focus();            
            bolIniting = false;
        }
        private void ChangeInit()
        {
            almSet.Status = AlarmStatus.OFF;            
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
            btnClr.Enabled = true;
        }
        private void NewInit()
        {
            almSet.Clear();
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
            DateTime n = DateTime.Now;
            switch (almSet.Type)
            {
                case AlarmType.Alarming:
                    TimeSpan ts = almSet.Alarming - n;
                    if (ts.CompareTo(Common.tsZero) < 0)
                    {
                        ts += Common.tsOneDay;
                    }
                    intH = ts.Hours; intM = ts.Minutes; intS = ts.Seconds;
                    lblType.Text = "Alarming:";
                    break;
                case AlarmType.Distance:
                    DateTime dt = n + almSet.Distance;
                    intH = dt.Hour; intM = dt.Minute; intS = dt.Second;
                    lblType.Text = "Distance:";
                    break;
                default:
                    intH = 0; intM = 0; intS = 0;
                    lblType.Text = "Unknown:";
                    break;
            }
            lblTime.Text = intH.ToString().PadLeft(2, (char)48) + 
                ":" + intM.ToString().PadLeft(2, (char)48) + 
                ":" + intS.ToString().PadLeft(2, (char)48);
        }
        private void TmrSet_Tick(object sender, EventArgs e)
        {
            if (WinMain.bolSetting)
            {
                FlushNote();
            }
        }        
        private void BtnClr_Click(object sender, EventArgs e)
        {
            almSet.Clear();
            this.Close();
        }
        private void BntSet_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            almSet.Status = AlarmStatus.OFF;
            almSet.Status = AlarmStatus.ON;           
            this.Close();
        }
        private void Nud_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar )
            {
                case (char)13:
                    almSet.Status = AlarmStatus.OFF;
                    almSet.Status = AlarmStatus.ON;
                    this.Close();
                    break;
                case (char)27:
                    almSet.Status = AlarmStatus.OFF;
                    this.Close();
                    break;
            }
        }
        private void Nud_ValueChanged(object sender, EventArgs e)
        {
            switch (almSet.Type)
            {
                case AlarmType.Alarming:
                    LoadAlarming();
                    break;
                case AlarmType.Distance:
                    LoadDistance();
                    break;
                default:
                    break;
            }
            FlushNote();
        }
        private void RdbAlm_CheckedChanged(object sender, EventArgs e)
        {            
            if (((RadioButton)sender).Checked & !bolIniting)
            {
                LoadAlarming();
                InitAlarm();
            }
        }
        private void RdbDst_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked & !bolIniting)
            {
                LoadDistance();
                InitAlarm();
            }            
        }
        private void Nud_GotFocus(object sender, EventArgs e)
        {
            NumericUpDown nud = (NumericUpDown)sender;
            nud.Select(0, 2);
        }
        private void LoadDistance()
        {
            almSet.Distance = new TimeSpan((int)nudH.Value, (int)nudM.Value, (int)nudS.Value);
        }
        private void LoadAlarming()
        {
            almSet.Alarming = Common.dtToday + (new TimeSpan((int)nudH.Value, (int)nudM.Value, (int)nudS.Value));
            if ((almSet.Alarming - DateTime.Now).CompareTo(Common.tsZero) < 0)
            {
                almSet.Alarming = almSet.Alarming.AddDays(1);
            }          
        }
    }
}
