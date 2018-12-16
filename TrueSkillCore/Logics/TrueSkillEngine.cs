using Moserware.Skills;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSkillCore.Biz;
using TrueSkillCore.Models;

namespace TrueSkillCore
{
    public class TrueSkillEngine
    {
        #region Member

        private KYOTEIContext _db = new KYOTEIContext();
        private Dictionary<int, string> playerIdToRiderIdDic = new Dictionary<int, string>();
        
        #endregion
        
        #region Property

        public Dictionary<string, KyoteiTrueSkill> KyoteiTrueSkillDic = new Dictionary<string, KyoteiTrueSkill>();

        #endregion

        #region Public-Method

        public void Analyze(DateTime fromDate, DateTime toDate)
        {
            var span = toDate - fromDate;
            var changingFromDate = fromDate;
            var fromToDic = new Dictionary<DateTime, DateTime>();
            var divideDate = 180;
            if (span.Days > divideDate)
            {
                var nensuu = Math.Ceiling((decimal)span.Days / (decimal)divideDate);
                for (int i = 0; i < nensuu; i++)
                {
                    var endDate = changingFromDate.AddDays(divideDate);
                    if (endDate < toDate)
                    {
                        fromToDic.Add(changingFromDate, endDate);
                    }
                    else
                    {
                        fromToDic.Add(changingFromDate, toDate);
                    }
                    changingFromDate = endDate.AddDays(1);
                }
            }
            else
            {
                fromToDic.Add(fromDate, toDate);
            }

            var teiNORiders = _db.DRaceDetails.Where(x => x.EventDate >= fromDate
                                                        && x.EventDate <= toDate)
                                              .GroupBy(x => new { x.EntryNO, x.TeiNO })
                                         .Select(x => x.Key);
            var gameInfo = GameInfo.DefaultGameInfo;

            var id = 1;
            foreach (var rider in teiNORiders.GroupBy(x => x.EntryNO).Select(x => x.Key))
            {
                KyoteiTrueSkillDic.Add(rider, new KyoteiTrueSkill(id,rider, 0));
                playerIdToRiderIdDic.Add(id, rider);
                id = id + 1;
            }

            foreach (var rider in teiNORiders)
            {
                var riderId = GetRiderId(rider.EntryNO, rider.TeiNO);
                KyoteiTrueSkillDic.Add(riderId, new KyoteiTrueSkill(id,rider.EntryNO, rider.TeiNO));
                playerIdToRiderIdDic.Add(id, riderId);
                id = id + 1;
            }

            foreach (var fromTo in fromToDic)
            {
                var from = fromTo.Key;
                var to = fromTo.Value;

                using (var db = new KYOTEIContext())
                {
                    var raceDetails = db.DRaceDetails.Where(x => x.EventDate >= from
                                                        && x.EventDate <= to)
                                                  .GroupBy(x => new { x.EventDate, x.TrackCD, x.RaceNO })
                                                  .ToList();
                    foreach (var race in raceDetails)
                    {
                        var ts = race.Select(x =>
                            new
                            {
                                Team = KyoteiTrueSkillDic[x.EntryNO].Team(gameInfo),
                                TeiNOTeam = KyoteiTrueSkillDic[GetRiderId(x.EntryNO,x.TeiNO)].Team(gameInfo),
                                Rank = GetFixPlace(x.FixPlace)
                            });

                        //総合値レーティング
                        SetRating(gameInfo, ts.Select(x => x.Team).ToArray(), ts.Select(x => x.Rank).ToArray());
                        //艇番毎レーティング
                        SetRating(gameInfo, ts.Select(x => x.TeiNOTeam).ToArray(), ts.Select(x => x.Rank).ToArray());
                    }
                }
            }
        }

        public void ExportCSV()
        {
            try
            {
                // appendをtrueにすると，既存のファイルに追記
                //         falseにすると，ファイルを新規作成する
                var append = false;
                // 出力用のファイルを開く
                using (var sw = new System.IO.StreamWriter(@"C:\Users\USER\Desktop\test.csv", append))
                {
                    sw.WriteLine("{0}, {1}, {2},{3},{4}", "EntryNO","艇番", "Mean", "ConservativeRating", "StandardDeviation");

                    foreach (var kyoteiTrueSkill in KyoteiTrueSkillDic)
                    {

                        try
                        {
                            sw.WriteLine("{0}, {1}, {2},{3},{4}",
                            kyoteiTrueSkill.Value.EntryNO,
                            kyoteiTrueSkill.Value.TeiNO,
                            kyoteiTrueSkill.Value.Rating.Mean,
                            kyoteiTrueSkill.Value.Rating.ConservativeRating,
                            kyoteiTrueSkill.Value.Rating.StandardDeviation);
                        }
                        catch (Exception)
                        {

                        }
                    }
                }
            }
            catch (System.Exception e)
            {
                // ファイルを開くのに失敗したときエラーメッセージを表示
                System.Console.WriteLine(e.Message);
            }
        }

        #endregion

        #region Private-Method

        private void SetRating(GameInfo info, Team[] teamArray,int[] rankArray)
        {
            var teams = Teams.Concat(teamArray);
            var newRatings = TrueSkillCalculator.CalculateNewRatings(info, teams, rankArray);

            foreach (var newRating in newRatings)
            {
                var key = playerIdToRiderIdDic[(int)newRating.Key.Id];
                KyoteiTrueSkillDic[key].Rating = newRating.Value;
            }
        }

        private string GetRiderId(string entryNO,int teiNO)
        {
            return entryNO + "_" + teiNO.ToString();
        }

        private int GetFixPlace(string fixPlace)
        {
            int val;
            if (int.TryParse(fixPlace, out val))
            {
                return val;
            }

            if (fixPlace == "L0" || fixPlace == "K0" || fixPlace == "S0")
            {
                return 4;
            }
            else
            {
                return 6;
            }
        }

        #endregion

    }
}
