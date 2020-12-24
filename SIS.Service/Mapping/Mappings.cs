using AutoMapper;
using SIS.Entity.Entities;

using SIS.Model.Models.GMP.Customer;
using SIS.Model.Models.GMP.Definitions;
using SIS.Model.Models.GMP.Settings;
using SIS.Models.Models.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Service.Mapping
{
    public class Mappings : Profile
    {
        public static void Configure(IMapperConfigurationExpression cfg)
        {
            //cfg.CreateMap<ApplicationServer, ApplicationServerDTO>();
            //cfg.CreateMap<ApplicationServerDTO, ApplicationServer>();
            cfg.CreateMap<Customers, CustomersDTO>();
            cfg.CreateMap<CustomersDTO, Customers>();
            cfg.CreateMap<Users, UsersDTO>();
            cfg.CreateMap<UsersDTO, Users>();
            cfg.CreateMap<ProgramsControl, ProgramsControlsDTO>();
            cfg.CreateMap<ProgramsControlsDTO, ProgramsControl>();
            cfg.CreateMap<FormLayouts, FormLayoutsDTO>();
            cfg.CreateMap<FormLayoutsDTO, FormLayouts>();
            cfg.CreateMap<Company, CompanyDTO>();
            cfg.CreateMap<CompanyDTO, Company>();
            cfg.CreateMap<Personels, PersonelsDTO>();
            cfg.CreateMap<PersonelsDTO, Personels>();
        }


    }
}
