using Google.Apis.YouTube.v3;
using System;
using System.Windows.Forms;
using Google.Apis.Services;
using Newtonsoft.Json;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Security.Policy;
using System.Text.Json;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;

namespace LoginRegister
{
    public partial class Data_Type : UserControl
    {
        public Data_Type(int param)
        {
            InitializeComponent();
            InitializeWebBrowser(param);
        }
        public WebClient wc = new WebClient();

        private string ApiYoutube() 
        {
            string apis = "https://youtube.googleapis.com/youtube/v3/playlistItems?part=snippet&maxResults=500&playlistId=PL-CtdCApEFH_HY6bL3JER8WJOxz1nb3_H&key=";
            string apiKey = "AIzaSyCu-w4S2yuoT-8PE2TteEAJ19QVYyvhueI";
            string url = apis + apiKey;
            return url;
        }
        public void InitializeWebBrowser(int param)
        {
            string url = ApiYoutube();


            
            var json = wc.DownloadString(url);

            JObject jsonObj = JObject.Parse(json);
            int count = jsonObj["items"].Count();

            string[] videoIdArr = new string[count];
            string[] videoThumb = new string[count];
            string[] videoTitle = new string[count];

            for (int i = 0; i < count; i++)
            {
                videoIdArr[i] = jsonObj["items"][i]["snippet"]["resourceId"]["videoId"].ToString();
                videoThumb[i] = jsonObj["items"][i]["snippet"]["thumbnails"]["high"]["url"].ToString();
                videoTitle[i] = jsonObj["items"][i]["snippet"]["title"].ToString();
            }

            
  
            web1.ScriptErrorsSuppressed = true;
            web1.DocumentCompleted += web1_DocumentCompleted;

            // Replace "VIDEO_ID" with the actual YouTube video ID you want to play
            string videoId = "9FqaMehDsUc";
            string embedUrl = $"https://www.youtube.com/embed/{videoIdArr[param]}?autoplay=1";

            string body = $"<iframe width='100%' height='100%' id='yt-player' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>";
            string sec = "";
            string watchUrl = ""; 
            /*for (int i = 0; i < count; i++)
            {
                embedUrl = $"https://www.youtube.com/embed/{videoIdArr[i]}?autoplay=1";
                body += $"<iframe width='500%' height='500%' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>";
            }*/
           /* for (int i = 0; i < count; i++)
            {
                watchUrl = $"https://www.youtube.com/watch?v={videoIdArr[i]}";
                sec += $"<a href='{watchUrl}' class='yt-video'> <img src='{videoThumb[i]}'> <h3>{videoTitle[i]}</h3> </img></a>";
            }*/
           // < body style = 'margin:50px;padding:50px;overflow:hidden' >
            // You can customize the width and height of the embedded video player
            string html = $@"
                <html>
                <head>
                    <meta http-equiv='X-UA-Compatible' content='IE=edge'/>
                    <meta http-equiv='content-type' content='text/html;charset=utf-8'/>
                    <meta name='viewport' content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0'/>
                </head>
                <body style='height:100%;weight:100%;margin:5px;padding:5px;overflow:'scroll';place-items:'center';>"
                   + body +"</body> " +
                   "<script> var player; function " +
                   "</script>" +
                   "</html>";
            web1.DocumentText = html;
        }
        public void webKill()
        {
            web1.Dispose();
            web1.Stop();
            //web1.Navigate("about:blank");
        }

        private void web1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
