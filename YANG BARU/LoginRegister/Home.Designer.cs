namespace LoginRegister
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            this.pnExercise = new Guna.UI2.WinForms.Guna2Panel();
            this.Exercise = new Guna.UI2.WinForms.Guna2Button();
            this.ProgressPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Completed = new System.Windows.Forms.Label();
            this.ProgressText = new System.Windows.Forms.Label();
            this.ProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.pnLearning = new Guna.UI2.WinForms.Guna2Panel();
            this.Learning = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.search_box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Welcome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnKata = new Guna.UI2.WinForms.Guna2Panel();
            this.HiText = new System.Windows.Forms.Label();
            this.Katakata = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.profile_pict = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.notif_button = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Photo = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnExercise.SuspendLayout();
            this.ProgressPanel.SuspendLayout();
            this.pnLearning.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.pnKata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnExercise
            // 
            this.pnExercise.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnExercise.BorderColor = System.Drawing.Color.Transparent;
            this.pnExercise.BorderRadius = 15;
            this.pnExercise.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnExercise.BorderThickness = 1;
            this.pnExercise.Controls.Add(this.Exercise);
            this.pnExercise.FillColor = System.Drawing.Color.White;
            this.pnExercise.ForeColor = System.Drawing.Color.Coral;
            this.pnExercise.Location = new System.Drawing.Point(263, 92);
            this.pnExercise.Margin = new System.Windows.Forms.Padding(0);
            this.pnExercise.Name = "pnExercise";
            this.pnExercise.ShadowDecoration.BorderRadius = 20;
            this.pnExercise.Size = new System.Drawing.Size(207, 105);
            this.pnExercise.TabIndex = 10;
            this.pnExercise.Paint += new System.Windows.Forms.PaintEventHandler(this.pnExercise_Paint);
            // 
            // Exercise
            // 
            this.Exercise.CheckedState.FillColor = System.Drawing.Color.White;
            this.Exercise.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.Exercise.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Exercise.DisabledState.FillColor = System.Drawing.Color.White;
            this.Exercise.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Exercise.FillColor = System.Drawing.Color.White;
            this.Exercise.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Exercise.HoverState.FillColor = System.Drawing.Color.White;
            this.Exercise.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Exercise.Location = new System.Drawing.Point(3, 39);
            this.Exercise.Name = "Exercise";
            this.Exercise.PressedColor = System.Drawing.Color.White;
            this.Exercise.Size = new System.Drawing.Size(201, 35);
            this.Exercise.TabIndex = 4;
            this.Exercise.Text = "Exercise";
            this.Exercise.Click += new System.EventHandler(this.Exercise_Click);
            // 
            // ProgressPanel
            // 
            this.ProgressPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.ProgressPanel.Location = new System.Drawing.Point(507, 336);
            this.ProgressPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ProgressPanel.Name = "ProgressPanel";
            this.ProgressPanel.ShadowDecoration.BorderRadius = 20;
            this.ProgressPanel.Size = new System.Drawing.Size(267, 98);
            this.ProgressPanel.TabIndex = 8;
            this.ProgressPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ProgressPanel_Paint);
            // 
            // Completed
            // 
            this.Completed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Completed.AutoSize = true;
            this.Completed.BackColor = System.Drawing.Color.Transparent;
            this.Completed.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completed.ForeColor = System.Drawing.Color.White;
            this.Completed.Location = new System.Drawing.Point(20, 49);
            this.Completed.Name = "Completed";
            this.Completed.Size = new System.Drawing.Size(121, 23);
            this.Completed.TabIndex = 2;
            this.Completed.Text = "Completed";
            this.Completed.Click += new System.EventHandler(this.Completed_Click);
            // 
            // ProgressText
            // 
            this.ProgressText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressText.AutoSize = true;
            this.ProgressText.BackColor = System.Drawing.Color.Transparent;
            this.ProgressText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgressText.ForeColor = System.Drawing.Color.Silver;
            this.ProgressText.Location = new System.Drawing.Point(21, 22);
            this.ProgressText.Name = "ProgressText";
            this.ProgressText.Size = new System.Drawing.Size(96, 18);
            this.ProgressText.TabIndex = 1;
            this.ProgressText.Text = "Progress Bar";
            this.ProgressText.Click += new System.EventHandler(this.ProgressText_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.ProgressBar.FillThickness = 15;
            this.ProgressBar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.ProgressBar.ForeColor = System.Drawing.Color.White;
            this.ProgressBar.Location = new System.Drawing.Point(169, 10);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Minimum = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.ProgressColor = System.Drawing.Color.LightSteelBlue;
            this.ProgressBar.ProgressColor2 = System.Drawing.Color.Blue;
            this.ProgressBar.ProgressThickness = 15;
            this.ProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProgressBar.ShowText = true;
            this.ProgressBar.Size = new System.Drawing.Size(77, 77);
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.Text = "ProgressBar";
            this.ProgressBar.Value = 69;
            this.ProgressBar.ValueChanged += new System.EventHandler(this.ProgressBar_ValueChanged);
            // 
            // pnLearning
            // 
            this.pnLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnLearning.BorderColor = System.Drawing.Color.Transparent;
            this.pnLearning.BorderRadius = 15;
            this.pnLearning.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnLearning.BorderThickness = 1;
            this.pnLearning.Controls.Add(this.Learning);
            this.pnLearning.FillColor = System.Drawing.Color.White;
            this.pnLearning.ForeColor = System.Drawing.Color.Coral;
            this.pnLearning.Location = new System.Drawing.Point(45, 92);
            this.pnLearning.Margin = new System.Windows.Forms.Padding(0);
            this.pnLearning.Name = "pnLearning";
            this.pnLearning.ShadowDecoration.BorderRadius = 20;
            this.pnLearning.Size = new System.Drawing.Size(204, 105);
            this.pnLearning.TabIndex = 9;
            this.pnLearning.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLearning_Paint);
            // 
            // Learning
            // 
            this.Learning.CheckedState.FillColor = System.Drawing.Color.White;
            this.Learning.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.Learning.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Learning.DisabledState.FillColor = System.Drawing.Color.White;
            this.Learning.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Learning.FillColor = System.Drawing.Color.White;
            this.Learning.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Learning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Learning.HoverState.FillColor = System.Drawing.Color.White;
            this.Learning.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Learning.Location = new System.Drawing.Point(3, 33);
            this.Learning.Name = "Learning";
            this.Learning.PressedColor = System.Drawing.Color.White;
            this.Learning.Size = new System.Drawing.Size(198, 45);
            this.Learning.TabIndex = 4;
            this.Learning.Text = "Learning";
            this.Learning.Click += new System.EventHandler(this.Learning_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.guna2PictureBox2);
            this.MainPanel.Controls.Add(this.search_box);
            this.MainPanel.Controls.Add(this.profile_pict);
            this.MainPanel.Controls.Add(this.notif_button);
            this.MainPanel.Controls.Add(this.Welcome);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.pnKata);
            this.MainPanel.Controls.Add(this.ProgressPanel);
            this.MainPanel.Controls.Add(this.pnExercise);
            this.MainPanel.Controls.Add(this.pnLearning);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(817, 482);
            this.MainPanel.TabIndex = 11;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // search_box
            // 
            this.search_box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_box.Animated = true;
            this.search_box.BorderRadius = 20;
            this.search_box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_box.DefaultText = "";
            this.search_box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_box.Location = new System.Drawing.Point(603, 16);
            this.search_box.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_box.Name = "search_box";
            this.search_box.PasswordChar = '\0';
            this.search_box.PlaceholderText = "Search";
            this.search_box.SelectedText = "";
            this.search_box.Size = new System.Drawing.Size(194, 38);
            this.search_box.TabIndex = 16;
            this.search_box.TextOffset = new System.Drawing.Point(30, 0);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.Color.Black;
            this.Welcome.Location = new System.Drawing.Point(44, 45);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(209, 23);
            this.Welcome.TabIndex = 12;
            this.Welcome.Text = "Welcome To Pylearn";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154)))));
            this.label2.Location = new System.Drawing.Point(44, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "Hi Ijal,";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pnKata
            // 
            this.pnKata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnKata.BorderColor = System.Drawing.Color.Transparent;
            this.pnKata.BorderRadius = 15;
            this.pnKata.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnKata.BorderThickness = 1;
            this.pnKata.Controls.Add(this.HiText);
            this.pnKata.Controls.Add(this.Photo);
            this.pnKata.Controls.Add(this.Katakata);
            this.pnKata.Controls.Add(this.label1);
            this.pnKata.FillColor = System.Drawing.Color.White;
            this.pnKata.ForeColor = System.Drawing.Color.Coral;
            this.pnKata.Location = new System.Drawing.Point(45, 210);
            this.pnKata.Margin = new System.Windows.Forms.Padding(0);
            this.pnKata.Name = "pnKata";
            this.pnKata.ShadowDecoration.BorderRadius = 20;
            this.pnKata.Size = new System.Drawing.Size(425, 224);
            this.pnKata.TabIndex = 11;
            this.pnKata.Paint += new System.Windows.Forms.PaintEventHandler(this.pnKata_Paint);
            // 
            // HiText
            // 
            this.HiText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HiText.BackColor = System.Drawing.Color.White;
            this.HiText.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HiText.ForeColor = System.Drawing.Color.Black;
            this.HiText.Location = new System.Drawing.Point(265, 160);
            this.HiText.Name = "HiText";
            this.HiText.Size = new System.Drawing.Size(157, 16);
            this.HiText.TabIndex = 4;
            this.HiText.Text = "J. Robert Oppenheimer";
            this.HiText.Click += new System.EventHandler(this.HiText_Click);
            // 
            // Katakata
            // 
            this.Katakata.BackColor = System.Drawing.Color.Transparent;
            this.Katakata.BorderThickness = 0;
            this.Katakata.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Katakata.DefaultText = "The optimist thinks this is the best of all possible worlds. \r\nThe pessimist fear" +
    "s it is true.";
            this.Katakata.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Katakata.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Katakata.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Katakata.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Katakata.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Katakata.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Katakata.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Katakata.Location = new System.Drawing.Point(24, 66);
            this.Katakata.Margin = new System.Windows.Forms.Padding(0);
            this.Katakata.Multiline = true;
            this.Katakata.Name = "Katakata";
            this.Katakata.PasswordChar = '\0';
            this.Katakata.PlaceholderText = "";
            this.Katakata.SelectedText = "";
            this.Katakata.Size = new System.Drawing.Size(224, 139);
            this.Katakata.TabIndex = 2;
            this.Katakata.TextOffset = new System.Drawing.Point(-10, 0);
            this.Katakata.TextChanged += new System.EventHandler(this.Katakata_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Words of the day";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.MainPanel;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::LoginRegister.Properties.Resources.search;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(616, 24);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(22, 21);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 17;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // profile_pict
            // 
            this.profile_pict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.profile_pict.BackColor = System.Drawing.Color.Transparent;
            this.profile_pict.FillColor = System.Drawing.Color.Transparent;
            this.profile_pict.Image = global::LoginRegister.Properties.Resources.memoji;
            this.profile_pict.ImageRotate = 0F;
            this.profile_pict.Location = new System.Drawing.Point(568, 18);
            this.profile_pict.Name = "profile_pict";
            this.profile_pict.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profile_pict.Size = new System.Drawing.Size(29, 30);
            this.profile_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_pict.TabIndex = 15;
            this.profile_pict.TabStop = false;
            this.profile_pict.UseTransparentBackground = true;
            // 
            // notif_button
            // 
            this.notif_button.BackColor = System.Drawing.Color.Transparent;
            this.notif_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notif_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notif_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notif_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notif_button.FillColor = System.Drawing.Color.Transparent;
            this.notif_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.notif_button.ForeColor = System.Drawing.Color.White;
            this.notif_button.Image = global::LoginRegister.Properties.Resources.notif;
            this.notif_button.ImageSize = new System.Drawing.Size(30, 30);
            this.notif_button.Location = new System.Drawing.Point(535, 22);
            this.notif_button.Name = "notif_button";
            this.notif_button.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.notif_button.Size = new System.Drawing.Size(27, 26);
            this.notif_button.TabIndex = 14;
            this.notif_button.UseTransparentBackground = true;
            this.notif_button.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Photo
            // 
            this.Photo.BackColor = System.Drawing.Color.Transparent;
            this.Photo.Image = global::LoginRegister.Properties.Resources.J__Robert_Oppenheimer;
            this.Photo.ImageRotate = 0F;
            this.Photo.Location = new System.Drawing.Point(285, 57);
            this.Photo.Name = "Photo";
            this.Photo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Photo.Size = new System.Drawing.Size(100, 100);
            this.Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Photo.TabIndex = 3;
            this.Photo.TabStop = false;
            this.Photo.UseTransparentBackground = true;
            this.Photo.Click += new System.EventHandler(this.Photo_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.MainPanel);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(817, 482);
            this.pnExercise.ResumeLayout(false);
            this.ProgressPanel.ResumeLayout(false);
            this.ProgressPanel.PerformLayout();
            this.pnLearning.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.pnKata.ResumeLayout(false);
            this.pnKata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnExercise;
        private Guna.UI2.WinForms.Guna2Button Exercise;
        private Guna.UI2.WinForms.Guna2Panel ProgressPanel;
        private System.Windows.Forms.Label Completed;
        private System.Windows.Forms.Label ProgressText;
        private Guna.UI2.WinForms.Guna2CircleProgressBar ProgressBar;
        private Guna.UI2.WinForms.Guna2Panel pnLearning;
        private Guna.UI2.WinForms.Guna2Button Learning;
        private Guna.UI2.WinForms.Guna2Panel MainPanel;
        private Guna.UI2.WinForms.Guna2CircleButton notif_button;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profile_pict;
        private Guna.UI2.WinForms.Guna2TextBox search_box;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel pnKata;
        private System.Windows.Forms.Label HiText;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Photo;
        private Guna.UI2.WinForms.Guna2TextBox Katakata;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}
