using System;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Data_Type : UserControl
    {
        public Data_Type()
        {
            InitializeComponent();
            InitializeWebBrowser();
        }

        private void InitializeWebBrowser()
        {
            web1.ScriptErrorsSuppressed = true;
            web1.DocumentCompleted += web1_DocumentCompleted;

            // Replace "VIDEO_ID" with the actual YouTube video ID you want to play
            string videoId = "9FqaMehDsUc";
            string embedUrl = $"https://www.youtube.com/embed/{videoId}?autoplay=1";

            // You can customize the width and height of the embedded video player
            string html = $@"
                <html>
                <head>
                    <meta http-equiv='X-UA-Compatible' content='IE=edge'/>
                    <meta http-equiv='content-type' content='text/html;charset=utf-8'/>
                    <meta name='viewport' content='width=device-width, initial-scale=1, maximum-scale=1, user-scalable=0'/>
                </head>
                <body style='margin:50px;padding:50px;overflow:hidden'>
                    <iframe width='500%' height='500%' src='{embedUrl}' frameborder='0' allowfullscreen></iframe>
                </body>
                </html>";
            web1.DocumentText = html;
        }

        private void web1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}
