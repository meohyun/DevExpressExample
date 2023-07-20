
namespace DevExpressExample
{
    partial class AGVInfo
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.freightListBox = new System.Windows.Forms.TextBox();
            this.agvNameBox = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.agvPosLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.stateLabel = new DevExpress.XtraEditors.LabelControl();
            this.releaseNumLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.releaseFreightBox = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.movingPathBox = new System.Windows.Forms.TextBox();
            this.moveTimeLabel = new DevExpress.XtraEditors.LabelControl();
            this.pauseBtn = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.moveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.spUpBtn = new DevExpress.XtraEditors.SimpleButton();
            this.spDownBtn = new DevExpress.XtraEditors.SimpleButton();
            this.agvSpeedLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.releaseFreightBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(599, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "보유한 화물";
            // 
            // freightListBox
            // 
            this.freightListBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.freightListBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.freightListBox.Location = new System.Drawing.Point(555, 101);
            this.freightListBox.Multiline = true;
            this.freightListBox.Name = "freightListBox";
            this.freightListBox.ReadOnly = true;
            this.freightListBox.Size = new System.Drawing.Size(167, 160);
            this.freightListBox.TabIndex = 5;
            // 
            // agvNameBox
            // 
            this.agvNameBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.agvNameBox.Location = new System.Drawing.Point(133, 101);
            this.agvNameBox.Name = "agvNameBox";
            this.agvNameBox.Size = new System.Drawing.Size(181, 27);
            this.agvNameBox.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(70, 101);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 23);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "이름 :";
            // 
            // agvPosLabel
            // 
            this.agvPosLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.agvPosLabel.Appearance.Options.UseFont = true;
            this.agvPosLabel.Location = new System.Drawing.Point(604, 540);
            this.agvPosLabel.Name = "agvPosLabel";
            this.agvPosLabel.Size = new System.Drawing.Size(118, 23);
            this.agvPosLabel.TabIndex = 11;
            this.agvPosLabel.Text = "X : 25   Y : 25";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(598, 287);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(91, 23);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "출고한 화물";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(37, 22);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(81, 23);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "운행시간 :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(234, 22);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 23);
            this.labelControl9.TabIndex = 18;
            this.labelControl9.Text = "상태 :";
            // 
            // stateLabel
            // 
            this.stateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Appearance.Options.UseFont = true;
            this.stateLabel.Location = new System.Drawing.Point(296, 22);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(91, 23);
            this.stateLabel.TabIndex = 19;
            this.stateLabel.Text = "입고지 정차";
            // 
            // releaseNumLabel
            // 
            this.releaseNumLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.releaseNumLabel.Appearance.Options.UseFont = true;
            this.releaseNumLabel.Location = new System.Drawing.Point(705, 482);
            this.releaseNumLabel.Name = "releaseNumLabel";
            this.releaseNumLabel.Size = new System.Drawing.Size(10, 23);
            this.releaseNumLabel.TabIndex = 21;
            this.releaseNumLabel.Text = "0";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(609, 482);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 23);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "출고횟수 :";
            // 
            // releaseFreightBox
            // 
            this.releaseFreightBox.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.releaseFreightBox.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.releaseFreightBox.Appearance.Options.UseBackColor = true;
            this.releaseFreightBox.Appearance.Options.UseFont = true;
            this.releaseFreightBox.HorizontalScrollbar = true;
            this.releaseFreightBox.Location = new System.Drawing.Point(555, 316);
            this.releaseFreightBox.Name = "releaseFreightBox";
            this.releaseFreightBox.Size = new System.Drawing.Size(167, 160);
            this.releaseFreightBox.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(407, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 23);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = "이동 경로";
            // 
            // movingPathBox
            // 
            this.movingPathBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.movingPathBox.Font = new System.Drawing.Font("Tahoma", 12F);
            this.movingPathBox.Location = new System.Drawing.Point(352, 101);
            this.movingPathBox.Multiline = true;
            this.movingPathBox.Name = "movingPathBox";
            this.movingPathBox.ReadOnly = true;
            this.movingPathBox.Size = new System.Drawing.Size(178, 160);
            this.movingPathBox.TabIndex = 24;
            // 
            // moveTimeLabel
            // 
            this.moveTimeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 16F);
            this.moveTimeLabel.Appearance.Options.UseFont = true;
            this.moveTimeLabel.Location = new System.Drawing.Point(133, 22);
            this.moveTimeLabel.Name = "moveTimeLabel";
            this.moveTimeLabel.Size = new System.Drawing.Size(51, 25);
            this.moveTimeLabel.TabIndex = 17;
            this.moveTimeLabel.Text = "00:00";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Appearance.ForeColor = System.Drawing.Color.Red;
            this.pauseBtn.Appearance.Options.UseFont = true;
            this.pauseBtn.Appearance.Options.UseForeColor = true;
            this.pauseBtn.Location = new System.Drawing.Point(528, 14);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(94, 41);
            this.pauseBtn.TabIndex = 25;
            this.pauseBtn.Text = "중지";
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // moveBtn
            // 
            this.moveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveBtn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.moveBtn.Appearance.Options.UseFont = true;
            this.moveBtn.Appearance.Options.UseForeColor = true;
            this.moveBtn.Location = new System.Drawing.Point(628, 14);
            this.moveBtn.Name = "moveBtn";
            this.moveBtn.Size = new System.Drawing.Size(94, 41);
            this.moveBtn.TabIndex = 26;
            this.moveBtn.Text = "이동";
            this.moveBtn.Click += new System.EventHandler(this.moveBtn_Click);
            // 
            // spUpBtn
            // 
            this.spUpBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spUpBtn.Appearance.ForeColor = System.Drawing.SystemColors.Highlight;
            this.spUpBtn.Appearance.Options.UseFont = true;
            this.spUpBtn.Appearance.Options.UseForeColor = true;
            this.spUpBtn.Location = new System.Drawing.Point(108, 199);
            this.spUpBtn.Name = "spUpBtn";
            this.spUpBtn.Size = new System.Drawing.Size(71, 28);
            this.spUpBtn.TabIndex = 27;
            this.spUpBtn.Text = "증가 ▲";
            this.spUpBtn.Click += new System.EventHandler(this.spUpBtn_Click);
            // 
            // spDownBtn
            // 
            this.spDownBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.spDownBtn.Appearance.ForeColor = System.Drawing.Color.LightCoral;
            this.spDownBtn.Appearance.Options.UseFont = true;
            this.spDownBtn.Appearance.Options.UseForeColor = true;
            this.spDownBtn.Location = new System.Drawing.Point(185, 199);
            this.spDownBtn.Name = "spDownBtn";
            this.spDownBtn.Size = new System.Drawing.Size(71, 28);
            this.spDownBtn.TabIndex = 28;
            this.spDownBtn.Text = "감소 ▼";
            this.spDownBtn.Click += new System.EventHandler(this.spDownBtn_Click);
            // 
            // agvSpeedLabel
            // 
            this.agvSpeedLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agvSpeedLabel.Appearance.Options.UseFont = true;
            this.agvSpeedLabel.Location = new System.Drawing.Point(133, 164);
            this.agvSpeedLabel.Name = "agvSpeedLabel";
            this.agvSpeedLabel.Size = new System.Drawing.Size(20, 23);
            this.agvSpeedLabel.TabIndex = 30;
            this.agvSpeedLabel.Text = "10";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(36, 164);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 23);
            this.labelControl5.TabIndex = 29;
            this.labelControl5.Text = "현재속도 :";
            // 
            // AGVInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 585);
            this.Controls.Add(this.agvSpeedLabel);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.spDownBtn);
            this.Controls.Add(this.spUpBtn);
            this.Controls.Add(this.moveBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.movingPathBox);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.releaseFreightBox);
            this.Controls.Add(this.releaseNumLabel);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.moveTimeLabel);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.agvPosLabel);
            this.Controls.Add(this.agvNameBox);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.freightListBox);
            this.Controls.Add(this.labelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AGVInfo";
            this.Text = "AGVData";
            this.Load += new System.EventHandler(this.AGVData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.releaseFreightBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.LabelControl agvPosLabel;
        public DevExpress.XtraEditors.LabelControl stateLabel;
        public DevExpress.XtraEditors.LabelControl releaseNumLabel;
        public System.Windows.Forms.TextBox freightListBox;
        public DevExpress.XtraEditors.ListBoxControl releaseFreightBox;
        public System.Windows.Forms.TextBox movingPathBox;
        public DevExpress.XtraEditors.LabelControl moveTimeLabel;
        public System.Windows.Forms.TextBox agvNameBox;
        public System.Windows.Forms.Timer timer1;
        public DevExpress.XtraEditors.SimpleButton pauseBtn;
        public DevExpress.XtraEditors.SimpleButton moveBtn;
        public DevExpress.XtraEditors.SimpleButton spUpBtn;
        public DevExpress.XtraEditors.SimpleButton spDownBtn;
        public DevExpress.XtraEditors.LabelControl agvSpeedLabel;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}