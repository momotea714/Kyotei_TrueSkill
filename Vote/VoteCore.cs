using AngleSharp.Parser.Html;
using Mono.Web;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    public class VoteCore
    {
        static Encoding encoder = Encoding.GetEncoding("utf-8");

        public async Task Vote()
        {
            var cc = await Login();
            var vote = await VoteWindow(cc);
        }

        private async Task<string> VoteWindow(CookieContainer cc)
        {
            var cid = string.Empty;
            var r = string.Empty;
            using (var handler = new HttpClientHandler() { CookieContainer = cc })
            using (var client = new HttpClient(handler))
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("inter1", "810d0d634e4f0bced9"),
                    new KeyValuePair<string, string>("inter2", "b653307810fc"),
                    new KeyValuePair<string, string>("inter3", "H0JS00000stContens"),
                });
                client.DefaultRequestHeaders.Referrer = new Uri(@"https://www.boatrace.jp/owpc/VoteBridgeNew.jsp?param=H0JS00000stContens&kbn=1&voteActionUrl=/owpc/pc/site/index.html");
                client.DefaultRequestHeaders.Host = "ib.mbrace.or.jp";
                var result = client.PostAsync(@"https://ib.mbrace.or.jp/tohyo-ap-pctohyo-web/auth/tb_login", content).Result;
                var query = HttpUtility.ParseQueryString(result.RequestMessage.RequestUri.Query);
                cid = query.Get("cid");
                r = query.Get("r");
            }

            var url = @"https://ib.mbrace.or.jp/tohyo-ap-pctohyo-web/service/bet/top/init?cid=" + cid + "&r=" + r;
            var a = HttpGet(url, cc);

            return string.Empty;
        }

        private string MyPage(CookieContainer cc)
        {
            // 足あとページへのアクセス
            string showlog = "https://www.boatrace.jp/owpc/pc/teleboat/mypage";
            return HttpGet(showlog, cc);
        }

        private async Task<CookieContainer> Login()
        {
            var userId = "08317519";
            var authNO = "1457";
            var pass = "tC7Y9A";
            var url = @"https://www.boatrace.jp/owpc/pc/login";

            CookieContainer cc;
            using (var handler = new HttpClientHandler())
            using (var client = new HttpClient(handler))
            {
                //ログイン用のPOSTデータ生成
                var content = new FormUrlEncodedContent(new Dictionary<string, string>
                    {
                        {"orteusPrevForward",@"DEFAULT_TARGET!/TENTP017A.jsp!false"},
                        { "org.apache.struts.taglib.html.TOKEN", "5d3546db2f10cfea8ea7e6aef26f10c9" },
                        { "in_KanyusyaNo", userId },
                        {"in_AnsyoNo",authNO},
                        {"in_PassWord",pass},
                        {"chkRakuraku","false"},
                        {"in_AuthAfterUrl",@"/"},
                        {"orteusElements","true"},
                        {"com.nec.jp.orteusActionMethod.login","controlLogin"},
                        {"login","Submit"},
                    });

                //ログイン
                var httpResponse = await client.PostAsync(url, content);
                //クッキー保存
                cc = handler.CookieContainer;
            }

            return cc;
        }

        //private async Task Vote()
        //{


        //}

        static string HttpGet(string url, CookieContainer cc)
        {

            // リクエストの作成
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.CookieContainer = cc;

            WebResponse res = req.GetResponse();

            // レスポンスの読み取り
            Stream resStream = res.GetResponseStream();
            StreamReader sr = new StreamReader(resStream, encoder);
            string result = sr.ReadToEnd();
            sr.Close();
            resStream.Close();

            return result;
        }

        static string HttpPost(string url, Hashtable vals, CookieContainer cc)
        {
            string param = "";
            foreach (string k in vals.Keys)
            {
                param += String.Format("{0}={1}&", k, vals[k]);
            }
            byte[] data = Encoding.ASCII.GetBytes(param);

            // リクエストの作成
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";
            req.ContentLength = data.Length;
            req.CookieContainer = cc;

            // ポスト・データの書き込み
            Stream reqStream = req.GetRequestStream();
            reqStream.Write(data, 0, data.Length);
            reqStream.Close();

            try
            {
                WebResponse res = req.GetResponse();
                // レスポンスの読み取り
                Stream resStream = res.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, encoder);
                string result = sr.ReadToEnd();
                sr.Close();
                resStream.Close();
                return result;
            }
            catch (Exception)
            {

                throw;
            }



        }
    }
}
