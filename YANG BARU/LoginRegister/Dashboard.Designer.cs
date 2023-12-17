namespace LoginRegister
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Profile = new Guna.UI2.WinForms.Guna2Button();
            this.Dash = new Guna.UI2.WinForms.Guna2Button();
            this.exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.exit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(747, 45);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.Settings);
            this.guna2Panel2.Controls.Add(this.Profile);
            this.guna2Panel2.Controls.Add(this.Dash);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 45);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(173, 382);
            this.guna2Panel2.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.AnimatedGIF = true;
            this.Settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Settings.CheckedState.FillColor = System.Drawing.Color.White;
            this.Settings.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Settings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Settings.CheckedState.Image = global::LoginRegister.Properties.Resources.settings1;
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.Settings.FillColor = System.Drawing.Color.White;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Settings.HoverState.FillColor = System.Drawing.Color.White;
            this.Settings.Image = global::LoginRegister.Properties.Resources.gray_settings2;
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.ImageOffset = new System.Drawing.Point(15, 0);
            this.Settings.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Settings.Location = new System.Drawing.Point(0, 88);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(173, 43);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.TextOffset = new System.Drawing.Point(10, 0);
            this.Settings.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.Settings.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // Profile
            // 
            this.Profile.Animated = true;
            this.Profile.AnimatedGIF = true;
            this.Profile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Profile.CheckedState.FillColor = System.Drawing.Color.White;
            this.Profile.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Profile.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Profile.CheckedState.Image = global::LoginRegister.Properties.Resources.profile1;
            this.Profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile.FillColor = System.Drawing.Color.White;
            this.Profile.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Profile.HoverState.FillColor = System.Drawing.Color.White;
            this.Profile.Image = global::LoginRegister.Properties.Resources.gray_profile2;
            this.Profile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Profile.ImageOffset = new System.Drawing.Point(15, 0);
            this.Profile.Location = new System.Drawing.Point(0, 45);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(173, 43);
            this.Profile.TabIndex = 0;
            this.Profile.Text = "Profile";
            this.Profile.TextOffset = new System.Drawing.Point(10, 0);
            this.Profile.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.Profile.Click += new System.EventHandler(this.Profile_Click);
            // 
            // Dash
            // 
            this.Dash.Animated = true;
            this.Dash.AnimatedGIF = true;
            this.Dash.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Dash.Checked = true;
            this.Dash.CheckedState.FillColor = System.Drawing.Color.White;
            this.Dash.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dash.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Dash.CheckedState.Image = global::LoginRegister.Properties.Resources.dash;
            this.Dash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dash.Dock = System.Windows.Forms.DockStyle.Top;
            this.Dash.FillColor = System.Drawing.Color.White;
            this.Dash.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Dash.HoverState.FillColor = System.Drawing.Color.White;
            this.Dash.Image = global::LoginRegister.Properties.Resources.gray_dash1;
            this.Dash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dash.ImageOffset = new System.Drawing.Point(15, 0);
            this.Dash.Location = new System.Drawing.Point(0, 0);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(173, 45);
            this.Dash.TabIndex = 0;
            this.Dash.Text = "Dashboard";
            this.Dash.TextOffset = new System.Drawing.Point(10, 0);
            this.Dash.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit.ImageRotate = 0F;
            this.exit.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Location = new System.Drawing.Point(692, 0);
            this.exit.Name = "exit";
            this.exit.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Size = new System.Drawing.Size(55, 45);
            this.exit.TabIndex = 2;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(173, 45);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(574, 382);
            this.guna2Panel3.TabIndex = 2;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.guna2Panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.guna2Panel4.BorderRadius = 20;
            this.guna2Panel4.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2CircleProgressBar1);
            this.guna2Panel4.ForeColor = System.Drawing.Color.Coral;
            this.guna2Panel4.Location = new System.Drawing.Point(336, 183);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel4.Size = new System.Drawing.Size(190, 142);
            this.guna2Panel4.TabIndex = 0;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2CircleProgressBar1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.guna2CircleProgressBar1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(38, 12);
            this.guna2CircleProgressBar1.Minimum = 0;
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.LightSteelBlue;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.Blue;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShowText = true;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(116, 116);
            this.guna2CircleProgressBar1.TabIndex = 0;
            this.guna2CircleProgressBar1.Text = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(747, 427);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button Dash;
        private Guna.UI2.WinForms.Guna2Button Profile;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
    }
}