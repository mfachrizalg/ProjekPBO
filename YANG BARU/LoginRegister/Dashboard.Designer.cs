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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Left = new Guna.UI2.WinForms.Guna2Panel();
            this.SidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.Topp = new Guna.UI2.WinForms.Guna2Panel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.learn = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.p_logo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Sidebar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Profile = new Guna.UI2.WinForms.Guna2Button();
            this.Dash = new Guna.UI2.WinForms.Guna2Button();
            this.Left.SuspendLayout();
            this.Topp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Left.BorderThickness = 1;
            this.Left.Controls.Add(this.Sidebar);
            this.Left.Controls.Add(this.Settings);
            this.Left.Controls.Add(this.Profile);
            this.Left.Controls.Add(this.Dash);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 0);
            this.Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(179, 526);
            this.Left.TabIndex = 1;
            this.Left.Paint += new System.Windows.Forms.PaintEventHandler(this.Left_Paint);
            // 
            // SidebarTrans
            // 
            this.SidebarTrans.Interval = 10;
            this.SidebarTrans.Tick += new System.EventHandler(this.SidebarTrans_Tick);
            // 
            // Topp
            // 
            this.Topp.BackColor = System.Drawing.Color.White;
            this.Topp.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Topp.BorderThickness = 1;
            this.Topp.Controls.Add(this.p_logo);
            this.Topp.Controls.Add(this.Minimize);
            this.Topp.Controls.Add(this.exit);
            this.Topp.Controls.Add(this.learn);
            this.Topp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topp.Location = new System.Drawing.Point(179, 0);
            this.Topp.Name = "Topp";
            this.Topp.Size = new System.Drawing.Size(817, 44);
            this.Topp.TabIndex = 4;
            this.Topp.Paint += new System.Windows.Forms.PaintEventHandler(this.Topp_Paint);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(179, 44);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(817, 482);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // learn
            // 
            this.learn.AutoSize = true;
            this.learn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.learn.Location = new System.Drawing.Point(60, 11);
            this.learn.Name = "learn";
            this.learn.Size = new System.Drawing.Size(71, 23);
            this.learn.TabIndex = 5;
            this.learn.Text = "ylearn";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockForm = true;
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MainPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // p_logo
            // 
            this.p_logo.BackColor = System.Drawing.Color.Transparent;
            this.p_logo.Image = global::LoginRegister.Properties.Resources.p;
            this.p_logo.ImageRotate = 0F;
            this.p_logo.Location = new System.Drawing.Point(38, 7);
            this.p_logo.Name = "p_logo";
            this.p_logo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.p_logo.Size = new System.Drawing.Size(31, 31);
            this.p_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_logo.TabIndex = 4;
            this.p_logo.TabStop = false;
            this.p_logo.UseTransparentBackground = true;
            // 
            // Minimize
            // 
            this.Minimize.AnimatedGIF = true;
            this.Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Minimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.Minimize.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.Minimize.ImageRotate = 0F;
            this.Minimize.ImageSize = new System.Drawing.Size(16, 16);
            this.Minimize.Location = new System.Drawing.Point(727, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.Minimize.Size = new System.Drawing.Size(45, 44);
            this.Minimize.TabIndex = 3;
            this.Minimize.UseTransparentBackground = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // exit
            // 
            this.exit.AnimatedGIF = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit.HoverState.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.ImageOffset = new System.Drawing.Point(0, 0);
            this.exit.ImageRotate = 0F;
            this.exit.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Location = new System.Drawing.Point(772, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Size = new System.Drawing.Size(45, 44);
            this.exit.TabIndex = 2;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar.Image = ((System.Drawing.Image)(resources.GetObject("Sidebar.Image")));
            this.Sidebar.ImageRotate = 0F;
            this.Sidebar.Location = new System.Drawing.Point(26, 3);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(19, 41);
            this.Sidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sidebar.TabIndex = 1;
            this.Sidebar.TabStop = false;
            this.Sidebar.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // Settings
            // 
            this.Settings.Animated = true;
            this.Settings.AnimatedGIF = true;
            this.Settings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Settings.CheckedState.FillColor = System.Drawing.Color.White;
            this.Settings.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Settings.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Settings.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Settings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Settings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Settings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Settings.FillColor = System.Drawing.Color.White;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Settings.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.ImageOffset = new System.Drawing.Point(15, 0);
            this.Settings.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Settings.Location = new System.Drawing.Point(0, 150);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(176, 53);
            this.Settings.TabIndex = 0;
            this.Settings.Text = "Settings";
            this.Settings.TextOffset = new System.Drawing.Point(10, 0);
            this.Settings.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Profile
            // 
            this.Profile.Animated = true;
            this.Profile.AnimatedGIF = true;
            this.Profile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Profile.CheckedState.FillColor = System.Drawing.Color.White;
            this.Profile.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Profile.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Profile.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Profile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Profile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Profile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Profile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Profile.FillColor = System.Drawing.Color.White;
            this.Profile.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Profile.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Profile.Image = ((System.Drawing.Image)(resources.GetObject("Profile.Image")));
            this.Profile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Profile.ImageOffset = new System.Drawing.Point(15, 0);
            this.Profile.Location = new System.Drawing.Point(0, 97);
            this.Profile.Margin = new System.Windows.Forms.Padding(0);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(176, 53);
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
            this.Dash.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.Dash.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dash.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dash.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dash.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dash.FillColor = System.Drawing.Color.White;
            this.Dash.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Dash.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Dash.Image = ((System.Drawing.Image)(resources.GetObject("Dash.Image")));
            this.Dash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dash.ImageOffset = new System.Drawing.Point(15, 0);
            this.Dash.Location = new System.Drawing.Point(0, 44);
            this.Dash.Margin = new System.Windows.Forms.Padding(0);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(176, 53);
            this.Dash.TabIndex = 0;
            this.Dash.Text = "Dashboard";
            this.Dash.TextOffset = new System.Drawing.Point(10, 0);
            this.Dash.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.Dash.Click += new System.EventHandler(this.Dash_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(996, 526);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Topp);
            this.Controls.Add(this.Left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Left.ResumeLayout(false);
            this.Topp.ResumeLayout(false);
            this.Topp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Left;
        private Guna.UI2.WinForms.Guna2Button Dash;
        private Guna.UI2.WinForms.Guna2Button Profile;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private System.Windows.Forms.Timer SidebarTrans;
        private Guna.UI2.WinForms.Guna2Panel Topp;
        private Guna.UI2.WinForms.Guna2ImageButton Minimize;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2PictureBox Sidebar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox p_logo;
        private System.Windows.Forms.Label learn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}