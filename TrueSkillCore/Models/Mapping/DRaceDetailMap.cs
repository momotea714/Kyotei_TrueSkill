using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DRaceDetailMap : EntityTypeConfiguration<DRaceDetail>
    {
        public DRaceDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD, t.RaceNO, t.TeiNO });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TeiNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FixPlace)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.EntryNO)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.WinningTrickCD)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("DRaceDetail");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.TeiNO).HasColumnName("TeiNO");
            this.Property(t => t.FixPlace).HasColumnName("FixPlace");
            this.Property(t => t.EntryNO).HasColumnName("EntryNO");
            this.Property(t => t.MoterNO).HasColumnName("MoterNO");
            this.Property(t => t.BoatNO).HasColumnName("BoatNO");
            this.Property(t => t.ShowTime).HasColumnName("ShowTime");
            this.Property(t => t.EntryCource).HasColumnName("EntryCource");
            this.Property(t => t.StartTiming).HasColumnName("StartTiming");
            this.Property(t => t.RaceTime).HasColumnName("RaceTime");
            this.Property(t => t.WinningTrickCD).HasColumnName("WinningTrickCD");
            this.Property(t => t.LateFlag).HasColumnName("LateFlag");
            this.Property(t => t.FlyingFlag).HasColumnName("FlyingFlag");
            this.Property(t => t.SideLinedFlag).HasColumnName("SideLinedFlag");
            this.Property(t => t.DisqualificationFlag).HasColumnName("DisqualificationFlag");

            // Relationships
            this.HasRequired(t => t.DRace)
                .WithMany(t => t.DRaceDetails)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD, d.RaceNO });
            this.HasRequired(t => t.DRace1)
                .WithMany(t => t.DRaceDetails1)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD, d.RaceNO });

        }
    }
}
