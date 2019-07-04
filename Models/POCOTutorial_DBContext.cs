using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using POCO.Models.Mapping;

namespace POCO.Models
{
    public partial class POCOTutorial_DBContext : DbContext
    {
        static POCOTutorial_DBContext()
        {
            Database.SetInitializer<POCOTutorial_DBContext>(null);
        }

        public POCOTutorial_DBContext()
            : base("Name=POCOTutorial_DBContext")
        {
        }

        public DbSet<Dept_TB> Dept_TB { get; set; }
        public DbSet<Emp_TB> Emp_TB { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Dept_TBMap());
            modelBuilder.Configurations.Add(new Emp_TBMap());
        }
    }
}
