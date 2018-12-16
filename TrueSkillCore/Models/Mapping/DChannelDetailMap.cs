using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DChannelDetailMap : EntityTypeConfiguration<DChannelDetail>
    {
        public DChannelDetailMap()
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

            this.Property(t => t.EntryNO)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("DChannelDetail");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.TeiNO).HasColumnName("TeiNO");
            this.Property(t => t.EntryNO).HasColumnName("EntryNO");
            this.Property(t => t.NationalScoringRate).HasColumnName("NationalScoringRate");
            this.Property(t => t.NationalMultiplePercentage).HasColumnName("NationalMultiplePercentage");
            this.Property(t => t.LocalScoringRate).HasColumnName("LocalScoringRate");
            this.Property(t => t.LocalMultiplePercentage).HasColumnName("LocalMultiplePercentage");
            this.Property(t => t.MoterNO).HasColumnName("MoterNO");
            this.Property(t => t.MoterMultiplePercentage).HasColumnName("MoterMultiplePercentage");
            this.Property(t => t.BoatNO).HasColumnName("BoatNO");
            this.Property(t => t.BoatMultiplePercentage).HasColumnName("BoatMultiplePercentage");

            // Relationships
            this.HasRequired(t => t.DChannelRace)
                .WithMany(t => t.DChannelDetails)
                .HasForeignKey(d => new { d.EventDate, d.TrackCD, d.RaceNO });

        }
    }
}
