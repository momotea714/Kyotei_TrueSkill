using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DRaceMap : EntityTypeConfiguration<DRace>
    {
        public DRaceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD, t.RaceNO });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.WeatherCD)
                .HasMaxLength(10);

            this.Property(t => t.WindDirectionCD)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DRace");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.EventDays).HasColumnName("EventDays");
            this.Property(t => t.WeatherCD).HasColumnName("WeatherCD");
            this.Property(t => t.WindDirectionCD).HasColumnName("WindDirectionCD");
            this.Property(t => t.WindSpeed).HasColumnName("WindSpeed");
            this.Property(t => t.WaveHeight).HasColumnName("WaveHeight");
            this.Property(t => t.FailureRaceFlag).HasColumnName("FailureRaceFlag");

            // Relationships
            this.HasRequired(t => t.DChannel)
                .WithMany(t => t.DRaces)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD });

        }
    }
}
