
namespace Multi_Timer
{
    partial class WinAuthor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAuthor));
            this.tmrAuthor = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llbOS = new System.Windows.Forms.LinkLabel();
            this.ptbITIL = new System.Windows.Forms.PictureBox();
            this.ptbITSS = new System.Windows.Forms.PictureBox();
            this.ptbOCP = new System.Windows.Forms.PictureBox();
            this.ptbVCP = new System.Windows.Forms.PictureBox();
            this.ptbRHCE = new System.Windows.Forms.PictureBox();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbITIL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbITSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVCP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRHCE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrAuthor
            // 
            this.tmrAuthor.Enabled = true;
            this.tmrAuthor.Interval = 2000;
            this.tmrAuthor.Tick += new System.EventHandler(this.TmrAuthor_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mr. Tianyue Ren";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "City: Beijing, P.R.China";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Born: 1987, Jan.";
            // 
            // llbOS
            // 
            this.llbOS.AutoSize = true;
            this.llbOS.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbOS.Location = new System.Drawing.Point(33, 222);
            this.llbOS.Margin = new System.Windows.Forms.Padding(4);
            this.llbOS.Name = "llbOS";
            this.llbOS.Size = new System.Drawing.Size(388, 18);
            this.llbOS.TabIndex = 10;
            this.llbOS.TabStop = true;
            this.llbOS.Text = "https://github.com/godners/Multi-Timer";
            this.llbOS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbOS_LinkClicked);
            // 
            // ptbITIL
            // 
            this.ptbITIL.Image = global::Multi_Timer.Properties.Resources.imgITIL;
            this.ptbITIL.Location = new System.Drawing.Point(302, 121);
            this.ptbITIL.Margin = new System.Windows.Forms.Padding(4);
            this.ptbITIL.Name = "ptbITIL";
            this.ptbITIL.Size = new System.Drawing.Size(118, 40);
            this.ptbITIL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbITIL.TabIndex = 9;
            this.ptbITIL.TabStop = false;
            // 
            // ptbITSS
            // 
            this.ptbITSS.Image = global::Multi_Timer.Properties.Resources.imgITSS;
            this.ptbITSS.Location = new System.Drawing.Point(302, 169);
            this.ptbITSS.Margin = new System.Windows.Forms.Padding(4);
            this.ptbITSS.Name = "ptbITSS";
            this.ptbITSS.Size = new System.Drawing.Size(118, 45);
            this.ptbITSS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbITSS.TabIndex = 8;
            this.ptbITSS.TabStop = false;
            // 
            // ptbOCP
            // 
            this.ptbOCP.Image = global::Multi_Timer.Properties.Resources.imgOCP;
            this.ptbOCP.Location = new System.Drawing.Point(201, 121);
            this.ptbOCP.Margin = new System.Windows.Forms.Padding(4);
            this.ptbOCP.Name = "ptbOCP";
            this.ptbOCP.Size = new System.Drawing.Size(93, 93);
            this.ptbOCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbOCP.TabIndex = 7;
            this.ptbOCP.TabStop = false;
            // 
            // ptbVCP
            // 
            this.ptbVCP.Image = global::Multi_Timer.Properties.Resources.imgVCP;
            this.ptbVCP.Location = new System.Drawing.Point(100, 121);
            this.ptbVCP.Margin = new System.Windows.Forms.Padding(4);
            this.ptbVCP.Name = "ptbVCP";
            this.ptbVCP.Size = new System.Drawing.Size(93, 93);
            this.ptbVCP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbVCP.TabIndex = 6;
            this.ptbVCP.TabStop = false;
            // 
            // ptbRHCE
            // 
            this.ptbRHCE.Image = global::Multi_Timer.Properties.Resources.imgRHCE;
            this.ptbRHCE.Location = new System.Drawing.Point(13, 121);
            this.ptbRHCE.Margin = new System.Windows.Forms.Padding(4);
            this.ptbRHCE.Name = "ptbRHCE";
            this.ptbRHCE.Size = new System.Drawing.Size(79, 93);
            this.ptbRHCE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbRHCE.TabIndex = 5;
            this.ptbRHCE.TabStop = false;
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(13, 13);
            this.ptbPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(100, 100);
            this.ptbPhoto.TabIndex = 1;
            this.ptbPhoto.TabStop = false;
            // 
            // WinAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 253);
            this.Controls.Add(this.llbOS);
            this.Controls.Add(this.ptbITIL);
            this.Controls.Add(this.ptbITSS);
            this.Controls.Add(this.ptbOCP);
            this.Controls.Add(this.ptbVCP);
            this.Controls.Add(this.ptbRHCE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbPhoto);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAuthor";
            this.Text = "Author - Mulit Timer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WinAuthor_FormClosed);
            this.Load += new System.EventHandler(this.WinAuthor_Load);
            this.Shown += new System.EventHandler(this.WinAuthor_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WinAuthor_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ptbITIL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbITSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbOCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVCP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRHCE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbPhoto;
        private System.Windows.Forms.Timer tmrAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbRHCE;
        private System.Windows.Forms.PictureBox ptbVCP;
        private System.Windows.Forms.PictureBox ptbOCP;
        private System.Windows.Forms.PictureBox ptbITSS;
        private System.Windows.Forms.PictureBox ptbITIL;
        private System.Windows.Forms.LinkLabel llbOS;
    }
}