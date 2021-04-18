namespace SIS.Client.Admin
{
    partial class login
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lc_Company = new DevExpress.XtraEditors.LookUpEdit();
            this.lc_serverList = new DevExpress.XtraEditors.LookUpEdit();
            this.bs_ServerList = new System.Windows.Forms.BindingSource(this.components);
            this.lc_Application = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_userCode = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            this.checkEdit11 = new DevExpress.XtraEditors.CheckEdit();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.img_bar = new DevExpress.Utils.SvgImageCollection(this.components);
            this.btn_Close = new DevExpress.XtraEditors.SimpleButton();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bs_Company = new System.Windows.Forms.BindingSource(this.components);
            this.bs_AppIdView = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_serverList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ServerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Application.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit11.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Company)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AppIdView)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lc_Company);
            this.layoutControl1.Controls.Add(this.lc_serverList);
            this.layoutControl1.Controls.Add(this.lc_Application);
            this.layoutControl1.Controls.Add(this.pictureEdit1);
            this.layoutControl1.Controls.Add(this.txt_userCode);
            this.layoutControl1.Controls.Add(this.txt_Password);
            this.layoutControl1.Controls.Add(this.checkEdit11);
            this.layoutControl1.Controls.Add(this.btn_login);
            this.layoutControl1.Controls.Add(this.btn_Close);
            this.layoutControl1.Controls.Add(this.checkEdit1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Images = this.img_bar;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(571, 8, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(283, 439);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lc_Company
            // 
            this.lc_Company.Location = new System.Drawing.Point(91, 187);
            this.lc_Company.Name = "lc_Company";
            this.lc_Company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_Company.Properties.NullText = "";
            this.lc_Company.Size = new System.Drawing.Size(180, 20);
            this.lc_Company.StyleController = this.layoutControl1;
            this.lc_Company.TabIndex = 12;
            // 
            // lc_serverList
            // 
            this.lc_serverList.Location = new System.Drawing.Point(103, 342);
            this.lc_serverList.Name = "lc_serverList";
            this.lc_serverList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_serverList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Server", "Server"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ServerName", "Server Adı")});
            this.lc_serverList.Properties.DataSource = this.bs_ServerList;
            this.lc_serverList.Properties.DisplayMember = "ServerName";
            this.lc_serverList.Properties.NullText = "";
            this.lc_serverList.Properties.ValueMember = "Id";
            this.lc_serverList.Size = new System.Drawing.Size(156, 20);
            this.lc_serverList.StyleController = this.layoutControl1;
            this.lc_serverList.TabIndex = 10;
            // 
            // bs_ServerList
            // 
            this.bs_ServerList.DataSource = typeof(SIS.Models.Models.App.ApplicationServerDTO);
            // 
            // lc_Application
            // 
            this.lc_Application.Location = new System.Drawing.Point(91, 115);
            this.lc_Application.Name = "lc_Application";
            this.lc_Application.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lc_Application.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("App", "Program")});
            this.lc_Application.Properties.DataSource = this.bs_AppIdView;
            this.lc_Application.Properties.DisplayMember = "App";
            this.lc_Application.Properties.NullText = "";
            this.lc_Application.Properties.ValueMember = "Id";
            this.lc_Application.Size = new System.Drawing.Size(180, 20);
            this.lc_Application.StyleController = this.layoutControl1;
            this.lc_Application.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(12, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(258, 99);
            this.pictureEdit1.StyleController = this.layoutControl1;
            this.pictureEdit1.TabIndex = 4;
            // 
            // txt_userCode
            // 
            this.txt_userCode.EditValue = "";
            this.txt_userCode.Location = new System.Drawing.Point(91, 139);
            this.txt_userCode.Name = "txt_userCode";
            this.txt_userCode.Size = new System.Drawing.Size(180, 20);
            this.txt_userCode.StyleController = this.layoutControl1;
            this.txt_userCode.TabIndex = 4;
            // 
            // txt_Password
            // 
            this.txt_Password.EditValue = "";
            this.txt_Password.Location = new System.Drawing.Point(91, 163);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(180, 20);
            this.txt_Password.StyleController = this.layoutControl1;
            this.txt_Password.TabIndex = 5;
            // 
            // checkEdit11
            // 
            this.checkEdit11.Location = new System.Drawing.Point(12, 211);
            this.checkEdit11.Name = "checkEdit11";
            this.checkEdit11.Properties.Caption = "Beni Hatırla";
            this.checkEdit11.Size = new System.Drawing.Size(259, 20);
            this.checkEdit11.StyleController = this.layoutControl1;
            this.checkEdit11.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.ImageOptions.ImageIndex = 1;
            this.btn_login.ImageOptions.ImageList = this.img_bar;
            this.btn_login.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btn_login.Location = new System.Drawing.Point(90, 378);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(181, 49);
            this.btn_login.StyleController = this.layoutControl1;
            this.btn_login.TabIndex = 7;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // img_bar
            // 
            this.img_bar.Add("bo_user", "image://svgimages/business objects/bo_user.svg");
            this.img_bar.Add("checkbox", "image://svgimages/content/checkbox.svg");
            this.img_bar.Add("close", "image://svgimages/outlook inspired/close.svg");
            this.img_bar.Add("private", "image://svgimages/scheduling/private.svg");
            this.img_bar.Add("encrypt", "image://svgimages/spreadsheet/encrypt.svg");
            this.img_bar.Add("bo_employee", "image://svgimages/business objects/bo_employee.svg");
            this.img_bar.Add("bo_localization", "image://svgimages/business objects/bo_localization.svg");
            this.img_bar.Add("timezones", "image://svgimages/scheduling/timezones.svg");
            this.img_bar.Add("clearheaderandfooter", "image://svgimages/richedit/clearheaderandfooter.svg");
            this.img_bar.Add("bo_category", "image://svgimages/business objects/bo_category.svg");
            this.img_bar.Add("bo_country_v92", "image://svgimages/business objects/bo_country_v92.svg");
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.ImageOptions.ImageIndex = 8;
            this.btn_Close.ImageOptions.ImageList = this.img_bar;
            this.btn_Close.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btn_Close.Location = new System.Drawing.Point(12, 378);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(74, 49);
            this.btn_Close.StyleController = this.layoutControl1;
            this.btn_Close.TabIndex = 8;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(12, 235);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Şifre Değiştir";
            this.checkEdit1.Size = new System.Drawing.Size(259, 20);
            this.checkEdit1.StyleController = this.layoutControl1;
            this.checkEdit1.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem5,
            this.layoutControlGroup1,
            this.layoutControlItem9,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(283, 439);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_userCode;
            this.layoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem2.ImageOptions.ImageIndex = 5;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 127);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem2.Text = "Kullanıcı Adı";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(76, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_Password;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.ImageOptions.ImageIndex = 4;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem3.Text = "Parola";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(76, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.checkEdit11;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem4.Text = "layoutControlItem3";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.pictureEdit1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(262, 103);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(262, 103);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(263, 103);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_Close;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 366);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(78, 53);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(78, 53);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(78, 53);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lc_Application;
            this.layoutControlItem7.ImageOptions.ImageIndex = 9;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem7.Text = "Program";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(76, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 247);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(263, 50);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_login;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem5.Location = new System.Drawing.Point(78, 366);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(185, 53);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(185, 53);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(185, 53);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "layoutControlItem4";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 297);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(263, 69);
            this.layoutControlGroup1.Text = "Bağlantı Bilgileri";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.lc_serverList;
            this.layoutControlItem8.ImageOptions.ImageIndex = 7;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(239, 24);
            this.layoutControlItem8.Text = "Server";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(76, 16);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.checkEdit1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 223);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.lc_Company;
            this.layoutControlItem10.ImageOptions.ImageIndex = 10;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 175);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(263, 24);
            this.layoutControlItem10.Text = "İşyeri";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(76, 16);
            // 
            // bs_AppIdView
            // 
            this.bs_AppIdView.DataSource = typeof(SIS.Data.App.AppIdView);
            // 
            // login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(283, 439);
            this.ControlBox = false;
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lc_Company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_serverList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ServerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lc_Application.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_userCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit11.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Company)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_AppIdView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txt_userCode;
        private DevExpress.XtraEditors.TextEdit txt_Password;
        private DevExpress.XtraEditors.CheckEdit checkEdit11;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.Utils.SvgImageCollection img_bar;
        private DevExpress.XtraEditors.LookUpEdit lc_Application;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private System.Windows.Forms.BindingSource bs_AppIdView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit lc_serverList;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btn_Close;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.LookUpEdit lc_Company;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private System.Windows.Forms.BindingSource bs_ServerList;
        private System.Windows.Forms.BindingSource bs_Company;
    }
}