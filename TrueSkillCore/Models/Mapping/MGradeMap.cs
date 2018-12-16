using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MGradeMap : EntityTypeConfiguration<MGrade>
    {
        public MGradeMap()
        {
            // Primary Key
            this.HasKey(t => t.GradeCD);

            // Properties
            this.Property(t => t.GradeCD)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GradeName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MGrade");
            this.Property(t => t.GradeCD).HasColumnName("GradeCD");
            this.Property(t => t.GradeName).HasColumnName("GradeName");
        }
    }
}
