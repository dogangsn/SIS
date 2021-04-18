using SIS.Data.App;
using SIS.DataAccess;
using SIS.Entity.Entities;

using SIS.Model.Models.GMP.Customer;
using SIS.Model.Models.Utilities;
using SIS.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Services.GMP.Customers
{
    public class CustomersService : BaseService
    {


        #region CustomerEdit/List

        public List<CustomersDTO> Get_List_Customers(GetValue getValue)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<List<SIS.Entity.Entities.Customers>, List<CustomersDTO>>(_db.Customers.Where(x=>x.Deleted == false /*&& x.CompanyRecId == getValue.CompanyId */&& x.IsArsiv == false).ToList());
            }
        }

        public CustomersDTO Get_Customers(GetValue getValue)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<SIS.Entity.Entities.Customers, CustomersDTO>(_db.Customers.FirstOrDefault(x => x.RecId == getValue.Id));
            }
        }

        public ActionResponse<CustomersDTO> Save_Customers(CustomersDTO model)
        {
            ActionResponse<CustomersDTO> response = new ActionResponse<CustomersDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (SISDbContext _db = new SISDbContext())
            {
                try
                {
                    if (response.Response.RecId == 0)
                    {
                        _db.Customers.Add(base.Map<CustomersDTO, SIS.Entity.Entities.Customers>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Customers.FirstOrDefault(x => x.RecId == response.Response.RecId);
                        if (entity != null)
                        {
                            _db.Entry(entity).CurrentValues.SetValues(model);
                            _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                        }
                    }
                    _db.SaveChanges();
                }
                catch (Exception e)
                {
                    response.Message = e.ToString();
                    response.ResponseType = ResponseType.Error;
                }
            }
            return response;
        }

        #endregion











    }
}
