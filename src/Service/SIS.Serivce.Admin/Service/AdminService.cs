using SIS.Data;
using SIS.Data.App;
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
