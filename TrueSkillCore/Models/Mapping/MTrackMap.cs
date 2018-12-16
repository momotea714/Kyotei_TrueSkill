using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MTrackMap : EntityTypeConfiguration<MTrack>
    {
        public MTrackMap()
        {
            // Primary Key
            this.HasKey(t => t.TrackCD);

            // Properties
            this.Property(t => t.TrackCD)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TrackName)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("MTrack");
            this.Property(t => t.TrackCD).HasColumnName("TrackCD");
            this.Property(t => t.TrackName).HasColumnName("TrackName");
        }
    }
}
