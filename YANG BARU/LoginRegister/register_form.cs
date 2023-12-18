﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Guna.UI2.WinForms;

namespace LoginRegister
{
    public partial class register_form : Form
    {
        private string otp;
        public register_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox3.UseSystemPasswordChar = true;

        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2TextBox3.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form f1 = new login_form();
            f1.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String email, password, confirm;
            email = guna2TextBox1.Text;
            password = guna2TextBox2.Text;
            confirm = guna2TextBox3.Text;

            SqlDataReader dr;
            SqlCommand cmd;

            conn.Open();

            try
            {
                if (email != string.Empty && password != string.Empty && confirm != string.Empty)
                {
                    if (password == confirm)
                    {
                        cmd = new SqlCommand("SELECT * FROM Login WHERE username = '" + email + "'", conn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            dr.Close();
                            MessageBox.Show("Username already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            cmd = new SqlCommand("INSERT INTO Login values(@username,@password, @userLevel)", conn);
                            cmd.Parameters.AddWithValue("@username", email);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.Parameters.AddWithValue("@userLevel", 1);
                            cmd.ExecuteNonQuery();
                            guna2TextBox1.Clear();
                            guna2TextBox2.Clear();
                            guna2TextBox3.Clear();
                            if (string.IsNullOrWhiteSpace(email) || !IsValidEmail(email))
                            {
                                MessageBox.Show("Invalid or empty recipient email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Account created successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            this.Hide();    
                            login_form f1 = new login_form();
                            f1.Show();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Password does not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("Please fill all the fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
            otp = GenerateOTP();
            SendOTPToEmail(email,otp);

            //MessageBox.Show("Account created successfully. Check your email for the OTP.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GenerateOTP()
        {
            // Implement your OTP generation logic here
            // For example, you can use a random number or a time-based algorithm
            return new Random().Next(100000, 999999).ToString();
        }

        private void SendOTPToEmail(string recipientEmail, string otp)
        {
            try
            {
                string senderEmail = "mohammad.fachrizal123@gmail.com"; // Replace with your Gmail address
                string senderPassword = "sdtk muas nmbq wobg"; // Replace with the App Password generated
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = "OTP Code";
                    mail.Body = "<h1>Hello</h1>" +
                        "\"Your OTP Code\", $\"Your OTP code is: {otp}\"";
                    mail.IsBodyHtml = true;
                    mail.Priority = MailPriority.High;

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                    //ShowOTPInputPopup();
                    MessageBox.Show("OTP sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                /*using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
                 {
                     MailMessage msg = new MailMessage();

                     msg.From = new MailAddress("mymailid");
                     msg.To.Add("receipientid");
                     msg.Subject = "test";
                     msg.Body = "Test Content";


                     client.Port = 587;

                     client.Credentials = new NetworkCredential(senderEmail,senderPassword);
                     client.EnableSsl = true;

                     MailMessage message = new MailMessage("mohammad.fachrizal123@gmail.com", recipientEmail, "Your OTP Code", $"Your OTP code is: {otp}");
                     client.Send(message);
                 }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send OTP: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        /*private void ShowOTPInputPopup()
        {
            using (Guna2TextBox txtOTPInput = new Guna2TextBox())
            using (Guna2Button btnVerify = new Guna2Button())
            using (Guna2Form otpInputForm = new Guna2Form())
            {
                // OTP Input Textbox
                txtOTPInput.PlaceholderText = "Enter OTP";
                txtOTPInput.PasswordChar = '\0'; // Set to '*' for password-style input
                txtOTPInput.Dock = DockStyle.Top;

                // Verify Button
                btnVerify.Text = "Verify OTP";
                btnVerify.Dock = DockStyle.Bottom;
                btnVerify.Click += (s, e) => VerifyOTP(txtOTPInput.Text);

                // OTP Input Form
                otpInputForm.Controls.Add(txtOTPInput);
                otpInputForm.Controls.Add(btnVerify);
                otpInputForm.Size = new System.Drawing.Size(250, 150);
                otpInputForm.StartPosition = FormStartPosition.CenterParent;

                // Show the OTP input pop-up
                DialogResult result = otpInputForm.ShowDialog(this);

                // Handle the result if needed
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("OTP Verified Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("OTP Verification Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }*/

       /* private void VerifyOTP(string enteredOTP)
        {
            // Perform OTP verification logic here
            // For simplicity, compare the entered OTP with a static OTP "123456"
            string actualOTP = "123456";
            if (enteredOTP == actualOTP)
            {
                // Set the result and close the OTP input form
                ((Guna2Form)((Guna2Button)btnVerify).TopLevelControl).DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}