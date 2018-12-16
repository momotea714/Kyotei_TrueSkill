using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MDividendCategoryMap : EntityTypeConfiguration<MDividendCategory>
    {
        public MDividendCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.DividendCategoryCD);

            // Properties
            this.Property(t => t.DividendCategoryCD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DividendCategoryName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MDividendCategory");
            this.Property(t => t.DividendCategoryCD).HasColumnName("DividendCategoryCD");
            this.Property(t => t.DividendCategoryName).HasColumnName("DividendCategoryName");
        }
    }
}
