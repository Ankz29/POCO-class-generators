using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace POCO.Models.Mapping
{
    public class Dept_TBMap : EntityTypeConfiguration<Dept_TB>
    {
        public Dept_TBMap()
        {
            // Primary Key
            this.HasKey(t => t.dept_no);

            // Properties
            this.Property(t => t.dept_no)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.dept_name)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.dept_location)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Dept_TB");
            this.Property(t => t.dept_no).HasColumnName("dept_no");
            this.Property(t => t.dept_name).HasColumnName("dept_name");
            this.Property(t => t.dept_location).HasColumnName("dept_location");
        }
    }
}
