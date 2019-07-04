using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace POCO.Models.Mapping
{
    public class Emp_TBMap : EntityTypeConfiguration<Emp_TB>
    {
        public Emp_TBMap()
        {
            // Primary Key
            this.HasKey(t => t.emp_id);

            // Properties
            this.Property(t => t.emp_id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.emp_name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Emp_TB");
            this.Property(t => t.emp_id).HasColumnName("emp_id");
            this.Property(t => t.emp_name).HasColumnName("emp_name");
            this.Property(t => t.mgr_emp_id).HasColumnName("mgr_emp_id");
            this.Property(t => t.dept_no).HasColumnName("dept_no");

            // Relationships
            this.HasRequired(t => t.Dept_TB)
                .WithMany(t => t.Emp_TB)
                .HasForeignKey(d => d.dept_no);

        }
    }
}
