using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DRaceDevidend
    {
        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public string DividendCategoryCD { get; set; }
        public int GyouNO { get; set; }
        public string Result { get; set; }
        public Nullable<int> Dividend { get; set; }
        public virtual DRace DRace { get; set; }
    }
}
