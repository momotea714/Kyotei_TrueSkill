using System;
using System.Collections.Generic;

namespace TrueSkillCore.Models
{
    public partial class DRace
    {
        public DRace()
        {
            this.DRaceDetails = new List<DRaceDetail>();
            this.DRaceDetails1 = new List<DRaceDetail>();
            this.DRaceDevidends = new List<DRaceDevidend>();
        }

        public System.DateTime EventDate { get; set; }
        public int TrackCD { get; set; }
        public int RaceNO { get; set; }
        public Nullable<int> EventDays { get; set; }
        public string WeatherCD { get; set; }
        public string WindDirectionCD { get; set; }
        public Nullable<int> WindSpeed { get; set; }
        public Nullable<int> WaveHeight { get; set; }
        public bool FailureRaceFlag { get; set; }
        public virtual DChannel DChannel { get; set; }
        public virtual ICollection<DRaceDetail> DRaceDetails { get; set; }
        public virtual ICollection<DRaceDetail> DRaceDetails1 { get; set; }
        public virtual ICollection<DRaceDevidend> DRaceDevidends { get; set; }
    }
}
