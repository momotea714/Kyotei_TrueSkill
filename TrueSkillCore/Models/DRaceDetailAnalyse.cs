using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DRaceDetailAnalyse
    {
        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public int TeiNO1 { get; set; }
        public int FixPlace1 { get; set; }
        public string EntryNO1 { get; set; }
        public int TeiNO2 { get; set; }
        public int FixPlace2 { get; set; }
        public string EntryNO2 { get; set; }
        public int TeiNO3 { get; set; }
        public int FixPlace3 { get; set; }
        public string EntryNO3 { get; set; }
        public int TeiNO4 { get; set; }
        public int FixPlace4 { get; set; }
        public string EntryNO4 { get; set; }
        public int TeiNO5 { get; set; }
        public int FixPlace5 { get; set; }
        public string EntryNO5 { get; set; }
        public int TeiNO6 { get; set; }
        public int FixPlace6 { get; set; }
        public string EntryNO6 { get; set; }
        public string AnalyseResult { get; set; }
    }
}
