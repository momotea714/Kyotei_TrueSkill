using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DChannelDetail
    {
        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public int TeiNO { get; set; }
        public string EntryNO { get; set; }
        public Nullable<decimal> NationalScoringRate { get; set; }
        public Nullable<decimal> NationalMultiplePercentage { get; set; }
        public Nullable<decimal> LocalScoringRate { get; set; }
        public Nullable<decimal> LocalMultiplePercentage { get; set; }
        public Nullable<int> MoterNO { get; set; }
        public Nullable<decimal> MoterMultiplePercentage { get; set; }
        public Nullable<int> BoatNO { get; set; }
        public Nullable<decimal> BoatMultiplePercentage { get; set; }
        public virtual DChannelRace DChannelRace { get; set; }
    }
}
