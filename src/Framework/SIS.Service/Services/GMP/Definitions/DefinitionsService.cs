using SIS.Data.App;
using SIS.DataAccess;
using SIS.Entity.Entities;
using SIS.Model.Models.GMP.Definitions;
using SIS.Model.Models.Utilities;
using SIS.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Services.GMP.Definitions
{
    public class DefinitionsService : BaseService
    {
        #region companyListEdit

        public List<CompanyDTO> GetList_Company()
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<List<Company>, List<CompanyDTO>>(_db.Company.ToList());
            }
        }

        public CompanyDTO Get_Company(GetValue _getValue)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<Company, CompanyDTO>(_db.Company.FirstOrDefault(x => x.RecId == _getValue.Id));
            }
        }

        public ActionResponse<CompanyDTO> Save_Company(CompanyDTO model)
        {
            ActionResponse<CompanyDTO> response = new ActionResponse<CompanyDTO>()
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
                        _db.Company.Add(base.Map<CompanyDTO, Company>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Company.FirstOrDefault(x => x.RecId == response.Response.RecId);
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

        public ActionResponse<CompanyDTO> DeleteCompany(int? RecId)
        {
            ActionResponse<CompanyDTO> response = new ActionResponse<CompanyDTO>();
            using (SISDbContext _db = new SISDbContext())
            {
                var record = _db.Company.Where(x => x.RecId == RecId).FirstOrDefault();
                if (record != null)
                {
                    _db.Company.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

        #region Personel
        public List<PersonelsDTO> GetList_Personel(GetValue _getValue)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<List<Personels>, List<PersonelsDTO>>(_db.Personels.Where(x=>x.CompanyId == _getValue.CompanyId).ToList());
            }
        }
        public PersonelsDTO Get_Personels(GetValue _getValue)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<Personels, PersonelsDTO>(_db.Personels.FirstOrDefault(x => x.RecId == _getValue.Id));
            }
        }

        public ActionResponse<PersonelsDTO> DeletePersonel(int? RecId)
        {
            ActionResponse<PersonelsDTO> response = new ActionResponse<PersonelsDTO>();
            using (SISDbContext _db = new SISDbContext())
            {
                var record = _db.Personels.Where(x => x.RecId == RecId).FirstOrDefault();
                if (record != null)
                {
                    _db.Personels.Remove(record);
                }
                _db.SaveChanges();
            }
            return response;
        }


        #endregion

    }
}
