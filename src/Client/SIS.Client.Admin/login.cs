using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using SIS.Models.Models.App;

using SIS.Model.Models.GMP.Settings;
using SIS.Model.Models.GMP.Definitions;

using SIS.Model.Models.Utilities;
using SIS.Data.Managers;
using SIS.Data.Model;
using SIS.Data;
using SIS.Client.blvalue;
using SIS.Data.App;

namespace SIS.Client.Admin
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
         
            Set_Form();
        }

        int __LoginTryCount = 0;

        public int ApplicationId;
        List<SIS.Entity.Entities.Admin.ApplicationServer> __List_ApplicationServer;
        int __OldServerId = 0;
        SIS.Data.App.LoginUser __dl_Users;
        LoginUser __dl_Users_Gmp;
        LoginUser __dl_Users_Htp;
        string _User_old = "";
        int __register_ServerId;
        string __ConnectionString;
        string __Sql_Server;
        string __Sql_Database;
        string __Sql_User;
        string __Sql_Password;
        int __register_DatabaseId;
        int __OldDatabaseId = 0;


        List<ApplicationServerDTO> applicationServers = new List<ApplicationServerDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();

        #region Record
        private void Set_Form()
        {
            SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();

            //if (!AppMain.AppValue.RunningLocalAdmin)
            //{
            //    SIS.Data.AppConfigs _AppConfigs = bl.blcAdmin.Run<SIS.Service.Admin.Service.AdminService, SIS.Data.AppConfigs>(r => r.get_AppConfigs());
            //}
            SIS.Data.App.AppIdView _AppIdView = new SIS.Data.App.AppIdView();
            if (SIS.Client.blvalue.AppMain.AppValue.GMPActive)
            {
                _AppIdView.Id = (int)Data.AdminAppType.GMP;
                _AppIdView.App = Data.AdminAppType.GMP.ToString();
                SIS.Client.Admin.blvalue.List_AppIdView.Add(_AppIdView);
            }
            if (SIS.Client.blvalue.AppMain.AppValue.HTPActive)
            {
                _AppIdView = new SIS.Data.App.AppIdView();

                _AppIdView.Id = (int)Data.AdminAppType.HTP;
                _AppIdView.App = Data.AdminAppType.HTP.ToString();
                SIS.Client.Admin.blvalue.List_AppIdView.Add(_AppIdView);
            }

            List<int> _List_ApplicationIds = new List<int>();
            _List_ApplicationIds.Add(blvalue.AplicationId);
            bs_AppIdView.DataSource = SIS.Client.Admin.blvalue.List_AppIdView;
        }
        #endregion
        private string get_DbKodAdmin_Database(string _CustomerGuidId)
        {
            SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
            _GetValue.IdStr = _CustomerGuidId;
            _GetValue.Id = blvalue.AplicationId;
            _GetValue.ConStr = Client.blvalue.AppMain.AppValue.ConAdminFirst;
            SIS.Data.ReturnProcess _ReturnProcess = bl.blcAdmin.Run<Service.Admin.AdminService, SIS.Data.ReturnProcess>(r => r.get_DbKodAdmin_Database(_GetValue));
            return _ReturnProcess.error;
        }
        private void set_DbAdmin_Database()
        {

            if (SIS.Client.blvalue.AppMain.AppValue.CloudLicense)
            {
                string _DbAdminDatabase = get_DbKodAdmin_Database(SIS.Client.blvalue.AppMain.AppValue.CustomerGuidId);
                if (_DbAdminDatabase == null) _DbAdminDatabase = "";
                if (_DbAdminDatabase != "")
                {
                    SIS.Client.blvalue.AppMain.AppValue.DbAdminConnectionDTO.Database = _DbAdminDatabase;
                    string connection = SIS.Client.blvalue.AppMain.AppValue.DbAdminConnectionDTO.Connection(blvalue.Cloude);
                    #region Token
                    IAuthService authService = new JWTService();
                    IAuthContainerModel model = GetJWTContainerModel("connection", connection);

                    string token = authService.GenerateToken(model);
                    if (!string.IsNullOrEmpty(token))
                    {
                        connection = token;
                    }
                    #endregion

                    SIS.Client.blvalue.AppMain.AppValue.ConAdmin = connection;
                    SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
                    _GetValue.ConStr = SIS.Client.blvalue.AppMain.AppValue.ConAdmin;
                    //var result = bl.blcAdmin.Run<Service.Admin.Service.AdminService, SIS.Data.ReturnProcess>(r => r.UpdateSqlDatabase(_GetValue));
                }
                else
                {
                    string connection = SIS.Client.blvalue.AppMain.AppValue.AdminConnectionDTO.Connection(blvalue.Cloude);
                    SIS.Client.blvalue.AppMain.AppValue.ConAdmin = SIS.Client.blvalue.AppMain.CreateJwtToken("connection", connection);                
                }
            }


        }
        private static JWTContainerModel GetJWTContainerModel(string name, string value)
        {
            return new JWTContainerModel
            {
                Claims = new List<ClaimDto>
                {
                    new ClaimDto( name,value)
                }
            };
        }
        private void login_Load(object sender, EventArgs e)
        {
            set_DbAdmin_Database();
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            do_login();
        }
        private bool do_IsNotValid()
        {
            bool _return = false;
            if (lc_Application.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Lütfen Program Belirtiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            if (txt_userCode.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Lütfen Kullanıcı Kodu Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            if (txt_Password.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Lütfen Parolanızı Giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            //if (lc_serverList.EditValue.ToString() == "")
            //{
            //    XtraMessageBox.Show("Server Seçimi Yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    _return = true;
            //}
            //if (lc_Company.EditValue == null || lc_Company.Text.ToString() == "")
            //{
            //    XtraMessageBox.Show("Lütfen Şirket Seçimi Yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    _return = true;
            //}
            return _return;
        }
        private void do_login()
        {
            if (lc_Company.EditValue == null) return;

            string _Password = txt_Password.Text.Trim();
            int _CompanyId = (int)lc_Company.EditValue;
            GetValue _GetValue = new GetValue();
            _GetValue.ConStr = __ConnectionString;
            _GetValue.CompanyId = _CompanyId;
            bl.AppService = AppServiceFactory.CreateApp((AdminAppType)blvalue.AplicationId);
            string _HashPassword = _user.HashPassword.Trim();

            if (bl.AppService.GetHashPassword(_Password) != _HashPassword)
            {
                __LoginTryCount++;
                if (__LoginTryCount == 3)
                {
                    bl.message.get_Warning("Three times a failed login attempt, the user has been made inactive, ask your system administrator.", AppMain.AppValue.Language);
                    blvalue.UserLoginOk = false;

                    this.Close();

                    return;
                }
                bl.message.get_Warning("Wrong Password", AppMain.AppValue.Language);
                txt_Password.Focus();
                return;
            }
            blvalue.UserLoginOk = true;
            AppMain.AppId = (int)lc_Application.GetColumnValue("Id");
            AppMain.AppValue.UserCode = _user.UserCode;

            _GetValue.ConStr = __ConnectionString;
            _GetValue.IdStr = AppMain.AppValue.UserCode;
            bl.AppService.Login(_GetValue);

            this.Close();
        }
        private void btn_Close_Click(object sender, EventArgs e)
        {
            blvalue.UserLoginOk = false;
            this.Close();
        }
        private void lc_serverList_EditValueChanged(object sender, EventArgs e)
        {
            bs_ApplicationServer.EndEdit();
            if (lc_serverList.Text == "") return;
            if (__List_ApplicationServer.Count == 0) return;
            int _ServerId = Convert.ToInt32(lc_serverList.EditValue);
            set_ServerIdValue(_ServerId);
        }
        private void set_ServerIdValue(int _ServerId)
        {
            if (__OldServerId != _ServerId)
            {
                __OldServerId = _ServerId;
            }
            else
            {
                return;
            }
            set_blvalue_ApiUrl(_ServerId);
            var _ApplicationServer = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault();
            List<SIS.Entity.Entities.Admin.ApplicationDatabase> _List_ApplicationDatabase = _ApplicationServer.ApplicationDatabase;
            bs_ApplicationDatabase.DataSource = _List_ApplicationDatabase;
            int _DatabaseId = _List_ApplicationDatabase[0].Id;
            if (__register_DatabaseId != 0)
            {
                if (_List_ApplicationDatabase.Where(l => l.Id == __register_DatabaseId).Count() > 0)
                {
                    _DatabaseId = __register_DatabaseId;
                }
            }
            lc_database.EditValue = _DatabaseId;
            set_DatabaseIdValue(_DatabaseId);

        }
        private void UseLocal()
        {
            if (AppMain.AppValue.ForceUseLocal)
            {
                AppMain.AppValue.ApiUrlApp = "";
            }
        }
        private void set_blvalue_ApiUrl(int _ServerId)
        {

            bl.AppService = AppServiceFactory.CreateApp((AdminAppType)blvalue.AplicationId);
            if (_ServerId != -1)
            {
                AppMain.AppValue.ApiUrlApp = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().ApiLocal;
                UseLocal();
                AppMain.AppValue.RunningLocalApp = string.IsNullOrEmpty(AppMain.AppValue.ApiUrlApp);
                bl.AppService.CreateBlc();
            }
        }
        private void set_DatabaseIdValue(int _DataBaseId)
        {
            if (__OldDatabaseId != _DataBaseId)
            {
                __OldDatabaseId = _DataBaseId;
            }
            else
            {
                return;
            }

            int _ServerId = Convert.ToInt32(lc_serverList.EditValue);
            int _DatabaseId = Convert.ToInt32(lc_database.EditValue);

            var server = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().ApplicationDatabase.Where(l => l.Id == _DatabaseId).FirstOrDefault();
            __ConnectionString = server.ConnectionString;

            __Sql_Server = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().Server;
            __Sql_User = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().Username;
            __Sql_Password = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().Password;

            __Sql_Database = __List_ApplicationServer.Where(l => l.Id == _ServerId).FirstOrDefault().ApplicationDatabase.Where(l => l.Id == _DatabaseId).FirstOrDefault().DatabaseName;

            set_blvalue_ApiUrl((int)lc_serverList.EditValue);
            SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
            _GetValue.ConStr = __ConnectionString;

            _GetValue.IdStr = txt_userCode.Text;

            bl.AppService = AppServiceFactory.CreateApp((AdminAppType)blvalue.AplicationId);
            try
            {
                AppMain.List_UserCompanyRight = bl.AppService.GetUserCompanyRights(_GetValue);
                bs_UserCompanyRight.DataSource = AppMain.List_UserCompanyRight;
            }
            catch (Exception _Exception)
            {

                bl.message.get_Warning(_Exception.InnerException == null ? _Exception.Message : _Exception.InnerException.Message, AppMain.AppValue.Language);
                txt_userCode.EditValue = "";
                txt_userCode.Focus();
            }
            finally
            {
                GetUsers(_GetValue);
            }



        }
        LoginUser _user;
        private Data.App.LoginUser GetUsers(GetValue _GetValue)
        {
            _user = bl.AppService.GetLoginUser(_GetValue);
            __dl_Users_Gmp = _user;
            __dl_Users = _user;
            return _user;
        }
        public bool get_User_ServerDatabase(string _User, string _CustomerGuidId)
        {
            bool _return = false;

            GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
            _GetValue.ConStr = AppMain.AppValue.ConAdmin;
            _GetValue.IdStr = _User;
            _GetValue.Id = blvalue.AplicationId;

            if (_CustomerGuidId != "00000000-0000-0000-0000-000000000000")
            {
                _GetValue.IdStr2 = _CustomerGuidId;
            }
            else
            {
                _GetValue.IdStr2 = "";
            }


            __List_ApplicationServer = bl.blcAdmin.Run<SIS.Service.Admin.AdminService, List<SIS.Entity.Entities.Admin.ApplicationServer>>(r => r.get_List_ApplicationServer_UserCode(_GetValue));
            __List_ApplicationServer = __List_ApplicationServer.Where(l => l.ApplicationDatabase.Count > 0).ToList();

            if (__List_ApplicationServer.Count == 0)
            {
                _User_old = "";
                txt_userCode.EditValue = "";
                lc_serverList.EditValue = -1;
                lc_database.EditValue = -1;
                bs_ApplicationServer.DataSource = null;
                bs_ApplicationDatabase.DataSource = null;
                bs_UserCompanyRight.DataSource = null;
                __OldServerId = 0;
                __OldDatabaseId = 0;
                lc_serverList.Refresh();
                lc_database.Refresh();
                lc_Company.Refresh();
                _return = false;
            }
            else
            {

                bs_ApplicationServer.DataSource = __List_ApplicationServer;
                lc_serverList.EditValue = -1;
                if (__register_ServerId != 0)
                {
                    if (__List_ApplicationServer.Where(l => l.Id == __register_ServerId).Count() > 0)
                    {
                        lc_serverList.EditValue = __register_ServerId;

                        if (__List_ApplicationServer.Count == 1)
                        {
                            set_ServerIdValue(__register_ServerId);
                        }
                    }
                    else
                    {
                        lc_serverList.EditValue = __List_ApplicationServer.FirstOrDefault().Id;
                    }
                }
                else
                {
                    lc_serverList.EditValue = __List_ApplicationServer.FirstOrDefault().Id;

                }
                _return = true;
            }

            return _return;
        }
        bool _PasswordFocus = false;
        private void txt_userCode_Leave(object sender, EventArgs e)
        {
            string _UserCode = txt_userCode.Text.ToString().Trim();

            if (_PasswordFocus)
            {
                if (_User_old == _UserCode)
                {
                    _PasswordFocus = false;
                    return;
                }
            }

            if (_UserCode == "")
            {
                _User_old = "";
                txt_userCode.EditValue = "";
                lc_serverList.EditValue = -1;
                lc_database.EditValue = -1;
                bs_ApplicationServer.DataSource = null;
                bs_ApplicationDatabase.DataSource = null;

                bs_UserCompanyRight.DataSource = null;
                __OldServerId = 0;
                __OldDatabaseId = 0;
                lc_serverList.Refresh();
                lc_database.Refresh();
                return;
            }

            blvalue.AplicationId = (int)lc_Application.EditValue;
            if (_User_old != _UserCode)
            {
                __OldServerId = 0;
                __OldDatabaseId = 0;
                if (!get_User_ServerDatabase(txt_userCode.Text.ToString(), AppMain.AppValue.CustomerGuidId))
                {
                    _User_old = "";
                    txt_userCode.EditValue = "";
                    txt_Password.EditValue = "";
                    lc_serverList.EditValue = -1;
                    lc_database.EditValue = -1;

                    bs_ApplicationServer.DataSource = null;
                    bs_ApplicationDatabase.DataSource = null;
                    bs_UserCompanyRight.DataSource = null;
                    __OldServerId = 0;
                    __OldDatabaseId = 0;
                    lc_serverList.Refresh();
                    lc_database.Refresh();
                    lc_Company.Refresh();
                    bl.message.get_Warning("User not found.", AppMain.AppValue.Language);
                    txt_userCode.Focus();
                    return;
                }
                else
                {
                    GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
                    _GetValue.ConStr = __ConnectionString;
                    _GetValue.IdStr = txt_userCode.Text;

                    bl.AppService = AppServiceFactory.CreateApp((AdminAppType)blvalue.AplicationId);
                    try
                    {
                        var users = GetUsers(_GetValue);
                        //txt_userCode.EditValue = users?.UserName;
                    }
                    catch (Exception _Exception)
                    {
                        bl.message.get_Warning(_Exception.InnerException == null ? _Exception.Message : _Exception.InnerException.Message, AppMain.AppValue.Language);
                    }


                    _PasswordFocus = true;
                    txt_Password.Focus();
                }

                _User_old = txt_userCode.Text.ToString();
            }
        }
        private void lc_Application_EditValueChanged(object sender, EventArgs e)
        {
            blvalue.AplicationId = (int)lc_Application.EditValue;
            _User_old = "";
            _PasswordFocus = false;
            if (!AppMain.AppValue.CloudLicense)
            {
                //do_Set_Registry_Read(blvalue.AplicationId);
            }
            else
            {
                //do_Set_Registry_License_Read(AppMain.AppValue.CustomerGuidId, blvalue.AplicationId);
            }
            if (txt_userCode.Text != "")
            {
                txt_userCode_Leave(null, null);
            }
        }
        private void lc_database_EditValueChanged(object sender, EventArgs e)
        {
            bs_ApplicationDatabase.EndEdit();
            if (lc_database.EditValue == null) return;
            if (lc_serverList.Text == "") return;
            if (__List_ApplicationServer.Count == 0) return;

            _User_old = "";
            int _DatabaseId = Convert.ToInt32(lc_database.EditValue);
            set_DatabaseIdValue(_DatabaseId);
        }
    }
}