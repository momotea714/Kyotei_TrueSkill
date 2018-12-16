using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MWinningTrickMap : EntityTypeConfiguration<MWinningTrick>
    {
        public MWinningTrickMap()
        {
            // Primary Key
            this.HasKey(t => t.WinningTrickCD);

            // Properties
            this.Property(t => t.WinningTrickCD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WinningTrickName)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("MWinningTrick");
            this.Property(t => t.WinningTrickCD).HasColumnName("WinningTrickCD");
            this.Property(t => t.WinningTrickName).HasColumnName("WinningTrickName");
        }
    }
}
