using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.LookAndFeel;
using System.Configuration;
using SIS.Data;
using SIS.Client.Admin;

namespace SIS.App
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }


        private void do_login()
        {
            set_AppSettings();

            login loForm = new login();
            loForm.TopMost = true;
            loForm.ShowDialog();
            if (AppMain.User != null)
            {
                //do_versionControl();
                //do_barDoldur();
                UserLookAndFeel.Default.SetSkinStyle(AppMain.User.DefaultTheme, AppMain.User.DefaultTheme2);
                switch (AppMain.AppId)
                {
                    case 1:
                        set_Menu();
                        break;
                    case 2:
                        set_Menu_GMP();
                        break;
                }
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            }
            else
            {
                Application.ExitThread();
            }

        }


        #region AccordionControl

        private void set_Menu()
        {
            ac_Menu.Elements.Clear();
            //set_AccordionControl_Menus(ac_Menu, bl.blmenu.get_List_Menus());
        }

        private void set_Menu_GMP()
        {
            ac_Menu.Elements.Clear();
            //set_AccordionControl_Menus(ac_Menu, bl.blmenu.get_List_Menus_GMP());
        }

        private AccordionControlElement get_add_AccordionControlElement(string _Text, bool _Group)
        {
            AccordionControlElement _ace;
            if (_Group)
            {
                //_ace = new AccordionControlElement() { Text = bl.language.get_Menu_Word_Control(_Text, AppMain.AppValue.Language), Style = ElementStyle.Group };
                _ace = new AccordionControlElement() { Text = _Text, Style = ElementStyle.Group };
            }
            else
            {
                //_ace = new AccordionControlElement() { Text = bl.language.get_Menu_Word_Control(_Text, AppMain.AppValue.Language), Style = ElementStyle.Item };
                _ace = new AccordionControlElement() { Text = _Text, Style = ElementStyle.Item };
            }
            return _ace;
        }

        public void set_AccordionControl_Menus(DevExpress.XtraBars.Navigation.AccordionControl _AccordionControl, List<SIS.Data.Menus> _List_Menus)
        {

            string _MenuMainGroup = "";
            string _MenuSubGroup = "";
            string _MenuGroup = "";
            AccordionControlElement ace_maingroup = new AccordionControlElement();
            AccordionControlElement ace_subgroup = new AccordionControlElement();
            AccordionControlElement ace_group = new AccordionControlElement();
            AccordionControlElement ace_item = new AccordionControlElement();
            foreach (SIS.Data.Menus _Menus in _List_Menus)
            {
                if (_MenuMainGroup != _Menus.MenuMainGroup)
                {
                    ace_maingroup = get_add_AccordionControlElement(_Menus.MenuMainGroup, true);
                    _AccordionControl.Elements.Add(ace_maingroup);
                    _MenuMainGroup = _Menus.MenuMainGroup;
                }

                if (_MenuSubGroup != _Menus.MenuSubGroup)
                {
                    ace_subgroup = get_add_AccordionControlElement(_Menus.MenuSubGroup, true);
                    ace_maingroup.Elements.Add(ace_subgroup);
                    _MenuSubGroup = _Menus.MenuSubGroup;
                }

                if (_MenuGroup != _Menus.MenuGroup)
                {
                    if (_Menus.MenuGroup == "")
                    {
                        ace_item = get_add_AccordionControlElement(_Menus.MenuText, false);
                        ace_item.Tag = _Menus.MenuMainGroup + "|" + _Menus.MenuForm;
                        ace_subgroup.Elements.Add(ace_item);

                        ace_item.Click += (sender, e) =>
                        {
                            Type configType = typeof(bl);
                            var properties = configType.GetProperty(_Menus.MenuMainGroup);
                            var aa = configType.GetField(_Menus.MenuMainGroup);
                            Type adminType = aa.FieldType;
                            var admin = Activator.CreateInstance(adminType, null);
                            var method = aa.FieldType.GetMethods().FirstOrDefault(r => r.Name == _Menus.MenuForm);
                            if (this.get_Form_Open(_Menus.MenuForm) == false)
                            {
                                method.Invoke(admin, new object[] { this });
                            }

                        };
                    }
                    else
                    {
                        ace_group = get_add_AccordionControlElement(_Menus.MenuGroup, true);
                        ace_subgroup.Elements.Add(ace_group);
                        ace_item = get_add_AccordionControlElement(_Menus.MenuText, false);
                        ace_item.Tag = _Menus.MenuMainGroup + "|" + _Menus.MenuForm;
                        ace_group.Elements.Add(ace_item);

                        ace_item.Click += (sender, e) =>
                        {
                            Type configType = typeof(bl);
                            var properties = configType.GetProperty(_Menus.MenuMainGroup);
                            var aa = configType.GetField(_Menus.MenuMainGroup);

                            Type adminType = aa.FieldType;
                            var admin = Activator.CreateInstance(adminType, null);
                            var method = aa.FieldType.GetMethods().FirstOrDefault(r => r.Name == _Menus.MenuForm);

                            if (this.get_Form_Open(_Menus.MenuForm) == false)
                            {
                                method.Invoke(admin, new object[] { this });
                            }

                        };

                    }
                    _MenuGroup = _Menus.MenuGroup;
                }
                else
                {
                    if (_Menus.MenuGroup != "")
                    {
                        ace_item = get_add_AccordionControlElement(_Menus.MenuText, false);
                        ace_item.Tag = _Menus.MenuMainGroup + "|" + _Menus.MenuForm;
                        ace_group.Elements.Add(ace_item);

                        ace_item.Click += (sender, e) =>
                        {
                            Type configType = typeof(bl);
                            var properties = configType.GetProperty(_Menus.MenuMainGroup);
                            var aa = configType.GetField(_Menus.MenuMainGroup);
                            Type adminType = aa.FieldType;
                            var admin = Activator.CreateInstance(adminType, null);
                            var method = aa.FieldType.GetMethods().FirstOrDefault(r => r.Name == _Menus.MenuForm);
                            if (this.get_Form_Open(_Menus.MenuForm) == false)
                            {
                                method.Invoke(admin, new object[] { this });
                            }
                        };
                    }
                    else
                    {
                        ace_item = get_add_AccordionControlElement(_Menus.MenuText, false);
                        ace_item.Click += (sender, e) =>
                        {
                            Type configType = typeof(bl);
                            var properties = configType.GetProperty(_Menus.MenuMainGroup);
                            var aa = configType.GetField(_Menus.MenuMainGroup);
                            Type adminType = aa.FieldType;
                            var admin = Activator.CreateInstance(adminType, null);
                            var method = aa.FieldType.GetMethods().FirstOrDefault(r => r.Name == _Menus.MenuForm);
                            if (this.get_Form_Open(_Menus.MenuForm) == false)
                            {
                                method.Invoke(admin, new object[] { this });
                            }
                        };
                        ace_item.Tag = _Menus.MenuMainGroup + "|" + _Menus.MenuForm;
                        if (_Menus.MenuSubGroup != "")
                        {
                            ace_subgroup.Elements.Add(ace_item);
                        }
                        else
                        {
                            ace_maingroup.Elements.Add(ace_item);
                        }
                    }
                }
            }

            _AccordionControl.Refresh();
        }

        private bool get_Form_Open(string _FormName)
        {
            bool _FormFound = false;
            foreach (DevExpress.XtraBars.Docking2010.Views.Tabbed.Document _Document in this.tabbedView1.Documents)
            {
                if (_Document.Form.Name == _FormName)
                {
                    _FormFound = true;
                    tabbedView1.Controller.Activate(_Document);
                    break;
                }
            }
            return _FormFound;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            do_login();
        }

        public static bool IsContainsValue(string find)
        {
            bool flag = false;
            foreach (string key in ConfigurationManager.AppSettings.AllKeys)
            {
                // string _value = ConfigurationManager.AppSettings[key].ToString();
                if (key == find)

                { flag = true; break; }
            }
            return flag;

        }

        public static void set_AppSettings()
        {
            try
            {
                if (IsContainsValue("GMPActive"))
                {
                    AppMain.GMPActive = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["GMPActive"]);
                }
                else
                {
                    AppMain.GMPActive = true;
                }
                if (IsContainsValue("HTPActive"))
                {
                    AppMain.HTPActive = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["HTPActive"]);
                }
                else
                {
                    AppMain.HTPActive = true;
                }


            }
            catch (Exception ex)
            {

                throw;
            }
        }


    }
}