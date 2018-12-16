using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DChannelRace
    {
        public DChannelRace()
        {
            this.DChannelDetails = new List<DChannelDetail>();
        }

        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public string RaceCategoryCD { get; set; }
        public Nullable<System.TimeSpan> CloseTime { get; set; }
        public virtual DChannel DChannel { get; set; }
        public virtual ICollection<DChannelDetail> DChannelDetails { get; set; }
    }
}
