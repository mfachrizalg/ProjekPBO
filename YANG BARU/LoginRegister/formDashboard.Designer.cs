namespace LoginRegister
{
    partial class formDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDashboard));
            this.Left = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelKiriAtas = new Guna.UI2.WinForms.Guna2Panel();
            this.SidebarTrans = new System.Windows.Forms.Timer(this.components);
            this.ProgressPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Completed = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.Topp = new Guna.UI2.WinForms.Guna2Panel();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Learning = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Learningg = new Guna.UI2.WinForms.Guna2Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Minimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.exit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Settings = new Guna.UI2.WinForms.Guna2Button();
            this.Profile = new Guna.UI2.WinForms.Guna2Button();
            this.Dash = new Guna.UI2.WinForms.Guna2Button();
            this.Sidebar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Left.SuspendLayout();
            this.PanelKiriAtas.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.Topp.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.Learning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar)).BeginInit();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.BackColor = System.Drawing.Color.White;
            this.Left.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Left.BorderThickness = 1;
            this.Left.Controls.Add(this.Settings);
            this.Left.Controls.Add(this.Profile);
            this.Left.Controls.Add(this.Dash);
            this.Left.Controls.Add(this.PanelKiriAtas);
            this.Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left.Location = new System.Drawing.Point(0, 0);
            this.Left.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(199, 526);
            this.Left.TabIndex = 1;
            this.Left.Paint += new System.Windows.Forms.PaintEventHandler(this.Left_Paint);
            // 
            // PanelKiriAtas
            // 
            this.PanelKiriAtas.Controls.Add(this.Sidebar);
            this.PanelKiriAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelKiriAtas.Location = new System.Drawing.Point(0, 0);
            this.PanelKiriAtas.Name = "PanelKiriAtas";
            this.PanelKiriAtas.Size = new System.Drawing.Size(199, 61);
            this.PanelKiriAtas.TabIndex = 0;
            this.PanelKiriAtas.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // SidebarTrans
            // 
            this.SidebarTrans.Interval = 10;
            this.SidebarTrans.Tick += new System.EventHandler(this.SidebarTrans_Tick);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ProgressPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ProgressPanel.BorderRadius = 15;
            this.ProgressPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ProgressPanel.BorderThickness = 1;
            this.ProgressPanel.Controls.Add(this.Completed);
            this.ProgressPanel.Controls.Add(this.ProgressText);
            this.ProgressPanel.Controls.Add(this.ProgressBar);
            this.ProgressPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.ProgressPanel.ForeColor = System.Drawing.Color.Coral;
            this.ProgressPanel.Location = new System.Drawing.Point(247, 295);
            this.ProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.ShadowDecoration.BorderRadius = 20;
            this.ProgressPanel.Size = new System.Drawing.Size(305, 179);
            this.ProgressPanel.TabIndex = 0;
            this.ProgressPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressPanel_Paint);
            // 
            // Completed
            // 
            this.Completed.AutoSize = true;
            this.Completed.BackColor = System.Drawing.Color.Transparent;
            this.Completed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completed.ForeColor = System.Drawing.Color.White;
            this.Completed.Location = new System.Drawing.Point(22, 84);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(121, 23);
            this.Completed.TabIndex = 2;
            this.Completed.Text = "Completed";
            // 
            // ProgressText
            // 
            this.ProgressText.AutoSize = true;
            this.ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.ProgressText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.Silver;
            this.ProgressText.Location = new System.Drawing.Point(23, 57);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(96, 18);
            this.ProgressText.TabIndex = 1;
            this.ProgressText.Text = "Progress Bar";
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(165, 28);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.LightSteelBlue;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.Blue;
            this.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.ShowText = true;
            this.ProgressBar.Size = new System.Drawing.Size(116, 116);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = "ProgressBar";
            this.ProgressBar.Value = 69;
            this.ProgressBar.ValueChanged += new System.EventHandler(this.guna2CircleProgressBar1_ValueChanged);
            // 
            // Topp
            // 
            this.Topp.BackColor = System.Drawing.Color.White;
            this.Topp.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Topp.BorderThickness = 1;
            this.Topp.Controls.Add(this.Minimize);
            this.Topp.Controls.Add(this.exit);
            this.Topp.Dock = System.Windows.Forms.DockStyle.Top;
            this.Topp.Location = new System.Drawing.Point(199, 0);
            this.Topp.Name = "Topp";
            this.Topp.Size = new System.Drawing.Size(797, 61);
            this.Topp.TabIndex = 4;
            this.Topp.Paint += new System.Windows.Forms.PaintEventHandler(this.Topp_Paint);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.guna2Panel1);
            this.MainPanel.Controls.Add(this.chart1);
            this.MainPanel.Controls.Add(this.ProgressPanel);
            this.MainPanel.Controls.Add(this.Learning);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(996, 526);
            this.MainPanel.TabIndex = 5;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // Learning
            // 
            this.Learning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Learning.BorderColor = System.Drawing.Color.Transparent;
            this.Learning.BorderRadius = 15;
            this.Learning.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.Learning.BorderThickness = 1;
            this.Learning.Controls.Add(this.Learningg);
            this.Learning.Controls.Add(this.label2);
            this.Learning.FillColor = System.Drawing.Color.White;
            this.Learning.ForeColor = System.Drawing.Color.Coral;
            this.Learning.Location = new System.Drawing.Point(247, 93);
            this.Learning.Margin = new System.Windows.Forms.Padding(0);
            this.Learning.Name = "Learning";
            this.Learning.ShadowDecoration.BorderRadius = 20;
            this.Learning.Size = new System.Drawing.Size(305, 179);
            this.Learning.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(119, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Section";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Learningg
            // 
            this.Learningg.CheckedState.FillColor = System.Drawing.Color.White;
            this.Learningg.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.Learningg.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Learningg.DisabledState.FillColor = System.Drawing.Color.White;
            this.Learningg.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Learningg.FillColor = System.Drawing.Color.White;
            this.Learningg.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Learningg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Learningg.HoverState.FillColor = System.Drawing.Color.White;
            this.Learningg.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Learningg.Location = new System.Drawing.Point(3, 68);
            this.Learningg.Name = "Learningg";
            this.Learningg.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Learningg.Size = new System.Drawing.Size(299, 45);
            this.Learningg.TabIndex = 4;
            this.Learningg.Text = "Learning";
            this.Learningg.Click += new System.EventHandler(this.Learningg_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(593, 295);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(305, 179);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.guna2Button1.Location = new System.Drawing.Point(3, 68);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.guna2Button1.Size = new System.Drawing.Size(299, 45);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "Exercise";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(119, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Section";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Coral;
            this.guna2Panel1.Location = new System.Drawing.Point(593, 93);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 20;
            this.guna2Panel1.Size = new System.Drawing.Size(305, 179);
            this.guna2Panel1.TabIndex = 7;
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
            this.Minimize.Location = new System.Drawing.Point(707, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize.Name = "Minimize";
            this.Minimize.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.Minimize.Size = new System.Drawing.Size(45, 61);
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
            this.exit.Location = new System.Drawing.Point(752, 0);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.PressedState.ImageSize = new System.Drawing.Size(16, 16);
            this.exit.Size = new System.Drawing.Size(45, 61);
            this.exit.TabIndex = 2;
            this.exit.UseTransparentBackground = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
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
            this.Settings.FillColor = System.Drawing.Color.White;
            this.Settings.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Settings.HoverState.FillColor = System.Drawing.Color.White;
            this.Settings.Image = global::LoginRegister.Properties.Resources.gray_settings2;
            this.Settings.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Settings.ImageOffset = new System.Drawing.Point(15, 0);
            this.Settings.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Settings.Location = new System.Drawing.Point(0, 167);
            this.Settings.Margin = new System.Windows.Forms.Padding(0);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(199, 53);
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
            this.Profile.FillColor = System.Drawing.Color.White;
            this.Profile.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Profile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Profile.HoverState.FillColor = System.Drawing.Color.White;
            this.Profile.Image = global::LoginRegister.Properties.Resources.gray_profile2;
            this.Profile.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Profile.ImageOffset = new System.Drawing.Point(15, 0);
            this.Profile.Location = new System.Drawing.Point(0, 114);
            this.Profile.Margin = new System.Windows.Forms.Padding(0);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(199, 53);
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
            this.Dash.FillColor = System.Drawing.Color.White;
            this.Dash.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Dash.HoverState.FillColor = System.Drawing.Color.White;
            this.Dash.Image = global::LoginRegister.Properties.Resources.gray_dash1;
            this.Dash.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dash.ImageOffset = new System.Drawing.Point(15, 0);
            this.Dash.Location = new System.Drawing.Point(0, 61);
            this.Dash.Margin = new System.Windows.Forms.Padding(0);
            this.Dash.Name = "Dash";
            this.Dash.Size = new System.Drawing.Size(199, 53);
            this.Dash.TabIndex = 0;
            this.Dash.Text = "Dashboard";
            this.Dash.TextOffset = new System.Drawing.Point(10, 0);
            this.Dash.CheckedChanged += new System.EventHandler(this.guna2Button2_CheckedChanged);
            this.Dash.Click += new System.EventHandler(this.Dash_Click);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.Transparent;
            this.Sidebar.Image = ((System.Drawing.Image)(resources.GetObject("Sidebar.Image")));
            this.Sidebar.ImageRotate = 0F;
            this.Sidebar.Location = new System.Drawing.Point(24, 12);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(19, 41);
            this.Sidebar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sidebar.TabIndex = 1;
            this.Sidebar.TabStop = false;
            this.Sidebar.Click += new System.EventHandler(this.Sidebar_Click);
            // 
            // formDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(996, 526);
            this.Controls.Add(this.Topp);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formDashboard";
            this.Text = "Dashboard";
            this.Left.ResumeLayout(false);
            this.PanelKiriAtas.ResumeLayout(false);
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.Topp.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.Learning.ResumeLayout(false);
            this.Learning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Sidebar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel Left;
        private Guna.UI2.WinForms.Guna2Button Dash;
        private Guna.UI2.WinForms.Guna2Button Profile;
        private Guna.UI2.WinForms.Guna2Button Settings;
        private Guna.UI2.WinForms.Guna2PictureBox Sidebar;
        private System.Windows.Forms.Timer SidebarTrans;
        private Guna.UI2.WinForms.Guna2Panel PanelKiriAtas;
        private Guna.UI2.WinForms.Guna2Panel Topp;
        private Guna.UI2.WinForms.Guna2ImageButton Minimize;
        private Guna.UI2.WinForms.Guna2ImageButton exit;
        private Guna.UI2.WinForms.Guna2Panel ProgressPanel;
        private System.Windows.Forms.Label Completed;
        private System.Windows.Forms.Label ProgressText;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2Panel Learning;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button Learningg;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label1;
    }
}