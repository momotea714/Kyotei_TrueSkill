using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MRaceCategoryMap : EntityTypeConfiguration<MRaceCategory>
    {
        public MRaceCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.RaceCategoryCD);

            // Properties
            this.Property(t => t.RaceCategoryCD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.RaceCategoryName)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("MRaceCategory");
            this.Property(t => t.RaceCategoryCD).HasColumnName("RaceCategoryCD");
            this.Property(t => t.RaceCategoryName).HasColumnName("RaceCategoryName");
        }
    }
}
