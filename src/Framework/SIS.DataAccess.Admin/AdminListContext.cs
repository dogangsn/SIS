using SIS.Data.Managers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.DataAccess.Admin
{
    public class AdminListContext : DbContext
    {
        IAuthService authService = new JWTService();

        public AdminListContext(string __ConnectionString)
        {

            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.UseDatabaseNullSemantics = true;

            __ConnectionString = authService.GetConnectionStringFromToken(__ConnectionString);


            this.Database.Connection.ConnectionString = __ConnectionString;
            //   this.Database.Initialize(false);

            Database.SetInitializer<AdminContext>(null);

        }


    }
}
