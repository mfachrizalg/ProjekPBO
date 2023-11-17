namespace Flat_Login_Form
{
    partial class Form2
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
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.Menubar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnSettings = new Guna.UI2.WinForms.Guna2Button();
            this.pnProfile = new Guna.UI2.WinForms.Guna2Button();
            this.pnCourse = new Guna.UI2.WinForms.Guna2Button();
            this.pnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menubar)).BeginInit();
            this.sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.Menubar);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 54);
            this.guna2Panel2.TabIndex = 4;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // Menubar
            // 
            this.Menubar.Image = global::Flat_Login_Form.Properties.Resources.menu;
            this.Menubar.ImageRotate = 0F;
            this.Menubar.Location = new System.Drawing.Point(21, 13);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(26, 21);
            this.Menubar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Menubar.TabIndex = 0;
            this.Menubar.TabStop = false;
            this.Menubar.Click += new System.EventHandler(this.Menu_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.White;
            this.sidebar.Controls.Add(this.pnSettings);
            this.sidebar.Controls.Add(this.pnProfile);
            this.sidebar.Controls.Add(this.pnCourse);
            this.sidebar.Controls.Add(this.pnDashboard);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 54);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(181, 396);
            this.sidebar.TabIndex = 5;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // pnSettings
            // 
            this.pnSettings.Animated = true;
            this.pnSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pnSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pnSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pnSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pnSettings.FillColor = System.Drawing.Color.Transparent;
            this.pnSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pnSettings.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnSettings.Image = global::Flat_Login_Form.Properties.Resources.settings;
            this.pnSettings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnSettings.ImageOffset = new System.Drawing.Point(10, 0);
            this.pnSettings.Location = new System.Drawing.Point(0, 129);
            this.pnSettings.Name = "pnSettings";
            this.pnSettings.Size = new System.Drawing.Size(181, 42);
            this.pnSettings.TabIndex = 1;
            this.pnSettings.Text = "Settings";
            this.pnSettings.TextOffset = new System.Drawing.Point(20, 0);
            this.pnSettings.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pnProfile
            // 
            this.pnProfile.Animated = true;
            this.pnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pnProfile.FillColor = System.Drawing.Color.Transparent;
            this.pnProfile.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pnProfile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnProfile.Image = global::Flat_Login_Form.Properties.Resources.profile3;
            this.pnProfile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnProfile.ImageOffset = new System.Drawing.Point(10, 0);
            this.pnProfile.Location = new System.Drawing.Point(0, 87);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(181, 42);
            this.pnProfile.TabIndex = 1;
            this.pnProfile.Text = "Profile";
            this.pnProfile.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // pnCourse
            // 
            this.pnCourse.Animated = true;
            this.pnCourse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pnCourse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pnCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pnCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pnCourse.FillColor = System.Drawing.Color.Transparent;
            this.pnCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.pnCourse.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnCourse.Image = global::Flat_Login_Form.Properties.Resources.course;
            this.pnCourse.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnCourse.ImageOffset = new System.Drawing.Point(10, 0);
            this.pnCourse.Location = new System.Drawing.Point(0, 45);
            this.pnCourse.Name = "pnCourse";
            this.pnCourse.Size = new System.Drawing.Size(181, 42);
            this.pnCourse.TabIndex = 1;
            this.pnCourse.Text = "Course";
            this.pnCourse.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // pnDashboard
            // 
            this.pnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.pnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.pnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.pnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.pnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.pnDashboard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDashboard.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pnDashboard.Image = global::Flat_Login_Form.Properties.Resources.dashboard_1;
            this.pnDashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pnDashboard.ImageOffset = new System.Drawing.Point(10, 0);
            this.pnDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnDashboard.Name = "pnDashboard";
            this.pnDashboard.Size = new System.Drawing.Size(181, 45);
            this.pnDashboard.TabIndex = 2;
            this.pnDashboard.Text = "Dashboard";
            this.pnDashboard.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 10;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menubar)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox Menubar;
        private Guna.UI2.WinForms.Guna2Panel sidebar;
        private Guna.UI2.WinForms.Guna2Button pnCourse;
        private Guna.UI2.WinForms.Guna2Button pnDashboard;
        private Guna.UI2.WinForms.Guna2Button pnSettings;
        private Guna.UI2.WinForms.Guna2Button pnProfile;
        private System.Windows.Forms.Timer sidebarTransition;
    }
}