using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MWindDirectionMap : EntityTypeConfiguration<MWindDirection>
    {
        public MWindDirectionMap()
        {
            // Primary Key
            this.HasKey(t => t.WindDirectionCD);

            // Properties
            this.Property(t => t.WindDirectionCD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WindDirectionName)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("MWindDirection");
            this.Property(t => t.WindDirectionCD).HasColumnName("WindDirectionCD");
            this.Property(t => t.WindDirectionName).HasColumnName("WindDirectionName");
        }
    }
}
