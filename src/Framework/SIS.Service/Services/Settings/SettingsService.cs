
using SIS.DataAccess;
using SIS.Entity.Entities;

using SIS.Model.Models.GMP.Settings;
using SIS.Model.Models.Utilities;
using SIS.Models.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Service.Settings
{
    public class SettingsService : BaseService
    {

        //#region KullaniciTanimlari

        //public List<UsersDTO> GetListUser()
        //{
        //    using (var _db = new MspDbContext())
        //    {
        //        return base.Map<List<Users>, List<UsersDTO>>(_db.users.ToList());
        //    }
        //}
        //public UsersDTO GetUser(string UserCode)
        //{
        //    using (var _db = new MspDbContext())
        //    {
        //        return base.Map<Users, UsersDTO>(_db.users.FirstOrDefault(x => x.username == UserCode));
        //    }
        //}

        public ActionResponse<UsersDTO> Save_Users(UsersDTO model)
        {
            ActionResponse<UsersDTO> response = new ActionResponse<UsersDTO>()
            {
                Response = model,
                ResponseType = ResponseType.Ok
            };
            using (SISDbContext _db = new SISDbContext())
            {
                try
                {
                    if (response.Response.id == 0)
                    {
                        var varMi = _db.Users.FirstOrDefault(x => x.username == model.username);
                        if (varMi != null)
                        {
                            response.Message = "Aynı Kullanıcı Kodu Kullanılmıştır.";
                            response.ResponseType = ResponseType.Error;
                            return response;
                        }
                        _db.Users.Add(base.Map<UsersDTO, Users>(model));
                        _db.SaveChanges();
                    }
                    else
                    {
                        var entity = _db.Users.FirstOrDefault(x => x.id == response.Response.id);
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
        //#endregion

        //#region Company

        //public List<CompanyDTO> GetList_Company()
        //{
        //    using (var _db = new MspDbContext())
        //    {
        //        return base.Map<List<Company>, List<CompanyDTO>>(_db.Company.ToList());
        //    }
        //}

        //public CompanyDTO Get_Company(int RecId)
        //{
        //    using (var _db = new MspDbContext())
        //    {
        //        return base.Map<Company, CompanyDTO>(_db.Company.FirstOrDefault(x=>x.RecId == RecId));
        //    }
        //}

        //public ActionResponse<CompanyDTO> Save_Company(CompanyDTO model)
        //{
        //    ActionResponse<CompanyDTO> response = new ActionResponse<CompanyDTO>()
        //    {
        //        Response = model,
        //        ResponseType = ResponseType.Ok
        //    };
        //    using (MspDbContext _db = new MspDbContext())
        //    {
        //        try
        //        {
        //            if (response.Response.RecId == 0)
        //            {
        //                _db.Company.Add(base.Map<CompanyDTO, Company>(model));
        //                _db.SaveChanges();
        //            }
        //            else
        //            {
        //                var entity = _db.Company.FirstOrDefault(x => x.RecId == response.Response.RecId);
        //                if (entity != null)
        //                {
        //                    _db.Entry(entity).CurrentValues.SetValues(model);
        //                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        //                }
        //            }
        //            _db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            response.Message = e.ToString();
        //            response.ResponseType = ResponseType.Error;
        //        }
        //    }
        //    return response;
        //}

        //public ActionResponse<CompanyDTO> DeleteCompany(int? RecId)
        //{
        //    ActionResponse<CompanyDTO> response = new ActionResponse<CompanyDTO>();
        //    using (MspDbContext _db = new MspDbContext())
        //    {
        //        var record = _db.Company.Where(x => x.RecId == RecId).FirstOrDefault();
        //        if (record != null)
        //        {
        //            _db.Company.Remove(record);
        //        }                
        //        _db.SaveChanges();
        //    }
        //    return response;
        //}

        //#endregion

        //#region Parameters

        //public ParametersDTO Get_Parameters()
        //{
        //    using (var _db = new MspDbContext())
        //    {
        //        return base.Map<Parameters, ParametersDTO>(_db.Parameters.FirstOrDefault());
        //    }
        //}

        //public ActionResponse<ParametersDTO> Save_Parameters(ParametersDTO model)
        //{
        //    ActionResponse<ParametersDTO> response = new ActionResponse<ParametersDTO>()
        //    {
        //        Response = model,
        //        ResponseType = ResponseType.Ok
        //    };
        //    using (MspDbContext _db = new MspDbContext())
        //    {
        //        try
        //        {
        //            if (response.Response.RecId == 0)
        //            {
        //                _db.Parameters.Add(base.Map<ParametersDTO, Parameters>(model));
        //                _db.SaveChanges();
        //            }
        //            else
        //            {
        //                var entity = _db.Parameters.FirstOrDefault(x => x.RecId == response.Response.RecId);
        //                if (entity != null)
        //                {
        //                    _db.Entry(entity).CurrentValues.SetValues(model);
        //                    _db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        //                }
        //            }
        //            _db.SaveChanges();
        //        }
        //        catch (Exception e)
        //        {
        //            response.Message = e.ToString();
        //            response.ResponseType = ResponseType.Error;
        //        }
        //    }
        //    return response;
        //}

        //#endregion

        #region LayoutGridDeleted

        public ActionResponse<FormLayoutsDTO> DeleteAllFormLayoutsDTO()
        {
            ActionResponse<FormLayoutsDTO> response = new ActionResponse<FormLayoutsDTO>() { ResponseType = ResponseType.Ok };
            using (SISDbContext _db = new SISDbContext())
            {
                try
                {
                    var record = _db.FormLayouts.ToList();
                    if (record.Count > 0)
                    {
                        _db.FormLayouts.RemoveRange(record);
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
