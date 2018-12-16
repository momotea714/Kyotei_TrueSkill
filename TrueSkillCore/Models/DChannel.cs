using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DChannel
    {
        public DChannel()
        {
            this.DChannelRaces = new List<DChannelRace>();
            this.DRaces = new List<DRace>();
        }

        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public System.DateTime EventStartDate { get; set; }
        public Nullable<int> EventDays { get; set; }
        public string GradeCD { get; set; }
        public string RaceName { get; set; }
        public string RaceFullName { get; set; }
        public virtual ICollection<DChannelRace> DChannelRaces { get; set; }
        public virtual ICollection<DRace> DRaces { get; set; }
    }
}
