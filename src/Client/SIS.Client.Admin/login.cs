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

namespace SIS.Client.Admin
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        public login()
        {
            InitializeComponent();
         
            Set_Form();
        }


        public int ApplicationId;
        string __ConnectionString;
        string __Sql_Server;
        string __Sql_Database;
        string __Sql_User;
        string __Sql_Password;

        List<ApplicationServerDTO> applicationServers = new List<ApplicationServerDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();

        #region Record
        private void Set_Form()
        {
            SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();

            if (!AppMain.AppValue.RunningLocalAdmin)
            {
                SIS.Data.AppConfigs _AppConfigs = bl.blcAdmin.Run<SIS.Service.Admin.AdminService, SIS.Data.AppConfigs>(r => r.get_AppConfigs());
            }


            AppIdView _AppIdView = new AppIdView();
            if (AppMain.GMPActive)
            {
                _AppIdView.Id = (int)AdminAppType.GMP;
                _AppIdView.App = AdminAppType.GMP.ToString();
                AppMain.List_AppIdView.Add(_AppIdView);
            }
            if (AppMain.HTPActive)
            {
                _AppIdView = new AppIdView();

                _AppIdView.Id = (int)AdminAppType.HTP;
                _AppIdView.App = AdminAppType.HTP.ToString();
                AppMain.List_AppIdView.Add(_AppIdView);
            }

            List<int> _List_ApplicationIds = new List<int>();
            _List_ApplicationIds.Add(AppMain.AplicationId);
            bs_AppIdView.DataSource = AppMain.List_AppIdView;


        }


        #endregion

        private string get_DbKodAdmin_Database(string _CustomerGuidId)
        {
            SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
            _GetValue.IdStr = _CustomerGuidId;
            _GetValue.Id = blvalue.AplicationId;
            _GetValue.ConStr = Client.blvalue.AppMain.AppValue.ConAdminFirst;
            SIS.Data.ReturnProcess _ReturnProcess = bl.blcAdmin.Run<Service.Admin.Service.AdminService, SIS.Data.ReturnProcess>(r => r.get_DbKodAdmin_Database(_GetValue));
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
                    var result = bl.blcAdmin.Run<Service.Admin.Service.AdminService, SIS.Data.ReturnProcess>(r => r.UpdateSqlDatabase(_GetValue));

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
            if (lc_serverList.EditValue.ToString() == "")
            {
                XtraMessageBox.Show("Server Seçimi Yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _return = true;
            }
            //if (lc_Company.EditValue == null || lc_Company.Text.ToString() == "")
            //{
            //    XtraMessageBox.Show("Lütfen Şirket Seçimi Yapınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    _return = true;
            //}
            return _return;
        }

        private void do_login()
        {

            if (do_IsNotValid()) return;
            AppMain.User = new UsersDTO();
            AppMain.User.password = txt_Password.Text;
            AppMain.User.username = txt_userCode.EditValue.ToString();

            var connection = applicationServers.FirstOrDefault(x => x.Id == (int)lc_serverList.EditValue);
            var config = new ConnectionDTO
            {
                Database = "SIS",
                Server = connection.Server,
                Password = connection.Password,
                UserId = connection.UserName
            };
            UserAuthDto model = new UserAuthDto
            {
                Config = config,
                User = AppMain.User
            };

            //var loginResponse = _repository.Run<AuthorizationService, ActionResponse<UsersDTO>>(x => x.LoginControl(model));
            //if (loginResponse.ResponseType != ResponseType.Ok)
            //{
            //    DevExpress.XtraEditors.XtraMessageBox.Show(loginResponse.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txt_Password.Focus();
            //    return;
            //}
            //AppMain.User = loginResponse.Response;

            switch (AppMain.AplicationId)
            {
                case 1:
                    AppMain.AppId = (int)lc_Application.GetColumnValue("Id");
                    AppMain.AppName = (string)lc_Application.GetColumnValue("App");
                    break;
                case 2:
                    AppMain.AppId = (int)lc_Application.GetColumnValue("Id");
                    AppMain.AppName = (string)lc_Application.GetColumnValue("App");
                    break;
            }

            this.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}