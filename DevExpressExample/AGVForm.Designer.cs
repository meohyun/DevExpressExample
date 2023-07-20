
namespace DevExpressExample
{
    partial class AGVForm
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
            this.LoadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ResetBtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.DeleteBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchCoBox = new System.Windows.Forms.ComboBox();
            this.SearchBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.ResetPathBtn = new DevExpress.XtraEditors.SimpleButton();
            this.ReleasePathBtn = new DevExpress.XtraEditors.SimpleButton();
            this.RackUnLoadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.RackLoadBtn = new DevExpress.XtraEditors.SimpleButton();
            this.startBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.rackNumTxt = new System.Windows.Forms.TextBox();
            this.LogListBox = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.ReceivePathBtn = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.LogoutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogListBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.Appearance.Options.UseFont = true;
            this.LoadBtn.Location = new System.Drawing.Point(52, 14);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(107, 42);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "데이터 로드";
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Appearance.Options.UseFont = true;
            this.ResetBtn.Location = new System.Drawing.Point(175, 14);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(107, 42);
            this.ResetBtn.TabIndex = 2;
            this.ResetBtn.Text = "데이터 초기화";
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.xtraTabControl1.Location = new System.Drawing.Point(10, 9);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1135, 691);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.DeleteBtn);
            this.xtraTabPage1.Controls.Add(this.SearchCoBox);
            this.xtraTabPage1.Controls.Add(this.SearchBtn);
            this.xtraTabPage1.Controls.Add(this.SearchBox);
            this.xtraTabPage1.Controls.Add(this.gridControl1);
            this.xtraTabPage1.Controls.Add(this.ResetBtn);
            this.xtraTabPage1.Controls.Add(this.LoadBtn);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1133, 665);
            this.xtraTabPage1.Text = "데이터 로드";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Appearance.Options.UseFont = true;
            this.DeleteBtn.Location = new System.Drawing.Point(1005, 14);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(101, 42);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "데이터 삭제";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SearchCoBox
            // 
            this.SearchCoBox.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchCoBox.FormattingEnabled = true;
            this.SearchCoBox.Location = new System.Drawing.Point(343, 602);
            this.SearchCoBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchCoBox.Name = "SearchCoBox";
            this.SearchCoBox.Size = new System.Drawing.Size(79, 30);
            this.SearchCoBox.TabIndex = 6;
            this.SearchCoBox.SelectedIndexChanged += new System.EventHandler(this.SearchCoBox_SelectedIndexChanged);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Appearance.Options.UseFont = true;
            this.SearchBtn.Location = new System.Drawing.Point(697, 600);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(79, 32);
            this.SearchBtn.TabIndex = 5;
            this.SearchBtn.Text = "검색";
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(444, 602);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(228, 30);
            this.SearchBox.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Location = new System.Drawing.Point(52, 60);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1054, 532);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 272;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.ResetPathBtn);
            this.xtraTabPage3.Controls.Add(this.ReleasePathBtn);
            this.xtraTabPage3.Controls.Add(this.RackUnLoadBtn);
            this.xtraTabPage3.Controls.Add(this.RackLoadBtn);
            this.xtraTabPage3.Controls.Add(this.startBtn);
            this.xtraTabPage3.Controls.Add(this.labelControl9);
            this.xtraTabPage3.Controls.Add(this.rackNumTxt);
            this.xtraTabPage3.Controls.Add(this.LogListBox);
            this.xtraTabPage3.Controls.Add(this.labelControl8);
            this.xtraTabPage3.Controls.Add(this.ReceivePathBtn);
            this.xtraTabPage3.Controls.Add(this.pictureEdit1);
            this.xtraTabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1133, 665);
            this.xtraTabPage3.Text = "경로 이동";
            this.xtraTabPage3.Paint += new System.Windows.Forms.PaintEventHandler(this.XtraTabPage3_Paint);
            // 
            // ResetPathBtn
            // 
            this.ResetPathBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ResetPathBtn.Appearance.Options.UseFont = true;
            this.ResetPathBtn.Location = new System.Drawing.Point(979, 14);
            this.ResetPathBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResetPathBtn.Name = "ResetPathBtn";
            this.ResetPathBtn.Size = new System.Drawing.Size(103, 46);
            this.ResetPathBtn.TabIndex = 16;
            this.ResetPathBtn.Text = "초기화";
            this.ResetPathBtn.Click += new System.EventHandler(this.ResetPathBtn_Click);
            // 
            // ReleasePathBtn
            // 
            this.ReleasePathBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ReleasePathBtn.Appearance.Options.UseFont = true;
            this.ReleasePathBtn.Location = new System.Drawing.Point(856, 14);
            this.ReleasePathBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReleasePathBtn.Name = "ReleasePathBtn";
            this.ReleasePathBtn.Size = new System.Drawing.Size(103, 46);
            this.ReleasePathBtn.TabIndex = 15;
            this.ReleasePathBtn.Text = "출고점 이동";
            this.ReleasePathBtn.Click += new System.EventHandler(this.ReleasePathBtn_Click);
            // 
            // RackUnLoadBtn
            // 
            this.RackUnLoadBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.RackUnLoadBtn.Appearance.Options.UseFont = true;
            this.RackUnLoadBtn.Location = new System.Drawing.Point(563, 14);
            this.RackUnLoadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RackUnLoadBtn.Name = "RackUnLoadBtn";
            this.RackUnLoadBtn.Size = new System.Drawing.Size(103, 46);
            this.RackUnLoadBtn.TabIndex = 14;
            this.RackUnLoadBtn.Text = "UnLoad";
            this.RackUnLoadBtn.Click += new System.EventHandler(this.RackUnloadBtn_Click);
            // 
            // RackLoadBtn
            // 
            this.RackLoadBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.RackLoadBtn.Appearance.Options.UseFont = true;
            this.RackLoadBtn.Location = new System.Drawing.Point(449, 14);
            this.RackLoadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RackLoadBtn.Name = "RackLoadBtn";
            this.RackLoadBtn.Size = new System.Drawing.Size(92, 46);
            this.RackLoadBtn.TabIndex = 13;
            this.RackLoadBtn.Text = "Load";
            this.RackLoadBtn.Click += new System.EventHandler(this.RackLoadBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.startBtn.Appearance.Options.UseFont = true;
            this.startBtn.Location = new System.Drawing.Point(338, 14);
            this.startBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(92, 46);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "출발";
            this.startBtn.Click += new System.EventHandler(this.SetRackPathBtn_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(49, 26);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(73, 24);
            this.labelControl9.TabIndex = 11;
            this.labelControl9.Text = "랙 번호 : ";
            // 
            // rackNumTxt
            // 
            this.rackNumTxt.Font = new System.Drawing.Font("Tahoma", 14F);
            this.rackNumTxt.Location = new System.Drawing.Point(144, 24);
            this.rackNumTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rackNumTxt.Name = "rackNumTxt";
            this.rackNumTxt.Size = new System.Drawing.Size(168, 30);
            this.rackNumTxt.TabIndex = 10;
            this.rackNumTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RackNumTxt_KeyPress);
            // 
            // LogListBox
            // 
            this.LogListBox.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogListBox.Appearance.Options.UseFont = true;
            this.LogListBox.HorizontalScrollbar = true;
            this.LogListBox.Location = new System.Drawing.Point(49, 520);
            this.LogListBox.Name = "LogListBox";
            this.LogListBox.Size = new System.Drawing.Size(1033, 133);
            this.LogListBox.TabIndex = 8;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(450, 933);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(0, 14);
            this.labelControl8.TabIndex = 7;
            // 
            // ReceivePathBtn
            // 
            this.ReceivePathBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.ReceivePathBtn.Appearance.Options.UseFont = true;
            this.ReceivePathBtn.Location = new System.Drawing.Point(732, 14);
            this.ReceivePathBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReceivePathBtn.Name = "ReceivePathBtn";
            this.ReceivePathBtn.Size = new System.Drawing.Size(103, 46);
            this.ReceivePathBtn.TabIndex = 6;
            this.ReceivePathBtn.Text = "입고점 이동";
            this.ReceivePathBtn.Click += new System.EventHandler(this.ReceivePathBtn_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureEdit1.Location = new System.Drawing.Point(49, 71);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.UseDisabledStatePainter = false;
            this.pictureEdit1.Size = new System.Drawing.Size(1033, 444);
            this.pictureEdit1.TabIndex = 5;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutBtn.Appearance.Options.UseFont = true;
            this.LogoutBtn.Location = new System.Drawing.Point(1020, 704);
            this.LogoutBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(125, 26);
            this.LogoutBtn.TabIndex = 4;
            this.LogoutBtn.Text = "로그아웃";
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 201;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1163, 741);
            this.Controls.Add(this.LogoutBtn);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DataForm";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogListBox)).EndInit();
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
        private System.Windows.Forms.ComboBox SearchCoBox;
        private DevExpress.XtraEditors.SimpleButton DeleteBtn;
        private DevExpress.XtraEditors.SimpleButton LogoutBtn;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton ReceivePathBtn;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ListBoxControl LogListBox;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox rackNumTxt;
        private DevExpress.XtraEditors.SimpleButton startBtn;
        private DevExpress.XtraEditors.SimpleButton RackLoadBtn;
        private DevExpress.XtraEditors.SimpleButton RackUnLoadBtn;
        private DevExpress.XtraEditors.SimpleButton ReleasePathBtn;
        private DevExpress.XtraEditors.SimpleButton ResetPathBtn;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Timer timer2;
    }
}