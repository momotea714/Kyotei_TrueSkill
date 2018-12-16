using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DRaceDetailAnalyseMap : EntityTypeConfiguration<DRaceDetailAnalyse>
    {
        public DRaceDetailAnalyseMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD, t.RaceNO, t.TeiNO1, t.TeiNO2, t.TeiNO3, t.TeiNO4, t.TeiNO5, t.TeiNO6 });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RaceNO)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TeiNO1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO1)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TeiNO2)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO2)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TeiNO3)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO3)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TeiNO4)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO4)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TeiNO5)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO5)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.TeiNO6)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.EntryNO6)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.AnalyseResult)
                .IsRequired()
                .HasMaxLength(60);

            // Table & Column Mappings
            this.ToTable("DRaceDetailAnalyse");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.RaceNO).HasColumnName("RaceNO");
            this.Property(t => t.TeiNO1).HasColumnName("TeiNO1");
            this.Property(t => t.FixPlace1).HasColumnName("FixPlace1");
            this.Property(t => t.EntryNO1).HasColumnName("EntryNO1");
            this.Property(t => t.TeiNO2).HasColumnName("TeiNO2");
            this.Property(t => t.FixPlace2).HasColumnName("FixPlace2");
            this.Property(t => t.EntryNO2).HasColumnName("EntryNO2");
            this.Property(t => t.TeiNO3).HasColumnName("TeiNO3");
            this.Property(t => t.FixPlace3).HasColumnName("FixPlace3");
            this.Property(t => t.EntryNO3).HasColumnName("EntryNO3");
            this.Property(t => t.TeiNO4).HasColumnName("TeiNO4");
            this.Property(t => t.FixPlace4).HasColumnName("FixPlace4");
            this.Property(t => t.EntryNO4).HasColumnName("EntryNO4");
            this.Property(t => t.TeiNO5).HasColumnName("TeiNO5");
            this.Property(t => t.FixPlace5).HasColumnName("FixPlace5");
            this.Property(t => t.EntryNO5).HasColumnName("EntryNO5");
            this.Property(t => t.TeiNO6).HasColumnName("TeiNO6");
            this.Property(t => t.FixPlace6).HasColumnName("FixPlace6");
            this.Property(t => t.EntryNO6).HasColumnName("EntryNO6");
            this.Property(t => t.AnalyseResult).HasColumnName("AnalyseResult");
        }
    }
}
