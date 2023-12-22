namespace LoginRegister
{
    partial class Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.pnMainSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.pnKata = new Guna.UI2.WinForms.Guna2Panel();
            this.Display_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Notifications_btn = new Guna.UI2.WinForms.Guna2Button();
            this.GlobalSettings = new System.Windows.Forms.Label();
            this.UserProfile_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pnSettings = new Guna.UI2.WinForms.Guna2Panel();
            this.pnMainSettings.SuspendLayout();
            this.pnKata.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMainSettings
            // 
            this.pnMainSettings.Controls.Add(this.pnKata);
            this.pnMainSettings.Controls.Add(this.pnSettings);
            this.pnMainSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainSettings.Location = new System.Drawing.Point(0, 0);
            this.pnMainSettings.Name = "pnMainSettings";
            this.pnMainSettings.Size = new System.Drawing.Size(817, 482);
            this.pnMainSettings.TabIndex = 0;
            this.pnMainSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMainSettings_Paint);
            // 
            // pnKata
            // 
            this.pnKata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnKata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnKata.BorderColor = System.Drawing.Color.Transparent;
            this.pnKata.BorderRadius = 20;
            this.pnKata.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnKata.BorderThickness = 1;
            this.pnKata.Controls.Add(this.Display_btn);
            this.pnKata.Controls.Add(this.Notifications_btn);
            this.pnKata.Controls.Add(this.GlobalSettings);
            this.pnKata.Controls.Add(this.UserProfile_btn);
            this.pnKata.FillColor = System.Drawing.Color.White;
            this.pnKata.ForeColor = System.Drawing.Color.Coral;
            this.pnKata.Location = new System.Drawing.Point(16, 14);
            this.pnKata.Margin = new System.Windows.Forms.Padding(0);
            this.pnKata.Name = "pnKata";
            this.pnKata.ShadowDecoration.BorderRadius = 20;
            this.pnKata.Size = new System.Drawing.Size(242, 455);
            this.pnKata.TabIndex = 15;
            this.pnKata.Paint += new System.Windows.Forms.PaintEventHandler(this.pnKata_Paint);
            // 
            // Display_btn
            // 
            this.Display_btn.Animated = true;
            this.Display_btn.AnimatedGIF = true;
            this.Display_btn.BackColor = System.Drawing.Color.White;
            this.Display_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Display_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Display_btn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Display_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Display_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Display_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Display_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Display_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Display_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Display_btn.FillColor = System.Drawing.Color.White;
            this.Display_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Display_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Display_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Display_btn.Image = ((System.Drawing.Image)(resources.GetObject("Display_btn.Image")));
            this.Display_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Display_btn.ImageOffset = new System.Drawing.Point(8, 0);
            this.Display_btn.Location = new System.Drawing.Point(6, 173);
            this.Display_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Display_btn.Name = "Display_btn";
            this.Display_btn.Size = new System.Drawing.Size(227, 53);
            this.Display_btn.TabIndex = 15;
            this.Display_btn.Text = "Display Settings";
            this.Display_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Display_btn.TextOffset = new System.Drawing.Point(10, 0);
            this.Display_btn.Click += new System.EventHandler(this.Display_btn_Click);
            // 
            // Notifications_btn
            // 
            this.Notifications_btn.Animated = true;
            this.Notifications_btn.AnimatedGIF = true;
            this.Notifications_btn.BackColor = System.Drawing.Color.White;
            this.Notifications_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Notifications_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.Notifications_btn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Notifications_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Notifications_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Notifications_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Notifications_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Notifications_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Notifications_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Notifications_btn.FillColor = System.Drawing.Color.White;
            this.Notifications_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Notifications_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Notifications_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Notifications_btn.Image = ((System.Drawing.Image)(resources.GetObject("Notifications_btn.Image")));
            this.Notifications_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Notifications_btn.ImageOffset = new System.Drawing.Point(8, 0);
            this.Notifications_btn.Location = new System.Drawing.Point(6, 120);
            this.Notifications_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Notifications_btn.Name = "Notifications_btn";
            this.Notifications_btn.Size = new System.Drawing.Size(227, 53);
            this.Notifications_btn.TabIndex = 14;
            this.Notifications_btn.Text = "Notifications";
            this.Notifications_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Notifications_btn.TextOffset = new System.Drawing.Point(10, 0);
            this.Notifications_btn.Click += new System.EventHandler(this.Notifications_btn_Click);
            // 
            // GlobalSettings
            // 
            this.GlobalSettings.AutoSize = true;
            this.GlobalSettings.BackColor = System.Drawing.Color.White;
            this.GlobalSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalSettings.ForeColor = System.Drawing.Color.Black;
            this.GlobalSettings.Location = new System.Drawing.Point(19, 24);
            this.GlobalSettings.Name = "GlobalSettings";
            this.GlobalSettings.Size = new System.Drawing.Size(156, 23);
            this.GlobalSettings.TabIndex = 13;
            this.GlobalSettings.Text = "Global Settings";
            // 
            // UserProfile_btn
            // 
            this.UserProfile_btn.Animated = true;
            this.UserProfile_btn.AnimatedGIF = true;
            this.UserProfile_btn.BackColor = System.Drawing.Color.White;
            this.UserProfile_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UserProfile_btn.Checked = true;
            this.UserProfile_btn.CheckedState.FillColor = System.Drawing.Color.White;
            this.UserProfile_btn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.UserProfile_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.UserProfile_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.UserProfile_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserProfile_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserProfile_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserProfile_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserProfile_btn.FillColor = System.Drawing.Color.White;
            this.UserProfile_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.UserProfile_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.UserProfile_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.UserProfile_btn.Image = ((System.Drawing.Image)(resources.GetObject("UserProfile_btn.Image")));
            this.UserProfile_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserProfile_btn.ImageOffset = new System.Drawing.Point(8, 0);
            this.UserProfile_btn.Location = new System.Drawing.Point(6, 67);
            this.UserProfile_btn.Margin = new System.Windows.Forms.Padding(0);
            this.UserProfile_btn.Name = "UserProfile_btn";
            this.UserProfile_btn.Size = new System.Drawing.Size(227, 53);
            this.UserProfile_btn.TabIndex = 1;
            this.UserProfile_btn.Text = "User Profile";
            this.UserProfile_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserProfile_btn.TextOffset = new System.Drawing.Point(10, 0);
            this.UserProfile_btn.Click += new System.EventHandler(this.UserProfile_btn_Click);
            // 
            // pnSettings
            // 
            this.pnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnSettings.BorderColor = System.Drawing.Color.Transparent;
            this.pnSettings.BorderRadius = 20;
            this.pnSettings.BorderThickness = 1;
            this.pnSettings.FillColor = System.Drawing.Color.White;
            this.pnSettings.ForeColor = System.Drawing.Color.Coral;
            this.pnSettings.Location = new System.Drawing.Point(271, 14);
            this.pnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.ShadowDecoration.BorderRadius = 20;
            this.pnSettings.Size = new System.Drawing.Size(530, 455);
            this.pnSettings.TabIndex = 16;
            this.pnSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.pnSettings_Paint);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.pnMainSettings);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(817, 482);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnMainSettings.ResumeLayout(false);
            this.pnKata.ResumeLayout(false);
            this.pnKata.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnMainSettings;
        private Guna.UI2.WinForms.Guna2Panel pnKata;
        private Guna.UI2.WinForms.Guna2Button Display_btn;
        private Guna.UI2.WinForms.Guna2Button Notifications_btn;
        private System.Windows.Forms.Label GlobalSettings;
        private Guna.UI2.WinForms.Guna2Button UserProfile_btn;
        private Guna.UI2.WinForms.Guna2Panel pnSettings;
    }
}
