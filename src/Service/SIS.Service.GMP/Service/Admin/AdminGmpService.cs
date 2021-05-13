using SIS.Data.Admin;
using SIS.Data.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.GMP.Service.Admin
{
    public class AdminGmpService : BaseService
    {
        [HttpAction(HttpType.Post)]
        public List<UserCompanyRight> get_List_UserCompanyRight(GetValue _GetValue)
        {
            List<UserCompanyRight> result = new List<UserCompanyRight>();
            return result;

            //using (var _db = new Syskod.DataAccess.Erp.ErpListContex(_GetValue.ConStr))
            //{
            //    string _sql = $"select c.RecId  As CompanyId, c.CompanyCode , c.Name As CompanyName, c.TaxNo,Isnull(c.Alias,'') as CompanyAlias,isnull(cor.EInvoiceDatabase,'SednaEInvoice') as EInvoiceDatabase from CompanyRight cr with (nolock) "
            //        + $" left outer join Company c with (nolock) on c.CompanyCode = cr.CompanyCode "
            //        + " left outer join Corporation cor with (nolock)  on c.CorporationId = cor.RecId  "
            //        + $" where cr.UserCode = N'{_GetValue.IdStr}'";

            //    var _return = _db.Database.SqlQuery<Syskod.Data.Admin.Pms.dto.UserCompanyRight>(_sql).ToList();

            //    return _return;
            //}
        }
    }
}
