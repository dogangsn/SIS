using SIS.Client.blvalue;
using SIS.Data.Managers;
using SIS.Data.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Client.Admin
{
    public class pl
    {

        public bool login(int _ApplicationId)
        {
            blvalue.UserLoginOk = false;
            set_AppSettings();
            SIS.Data.App.GetValue _GetValue = new SIS.Data.App.GetValue();
            _GetValue.ConStr = AppMain.AppValue.ConAdmin;

           Data.ReturnProcess _ReturnProcess = bl.blcAdmin.Run<SIS.Service.Admin.AdminService, SIS.Data.ReturnProcess>(r => r.get_SqlData_Connect(_GetValue));
            if (_ReturnProcess.processok)
            {
                login _login = new login();
                //_login.Icon = blvalue.formico;
                _login.ShowDialog();
            }
            else
            {
                bl.message.get_Warning("Admin Database Not Connect :" + _ReturnProcess.error, AppMain.AppValue.Language);
                blvalue.UserLoginOk = false;
            }
            return blvalue.UserLoginOk;
        }


        public static void set_AppSettings()
        {
            try
            {
                if (IsContainsValue("GMPActive"))
                {
                    SIS.Client.blvalue.AppMain.AppValue.GMPActive = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["GMPActive"]);
                }
                else
                {
                    SIS.Client.blvalue.AppMain.AppValue.GMPActive = true;
                }
                if (IsContainsValue("HTPActive"))
                {
                    Client.blvalue.AppMain.AppValue.HTPActive = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["HTPActive"]);
                }
                else
                {
                    Client.blvalue.AppMain.AppValue.HTPActive = true;
                }


                bool _ConnectionApi = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["ConnectionApi"]);

                if (SIS.Client.blvalue.AppMain.AppValue.ForceUseLocal)
                {
                    blvalue.Connection = "";
                    _ConnectionApi = false;
                }
                Data.App.ConnectionDTO AdminConnection = new SIS.Data.App.ConnectionDTO();

                AppMain.AppValue.ApiUrlAdmin = blvalue.Connection;
                if (blvalue.Connection == "")
                {
                    AppMain.AppValue.RunningLocalAdmin = true;
                    blvalue.Connection = "Local";


                    AdminConnection.Server = System.Configuration.ConfigurationManager.AppSettings["Server"];
                    AdminConnection.Database = System.Configuration.ConfigurationManager.AppSettings["Database"];
                    AdminConnection.UserId = System.Configuration.ConfigurationManager.AppSettings["Username"];
                    AdminConnection.Password = System.Configuration.ConfigurationManager.AppSettings["Password"];

                }
                bl.blcAdmin = new SIS.Service.Admin.Repository(AppMain.AppValue.RunningLocalAdmin, AppMain.AppValue.ApiUrlAdmin);
                if (!AppMain.AppValue.RunningLocalAdmin & _ConnectionApi == true)
                {
                    SIS.Data.App.SISAdmin _SISAdmin = bl.blcAdmin.get_KodAdmin<SIS.Service.Admin.AdminService, SIS.Data.App.SISAdmin>(r => r.get_KodAdmin());
                    AdminConnection.Server = _SISAdmin.Server;
                    AdminConnection.Database = _SISAdmin.Database;
                    AdminConnection.UserId = _SISAdmin.Username;
                    AdminConnection.Password = _SISAdmin.Password;
                }


                if (!AppMain.AppValue.RunningLocalAdmin & _ConnectionApi == false)
                {
                    AdminConnection.Server = System.Configuration.ConfigurationManager.AppSettings["Server"];
                    AdminConnection.Database = System.Configuration.ConfigurationManager.AppSettings["Database"];
                    AdminConnection.UserId = System.Configuration.ConfigurationManager.AppSettings["Username"];
                    AdminConnection.Password = System.Configuration.ConfigurationManager.AppSettings["Password"];
                }
                string connection = AdminConnection.Connection(blvalue.Cloude);
                #region Token
                IAuthService authService = new JWTService();
                IAuthContainerModel model = GetJWTContainerModel("connection", connection);

                string token = authService.GenerateToken(model);
                if (!string.IsNullOrEmpty(token))
                {
                    connection = token;
                }
                #endregion
                AppMain.AppValue.ConAdmin = connection;
                AppMain.AppValue.ConAdminFirst = connection;

                SIS.Data.App.GetValue _GetValue = SIS.Client.Admin.bl.get_GetValue();
                _GetValue.ConStr = AppMain.AppValue.ConAdmin;

            }
            catch (Exception ex)
            {
                bl.message.get_Warning(ex.Message, AppMain.AppValue.Language);
            }
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

    }
}
