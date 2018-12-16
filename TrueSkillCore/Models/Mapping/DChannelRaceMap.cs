using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DChannelRaceMap : EntityTypeConfiguration<DChannelRace>
    {
        public DChannelRaceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD, t.RaceNO });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceCategoryCD)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("DChannelRace");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.RaceCategoryCD).HasColumnName("RaceCategoryCD");
            this.Property(t => t.CloseTime).HasColumnName("CloseTime");

            // Relationships
            this.HasRequired(t => t.DChannel)
                .WithMany(t => t.DChannelRaces)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD });

        }
    }
}
