using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TrueSkillCore.Models.Mapping;

namespace TrueSkillCore.Models
{
    public partial class KYOTEIContext : DbContext
    {
        static KYOTEIContext()
        {
            Database.SetInitializer<KYOTEIContext>(null);
        }

        public KYOTEIContext()
            : base("Name=KYOTEIContext")
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        public DbSet<DChannel> DChannels { get; set; }
        public DbSet<DChannelDetail> DChannelDetails { get; set; }
        public DbSet<DChannelRace> DChannelRaces { get; set; }
        public DbSet<DRace> DRaces { get; set; }
        public DbSet<DRaceDetail> DRaceDetails { get; set; }
        public DbSet<DRaceDetailAnalyse> DRaceDetailAnalyses { get; set; }
        public DbSet<DRaceDevidend> DRaceDevidends { get; set; }
        public DbSet<MDividendCategory> MDividendCategories { get; set; }
        public DbSet<MGrade> MGrades { get; set; }
        public DbSet<MRaceCategory> MRaceCategories { get; set; }
        public DbSet<MRider> MRiders { get; set; }
        public DbSet<MTrack> MTracks { get; set; }
        public DbSet<MWeather> MWeathers { get; set; }
        public DbSet<MWindDirection> MWindDirections { get; set; }
        public DbSet<MWinningTrick> MWinningTricks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DChannelMap());
            modelBuilder.Configurations.Add(new DChannelDetailMap());
            modelBuilder.Configurations.Add(new DChannelRaceMap());
            modelBuilder.Configurations.Add(new DRaceMap());
            modelBuilder.Configurations.Add(new DRaceDetailMap());
            modelBuilder.Configurations.Add(new DRaceDetailAnalyseMap());
            modelBuilder.Configurations.Add(new DRaceDevidendMap());
            modelBuilder.Configurations.Add(new MDividendCategoryMap());
            modelBuilder.Configurations.Add(new MGradeMap());
            modelBuilder.Configurations.Add(new MRaceCategoryMap());
            modelBuilder.Configurations.Add(new MRiderMap());
            modelBuilder.Configurations.Add(new MTrackMap());
            modelBuilder.Configurations.Add(new MWeatherMap());
            modelBuilder.Configurations.Add(new MWindDirectionMap());
            modelBuilder.Configurations.Add(new MWinningTrickMap());
        }
    }
}
