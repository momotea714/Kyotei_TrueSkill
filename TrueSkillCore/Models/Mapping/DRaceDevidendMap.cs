using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DRaceDevidendMap : EntityTypeConfiguration<DRaceDevidend>
    {
        public DRaceDevidendMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD, t.RaceNO, t.DividendCategoryCD, t.GyouNO });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DividendCategoryCD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.GyouNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Result)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DRaceDevidend");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.DividendCategoryCD).HasColumnName("DividendCategoryCD");
            this.Property(t => t.GyouNO).HasColumnName("GyouNO");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.Dividend).HasColumnName("Dividend");

            // Relationships
            this.HasRequired(t => t.DRace)
                .WithMany(t => t.DRaceDevidends)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD, d.RaceNO });

        }
    }
}
