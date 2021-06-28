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
        private Graphics gpcMain;
        public WinMain()
        {
            InitializeComponent();            
        }
        private void WinMain_Load(object sender, EventArgs e)
        {
            bolSetting = false;
            this.SetStyle(ControlStyles.StandardClick, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            sfdMain.InitialDirectory = Common.strDocPath;
            ofdMain.InitialDirectory = Common.strDocPath;

            tmrInit.Interval = Common.intPrecision / 2;
            MainStyle.Style = WinStyle.WithList;
            MainStyle.InitPnt();
            Clock.InitPntPin();
            
            InitAlarm(); 
            InitLbls();
            InitBtns();
            FlushLbls();             
            FlushBtns();
            FlushAlarm();
            GraphMain();
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
        private void FlushAlarm()
        {
            DateTime n = DateTime.Now;
            for (int i = 0; i < almMain.Length; i++)
            {
                if (almMain[i].Configed == AlarmConfiged.Configed)
                {
                    switch (almMain[i].Type)
                    {
                        case AlarmType.Alarming:
                            if ((almMain[i].Alarming - n).CompareTo(Common.tsZero) < 0)
                            {
                                almMain[i].Alarming += Common.tsOneDay;
                            }
                            break;
                        case AlarmType.Distance:
                            if (almMain[i].Distance.CompareTo(Common.tsZero) < 0)
                            {
                                almMain[i].StartAt += Common.tsOneDay;
                            }
                            break;
                        default:
                            almMain[i].Clear();
                            break;
                    }
                    if (almMain[i].Status == AlarmStatus.ON)
                    {
                        int intInteval;
                        switch (almMain[i].Type)
                        {
                            case AlarmType.Alarming:
                                intInteval = (almMain[i].Alarming - n).CompareTo(Common.tsActive);
                                break;
                            case AlarmType.Distance:
                                intInteval = (almMain[i].StartAt - n).CompareTo(Common.tsActive);
                                break;
                            default:
                                intInteval = int.MinValue;
                                break;                            
                        }
                        if (intInteval >= 0)
                        {
                            almMain[i].Status = AlarmStatus.Active;
                        }
                        else
                        {
                            if (almMain[i].Status == AlarmStatus.Active)
                            {
                                almMain[i].Status = AlarmStatus.OFF;
                            }
                        }
                        if (intInteval == int.MinValue)
                        {
                            almMain[i].Status = AlarmStatus.OFF;
                        }
                    }
                }
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
                lblTag[i].Tag = i; 
                lblTag[i].DoubleClick += new EventHandler(this.LblTag_CLick);
                lblID[i].TabIndex = 900 + i * 10;
                lblAlm[i].TabIndex = 901 + i * 10;
                lblDst[i].TabIndex = 902 + i * 10;
                lblTag[i].TabIndex = 903 + i * 10;                
            }

        }
        private void GraphMain()
        {
            switch (MainStyle.Style)
            {
                case WinStyle.WithList:
                    btnList.Text = ">LIST";
                    GraphMain_Visable(true);
                    break;
                case WinStyle.OnlyClock:
                    btnList.Text = "<LIST";
                    GraphMain_Visable(false);
                    break;
                default:
                    MainStyle.SwitchError();
                    break;
            }
            this.Size = MainStyle.SizMain;
            Clock.InitPntPin();
            GraphMain_Location();
            GraphMain_ToCenter();
        }
        private void GraphMain_Location()
        {
            btnList.Location = MainStyle.PntBtnList;
            lblTitleID.Location = MainStyle.PntLblTitleID;
            lblTitleAlm.Location = MainStyle.PntLblTitleAlm;
            lblTitleDst.Location = MainStyle.PntLblTitleDst;
            btnAllON.Location = MainStyle.PntBtnAllON;
            btnAllOFF.Location = MainStyle.PntBtnAllOFF;
            btnAllClr.Location = MainStyle.PntBtnAllClr;
            lblNote.Location = MainStyle.PntLblNote;
            btnLoad.Location = MainStyle.PntBtnLoad;
            btnSave.Location = MainStyle.PntBtnSave;
            btnAuthor.Location = MainStyle.PntBtnAuthor;
            for (int i = 0; i < lblAlm.Length; i++)
            {
                lblID[i].Location = MainStyle.PntLblID[i];
                lblAlm[i].Location = MainStyle.PntLblAlm[i];
                lblDst[i].Location = MainStyle.PntLblDst[i];
                btnSet[i].Location = MainStyle.PntBtnSet[i];
                btnON[i].Location = MainStyle.PntBtnON[i];
                btnClr[i].Location = MainStyle.PntBtnClr[i];
                lblTag[i].Location = MainStyle.PntLblTag(i);
            }
        }
        private void GraphMain_Visable(bool inp)
        {
            lblNow.Visible = inp; 
            lblTitleID.Visible = inp;
            lblTitleAlm.Visible = inp; 
            lblTitleDst.Visible = inp; 
            btnAllON.Visible = inp; 
            btnAllOFF.Visible = inp; 
            btnAllClr.Visible = inp; 
            for (int i = 0; i < almMain.Length; i++)
            {
                lblID[i].Visible = inp; 
                lblAlm[i].Visible = inp; 
                lblDst[i].Visible = inp; 
                btnSet[i].Visible = inp;
                btnON[i].Visible = inp; 
                btnClr[i].Visible = inp;
            }
        }
        private void GraphMain_ToCenter()
        {
            Size s = this.Size;
            Rectangle rtg = Screen.GetBounds(this);
            Point p = new Point((rtg.Width - s.Width) / 2, (rtg.Height - s.Height) / 2);
            this.Location= new Point((rtg.Width - s.Width) / 2, (rtg.Height - s.Height) / 2);
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
                btnSet[i].Tag = i;
                btnSet[i].Click += new EventHandler(this.BtnSet_Click);
                btnON[i].TabIndex = 101 + i * 10;
                btnON[i].Tag = i;
                btnON[i].Click += new EventHandler(this.BtnON_Click);
                btnClr[i].TabIndex = 102 + i * 10;
                btnClr[i].Tag = i;
                btnClr[i].Click += new EventHandler(this.BtnClr_Click);
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
                        ColorLbl(i, Color.Gray);
                        break;
                    case AlarmConfiged.Configed:
                        switch (almMain[i].Status)
                        {
                            case AlarmStatus.ON:
                                ColorLbl(i, Color.Black);
                                break;
                            case AlarmStatus.Active:
                                ColorLbl(i, Color.Red);
                                break;
                            case AlarmStatus.OFF:
                            default:
                                ColorLbl(i, Color.Gray);
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
                        ColorLbl(i, Color.Gray);
                        break;
                }
            }
        }
        private void FlushBtns()
        {
            bool bolAllON = false;
            bool bolAllOFF = false;
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
                    default:
                        btnON[i].Enabled = false;
                        btnON[i].Text = "ON";
                        btnClr[i].Enabled = false;
                        break;
                }
            }
            btnAllON.Enabled = bolAllON;
            btnAllOFF.Enabled = bolAllOFF;
            btnAllClr.Enabled = bolAllON | bolAllOFF;
            btnSave.Enabled = bolAllON | bolAllOFF;
        }
        private void TmrInit_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;
            lblNow.Text = Common.NowString(n);
            int i = Math.Min(n.Millisecond, 1000 - n.Millisecond);
            if (i < Common.intPrecision)
            {
                GraphClock();
                tmrMain.Enabled = true;
                tmrInit.Enabled = false;
            }
        }
        private void TmrMain_Tick(object sender, EventArgs e)
        {
            DateTime n = DateTime.Now;            
            if (!bolSetting)
            {
                lblNow.Text = Common.NowString(n);
                FlushAlarm();
                FlushLbls();
                FlushBtns();
                GraphClock();
            }         
        }
        private void BtnSet_Click(object sender, EventArgs e)
        {
            int i = (int)(((Button)sender).Tag);
            ShowWinSet(i);
        }
        private void BtnON_Click(object sender, EventArgs e)
        {
            int i = (int)(((Button)sender).Tag);
            switch (almMain[i].Status)
            {
                case AlarmStatus.ON:
                    almMain[i].Status = AlarmStatus.OFF;
                    break;
                case AlarmStatus.OFF:
                case AlarmStatus.Active:
                default:
                    almMain[i].Status = AlarmStatus.ON;
                    break;
            }
            FlushBtns();
            FlushLbls();
        }
        private void BtnClr_Click(object sender, EventArgs e)
        {
            int i = (int)(((Button)sender).Tag);
            almMain[i].Clear();
            FlushBtns();
            FlushLbls();
        }
        private void LblTag_CLick(object sender, EventArgs e)
        {
            int i = (int)(((Label)sender).Tag);
            ShowWinSet(i);
        }
        private void ShowWinSet(int inp)
        {
            bolSetting = true;
            WinSet.intID = inp;
            Form f = new WinSet();            
            Point p = this.Location;
            p.X += (this.Size.Width - f.Width) / 2;
            p.Y += (this.Size.Height - f.Height) / 2;
            this.ShowInTaskbar = false;
            f.Show(this);
            f.Location = p;
            f.Activate();
            this.Enabled = false;            
        }
        private void BtnAllON_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < almMain.Length; i++)
            {
                if (almMain[i].Configed == AlarmConfiged.Configed)
                {
                    almMain[i].Status = AlarmStatus.ON;
                }
            }
            FlushBtns();
            FlushLbls();
        }
        private void BtnAllOFF_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < almMain.Length; i++)
            {
                if (almMain[i].Configed == AlarmConfiged.Configed)
                {
                    almMain[i].Status = AlarmStatus.OFF;
                }
            }
            FlushBtns();
            FlushLbls();
        }
        private void BtnAllClr_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < almMain.Length; i++)
            {
                almMain[i].Clear();
            }
            FlushBtns();
            FlushLbls();
        }
        private void WinMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                nfiMain.Visible = true;
                this.ShowInTaskbar = false;
            }
        }
        private void NfiMain_Click(object sender, EventArgs e)
        {
            GraphMain_ToCenter();
            this.WindowState = FormWindowState.Normal;
            nfiMain.Visible = false;
            this.ShowInTaskbar = true;
        }
        private void ColorLbl(int ID, Color clr)
        {
            lblAlm[ID].ForeColor = clr;
            lblDst[ID].ForeColor = clr;
            lblTag[ID].ForeColor = clr;
            lblID[ID].ForeColor = clr;
        }
        private void GraphClock()
        {
            gpcMain = this.CreateGraphics();
            gpcMain.Clear(this.BackColor);
            DateTime n = DateTime.Now;
            gpcMain.DrawEllipse(Clock.penCircle, Clock.RtgCircle);
            gpcMain.DrawLine(Clock.penHour, Clock.PntCenter, Clock.PntHour(n));
            gpcMain.DrawLine(Clock.penMinute, Clock.PntCenter, Clock.PntMinute(n));
            gpcMain.DrawLine(Clock.penSecond, Clock.PntCenter, Clock.PntSecond(n));
            gpcMain.FillEllipse(Clock.brsBlack, Clock.RtgCenterOut);
            gpcMain.FillEllipse(Clock.brsBackColor, Clock.RtgCenterIn);
            for (int i = 0; i < Clock.rtgPin.Length; i++)
            {
                gpcMain.FillRectangle(Clock.brsBlack, Clock.rtgPin[i]);
            }
        }
        private void BtnAuthor_Click(object sender, EventArgs e)
        {
            Form f = new WinAuthor();
            Point p = this.Location;
            p.X += (this.Size.Width - f.Width) / 2;
            p.Y += (this.Size.Height - f.Height) / 2;
            this.ShowInTaskbar = false;
            f.Show(this);
            f.Location = p;
            this.Enabled = false;
            f.Activate();
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            sfdMain.ShowDialog();
            XML.Save(sfdMain.FileName);
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
            if (System.IO.File.Exists(ofdMain.FileName))
            {
                XML.Load(ofdMain.FileName);
            }
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            switch (MainStyle.Style)
            {
                case WinStyle.OnlyClock:
                    MainStyle.Style = WinStyle.WithList;
                    break;
                case WinStyle.WithList:
                    MainStyle.Style = WinStyle.OnlyClock;
                    break;
                default:
                    MainStyle.SwitchError();
                    break;
            }
            GraphMain();
        }
    }
}
