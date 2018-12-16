using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrueSkillCore;
using TrueSkillCore.Logics;
using Vote;

namespace TrueSkillExecutor
{
    class Program
    {
        static void Main(string[] args)
        {
            //var scraping = new ScrapingCore();
            //scraping.GetRaceResult().Wait();



            //var vote = new VoteCore();
            //vote.Vote().Wait();

            //TrueSkillSamples.RunSamples();


            var engine = new TrueSkillEngine();
            engine.Analyze(new DateTime(2018, 1, 1), DateTime.Today);
            engine.ExportCSV();
        }
    }
}
