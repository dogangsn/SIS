using SIS.Data.Managers;
using SIS.Entity.Entities;
using SIS.Entity.Entities.GMP;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.DataAccess.GMP
{
    public partial class GmpContext : DbContext
    {
        IAuthService authService = new JWTService();
        public GmpContext(string __ConnectionString)
          : base("GmpContext")
        {

            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.UseDatabaseNullSemantics = true;
            this.Configuration.ValidateOnSaveEnabled = false;


            __ConnectionString = authService.GetConnectionStringFromToken(__ConnectionString);

            this.Database.Connection.ConnectionString = __ConnectionString;
            Database.CommandTimeout = 10000;

            Database.SetInitializer<GmpContext>(null);

        }

        public DbSet<Company> Company { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Customers> Customers { get; set; }

    }
}
