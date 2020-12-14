using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Ribbon;

namespace SIS.App
{
    partial class MainForm
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteDropDownButtonItem1 = new DevExpress.XtraBars.SkinPaletteDropDownButtonItem();
            this.img_main = new DevExpress.Utils.SvgImageCollection(this.components);
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ac_Menu = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.lblUsers = new DevExpress.XtraBars.BarStaticItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ac_Menu)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.barButtonItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem2);
            this.ribbonStatusBar.ItemLinks.Add(this.lblUsers);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 573);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1192, 24);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barButtonItem1.Caption = "Save Layout";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "Version";
            this.barStaticItem1.Enabled = false;
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.barStaticItem1.VisibleInSearchMenu = false;
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem2.Caption = "0.0.0.0";
            this.barStaticItem2.Id = 3;
            this.barStaticItem2.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.barStaticItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.AllowKeyTips = false;
            this.ribbonControl1.AllowMdiChildButtons = false;
            this.ribbonControl1.AllowMinimizeRibbon = false;
            this.ribbonControl1.AllowTrimPageText = false;
            this.ribbonControl1.AutoHideEmptyItems = true;
            this.ribbonControl1.CaptionBarItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonControl1.CaptionBarItemLinks.Add(this.skinPaletteDropDownButtonItem1);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.img_main;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinRibbonGalleryBarItem1,
            this.skinPaletteDropDownButtonItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barStaticItem1,
            this.barStaticItem2,
            this.barButtonItem1,
            this.lblUsers});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsPageCategories.ShowCaptions = false;
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1192, 32);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar;
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinPaletteDropDownButtonItem1
            // 
            this.skinPaletteDropDownButtonItem1.Id = 1;
            this.skinPaletteDropDownButtonItem1.Name = "skinPaletteDropDownButtonItem1";
            // 
            // img_main
            // 
            this.img_main.Add("icon_scale", "image://svgimages/outlook inspired/icon_scale.svg");
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.DockedAsTabbedDocument = true;
            this.dockPanel1.ID = new System.Guid("678ed2f2-d26c-42e8-8105-5b4d94881f90");
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.SavedIndex = 0;
            this.dockPanel1.SavedMdiDocument = true;
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 26);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(192, 171);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("090ecf84-183b-4a8e-ae5a-641c5b34d783");
            this.dockPanel2.Location = new System.Drawing.Point(0, 32);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.Size = new System.Drawing.Size(200, 541);
            this.dockPanel2.Text = "Menu";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.ac_Menu);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(193, 512);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // ac_Menu
            // 
            this.ac_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ac_Menu.Location = new System.Drawing.Point(0, 0);
            this.ac_Menu.Name = "ac_Menu";
            this.ac_Menu.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.ac_Menu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.ac_Menu.Size = new System.Drawing.Size(193, 512);
            this.ac_Menu.TabIndex = 0;
            this.ac_Menu.Text = "accordionControl1";
            // 
            // lblUsers
            // 
            this.lblUsers.Caption = "users";
            this.lblUsers.Id = 6;
            this.lblUsers.Name = "lblUsers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 597);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ac_Menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private RibbonControl ribbonControl1;
        private DocumentManager documentManager1;
        private DockPanel dockPanel2;
        private ControlContainer dockPanel2_Container;
        private AccordionControl ac_Menu;
        private TabbedView tabbedView1;
        private DockManager dockManager1;
        private DockPanel dockPanel1;
        private ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private DevExpress.XtraBars.SkinPaletteDropDownButtonItem skinPaletteDropDownButtonItem1;
        private DevExpress.Utils.SvgImageCollection img_main;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarStaticItem lblUsers;
    }
}