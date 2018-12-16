using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DRaceDetail
    {
        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public int TeiNO { get; set; }
        public string FixPlace { get; set; }
        public string EntryNO { get; set; }
        public Nullable<int> MoterNO { get; set; }
        public Nullable<int> BoatNO { get; set; }
        public Nullable<decimal> ShowTime { get; set; }
        public Nullable<int> EntryCource { get; set; }
        public Nullable<decimal> StartTiming { get; set; }
        public Nullable<decimal> RaceTime { get; set; }
        public string WinningTrickCD { get; set; }
        public bool LateFlag { get; set; }
        public bool FlyingFlag { get; set; }
        public bool SideLinedFlag { get; set; }
        public bool DisqualificationFlag { get; set; }
        public virtual DRace DRace { get; set; }
        public virtual DRace DRace1 { get; set; }
    }
}
