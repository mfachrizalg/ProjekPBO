﻿using Guna.UI2.WinForms;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Security.Cryptography;
using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using System.Diagnostics;

namespace LoginRegister
{
    public partial class login_form : Form
    {
        private const string clientId = "900338522363-ov9l41gueonfl0o54r3eto3j4hdhsec1.apps.googleusercontent.com";
        private const string redirectUri = "http://localhost:5000";
        private const string clientSecret = "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";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";
        public int userLVL { get; set; }
        public login_form()
        {
            InitializeComponent();
        }
        string conn_str = @"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True";
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void pctBerdua_Click(object sender, EventArgs e)
        {

        }
        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Terms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username, password;
            //int level;
            username = boxUsername.Text;
            password = boxPassword.Text;
            conn.Open();
            string level_querry = "SELECT userLevel FROM UserData WHERE username = '" + username + "'";


            try
            {
                String querry = "SELECT * FROM UserData WHERE username = '" + boxUsername.Text + "' AND password = '" + boxPassword.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                string searchColumn = "username";
                string searchVal = username;
                string resultColumn = "userLevel";

                DataRow[] selectedRows = dt.Select($"{searchColumn} = '{searchVal}'");

                int level = (int)selectedRows[0][resultColumn];
                userLVL = level;

                if (boxUsername.Text != string.Empty || boxPassword.Text != string.Empty)
                {
                    if (CheckBox.Checked == true)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            username = boxUsername.Text;
                            password = boxPassword.Text;

                            MessageBox.Show(level.ToString());

                            MessageBox.Show("Login Successful");
 /*                           var level1 = new lvl1();
                            var row = dt.Rows[0];
                            level1.Username = row["username"].ToString();
                            level1.userLevel = (int)row["userLevel"];
                            boxUsername.Clear();
                            boxPassword.Clear();
                            this.Hide();
                            level1.Show();*/
                            Dashboard dash = new Dashboard();
                            dash.username = username;
                            dash.userLVL = level;

                            this.Hide();
                            dash.Show();
                        
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check the agreement terms");
                    }


                }
                else
                {
                    MessageBox.Show("Please enter all the field");
                }



            }
            catch { MessageBox.Show("ERROR"); }
            finally { conn.Close(); }
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Privacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void boxPassword_TextChanged(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = true;
        }

        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
            {
                boxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                boxPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register_form f1 = new register_form();
            f1.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void or_Click(object sender, EventArgs e)
        {

        }

        private async void Google_Click(object sender, EventArgs e)
        {

            try
            {
                // Obtain the ID token from the Google Sign-In API response
                string idToken = await PerformGoogleSignIn();

                // TODO: Process the ID token as needed
                MessageBox.Show("Google Sign-In Success");
                this.Hide();
                register_form f1 = new register_form();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during Google Sign-In: {ex.Message}", "Error");
            }
        }
        private async Task<string> PerformGoogleSignIn()
        {
            // Generate a unique state parameter to prevent CSRF attacks
            string state = Guid.NewGuid().ToString("N");

            // Create the OAuth 2.0 authorization request URL
            string authorizationRequestUrl = $"https://accounts.google.com/o/oauth2/auth" +
                $"?client_id={clientId}" +
                $"&redirect_uri={redirectUri}" +
                $"&response_type=code" +
                $"&scope=openid%20profile" +
                $"&state={state}";

            // Open the default web browser for the user to sign in
            Process.Start(new ProcessStartInfo(authorizationRequestUrl) { UseShellExecute = true });

            // Start a simple HTTP server to receive the callback
            var listener = new HttpListener();
            listener.Prefixes.Add(redirectUri + "/");
            listener.Start();

            // Wait for the OAuth authorization response
            var context = await listener.GetContextAsync();
            var response = context.Response;
            string responseString = "<html><head></head><body>Authorization successful. You can close this window now.</body></html>";
            var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var responseOutput = response.OutputStream;
            await responseOutput.WriteAsync(buffer, 0, buffer.Length);
            responseOutput.Close();

            // Parse the response to extract the authorization code
            var queryParams = System.Web.HttpUtility.ParseQueryString(context.Request.Url.Query);
            string authorizationCode = queryParams["code"];

            listener.Stop();

            // Exchange authorization code for ID token
            return await ExchangeCodeForIdToken(authorizationCode);
        }

        private async Task<string> ExchangeCodeForIdToken(string authorizationCode)
        {
            using (var client = new HttpClient())
            {
                var tokenEndpoint = "https://oauth2.googleapis.com/token";
                var tokenRequest = new Dictionary<string, string>
                {
                    { "code", authorizationCode },
                    { "client_id", clientId },
                    { "client_secret", clientSecret }, // Replace with your client secret
                    { "redirect_uri", redirectUri },
                    { "grant_type", "authorization_code" }
                };

                var tokenResponse = await client.PostAsync(tokenEndpoint, new FormUrlEncodedContent(tokenRequest));
                var tokenContent = await tokenResponse.Content.ReadAsStringAsync();
                var tokenData = JsonConvert.DeserializeObject<Dictionary<string, string>>(tokenContent);
                return tokenData["id_token"];
            }
        }

        private void and_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void course_Click(object sender, EventArgs e)
        {

        }

        private void pnKiri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}