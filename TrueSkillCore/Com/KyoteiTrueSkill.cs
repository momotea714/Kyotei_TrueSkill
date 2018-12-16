using Moserware.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueSkillCore.Biz
{
    public class KyoteiTrueSkill
    {

        public KyoteiTrueSkill(int id,string entryNO,int teiNO)
        {
            Player = new Player(id);
            EntryNO = entryNO;
            TeiNO = teiNO;
        }

        public string EntryNO { get; set; }
        public int TeiNO { get; set; }
        public Player Player { get; set; }
        public Team Team(GameInfo info)
        {
            if (Rating == null)
            {
                return new Team(Player, info.DefaultRating);
            }
            else
            {
                return new Team(Player, Rating);
            }
        }
        public Rating Rating { get; set; }
    }
}
