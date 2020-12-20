namespace SIS.App.Screens.GMP.Customer
{
    partial class CustomerList
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
            this.bbi_NewCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_EditCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_DeletedCustomer = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Refresh = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.img_sic = new DevExpress.Utils.SvgImageCollection(this.components);
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.gc_CustomerList = new DevExpress.XtraGrid.GridControl();
            this.gcv_CustomerList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bs_CustomerList = new System.Windows.Forms.BindingSource(this.components);
            this.colTCKimlikNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCinsiyeti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecordDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeslek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalistigiYer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKilo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsEvAdresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsİsAdresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvAdresIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvAdressIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdresIl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdresIlce = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEposta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCebinizeMesajGelsin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaAdress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaturaUnvan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiDairesi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVergiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbi_Arsiv = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_CustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CustomerList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
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
            this.bbi_NewCustomer,
            this.bbi_EditCustomer,
            this.bbi_DeletedCustomer,
            this.bbi_Refresh,
            this.barButtonItem5,
            this.barSubItem1,
            this.barButtonItem6,
            this.barButtonItem1,
            this.bbi_Arsiv});
            this.barManager1.MaxItemId = 9;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_NewCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_EditCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_DeletedCustomer),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Refresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbi_Arsiv)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // bbi_NewCustomer
            // 
            this.bbi_NewCustomer.Caption = "Yeni Müşteri";
            this.bbi_NewCustomer.Id = 0;
            this.bbi_NewCustomer.ImageOptions.ImageIndex = 0;
            this.bbi_NewCustomer.Name = "bbi_NewCustomer";
            this.bbi_NewCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_NewCustomer_ItemClick);
            // 
            // bbi_EditCustomer
            // 
            this.bbi_EditCustomer.Caption = "Düzenle";
            this.bbi_EditCustomer.Id = 1;
            this.bbi_EditCustomer.ImageOptions.ImageIndex = 5;
            this.bbi_EditCustomer.Name = "bbi_EditCustomer";
            this.bbi_EditCustomer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbi_EditCustomer_ItemClick);
            // 
            // bbi_DeletedCustomer
            // 
            this.bbi_DeletedCustomer.Caption = "Sil";
            this.bbi_DeletedCustomer.Id = 2;
            this.bbi_DeletedCustomer.ImageOptions.ImageIndex = 6;
            this.bbi_DeletedCustomer.Name = "bbi_DeletedCustomer";
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
            this.barDockControlTop.Size = new System.Drawing.Size(963, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 510);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 42);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 510);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 510);
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
            this.img_sic.Add("text", "image://svgimages/spreadsheet/text.svg");
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Export";
            this.barButtonItem5.Id = 4;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // gc_CustomerList
            // 
            this.gc_CustomerList.DataSource = this.bs_CustomerList;
            this.gc_CustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_CustomerList.Location = new System.Drawing.Point(0, 0);
            this.gc_CustomerList.MainView = this.gcv_CustomerList;
            this.gc_CustomerList.MenuManager = this.barManager1;
            this.gc_CustomerList.Name = "gc_CustomerList";
            this.gc_CustomerList.Size = new System.Drawing.Size(963, 510);
            this.gc_CustomerList.TabIndex = 4;
            this.gc_CustomerList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_CustomerList});
            // 
            // gcv_CustomerList
            // 
            this.gcv_CustomerList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTCKimlikNo,
            this.colAdSoyad,
            this.colDogumTarihi,
            this.colCinsiyeti,
            this.colRecordDate,
            this.colMeslek,
            this.colCalistigiYer,
            this.colKonu,
            this.colBoy,
            this.colKilo,
            this.colIsEvAdresi,
            this.colIsİsAdresi,
            this.colEvAdress,
            this.colEvAdresIlce,
            this.colEvAdressIl,
            this.colIsAdres,
            this.colIsAdresIl,
            this.colIsAdresIlce,
            this.colEvTel,
            this.colCepTel,
            this.colCepTel2,
            this.colIsTel,
            this.colEposta,
            this.colFax,
            this.colCebinizeMesajGelsin,
            this.colPhoto,
            this.colRemark,
            this.colFaturaAdress,
            this.colFaturaUnvan,
            this.colVergiDairesi,
            this.colVergiNo});
            this.gcv_CustomerList.GridControl = this.gc_CustomerList;
            this.gcv_CustomerList.Name = "gcv_CustomerList";
            this.gcv_CustomerList.OptionsView.ShowGroupPanel = false;
            this.gcv_CustomerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcv_CustomerList_MouseDown);
            this.gcv_CustomerList.DoubleClick += new System.EventHandler(this.gcv_CustomerList_DoubleClick);
            // 
            // bs_CustomerList
            // 
            this.bs_CustomerList.DataSource = typeof(SIS.Model.Models.GMP.Customer.CustomersDTO);
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
            // colDogumTarihi
            // 
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.Name = "colDogumTarihi";
            this.colDogumTarihi.Visible = true;
            this.colDogumTarihi.VisibleIndex = 2;
            // 
            // colCinsiyeti
            // 
            this.colCinsiyeti.FieldName = "Cinsiyeti";
            this.colCinsiyeti.Name = "colCinsiyeti";
            this.colCinsiyeti.Visible = true;
            this.colCinsiyeti.VisibleIndex = 3;
            // 
            // colRecordDate
            // 
            this.colRecordDate.FieldName = "RecordDate";
            this.colRecordDate.Name = "colRecordDate";
            this.colRecordDate.Visible = true;
            this.colRecordDate.VisibleIndex = 4;
            // 
            // colMeslek
            // 
            this.colMeslek.FieldName = "Meslek";
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.Visible = true;
            this.colMeslek.VisibleIndex = 5;
            // 
            // colCalistigiYer
            // 
            this.colCalistigiYer.FieldName = "CalistigiYer";
            this.colCalistigiYer.Name = "colCalistigiYer";
            this.colCalistigiYer.Visible = true;
            this.colCalistigiYer.VisibleIndex = 6;
            // 
            // colKonu
            // 
            this.colKonu.FieldName = "Konu";
            this.colKonu.Name = "colKonu";
            this.colKonu.Visible = true;
            this.colKonu.VisibleIndex = 7;
            // 
            // colBoy
            // 
            this.colBoy.FieldName = "Boy";
            this.colBoy.Name = "colBoy";
            this.colBoy.Visible = true;
            this.colBoy.VisibleIndex = 8;
            // 
            // colKilo
            // 
            this.colKilo.FieldName = "Kilo";
            this.colKilo.Name = "colKilo";
            this.colKilo.Visible = true;
            this.colKilo.VisibleIndex = 9;
            // 
            // colIsEvAdresi
            // 
            this.colIsEvAdresi.FieldName = "IsEvAdresi";
            this.colIsEvAdresi.Name = "colIsEvAdresi";
            this.colIsEvAdresi.Visible = true;
            this.colIsEvAdresi.VisibleIndex = 10;
            // 
            // colIsİsAdresi
            // 
            this.colIsİsAdresi.FieldName = "IsİsAdresi";
            this.colIsİsAdresi.Name = "colIsİsAdresi";
            this.colIsİsAdresi.Visible = true;
            this.colIsİsAdresi.VisibleIndex = 11;
            // 
            // colEvAdress
            // 
            this.colEvAdress.FieldName = "EvAdress";
            this.colEvAdress.Name = "colEvAdress";
            this.colEvAdress.Visible = true;
            this.colEvAdress.VisibleIndex = 12;
            // 
            // colEvAdresIlce
            // 
            this.colEvAdresIlce.FieldName = "EvAdresIlce";
            this.colEvAdresIlce.Name = "colEvAdresIlce";
            this.colEvAdresIlce.Visible = true;
            this.colEvAdresIlce.VisibleIndex = 13;
            // 
            // colEvAdressIl
            // 
            this.colEvAdressIl.FieldName = "EvAdressIl";
            this.colEvAdressIl.Name = "colEvAdressIl";
            this.colEvAdressIl.Visible = true;
            this.colEvAdressIl.VisibleIndex = 14;
            // 
            // colIsAdres
            // 
            this.colIsAdres.FieldName = "IsAdres";
            this.colIsAdres.Name = "colIsAdres";
            this.colIsAdres.Visible = true;
            this.colIsAdres.VisibleIndex = 15;
            // 
            // colIsAdresIl
            // 
            this.colIsAdresIl.FieldName = "IsAdresIl";
            this.colIsAdresIl.Name = "colIsAdresIl";
            this.colIsAdresIl.Visible = true;
            this.colIsAdresIl.VisibleIndex = 16;
            // 
            // colIsAdresIlce
            // 
            this.colIsAdresIlce.FieldName = "IsAdresIlce";
            this.colIsAdresIlce.Name = "colIsAdresIlce";
            this.colIsAdresIlce.Visible = true;
            this.colIsAdresIlce.VisibleIndex = 17;
            // 
            // colEvTel
            // 
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 18;
            // 
            // colCepTel
            // 
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 19;
            // 
            // colCepTel2
            // 
            this.colCepTel2.FieldName = "CepTel2";
            this.colCepTel2.Name = "colCepTel2";
            this.colCepTel2.Visible = true;
            this.colCepTel2.VisibleIndex = 20;
            // 
            // colIsTel
            // 
            this.colIsTel.FieldName = "IsTel";
            this.colIsTel.Name = "colIsTel";
            this.colIsTel.Visible = true;
            this.colIsTel.VisibleIndex = 21;
            // 
            // colEposta
            // 
            this.colEposta.FieldName = "Eposta";
            this.colEposta.Name = "colEposta";
            this.colEposta.Visible = true;
            this.colEposta.VisibleIndex = 22;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 23;
            // 
            // colCebinizeMesajGelsin
            // 
            this.colCebinizeMesajGelsin.FieldName = "CebinizeMesajGelsin";
            this.colCebinizeMesajGelsin.Name = "colCebinizeMesajGelsin";
            this.colCebinizeMesajGelsin.Visible = true;
            this.colCebinizeMesajGelsin.VisibleIndex = 24;
            // 
            // colPhoto
            // 
            this.colPhoto.FieldName = "Photo";
            this.colPhoto.Name = "colPhoto";
            this.colPhoto.Visible = true;
            this.colPhoto.VisibleIndex = 25;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 26;
            // 
            // colFaturaAdress
            // 
            this.colFaturaAdress.FieldName = "FaturaAdress";
            this.colFaturaAdress.Name = "colFaturaAdress";
            this.colFaturaAdress.Visible = true;
            this.colFaturaAdress.VisibleIndex = 27;
            // 
            // colFaturaUnvan
            // 
            this.colFaturaUnvan.FieldName = "FaturaUnvan";
            this.colFaturaUnvan.Name = "colFaturaUnvan";
            this.colFaturaUnvan.Visible = true;
            this.colFaturaUnvan.VisibleIndex = 28;
            // 
            // colVergiDairesi
            // 
            this.colVergiDairesi.FieldName = "VergiDairesi";
            this.colVergiDairesi.Name = "colVergiDairesi";
            this.colVergiDairesi.Visible = true;
            this.colVergiDairesi.VisibleIndex = 29;
            // 
            // colVergiNo
            // 
            this.colVergiNo.FieldName = "VergiNo";
            this.colVergiNo.Name = "colVergiNo";
            this.colVergiNo.Visible = true;
            this.colVergiNo.VisibleIndex = 30;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Arşive Kaldır";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.ImageIndex = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bbi_Arsiv
            // 
            this.bbi_Arsiv.Caption = "Arşiv";
            this.bbi_Arsiv.Id = 8;
            this.bbi_Arsiv.ImageOptions.ImageIndex = 7;
            this.bbi_Arsiv.Name = "bbi_Arsiv";
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 552);
            this.Controls.Add(this.gc_CustomerList);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CustomerList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteriler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerList_FormClosing);
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_sic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_CustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_CustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CustomerList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.SvgImageCollection img_sic;
        private DevExpress.XtraBars.BarButtonItem bbi_NewCustomer;
        private DevExpress.XtraBars.BarButtonItem bbi_EditCustomer;
        private DevExpress.XtraBars.BarButtonItem bbi_DeletedCustomer;
        private DevExpress.XtraBars.BarButtonItem bbi_Refresh;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraGrid.GridControl gc_CustomerList;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_CustomerList;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private System.Windows.Forms.BindingSource bs_CustomerList;
        private DevExpress.XtraGrid.Columns.GridColumn colTCKimlikNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colCinsiyeti;
        private DevExpress.XtraGrid.Columns.GridColumn colRecordDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMeslek;
        private DevExpress.XtraGrid.Columns.GridColumn colCalistigiYer;
        private DevExpress.XtraGrid.Columns.GridColumn colKonu;
        private DevExpress.XtraGrid.Columns.GridColumn colBoy;
        private DevExpress.XtraGrid.Columns.GridColumn colKilo;
        private DevExpress.XtraGrid.Columns.GridColumn colIsEvAdresi;
        private DevExpress.XtraGrid.Columns.GridColumn colIsİsAdresi;
        private DevExpress.XtraGrid.Columns.GridColumn colEvAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colEvAdresIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colEvAdressIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdres;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdresIl;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdresIlce;
        private DevExpress.XtraGrid.Columns.GridColumn colEvTel;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel2;
        private DevExpress.XtraGrid.Columns.GridColumn colIsTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEposta;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colCebinizeMesajGelsin;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoto;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaAdress;
        private DevExpress.XtraGrid.Columns.GridColumn colFaturaUnvan;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiDairesi;
        private DevExpress.XtraGrid.Columns.GridColumn colVergiNo;
        private DevExpress.XtraBars.BarButtonItem bbi_Arsiv;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
    }
}