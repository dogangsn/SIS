namespace SIS.Entity.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SIS.Data;

    public partial class SISDbContext : DbContext
    {
        //public SISDbContext()
        //    : base("name=SISDbContext")
        //{
        //}
        public SISDbContext()
                : base("initial catalog=" + AppMain.SqlConnection.Database
                + ";data source=" + AppMain.SqlConnection.Server
                + ";user id=" + AppMain.SqlConnection.UserId
                + ";password=" + AppMain.SqlConnection.Password)
        {
        }

        public SISDbContext(string connectionString) : base(connectionString)
        {
        }

        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<FormLayouts> FormLayouts { get; set; }
        public virtual DbSet<ApplicationServer> ApplicationServer { get; set; }
        public virtual DbSet<ProgramsControl> ProgramsControl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
