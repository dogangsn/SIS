using SIS.Data;
using SIS.Data.App;
using SIS.Service.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Admin.Service
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



    }
}
