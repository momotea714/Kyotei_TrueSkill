using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class DChannelMap : EntityTypeConfiguration<DChannel>
    {
        public DChannelMap()
        {
            // Primary Key
            this.HasKey(t => new { t.EventDate, t.TrackCD });

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GradeCD)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.RaceName)
                .HasMaxLength(20);

            this.Property(t => t.RaceFullName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("DChannel");
            this.Property(t => t.EventDate).HasColumnName("EventDate");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
            this.Property(t => t.EventDays).HasColumnName("EventDays");
            this.Property(t => t.GradeCD).HasColumnName("GradeCD");
            this.Property(t => t.RaceName).HasColumnName("RaceName");
            this.Property(t => t.RaceFullName).HasColumnName("RaceFullName");
        }
    }
}
