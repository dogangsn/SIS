using SIS.Data.App;
using SIS.DataAccess.GMP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.GMP.Service.System
{
    public class SystemService : BaseService
    {

        [HttpAction(HttpType.Post)]
        public LoginUser Get_LoginUsersByCode(SIS.Data.App.GetValue _GetValue)
        {
            using (var _db = new GmpListContext(_GetValue.ConStr))
            {
                string _sql = $"SELECT UserCode,UserName,HashPassword from Users Where UserCode = N'{_GetValue.IdStr}'  ";

                var _return = _db.Database.SqlQuery<LoginUser>(_sql).FirstOrDefault();

                return _return;
            }
        }


    }
}
