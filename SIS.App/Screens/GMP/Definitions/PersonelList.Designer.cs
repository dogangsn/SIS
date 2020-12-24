namespace SIS.App.Screens.GMP.Definitions
{
    partial class PersonelList
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bbi_New = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Edit = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.gc_PersonelList = new DevExpress.XtraGrid.GridControl();
            this.gcv_PersonelList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bs_Personels = new System.Windows.Forms.BindingSource(this.components);
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGörevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PersonelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_PersonelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Personels)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.img_sic;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbi_New,
            this.bbi_Edit,
            this.bbi_Delete,
            this.bbi_Refresh,
            this.barButtonItem5,
            this.barSubItem1,
            this.barButtonItem6});
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_New),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Edit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Delete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_New
            // 
            this.bbi_New.Caption = "Yeni Müşteri";
            this.bbi_New.Id = 0;
            this.bbi_New.ImageOptions.ImageIndex = 0;
            this.bbi_New.Name = "bbi_New";
            this.bbi_New.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_New_ItemClick);
            // 
            // bbi_Edit
            // 
            this.bbi_Edit.Caption = "Düzenle";
            this.bbi_Edit.Id = 1;
            this.bbi_Edit.ImageOptions.ImageIndex = 5;
            this.bbi_Edit.Name = "bbi_Edit";
            this.bbi_Edit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Edit_ItemClick);
            // 
            // bbi_Delete
            // 
            this.bbi_Delete.Caption = "Sil";
            this.bbi_Delete.Id = 2;
            this.bbi_Delete.ImageOptions.ImageIndex = 6;
            this.bbi_Delete.Name = "bbi_Delete";
            this.bbi_Delete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Delete_ItemClick);
            // 
            // bbi_Refresh
            // 
            this.bbi_Refresh.Caption = "Yenile";
            this.bbi_Refresh.Id = 3;
            this.bbi_Refresh.ImageOptions.ImageIndex = 2;
            this.bbi_Refresh.Name = "bbi_Refresh";
            this.bbi_Refresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_Refresh_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Export";
            this.barSubItem1.Id = 5;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Yazdır";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.ImageIndex = 1;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(896, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 505);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(896, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 505);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(896, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 505);
            // 
            // img_sic
            // 
            this.img_sic.ImageSize = new System.Drawing.Size(32, 32);
            this.img_sic.Add("newemployee", "image://svgimages/outlook inspired/newemployee.svg");
            this.img_sic.Add("print", "image://svgimages/dashboards/print.svg");
            this.img_sic.Add("changeview", "image://svgimages/outlook inspired/changeview.svg");
            this.img_sic.Add("delete", "image://svgimages/outlook inspired/delete.svg");
            this.img_sic.Add("preview", "image://svgimages/print/preview.svg");
            this.img_sic.Add("edit", "image://svgimages/dashboards/edit.svg");
            this.img_sic.Add("deletetablerows", "image://svgimages/richedit/deletetablerows.svg");
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Export";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // gc_PersonelList
            // 
            this.gc_PersonelList.DataSource = this.bs_Personels;
            this.gc_PersonelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_PersonelList.Location = new System.Drawing.Point(0, 0);
            this.gc_PersonelList.MainView = this.gcv_PersonelList;
            this.gc_PersonelList.MenuManager = this.barManager1;
            this.gc_PersonelList.Name = "gc_PersonelList";
            this.gc_PersonelList.Size = new System.Drawing.Size(896, 505);
            this.gc_PersonelList.TabIndex = 4;
            this.gc_PersonelList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_PersonelList});
            // 
            // gcv_PersonelList
            // 
            this.gcv_PersonelList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdSoyad,
            this.colTCKimlikNo,
            this.colGörevi,
            this.colDogumTarihi,
            this.colEposta,
            this.colCepTel});
            this.gcv_PersonelList.GridControl = this.gc_PersonelList;
            this.gcv_PersonelList.Name = "gcv_PersonelList";
            this.gcv_PersonelList.OptionsView.ColumnAutoWidth = false;
            this.gcv_PersonelList.OptionsView.ShowAutoFilterRow = true;
            this.gcv_PersonelList.OptionsView.ShowGroupPanel = false;
            // 
            // bs_Personels
            // 
            this.bs_Personels.DataSource = typeof(SIS.Model.Models.GMP.Definitions.PersonelsDTO);
            // 
            // colTCKimlikNo
            // 
            this.colTCKimlikNo.FieldName = "TCKimlikNo";
            this.colTCKimlikNo.Name = "colTCKimlikNo";
            this.colTCKimlikNo.Visible = true;
            this.colTCKimlikNo.VisibleIndex = 0;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 1;
            // 
            // colGörevi
            // 
            this.colGörevi.FieldName = "Görevi";
            this.colGörevi.Name = "colGörevi";
            this.colGörevi.Visible = true;
            this.colGörevi.VisibleIndex = 2;
            // 
            // colDogumTarihi
            // 
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.Name = "colDogumTarihi";
            this.colDogumTarihi.Visible = true;
            this.colDogumTarihi.VisibleIndex = 3;
            // 
            // colEposta
            // 
            this.colEposta.FieldName = "Eposta";
            this.colEposta.Name = "colEposta";
            this.colEposta.Visible = true;
            this.colEposta.VisibleIndex = 4;
            // 
            // colCepTel
            // 
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 5;
            // 
            // PersonelList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 547);
            this.Controls.Add(this.gc_PersonelList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PersonelList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Listesi";
            this.Load += new System.EventHandler(this.PersonelList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_PersonelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_PersonelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Personels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem bbi_New;
        private DevExpress.XtraBars.BarButtonItem bbi_Edit;
        private DevExpress.XtraBars.BarButtonItem bbi_Delete;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraGrid.GridControl gc_PersonelList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_PersonelList;
        private System.Windows.Forms.BindingSource bs_Personels;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colGörevi;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colEposta;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel;
    }
}