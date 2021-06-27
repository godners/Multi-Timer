
namespace Multi_Timer
{
    partial class WinSet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinSet));
            this.rdbAlm = new System.Windows.Forms.RadioButton();
            this.rdbDst = new System.Windows.Forms.RadioButton();
            this.nudM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudS = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnON = new System.Windows.Forms.Button();
            this.bntSet = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.tmrSet = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbAlm
            // 
            this.rdbAlm.AutoSize = true;
            this.rdbAlm.Checked = true;
            this.rdbAlm.Location = new System.Drawing.Point(13, 13);
            this.rdbAlm.Margin = new System.Windows.Forms.Padding(4);
            this.rdbAlm.Name = "rdbAlm";
            this.rdbAlm.Size = new System.Drawing.Size(106, 22);
            this.rdbAlm.TabIndex = 100;
            this.rdbAlm.TabStop = true;
            this.rdbAlm.Text = "&Alarming";
            this.rdbAlm.UseVisualStyleBackColor = true;
            this.rdbAlm.CheckedChanged += new System.EventHandler(this.RdbAlm_CheckedChanged);
            // 
            // rdbDst
            // 
            this.rdbDst.AutoSize = true;
            this.rdbDst.Location = new System.Drawing.Point(128, 13);
            this.rdbDst.Margin = new System.Windows.Forms.Padding(4);
            this.rdbDst.Name = "rdbDst";
            this.rdbDst.Size = new System.Drawing.Size(106, 22);
            this.rdbDst.TabIndex = 101;
            this.rdbDst.Text = "&Distance";
            this.rdbDst.UseVisualStyleBackColor = true;
            this.rdbDst.CheckedChanged += new System.EventHandler(this.RdbDst_CheckedChanged);
            // 
            // nudM
            // 
            this.nudM.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudM.Location = new System.Drawing.Point(98, 43);
            this.nudM.Margin = new System.Windows.Forms.Padding(4);
            this.nudM.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudM.Name = "nudM";
            this.nudM.Size = new System.Drawing.Size(51, 26);
            this.nudM.TabIndex = 201;
            this.nudM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudM.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            this.nudM.GotFocus += new System.EventHandler(this.Nud_GotFocus);
            this.nudM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nud_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 900;
            this.label1.Text = ":";
            // 
            // nudS
            // 
            this.nudS.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudS.Location = new System.Drawing.Point(183, 43);
            this.nudS.Margin = new System.Windows.Forms.Padding(4);
            this.nudS.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudS.Name = "nudS";
            this.nudS.Size = new System.Drawing.Size(51, 26);
            this.nudS.TabIndex = 202;
            this.nudS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudS.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            this.nudS.GotFocus += new System.EventHandler(this.Nud_GotFocus);
            this.nudS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nud_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 18);
            this.label2.TabIndex = 901;
            this.label2.Text = ":";
            // 
            // btnON
            // 
            this.btnON.Location = new System.Drawing.Point(13, 103);
            this.btnON.Margin = new System.Windows.Forms.Padding(4);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(47, 26);
            this.btnON.TabIndex = 300;
            this.btnON.Text = "&ON";
            this.btnON.UseVisualStyleBackColor = true;
            this.btnON.Click += new System.EventHandler(this.BtnON_Click);
            // 
            // bntSet
            // 
            this.bntSet.Location = new System.Drawing.Point(68, 103);
            this.bntSet.Margin = new System.Windows.Forms.Padding(4);
            this.bntSet.Name = "bntSet";
            this.bntSet.Size = new System.Drawing.Size(63, 26);
            this.bntSet.TabIndex = 301;
            this.bntSet.Text = "&SET";
            this.bntSet.UseVisualStyleBackColor = true;
            this.bntSet.Click += new System.EventHandler(this.BntSet_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(139, 103);
            this.btnClr.Margin = new System.Windows.Forms.Padding(4);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(95, 26);
            this.btnClr.TabIndex = 302;
            this.btnClr.Text = "&CLEAR";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.BtnClr_Click);
            // 
            // tmrSet
            // 
            this.tmrSet.Enabled = true;
            this.tmrSet.Interval = 500;
            this.tmrSet.Tick += new System.EventHandler(this.TmrSet_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(147, 77);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(88, 18);
            this.lblTime.TabIndex = 905;
            this.lblTime.Text = "88:88:88";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(13, 77);
            this.lblType.Margin = new System.Windows.Forms.Padding(4);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(88, 18);
            this.lblType.TabIndex = 906;
            this.lblType.Text = "Unknown:";
            // 
            // nudH
            // 
            this.nudH.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.nudH.Location = new System.Drawing.Point(13, 43);
            this.nudH.Margin = new System.Windows.Forms.Padding(4);
            this.nudH.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(51, 26);
            this.nudH.TabIndex = 200;
            this.nudH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudH.ValueChanged += new System.EventHandler(this.Nud_ValueChanged);
            this.nudH.GotFocus += new System.EventHandler(this.Nud_GotFocus);
            this.nudH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nud_KeyPress);
            // 
            // WinSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 142);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.bntSet);
            this.Controls.Add(this.btnON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudM);
            this.Controls.Add(this.nudH);
            this.Controls.Add(this.rdbDst);
            this.Controls.Add(this.rdbAlm);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alarmer 8 - Multi Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinSet_Closed);
            this.Shown += new System.EventHandler(this.WinSet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.nudM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAlm;
        private System.Windows.Forms.RadioButton rdbDst;
        private System.Windows.Forms.NumericUpDown nudM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Button bntSet;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Timer tmrSet;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.NumericUpDown nudH;
    }
}