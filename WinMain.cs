using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Multi_Timer
{
    public partial class WinMain : Form
    {        
        private Label[] lblID;
        private Label[] lblAlm;
        private Label[] lblDst;
        private Label[] lblTag;
        private Button[] btnSet;
        private Button[] btnON;
        private Button[] btnClr;
        static public bool bolSetting; 
        static public Alarm[] almMain;
        public WinMain()
        {
            InitializeComponent();            
        }
        private void WinMain_Load(object sender, EventArgs e)
        {
            bolSetting = false;
            InitAlarm();
            InitLbls();
            InitBtns();
            FlushLbls();
            FlushBtns();
            //MessageBox.Show(((char)48).ToString());

        }

        private void InitAlarm()
        {
            almMain = new Alarm[8];
            for (int i = 0; i < almMain.Length; i++)
            {
                almMain[i] = new Alarm();
                almMain[i].Clear();
            }
        }
        private void InitLbls()
        {
            lblID = new Label[8]; lblAlm = new Label[8]; lblDst = new Label[8]; lblTag = new Label[8];
            lblID[0] = lblID0; lblID[1] = lblID1; lblID[2] = lblID2; lblID[3] = lblID3;
            lblID[4] = lblID4; lblID[5] = lblID5; lblID[6] = lblID6; lblID[7] = lblID7;
            lblAlm[0] = lblAlm0; lblAlm[1] = lblAlm1; lblAlm[2] = lblAlm2; lblAlm[3] = lblAlm3;
            lblAlm[4] = lblAlm4; lblAlm[5] = lblAlm5; lblAlm[6] = lblAlm6; lblAlm[7] = lblAlm7;
            lblDst[0] = lblDst0; lblDst[1] = lblDst1; lblDst[2] = lblDst2; lblDst[3] = lblDst3;
            lblDst[4] = lblDst4; lblDst[5] = lblDst5; lblDst[6] = lblDst6; lblDst[7] = lblDst7;
            lblTag[0] = lblTag0; lblTag[1] = lblTag1; lblTag[2] = lblTag2; lblTag[3] = lblTag3;
            lblTag[4] = lblTag4; lblTag[5] = lblTag5; lblTag[6] = lblTag6; lblTag[7] = lblTag7;
            for (int i = 0; i< almMain.Length; i++)
            {
                lblID[i].Text = i.ToString();
                lblTag[i].Text = i.ToString();
                lblTag[i].DoubleClick += new EventHandler(this.lblTag_DoubleCLick);
                lblID[i].TabIndex = 900 + i * 10;
                lblAlm[i].TabIndex = 901 + i * 10;
                lblDst[i].TabIndex = 902 + i * 10;
                lblTag[i].TabIndex = 903 + i * 10;
            }
        }
        private void InitBtns()
        {
            btnSet = new Button[8]; btnON = new Button[8]; btnClr = new Button[8];
            btnSet[0] = btnSet0; btnSet[1] = btnSet1; btnSet[2] = btnSet2; btnSet[3] = btnSet3;
            btnSet[4] = btnSet4; btnSet[5] = btnSet5; btnSet[6] = btnSet6; btnSet[7] = btnSet7;
            btnON[0] = btnON0; btnON[1] = btnON1; btnON[2] = btnON2; btnON[3] = btnON3;
            btnON[4] = btnON4; btnON[5] = btnON5; btnON[6] = btnON6; btnON[7] = btnON7;
            btnClr[0] = btnClr0; btnClr[1] = btnClr1; btnClr[2] = btnClr2; btnClr[3] = btnClr3;
            btnClr[4] = btnClr4; btnClr[5] = btnClr5; btnClr[6] = btnClr6; btnClr[7] = btnClr7;
            for (int i = 0; i < almMain.Length; i++)
            {
                btnSet[i].TabIndex = 100 + i * 10;
                btnSet[i].Click += new EventHandler(this.btnSet_Click);
                btnON[i].TabIndex = 101 + i * 10;
                btnClr[i].TabIndex = 102 + i * 10;
            }
        }
        private void FlushLbls()
        {
            for (int i = 0; i < almMain.Length; i++)
            {
                switch (almMain[i].Configed)
                {
                    case AlarmConfiged.Unconfiged:
                        lblAlm[i].Text = Common.NoDefine;
                        lblDst[i].Text = Common.NoDefine;
                        lblAlm[i].Font = Common.fntUnconfig;
                        lblAlm[i].Font = Common.fntUnconfig;
                        lblTag[i].Font = Common.fntUnconfig;
                        lblID[i].ForeColor = Color.Gray;
                        lblAlm[i].ForeColor = Color.Gray;
                        lblDst[i].ForeColor = Color.Gray;
                        lblTag[i].ForeColor = Color.Gray;
                        break;
                    case AlarmConfiged.Configed:
                        switch (almMain[i].Status)
                        {
                            case AlarmStatus.ON:
                                lblID[i].ForeColor = Color.Black;
                                lblAlm[i].ForeColor = Color.Black;
                                lblDst[i].ForeColor = Color.Black;
                                lblTag[i].ForeColor = Color.Black;
                                break;
                            case AlarmStatus.OFF:
                                lblID[i].ForeColor = Color.Gray;
                                lblAlm[i].ForeColor = Color.Gray;
                                lblDst[i].ForeColor = Color.Gray;
                                lblTag[i].ForeColor = Color.Gray;
                                break;
                            case AlarmStatus.Active:
                                lblID[i].ForeColor = Color.Red;
                                lblAlm[i].ForeColor = Color.Red;
                                lblDst[i].ForeColor = Color.Red;
                                lblTag[i].ForeColor = Color.Red;
                                break;
                            default:
                                lblID[i].ForeColor = Color.Gray;
                                lblAlm[i].ForeColor = Color.Gray;
                                lblDst[i].ForeColor = Color.Gray;
                                lblTag[i].ForeColor = Color.Gray;
                                break;
                        }
                        switch (almMain[i].Type)
                        {
                            case AlarmType.Alarming:
                                lblAlm[i].Font = Common.fntConfiged;
                                lblDst[i].Font = Common.fntUnconfig;
                                lblTag[i].Font = Common.fntConfiged;
                                lblAlm[i].Text = Common.LblString(almMain[i].Alarming);
                                if (almMain[i].Status == AlarmStatus.ON) 
                                {
                                    lblDst[i].Text = Common.LblString(almMain[i].Distance);
                                }
                                else
                                {
                                    lblDst[i].Text = Common.NoDefine;
                                }
                                break;
                            case AlarmType.Distance:
                                lblAlm[i].Font = Common.fntUnconfig;
                                lblDst[i].Font = Common.fntConfiged;
                                lblTag[i].Font = Common.fntConfiged;
                                if (almMain[i].Status == AlarmStatus.ON)
                                {
                                    lblAlm[i].Text = Common.LblString(almMain[i].Alarming);
                                }
                                else
                                {
                                    lblAlm[i].Text = Common.NoDefine;
                                }
                                lblDst[i].Text = Common.LblString(almMain[i].Distance);
                                break;
                            default:
                                lblAlm[i].Font = Common.fntUnconfig;
                                lblDst[i].Font = Common.fntUnconfig;
                                lblTag[i].Font = Common.fntUnconfig;
                                lblAlm[i].Text = Common.NoDefine;
                                lblDst[i].Text = Common.NoDefine;
                                break;
                        }
                        break;
                    default:
                        lblAlm[i].Text = Common.NoDefine;
                        lblDst[i].Text = Common.NoDefine;
                        lblAlm[i].Font = Common.fntUnconfig;
                        lblAlm[i].Font = Common.fntUnconfig;
                        lblTag[i].Font = Common.fntUnconfig;
                        lblAlm[i].ForeColor = Color.Gray;
                        lblDst[i].ForeColor = Color.Gray;
                        lblTag[i].ForeColor = Color.Gray;
                        break;
                }
            }

        }
        private void FlushBtns()
        {
            bool bolAllON = false;
            bool bolAllOFF = false;
            bool bolAllClr = false;
            for (int i = 0; i < almMain.Length; i++)
            {
                switch (almMain[i].Configed)
                {
                    case AlarmConfiged.Configed:
                        btnON[i].Enabled = true;
                        switch (almMain[i].Status)
                        {
                            case AlarmStatus.ON:
                                btnON[i].Text = "OFF";
                                bolAllOFF = true;
                                break;
                            case AlarmStatus.OFF:
                                btnON[i].Text = "ON";
                                bolAllON = true;
                                break;
                            case AlarmStatus.Active:
                                btnON[i].Text = "ON";
                                bolAllON = true;
                                break;
                            default:
                                btnON[i].Text = "ON";
                                break;
                        }
                        btnClr[i].Enabled = true;
                        break;
                    case AlarmConfiged.Unconfiged:
                        btnON[i].Enabled = false;
                        btnON[i].Text = "ON";
                        btnClr[i].Enabled = false;
                        break;
                    default:
                        btnON[i].Enabled = false;
                        btnON[i].Text = "ON";
                        btnClr[i].Enabled = false;
                        break;
                }
            }
            btnAllON.Enabled = bolAllON;
            btnAllOFF.Enabled = bolAllOFF;
            btnAllClr.Enabled = bolAllClr;
            btnSave.Enabled = bolAllClr;
        }
        private void tmrInit_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            lblNow.Text = Common.NowString(n);
            if (n.Millisecond < 20)
            {
                tmrMain.Enabled = true;
                tmrInit.Enabled = false;
            }
        }
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;            
            if (!bolSetting)
            {
                lblNow.Text = Common.NowString(n);
                FlushLbls();
                FlushBtns();
            }
            
            

        }
        private void btnSet_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Name;
            ShowWinSet(Convert.ToInt32(s.Substring(s.Length - 1)));
        }
        private void lblTag_DoubleCLick(object sender, EventArgs e)
        {
            string s = ((Label)sender).Name;
            ShowWinSet(Convert.ToInt32(s.Substring(s.Length - 1)));
        }
        private void ShowWinSet(int inp)
        {
            bolSetting = true;
            WinSet.intID = inp;
            Form f = new WinSet();            
            Point p = this.Location;
            p.X += (this.Size.Width - f.Width) / 2;
            p.Y += (this.Size.Height - f.Height) / 2;
            f.Show(this);
            f.Location = p;
            this.Enabled = false;            
        }
        private void WinMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                nfiMain.Visible = true;
                this.ShowInTaskbar = false;
            }
        }
        private void nfiMain_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            nfiMain.Visible = false;
            this.ShowInTaskbar = true;
        }
    }
}
