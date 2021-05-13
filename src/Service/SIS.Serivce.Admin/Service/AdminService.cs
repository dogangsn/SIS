using SIS.Data;
using SIS.Data.App;
using SIS.Data.Managers;
using SIS.Data.Model;
using SIS.Entity.Entities.Admin;
using SIS.Serivce.Admin;
using SIS.Service.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Admin
{
    public class AdminService : BaseService
    {

        [HttpAction(HttpType.Post)]
        public ReturnProcess get_DbKodAdmin_Database(SIS.Data.App.GetValue _GetValue)
        {
            SIS.Data.ReturnProcess _ReturnProcess = new SIS.Data.ReturnProcess();
            try
            {
                //using (var _db = new SIS.DataAccess.Admin.AdminContext(_GetValue.ConStr))
                //{
                //    string _sql = $"Select Isnull(DbAdmin,'') from Customers Where GuidId = '{_GetValue.IdStr}' ";

                //    _ReturnProcess.error = _db.Database.SqlQuery<string>(_sql).FirstOrDefault();

                //}
                _ReturnProcess.processok = true;

            }
            catch (Exception exception)
            {
                _ReturnProcess.processok = false;
                _ReturnProcess.error = exception.ToString();

            }
            return _ReturnProcess;


        }

        [HttpAction(HttpType.Post)]
        public SIS.Data.ReturnProcess get_SqlData_Connect(SIS.Data.App.GetValue _GetValue)
        {
            SIS.Data.ReturnProcess _ReturnProcess = new ReturnProcess();
            try
            {
                using (var _db = new SIS.DataAccess.Admin.AdminListContext(_GetValue.ConStr))
                {
                    string _sql = "Select 1";
                    int _int = _db.Database.SqlQuery<int>(_sql).FirstOrDefault();
                }

                _ReturnProcess.processok = true;
            }
            catch (Exception _Exception)
            {
                _ReturnProcess.processok = false;
                _ReturnProcess.error = _Exception.InnerException == null ? _Exception.Message : _Exception.InnerException.Message;
            }


            return _ReturnProcess;
        }

        [HttpAction(HttpType.Get)]
        public SIS.Data.App.SISAdmin get_KodAdmin()
        {
            SIS.Data.App.SISAdmin _KodAdmin = new SISAdmin();
            return _KodAdmin;

        }

        [HttpAction(HttpType.Post)]
        public List<SIS.Entity.Entities.Admin.ApplicationServer> get_List_ApplicationServer_UserCode(GetValue _GetValue)
        {
            using (var _db = new SIS.DataAccess.Admin.AdminListContext(_GetValue.ConStr))
            {
                string _sql = Helper.get_sql_ApplicationServer(_GetValue.Id.Value, _GetValue.IdStr, _GetValue.IdStr2);
                List<ApplicationServer> _return = _db.Database.SqlQuery<ApplicationServer>(_sql).ToList();


                IAuthService authService = new JWTService();

                foreach (ApplicationServer _ApplicationServer in _return)
                {
                    _ApplicationServer.Password = get_SqlPassword_Local(_ApplicationServer.Password);
                    _sql = $"Select * from ApplicationDatabase with (nolock) Where ApplicationId = { _GetValue.Id} And ServerId = {_ApplicationServer.Id} ";
                    _ApplicationServer.ApplicationDatabase = _db.Database.SqlQuery<ApplicationDatabase>(_sql).ToList();

                    foreach (ApplicationDatabase _ApplicationDatabase in _ApplicationServer.ApplicationDatabase)
                    {
                        string connection = "";
                        string invoiceConnection = "";

                        if (_ApplicationServer.ServerCloude.Value)
                        {

                            connection = $"Server = tcp:{_ApplicationServer.Server},1433; Initial Catalog = {_ApplicationDatabase.DatabaseName}; Persist Security Info = False; User ID = {_ApplicationServer.Username}; Password = {_ApplicationServer.Password}; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
                            invoiceConnection = $"Server = tcp:{_ApplicationServer.Server},1433; Initial Catalog = SednaEInvoice; Persist Security Info = False; User ID = {_ApplicationServer.Username}; Password = {_ApplicationServer.Password}; MultipleActiveResultSets = True; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
                        }
                        else
                        {
                            connection = $"data source= {_ApplicationServer.Server};initial catalog={_ApplicationDatabase.DatabaseName};persist security info=True;user id={_ApplicationServer.Username};password={_ApplicationServer.Password};MultipleActiveResultSets=True;App=EntityFramework";
                            invoiceConnection = $"data source= {_ApplicationServer.Server};initial catalog=SednaEInvoice;persist security info=True;user id={_ApplicationServer.Username};password={_ApplicationServer.Password};MultipleActiveResultSets=True;App=EntityFramework";

                        }

                        #region Token
                        IAuthContainerModel model = GetJWTContainerModel("connection", connection);
                        string token = authService.GenerateToken(model);
                        string token2 = authService.GenerateToken(GetJWTContainerModel("connection", invoiceConnection));
                        connection = token;
                        invoiceConnection = token2;

                        #endregion

                        _ApplicationDatabase.ConnectionString = connection;
                    }
                }
                return _return;

            }
        }

        [HttpAction(HttpType.Get)]
        public string get_SqlPassword_Local(string _Password)
        {
            Helper _Helper = new Helper();
            _Helper.SetupDefination();
            return _Helper.SifreCoz(_Password);

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

        #region Layout
        [HttpAction(HttpType.Get)]
        public SIS.Entity.Entities.Admin.FormLayouts get_FormLayouts(string _ConStr, string _UserCode, string _FormName, string _ControlName)
        {
            using (var _db = new SIS.DataAccess.Admin.AdminContext(_ConStr))
            {
                string _sql = $"SELECT * From FormLayouts with (nolock) WHERE ApplicationId = 2 And UserCode  = N'{_UserCode}' And FormName = N'{_FormName}' And ControlName = N'{_ControlName}'";

                var _return = _db.Database.SqlQuery<SIS.Entity.Entities.Admin.FormLayouts>(_sql).FirstOrDefault();
                return _return;

            }
        }



        #endregion


    }
}
