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

using SIS.Data;
using SIS.Data.DbConectionModel;
using SIS.Model.Models.GMP.Settings;
using SIS.Model.Models.GMP.Definitions;
using SIS.Data.App;
using SIS.Model.Models.Utilities;


namespace SIS.Client.Admin
{
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        //Repository _repository = new Repository();
        public login()
        {
            InitializeComponent();
         
            Set_Form();
        }
        List<ApplicationServerDTO> applicationServers = new List<ApplicationServerDTO>();
        List<CompanyDTO> _company = new List<CompanyDTO>();

        #region Record
        private void Set_Form()
        {

            #region CreateFile
            string root = @"C:\SIS";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }
            string path = @"C:\SIS\ConnectString.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("data source=DG;initial catalog=SIS;user id=sa;password=123D654!;");
                }
            }
            string[] conArry;
            using (StreamReader sr = File.OpenText(path))
            {
                string str = sr.ReadLine();
                conArry = str.Split(';');
            }
            List<string> conn = new List<string>();
            foreach (var item in conArry)
            {
                int position = item.IndexOf("=");
                if (position < 0)
                    continue;
                conn.Add(item.Substring(position + 1));
            }
            AppMain.SqlConnection = new ConnectionDTO
            {
                Database = conn[1], //Global.SqlConnection.Database,
                Server = conn[0], //"R00T\\SQLEXPRESS", //Global.SqlConnection.Server,
                Password = conn[3], //Global.SqlConnection.Password,
                UserId = conn[2] //Global.SqlConnection.UserId
            };
            #endregion

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

            if (App.Tool.AppTools.sqlKontrol(AppMain.SqlConnection.Server, AppMain.SqlConnection.Database, AppMain.SqlConnection.UserId, AppMain.SqlConnection.Password) == false)
            {
                XtraMessageBox.Show("Bağlantı hatası.Veritabanı ayarlarınızı kontrol ediniz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDatabase();

        }

        public void LoadDatabase()
        {
            //applicationServers = _repository.Run<StartUp, List<ApplicationServerDTO>>(x => x.Get_List_ApplicationServer());
            //bs_ServerList.DataSource = applicationServers;

            if (applicationServers.Count > 0)
                lc_serverList.EditValue = applicationServers.FirstOrDefault().Id;

            //_company = _repository.Run<StartUp, List<CompanyDTO>>(x => x.GetList_Company());
            //bs_company.DataSource = _company;
        } 
        #endregion

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