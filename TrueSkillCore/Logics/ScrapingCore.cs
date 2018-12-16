using AngleSharp.Dom.Html;
using AngleSharp.Parser.Html;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrueSkillCore.Models;

namespace TrueSkillCore.Logics
{
    public class ScrapingCore
    {
        public async Task GetRaceResult()
        {
            var urlstring = @"http://boatrace.jp/owpc/pc/race/racelist?rno=12&jcd=01&hd=20181112";

            // 指定したサイトのHTMLをストリームで取得する
            var doc = default(IHtmlDocument);
            using (var client = new HttpClient())
            using (var stream = await client.GetStreamAsync(new Uri(urlstring)))
            {
                // AngleSharp.Parser.Html.HtmlParserオブジェクトにHTMLをパースさせる
                var parser = new HtmlParser();
                doc = await parser.ParseAsync(stream);
            }

            // HTMLからtitleタグの値(サイトのタイトルとして表示される部分)を取得する
            var title = doc.Title;

            var tbodys = doc.QuerySelectorAll(@"body > main > div > div > div > div.contentsFrame1_inner > div:nth-child(4) tbody");

            var details = new List<DRaceDetail>();
            foreach (var tbody in tbodys)
            {
                foreach (var tr in tbody.Children)
                {
                    for (int i = 0; i < tr.Children.Length; i++)
                    {
                        var td = tr.Children[i];
                        if (i == 0)
                        {
                            Debug.WriteLine(td.InnerHtml);
                        }
                        if (i == 2)
                        {
                            for (int t = 0; t < td.Children.Length; t++)
                            {
                                Debug.WriteLine(td.Children[t].InnerHtml);
                            }
                        }

                    }
                }
                var detail = new DRaceDetail
                {
                    
                };
            }

            Debug.WriteLine(title);
        }
    }
}
