using SIS.Data.Managers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.DataAccess.Admin
{
    public partial class AdminContext : DbContext
    {
        IAuthService authService = new JWTService();
        public AdminContext(string __ConnectionString)
    : base("AdminContext")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.UseDatabaseNullSemantics = true;
            __ConnectionString = authService.GetConnectionStringFromToken(__ConnectionString);
            this.Database.Connection.ConnectionString = __ConnectionString;

            Database.SetInitializer<AdminContext>(null);
        }




    }
}
