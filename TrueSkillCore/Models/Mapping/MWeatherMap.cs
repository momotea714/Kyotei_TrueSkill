using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MWeatherMap : EntityTypeConfiguration<MWeather>
    {
        public MWeatherMap()
        {
            // Primary Key
            this.HasKey(t => t.WeatherCD);

            // Properties
            this.Property(t => t.WeatherCD)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.WeatherName)
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("MWeather");
            this.Property(t => t.WeatherCD).HasColumnName("WeatherCD");
            this.Property(t => t.WeatherName).HasColumnName("WeatherName");
        }
    }
}
