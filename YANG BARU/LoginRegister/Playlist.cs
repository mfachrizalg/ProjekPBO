using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Net.Http;
using Newtonsoft.Json;
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Threading;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;
using System.Management;

namespace LoginRegister
{
    public partial class Playlist : UserControl
    {
        private const string apiKey = "AIzaSyCu-w4S2yuoT-8PE2TteEAJ19QVYyvhueI";
        private YouTubeService youTubeService;
        public Playlist()
        {
            InitializeComponent();
            InitializeYouTubeService();
        }
        private async void get_videos() 
        {
            
        }
        private void InitializeYouTubeService()
        {
            youTubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = apiKey,
                ApplicationName = "Playlist"
            }) ;
        }
        public static Panel CreatePanel(int x, int y) 
        {
            Panel panel = new Panel();
            panel.Size = new Size(200, 200);
            panel.Location = new Point(x, y);

            return panel;
        }
  
        private void Playlist_Load(object sender, EventArgs e)
        {
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            CreatePanel(0, 0);
        }
    }
}
