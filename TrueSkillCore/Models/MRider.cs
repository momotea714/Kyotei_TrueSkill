using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class MRider
    {
        public System.DateTime KaiteiDate { get; set; }
        public string EntryNO { get; set; }
        public string RiderName { get; set; }
        public string RiderNameKana { get; set; }
        public string Branch { get; set; }
        public string Class { get; set; }
        public string Era { get; set; }
        public string BirthDay { get; set; }
        public string SexCD { get; set; }
        public Nullable<byte> Age { get; set; }
        public Nullable<byte> Height { get; set; }
        public Nullable<byte> Weight { get; set; }
        public string BloodType { get; set; }
        public Nullable<decimal> WinningRate { get; set; }
        public Nullable<decimal> MultipleWinningRate { get; set; }
        public Nullable<int> FirstPlaceCount { get; set; }
        public Nullable<int> SecondPlaceCount { get; set; }
        public Nullable<int> RaceCount { get; set; }
        public Nullable<int> ChampionshipRaceCount { get; set; }
        public Nullable<int> ChampionshipRaceWonCount { get; set; }
        public Nullable<decimal> AverageStartTiming { get; set; }
        public Nullable<int> FirstCourceEnterCount { get; set; }
        public Nullable<decimal> FirstCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> FirstCourceAverageStartTiming { get; set; }
        public Nullable<decimal> FirstCourceAverageStartRank { get; set; }
        public Nullable<int> SecondCourceEnterCount { get; set; }
        public Nullable<decimal> SecondCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> SecondCourceAverageStartTiming { get; set; }
        public Nullable<decimal> SecondCourceAverageStartRank { get; set; }
        public Nullable<int> ThirdCourceEnterCount { get; set; }
        public Nullable<decimal> ThirdCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> ThirdCourceAverageStartTiming { get; set; }
        public Nullable<decimal> ThirdCourceAverageStartRank { get; set; }
        public Nullable<int> FourthCourceEnterCount { get; set; }
        public Nullable<decimal> FourthCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> FourthCourceAverageStartTiming { get; set; }
        public Nullable<decimal> FourthCourceAverageStartRank { get; set; }
        public Nullable<int> FifthCourceEnterCount { get; set; }
        public Nullable<decimal> FifthCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> FifthCourceAverageStartTiming { get; set; }
        public Nullable<decimal> FifthCourceAverageStartRank { get; set; }
        public Nullable<int> SixthCourceEnterCount { get; set; }
        public Nullable<decimal> SixthCourceMultipleWinningPercentage { get; set; }
        public Nullable<decimal> SixthCourceAverageStartTiming { get; set; }
        public Nullable<decimal> SixthCourceAverageStartRank { get; set; }
        public string PreviousClass { get; set; }
        public string SecondLastClass { get; set; }
        public string ThirdLastClass { get; set; }
        public Nullable<decimal> PreviousAbilityIndex { get; set; }
        public Nullable<decimal> AbilityIndex { get; set; }
        public Nullable<short> Year { get; set; }
        public Nullable<byte> Period { get; set; }
        public Nullable<System.DateTime> CalculatedStartDate { get; set; }
        public Nullable<System.DateTime> CalculatedEndDate { get; set; }
        public Nullable<short> TrainingPeriod { get; set; }
        public Nullable<short> FirstCourceFirstPlaceCount { get; set; }
        public Nullable<short> FirstCourceSecondPlaceCount { get; set; }
        public Nullable<short> FirstCourceThirdPlaceCount { get; set; }
        public Nullable<short> FirstCourceFourthPlaceCount { get; set; }
        public Nullable<short> FirstCourceFifthPlaceCount { get; set; }
        public Nullable<short> FirstCourceSixthPlaceCount { get; set; }
        public Nullable<short> FirstCourceFCount { get; set; }
        public Nullable<short> FirstCourceL0Count { get; set; }
        public Nullable<short> FirstCourceL1Count { get; set; }
        public Nullable<short> FirstCourceK0Count { get; set; }
        public Nullable<short> FirstCourceK1Count { get; set; }
        public Nullable<short> FirstCourceS0Count { get; set; }
        public Nullable<short> FirstCourceS1Count { get; set; }
        public Nullable<short> FirstCourceS2Count { get; set; }
        public Nullable<short> SecondCourceFirstPlaceCount { get; set; }
        public Nullable<short> SecondCourceSecondPlaceCount { get; set; }
        public Nullable<short> SecondCourceThirdPlaceCount { get; set; }
        public Nullable<short> SecondCourceFourthPlaceCount { get; set; }
        public Nullable<short> SecondCourceFifthPlaceCount { get; set; }
        public Nullable<short> SecondCourceSixthPlaceCount { get; set; }
        public Nullable<short> SecondCourceFCount { get; set; }
        public Nullable<short> SecondCourceL0Count { get; set; }
        public Nullable<short> SecondCourceL1Count { get; set; }
        public Nullable<short> SecondCourceK0Count { get; set; }
        public Nullable<short> SecondCourceK1Count { get; set; }
        public Nullable<short> SecondCourceS0Count { get; set; }
        public Nullable<short> SecondCourceS1Count { get; set; }
        public Nullable<short> SecondCourceS2Count { get; set; }
        public Nullable<short> ThirdCourceFirstPlaceCount { get; set; }
        public Nullable<short> ThirdCourceSecondPlaceCount { get; set; }
        public Nullable<short> ThirdCourceThirdPlaceCount { get; set; }
        public Nullable<short> ThirdCourceFourthPlaceCount { get; set; }
        public Nullable<short> ThirdCourceFifthPlaceCount { get; set; }
        public Nullable<short> ThirdCourceSixthPlaceCount { get; set; }
        public Nullable<short> ThirdCourceFCount { get; set; }
        public Nullable<short> ThirdCourceL0Count { get; set; }
        public Nullable<short> ThirdCourceL1Count { get; set; }
        public Nullable<short> ThirdCourceK0Count { get; set; }
        public Nullable<short> ThirdCourceK1Count { get; set; }
        public Nullable<short> ThirdCourceS0Count { get; set; }
        public Nullable<short> ThirdCourceS1Count { get; set; }
        public Nullable<short> ThirdCourceS2Count { get; set; }
        public Nullable<short> FourthCourceFirstPlaceCount { get; set; }
        public Nullable<short> FourthCourceSecondPlaceCount { get; set; }
        public Nullable<short> FourthCourceThirdPlaceCount { get; set; }
        public Nullable<short> FourthCourceFourthPlaceCount { get; set; }
        public Nullable<short> FourthCourceFifthPlaceCount { get; set; }
        public Nullable<short> FourthCourceSixthPlaceCount { get; set; }
        public Nullable<short> FourthCourceFCount { get; set; }
        public Nullable<short> FourthCourceL0Count { get; set; }
        public Nullable<short> FourthCourceL1Count { get; set; }
        public Nullable<short> FourthCourceK0Count { get; set; }
        public Nullable<short> FourthCourceK1Count { get; set; }
        public Nullable<short> FourthCourceS0Count { get; set; }
        public Nullable<short> FourthCourceS1Count { get; set; }
        public Nullable<short> FourthCourceS2Count { get; set; }
        public Nullable<short> FifthCourceFirstPlaceCount { get; set; }
        public Nullable<short> FifthCourceSecondPlaceCount { get; set; }
        public Nullable<short> FifthCourceThirdPlaceCount { get; set; }
        public Nullable<short> FifthCourceFourthPlaceCount { get; set; }
        public Nullable<short> FifthCourceFifthPlaceCount { get; set; }
        public Nullable<short> FifthCourceSixthPlaceCount { get; set; }
        public Nullable<short> FifthCourceFCount { get; set; }
        public Nullable<short> FifthCourceL0Count { get; set; }
        public Nullable<short> FifthCourceL1Count { get; set; }
        public Nullable<short> FifthCourceK0Count { get; set; }
        public Nullable<short> FifthCourceK1Count { get; set; }
        public Nullable<short> FifthCourceS0Count { get; set; }
        public Nullable<short> FifthCourceS1Count { get; set; }
        public Nullable<short> FifthCourceS2Count { get; set; }
        public Nullable<short> SixthCourceFirstPlaceCount { get; set; }
        public Nullable<short> SixthCourceSecondPlaceCount { get; set; }
        public Nullable<short> SixthCourceThirdPlaceCount { get; set; }
        public Nullable<short> SixthCourceFourthPlaceCount { get; set; }
        public Nullable<short> SixthCourceFifthPlaceCount { get; set; }
        public Nullable<short> SixthCourceSixthPlaceCount { get; set; }
        public Nullable<short> SixthCourceFCount { get; set; }
        public Nullable<short> SixthCourceL0Count { get; set; }
        public Nullable<short> SixthCourceL1Count { get; set; }
        public Nullable<short> SixthCourceK0Count { get; set; }
        public Nullable<short> SixthCourceK1Count { get; set; }
        public Nullable<short> SixthCourceS0Count { get; set; }
        public Nullable<short> SixthCourceS1Count { get; set; }
        public Nullable<short> SixthCourceS2Count { get; set; }
        public Nullable<short> NoCourceL0Count { get; set; }
        public Nullable<short> NoCourceL1Count { get; set; }
        public Nullable<short> NoCourceK0Count { get; set; }
        public Nullable<short> NoCourceK1Count { get; set; }
        public string BirthPlace { get; set; }
    }
}
