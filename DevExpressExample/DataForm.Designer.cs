
namespace DevExpressExample
{
    partial class DataForm
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
            this.LoadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ResetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.UpdateBtn = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchCoBox = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ClearBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.AmountCoBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.GradeCoBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.resetPathBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.setPointBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.yBox = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.xBox = new System.Windows.Forms.TextBox();
            this.LogoutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Appearance.Options.UseFont = true;
            this.LoadBtn.Location = new System.Drawing.Point(74, 23);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(112, 54);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "데이터 로드";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Appearance.Options.UseFont = true;
            this.ResetBtn.Location = new System.Drawing.Point(205, 23);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(116, 52);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "데이터 초기화";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 11);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1239, 736);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.UpdateBtn);
            this.xtraTabPage1.Controls.Add(this.DeleteBtn);
            this.xtraTabPage1.Controls.Add(this.SearchCoBox);
            this.xtraTabPage1.Controls.Add(this.SearchBtn);
            this.xtraTabPage1.Controls.Add(this.SearchBox);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.ResetBtn);
            this.xtraTabPage1.Controls.Add(this.LoadBtn);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1237, 704);
            this.xtraTabPage1.Text = "데이터 로드";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Appearance.Options.UseFont = true;
            this.UpdateBtn.Location = new System.Drawing.Point(1028, 25);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(120, 52);
            this.UpdateBtn.TabIndex = 8;
            this.UpdateBtn.Text = "데이터 수정";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Location = new System.Drawing.Point(889, 23);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(123, 52);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "데이터 삭제";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchCoBox
            // 
            this.SearchCoBox.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCoBox.FormattingEnabled = true;
            this.SearchCoBox.Location = new System.Drawing.Point(383, 649);
            this.SearchCoBox.Name = "SearchCoBox";
            this.SearchCoBox.Size = new System.Drawing.Size(113, 35);
            this.SearchCoBox.TabIndex = 6;
            this.SearchCoBox.SelectedIndexChanged += new System.EventHandler(this.SearchCoBox_SelectedIndexChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Location = new System.Drawing.Point(806, 640);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(113, 51);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(542, 649);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(227, 35);
            this.SearchBox.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(74, 96);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1097, 524);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.labelControl5);
            this.xtraTabPage2.Controls.Add(this.labelControl4);
            this.xtraTabPage2.Controls.Add(this.labelControl3);
            this.xtraTabPage2.Controls.Add(this.labelControl2);
            this.xtraTabPage2.Controls.Add(this.labelControl1);
            this.xtraTabPage2.Controls.Add(this.ClearBtn);
            this.xtraTabPage2.Controls.Add(this.SaveBtn);
            this.xtraTabPage2.Controls.Add(this.AmountCoBox);
            this.xtraTabPage2.Controls.Add(this.dateTimePicker1);
            this.xtraTabPage2.Controls.Add(this.GradeCoBox);
            this.xtraTabPage2.Controls.Add(this.NameBox);
            this.xtraTabPage2.Controls.Add(this.IdBox);
            this.xtraTabPage2.Controls.Add(this.label5);
            this.xtraTabPage2.Controls.Add(this.label4);
            this.xtraTabPage2.Controls.Add(this.label3);
            this.xtraTabPage2.Controls.Add(this.label2);
            this.xtraTabPage2.Controls.Add(this.label1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1237, 704);
            this.xtraTabPage2.Text = "데이터 추가";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(592, 477);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(0, 24);
            this.labelControl5.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(40959, 40959);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(0, 24);
            this.labelControl4.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(592, 332);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(0, 24);
            this.labelControl3.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(592, 252);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 24);
            this.labelControl2.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(592, 178);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 24);
            this.labelControl1.TabIndex = 12;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Appearance.Options.UseFont = true;
            this.ClearBtn.Location = new System.Drawing.Point(646, 600);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(127, 56);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "데이터 초기화";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Appearance.Options.UseFont = true;
            this.SaveBtn.Location = new System.Drawing.Point(471, 600);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(123, 56);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "데이터 저장";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AmountCoBox
            // 
            this.AmountCoBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountCoBox.FormattingEnabled = true;
            this.AmountCoBox.Location = new System.Drawing.Point(592, 435);
            this.AmountCoBox.Name = "AmountCoBox";
            this.AmountCoBox.Size = new System.Drawing.Size(117, 36);
            this.AmountCoBox.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(592, 372);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 26);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // GradeCoBox
            // 
            this.GradeCoBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GradeCoBox.FormattingEnabled = true;
            this.GradeCoBox.Location = new System.Drawing.Point(592, 290);
            this.GradeCoBox.Name = "GradeCoBox";
            this.GradeCoBox.Size = new System.Drawing.Size(117, 36);
            this.GradeCoBox.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(592, 206);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(210, 40);
            this.NameBox.TabIndex = 6;
            // 
            // IdBox
            // 
            this.IdBox.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdBox.Location = new System.Drawing.Point(592, 132);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(210, 40);
            this.IdBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "기부 금액 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "날짜 : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(477, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "학년 : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(477, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름 : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id :";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.resetPathBtn);
            this.xtraTabPage3.Controls.Add(this.pictureEdit1);
            this.xtraTabPage3.Controls.Add(this.setPointBtn);
            this.xtraTabPage3.Controls.Add(this.labelControl7);
            this.xtraTabPage3.Controls.Add(this.yBox);
            this.xtraTabPage3.Controls.Add(this.labelControl6);
            this.xtraTabPage3.Controls.Add(this.xBox);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1237, 704);
            this.xtraTabPage3.Text = "도형 움직이기";
            // 
            // resetPathBtn
            // 
            this.resetPathBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.resetPathBtn.Appearance.Options.UseFont = true;
            this.resetPathBtn.Location = new System.Drawing.Point(72, 597);
            this.resetPathBtn.Name = "resetPathBtn";
            this.resetPathBtn.Size = new System.Drawing.Size(126, 63);
            this.resetPathBtn.TabIndex = 6;
            this.resetPathBtn.Text = "경로 초기화";
            this.resetPathBtn.Click += new System.EventHandler(this.resetPathBtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(72, 63);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.NullText = " ";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(1089, 510);
            this.pictureEdit1.TabIndex = 5;
            // 
            // setPointBtn
            // 
            this.setPointBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.setPointBtn.Appearance.Options.UseFont = true;
            this.setPointBtn.Location = new System.Drawing.Point(1021, 603);
            this.setPointBtn.Name = "setPointBtn";
            this.setPointBtn.Size = new System.Drawing.Size(131, 63);
            this.setPointBtn.TabIndex = 4;
            this.setPointBtn.Text = "경로 지정";
            this.setPointBtn.Click += new System.EventHandler(this.setPointBtn_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(679, 621);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 30);
            this.labelControl7.TabIndex = 3;
            this.labelControl7.Text = "y좌표 :";
            // 
            // yBox
            // 
            this.yBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.yBox.Location = new System.Drawing.Point(759, 620);
            this.yBox.Name = "yBox";
            this.yBox.Size = new System.Drawing.Size(219, 36);
            this.yBox.TabIndex = 2;
            this.yBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yBox_KeyPress);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(307, 615);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 30);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "x좌표 :";
            // 
            // xBox
            // 
            this.xBox.Font = new System.Drawing.Font("Tahoma", 14F);
            this.xBox.Location = new System.Drawing.Point(393, 615);
            this.xBox.Name = "xBox";
            this.xBox.Size = new System.Drawing.Size(216, 36);
            this.xBox.TabIndex = 0;
            this.xBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xBox_KeyPress);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Appearance.Options.UseFont = true;
            this.LogoutBtn.Location = new System.Drawing.Point(68, 753);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(143, 34);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "로그아웃";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(329, 768);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 18);
            this.labelControl8.TabIndex = 7;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 797);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "DataForm";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage2.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton LoadBtn;
        private DevExpress.XtraEditors.SimpleButton ResetBtn;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.SimpleButton SearchBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.ComboBox SearchCoBox;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private System.Windows.Forms.ComboBox AmountCoBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox GradeCoBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton ClearBtn;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton UpdateBtn;
        private DevExpress.XtraEditors.SimpleButton LogoutBtn;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.SimpleButton setPointBtn;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.TextBox yBox;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox xBox;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton resetPathBtn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}