using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TrueSkillCore.Models.Mapping
{
    public class MRiderMap : EntityTypeConfiguration<MRider>
    {
        public MRiderMap()
        {
            // Primary Key
            this.HasKey(t => new { t.KaiteiDate, t.EntryNO });

            // Properties
            this.Property(t => t.EntryNO)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.RiderName)
                .HasMaxLength(16);

            this.Property(t => t.RiderNameKana)
                .HasMaxLength(15);

            this.Property(t => t.Branch)
                .HasMaxLength(4);

            this.Property(t => t.Class)
                .HasMaxLength(2);

            this.Property(t => t.Era)
                .HasMaxLength(1);

            this.Property(t => t.BirthDay)
                .HasMaxLength(6);

            this.Property(t => t.SexCD)
                .HasMaxLength(1);

            this.Property(t => t.BloodType)
                .HasMaxLength(2);

            this.Property(t => t.PreviousClass)
                .HasMaxLength(2);

            this.Property(t => t.SecondLastClass)
                .HasMaxLength(2);

            this.Property(t => t.ThirdLastClass)
                .HasMaxLength(2);

            this.Property(t => t.BirthPlace)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("MRider");
            this.Property(t => t.KaiteiDate).HasColumnName("KaiteiDate");
            this.Property(t => t.EntryNO).HasColumnName("EntryNO");
            this.Property(t => t.RiderName).HasColumnName("RiderName");
            this.Property(t => t.RiderNameKana).HasColumnName("RiderNameKana");
            this.Property(t => t.Branch).HasColumnName("Branch");
            this.Property(t => t.Class).HasColumnName("Class");
            this.Property(t => t.Era).HasColumnName("Era");
            this.Property(t => t.BirthDay).HasColumnName("BirthDay");
            this.Property(t => t.SexCD).HasColumnName("SexCD");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Height).HasColumnName("Height");
            this.Property(t => t.Weight).HasColumnName("Weight");
            this.Property(t => t.BloodType).HasColumnName("BloodType");
            this.Property(t => t.WinningRate).HasColumnName("WinningRate");
            this.Property(t => t.MultipleWinningRate).HasColumnName("MultipleWinningRate");
            this.Property(t => t.FirstPlaceCount).HasColumnName("FirstPlaceCount");
            this.Property(t => t.SecondPlaceCount).HasColumnName("SecondPlaceCount");
            this.Property(t => t.RaceCount).HasColumnName("RaceCount");
            this.Property(t => t.ChampionshipRaceCount).HasColumnName("ChampionshipRaceCount");
            this.Property(t => t.ChampionshipRaceWonCount).HasColumnName("ChampionshipRaceWonCount");
            this.Property(t => t.AverageStartTiming).HasColumnName("AverageStartTiming");
            this.Property(t => t.FirstCourceEnterCount).HasColumnName("FirstCourceEnterCount");
            this.Property(t => t.FirstCourceMultipleWinningPercentage).HasColumnName("FirstCourceMultipleWinningPercentage");
            this.Property(t => t.FirstCourceAverageStartTiming).HasColumnName("FirstCourceAverageStartTiming");
            this.Property(t => t.FirstCourceAverageStartRank).HasColumnName("FirstCourceAverageStartRank");
            this.Property(t => t.SecondCourceEnterCount).HasColumnName("SecondCourceEnterCount");
            this.Property(t => t.SecondCourceMultipleWinningPercentage).HasColumnName("SecondCourceMultipleWinningPercentage");
            this.Property(t => t.SecondCourceAverageStartTiming).HasColumnName("SecondCourceAverageStartTiming");
            this.Property(t => t.SecondCourceAverageStartRank).HasColumnName("SecondCourceAverageStartRank");
            this.Property(t => t.ThirdCourceEnterCount).HasColumnName("ThirdCourceEnterCount");
            this.Property(t => t.ThirdCourceMultipleWinningPercentage).HasColumnName("ThirdCourceMultipleWinningPercentage");
            this.Property(t => t.ThirdCourceAverageStartTiming).HasColumnName("ThirdCourceAverageStartTiming");
            this.Property(t => t.ThirdCourceAverageStartRank).HasColumnName("ThirdCourceAverageStartRank");
            this.Property(t => t.FourthCourceEnterCount).HasColumnName("FourthCourceEnterCount");
            this.Property(t => t.FourthCourceMultipleWinningPercentage).HasColumnName("FourthCourceMultipleWinningPercentage");
            this.Property(t => t.FourthCourceAverageStartTiming).HasColumnName("FourthCourceAverageStartTiming");
            this.Property(t => t.FourthCourceAverageStartRank).HasColumnName("FourthCourceAverageStartRank");
            this.Property(t => t.FifthCourceEnterCount).HasColumnName("FifthCourceEnterCount");
            this.Property(t => t.FifthCourceMultipleWinningPercentage).HasColumnName("FifthCourceMultipleWinningPercentage");
            this.Property(t => t.FifthCourceAverageStartTiming).HasColumnName("FifthCourceAverageStartTiming");
            this.Property(t => t.FifthCourceAverageStartRank).HasColumnName("FifthCourceAverageStartRank");
            this.Property(t => t.SixthCourceEnterCount).HasColumnName("SixthCourceEnterCount");
            this.Property(t => t.SixthCourceMultipleWinningPercentage).HasColumnName("SixthCourceMultipleWinningPercentage");
            this.Property(t => t.SixthCourceAverageStartTiming).HasColumnName("SixthCourceAverageStartTiming");
            this.Property(t => t.SixthCourceAverageStartRank).HasColumnName("SixthCourceAverageStartRank");
            this.Property(t => t.PreviousClass).HasColumnName("PreviousClass");
            this.Property(t => t.SecondLastClass).HasColumnName("SecondLastClass");
            this.Property(t => t.ThirdLastClass).HasColumnName("ThirdLastClass");
            this.Property(t => t.PreviousAbilityIndex).HasColumnName("PreviousAbilityIndex");
            this.Property(t => t.AbilityIndex).HasColumnName("AbilityIndex");
            this.Property(t => t.Year).HasColumnName("Year");
            this.Property(t => t.Period).HasColumnName("Period");
            this.Property(t => t.CalculatedStartDate).HasColumnName("CalculatedStartDate");
            this.Property(t => t.CalculatedEndDate).HasColumnName("CalculatedEndDate");
            this.Property(t => t.TrainingPeriod).HasColumnName("TrainingPeriod");
            this.Property(t => t.FirstCourceFirstPlaceCount).HasColumnName("FirstCourceFirstPlaceCount");
            this.Property(t => t.FirstCourceSecondPlaceCount).HasColumnName("FirstCourceSecondPlaceCount");
            this.Property(t => t.FirstCourceThirdPlaceCount).HasColumnName("FirstCourceThirdPlaceCount");
            this.Property(t => t.FirstCourceFourthPlaceCount).HasColumnName("FirstCourceFourthPlaceCount");
            this.Property(t => t.FirstCourceFifthPlaceCount).HasColumnName("FirstCourceFifthPlaceCount");
            this.Property(t => t.FirstCourceSixthPlaceCount).HasColumnName("FirstCourceSixthPlaceCount");
            this.Property(t => t.FirstCourceFCount).HasColumnName("FirstCourceFCount");
            this.Property(t => t.FirstCourceL0Count).HasColumnName("FirstCourceL0Count");
            this.Property(t => t.FirstCourceL1Count).HasColumnName("FirstCourceL1Count");
            this.Property(t => t.FirstCourceK0Count).HasColumnName("FirstCourceK0Count");
            this.Property(t => t.FirstCourceK1Count).HasColumnName("FirstCourceK1Count");
            this.Property(t => t.FirstCourceS0Count).HasColumnName("FirstCourceS0Count");
            this.Property(t => t.FirstCourceS1Count).HasColumnName("FirstCourceS1Count");
            this.Property(t => t.FirstCourceS2Count).HasColumnName("FirstCourceS2Count");
            this.Property(t => t.SecondCourceFirstPlaceCount).HasColumnName("SecondCourceFirstPlaceCount");
            this.Property(t => t.SecondCourceSecondPlaceCount).HasColumnName("SecondCourceSecondPlaceCount");
            this.Property(t => t.SecondCourceThirdPlaceCount).HasColumnName("SecondCourceThirdPlaceCount");
            this.Property(t => t.SecondCourceFourthPlaceCount).HasColumnName("SecondCourceFourthPlaceCount");
            this.Property(t => t.SecondCourceFifthPlaceCount).HasColumnName("SecondCourceFifthPlaceCount");
            this.Property(t => t.SecondCourceSixthPlaceCount).HasColumnName("SecondCourceSixthPlaceCount");
            this.Property(t => t.SecondCourceFCount).HasColumnName("SecondCourceFCount");
            this.Property(t => t.SecondCourceL0Count).HasColumnName("SecondCourceL0Count");
            this.Property(t => t.SecondCourceL1Count).HasColumnName("SecondCourceL1Count");
            this.Property(t => t.SecondCourceK0Count).HasColumnName("SecondCourceK0Count");
            this.Property(t => t.SecondCourceK1Count).HasColumnName("SecondCourceK1Count");
            this.Property(t => t.SecondCourceS0Count).HasColumnName("SecondCourceS0Count");
            this.Property(t => t.SecondCourceS1Count).HasColumnName("SecondCourceS1Count");
            this.Property(t => t.SecondCourceS2Count).HasColumnName("SecondCourceS2Count");
            this.Property(t => t.ThirdCourceFirstPlaceCount).HasColumnName("ThirdCourceFirstPlaceCount");
            this.Property(t => t.ThirdCourceSecondPlaceCount).HasColumnName("ThirdCourceSecondPlaceCount");
            this.Property(t => t.ThirdCourceThirdPlaceCount).HasColumnName("ThirdCourceThirdPlaceCount");
            this.Property(t => t.ThirdCourceFourthPlaceCount).HasColumnName("ThirdCourceFourthPlaceCount");
            this.Property(t => t.ThirdCourceFifthPlaceCount).HasColumnName("ThirdCourceFifthPlaceCount");
            this.Property(t => t.ThirdCourceSixthPlaceCount).HasColumnName("ThirdCourceSixthPlaceCount");
            this.Property(t => t.ThirdCourceFCount).HasColumnName("ThirdCourceFCount");
            this.Property(t => t.ThirdCourceL0Count).HasColumnName("ThirdCourceL0Count");
            this.Property(t => t.ThirdCourceL1Count).HasColumnName("ThirdCourceL1Count");
            this.Property(t => t.ThirdCourceK0Count).HasColumnName("ThirdCourceK0Count");
            this.Property(t => t.ThirdCourceK1Count).HasColumnName("ThirdCourceK1Count");
            this.Property(t => t.ThirdCourceS0Count).HasColumnName("ThirdCourceS0Count");
            this.Property(t => t.ThirdCourceS1Count).HasColumnName("ThirdCourceS1Count");
            this.Property(t => t.ThirdCourceS2Count).HasColumnName("ThirdCourceS2Count");
            this.Property(t => t.FourthCourceFirstPlaceCount).HasColumnName("FourthCourceFirstPlaceCount");
            this.Property(t => t.FourthCourceSecondPlaceCount).HasColumnName("FourthCourceSecondPlaceCount");
            this.Property(t => t.FourthCourceThirdPlaceCount).HasColumnName("FourthCourceThirdPlaceCount");
            this.Property(t => t.FourthCourceFourthPlaceCount).HasColumnName("FourthCourceFourthPlaceCount");
            this.Property(t => t.FourthCourceFifthPlaceCount).HasColumnName("FourthCourceFifthPlaceCount");
            this.Property(t => t.FourthCourceSixthPlaceCount).HasColumnName("FourthCourceSixthPlaceCount");
            this.Property(t => t.FourthCourceFCount).HasColumnName("FourthCourceFCount");
            this.Property(t => t.FourthCourceL0Count).HasColumnName("FourthCourceL0Count");
            this.Property(t => t.FourthCourceL1Count).HasColumnName("FourthCourceL1Count");
            this.Property(t => t.FourthCourceK0Count).HasColumnName("FourthCourceK0Count");
            this.Property(t => t.FourthCourceK1Count).HasColumnName("FourthCourceK1Count");
            this.Property(t => t.FourthCourceS0Count).HasColumnName("FourthCourceS0Count");
            this.Property(t => t.FourthCourceS1Count).HasColumnName("FourthCourceS1Count");
            this.Property(t => t.FourthCourceS2Count).HasColumnName("FourthCourceS2Count");
            this.Property(t => t.FifthCourceFirstPlaceCount).HasColumnName("FifthCourceFirstPlaceCount");
            this.Property(t => t.FifthCourceSecondPlaceCount).HasColumnName("FifthCourceSecondPlaceCount");
            this.Property(t => t.FifthCourceThirdPlaceCount).HasColumnName("FifthCourceThirdPlaceCount");
            this.Property(t => t.FifthCourceFourthPlaceCount).HasColumnName("FifthCourceFourthPlaceCount");
            this.Property(t => t.FifthCourceFifthPlaceCount).HasColumnName("FifthCourceFifthPlaceCount");
            this.Property(t => t.FifthCourceSixthPlaceCount).HasColumnName("FifthCourceSixthPlaceCount");
            this.Property(t => t.FifthCourceFCount).HasColumnName("FifthCourceFCount");
            this.Property(t => t.FifthCourceL0Count).HasColumnName("FifthCourceL0Count");
            this.Property(t => t.FifthCourceL1Count).HasColumnName("FifthCourceL1Count");
            this.Property(t => t.FifthCourceK0Count).HasColumnName("FifthCourceK0Count");
            this.Property(t => t.FifthCourceK1Count).HasColumnName("FifthCourceK1Count");
            this.Property(t => t.FifthCourceS0Count).HasColumnName("FifthCourceS0Count");
            this.Property(t => t.FifthCourceS1Count).HasColumnName("FifthCourceS1Count");
            this.Property(t => t.FifthCourceS2Count).HasColumnName("FifthCourceS2Count");
            this.Property(t => t.SixthCourceFirstPlaceCount).HasColumnName("SixthCourceFirstPlaceCount");
            this.Property(t => t.SixthCourceSecondPlaceCount).HasColumnName("SixthCourceSecondPlaceCount");
            this.Property(t => t.SixthCourceThirdPlaceCount).HasColumnName("SixthCourceThirdPlaceCount");
            this.Property(t => t.SixthCourceFourthPlaceCount).HasColumnName("SixthCourceFourthPlaceCount");
            this.Property(t => t.SixthCourceFifthPlaceCount).HasColumnName("SixthCourceFifthPlaceCount");
            this.Property(t => t.SixthCourceSixthPlaceCount).HasColumnName("SixthCourceSixthPlaceCount");
            this.Property(t => t.SixthCourceFCount).HasColumnName("SixthCourceFCount");
            this.Property(t => t.SixthCourceL0Count).HasColumnName("SixthCourceL0Count");
            this.Property(t => t.SixthCourceL1Count).HasColumnName("SixthCourceL1Count");
            this.Property(t => t.SixthCourceK0Count).HasColumnName("SixthCourceK0Count");
            this.Property(t => t.SixthCourceK1Count).HasColumnName("SixthCourceK1Count");
            this.Property(t => t.SixthCourceS0Count).HasColumnName("SixthCourceS0Count");
            this.Property(t => t.SixthCourceS1Count).HasColumnName("SixthCourceS1Count");
            this.Property(t => t.SixthCourceS2Count).HasColumnName("SixthCourceS2Count");
            this.Property(t => t.NoCourceL0Count).HasColumnName("NoCourceL0Count");
            this.Property(t => t.NoCourceL1Count).HasColumnName("NoCourceL1Count");
            this.Property(t => t.NoCourceK0Count).HasColumnName("NoCourceK0Count");
            this.Property(t => t.NoCourceK1Count).HasColumnName("NoCourceK1Count");
            this.Property(t => t.BirthPlace).HasColumnName("BirthPlace");
        }
    }
}
