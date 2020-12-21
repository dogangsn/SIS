﻿
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

namespace SIS.Service.Service.App
{
    public class StartUp : BaseService
    {
        public ProgramsControlsDTO CheckVersion()
        {
            ProgramsControlsDTO dataVersion = new ProgramsControlsDTO()
            {
                MspVersion = "1.0.0.0",
            };
            using (SISDbContext db = new SISDbContext())
            {
                var versionDto = db.Database.SqlQuery<ProgramsControlsDTO>("select * from ProgramsControl").FirstOrDefault();
                if (versionDto == null)
                {
                    db.ProgramsControl.Add(base.Map<ProgramsControlsDTO, ProgramsControl>(dataVersion));
                    db.SaveChanges();
                    versionDto.MspVersion = dataVersion.MspVersion;
                }
                dataVersion = versionDto;
            }

            return dataVersion;
        }

        public List<ApplicationServerDTO> Get_List_ApplicationServer()
        {
            using (SISDbContext _db = new SISDbContext())
            {
                return base.Map<List<ApplicationServer>, List<ApplicationServerDTO>>(_db.ApplicationServer.ToList());
            }
        }

        //public List<CompanyDTO> GetList_Company()
        //{
        //    using (var _db = new SISDbContext())
        //    {
        //        return base.Map<List<Company>, List<CompanyDTO>>(_db.Company.ToList());
        //    }
        //}
        public UsersDTO GetUser(string UserCode)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<Users, UsersDTO>(_db.Users.FirstOrDefault(x=>x.username == UserCode));
            }
        }



        public ActionResponse<FormLayoutsDTO> Save_FormLayout(FormLayoutsDTO gridSettings)
        {
            ActionResponse<FormLayoutsDTO> response = new ActionResponse<FormLayoutsDTO>()
            {
                Response = gridSettings,
                ResponseType = ResponseType.Ok
            };
            using (var _db = new SISDbContext())
            {
                try
                {
                    var grid = _db.FormLayouts.Where(x => x.ControlName == gridSettings.ControlName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode).FirstOrDefault();
                    if (grid != null)
                    {
                        gridSettings.RecId = grid.RecId;
                        _db.Entry(grid).CurrentValues.SetValues(gridSettings);
                        _db.Entry(grid).State = System.Data.Entity.EntityState.Modified;
                    }
                    else
                    {
                        _db.FormLayouts.Add(base.Map<FormLayoutsDTO, FormLayouts>(gridSettings));
                        _db.SaveChanges();
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

        public FormLayoutsDTO Get_FormLayout(FormLayoutsDTO gridSettings)
        {
            using (var _db = new SISDbContext())
            {
                return base.Map<FormLayouts, FormLayoutsDTO>(_db.FormLayouts.FirstOrDefault(x => x.ControlName == gridSettings.ControlName && x.FormName == gridSettings.FormName && x.UserCode == gridSettings.UserCode));
            }
        }


    }
}
