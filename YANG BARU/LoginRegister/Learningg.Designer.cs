namespace LoginRegister
{
    partial class Learningg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Learningg));
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.pnLearning = new Guna.UI2.WinForms.Guna2Panel();
            this.pnList = new Guna.UI2.WinForms.Guna2Panel();
            this.introContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.DataType = new Guna.UI2.WinForms.Guna2Button();
            this.Intro = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.GlobalSettings = new System.Windows.Forms.Label();
            this.back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnList.SuspendLayout();
            this.introContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTransition
            // 
            this.MenuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick_1);
            // 
            // pnLearning
            // 
            this.pnLearning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnLearning.BorderColor = System.Drawing.Color.Transparent;
            this.pnLearning.BorderRadius = 20;
            this.pnLearning.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnLearning.BorderThickness = 1;
            this.pnLearning.FillColor = System.Drawing.Color.White;
            this.pnLearning.ForeColor = System.Drawing.Color.Coral;
            this.pnLearning.Location = new System.Drawing.Point(62, 20);
            this.pnLearning.Margin = new System.Windows.Forms.Padding(0);
            this.pnLearning.Name = "pnLearning";
            this.pnLearning.ShadowDecoration.BorderRadius = 20;
            this.pnLearning.Size = new System.Drawing.Size(372, 355);
            this.pnLearning.TabIndex = 38;
            this.pnLearning.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLearning_Paint);
            // 
            // pnList
            // 
            this.pnList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnList.BorderColor = System.Drawing.Color.Transparent;
            this.pnList.BorderRadius = 20;
            this.pnList.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnList.BorderThickness = 1;
            this.pnList.Controls.Add(this.introContainer);
            this.pnList.Controls.Add(this.guna2Separator2);
            this.pnList.Controls.Add(this.GlobalSettings);
            this.pnList.FillColor = System.Drawing.Color.White;
            this.pnList.ForeColor = System.Drawing.Color.Coral;
            this.pnList.Location = new System.Drawing.Point(448, 20);
            this.pnList.Margin = new System.Windows.Forms.Padding(0);
            this.pnList.Name = "pnList";
            this.pnList.ShadowDecoration.BorderRadius = 20;
            this.pnList.Size = new System.Drawing.Size(156, 355);
            this.pnList.TabIndex = 14;
            this.pnList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnList_Paint);
            // 
            // introContainer
            // 
            this.introContainer.BackColor = System.Drawing.Color.White;
            this.introContainer.Controls.Add(this.DataType);
            this.introContainer.Controls.Add(this.Intro);
            this.introContainer.Location = new System.Drawing.Point(2, 57);
            this.introContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.introContainer.Name = "introContainer";
            this.introContainer.Size = new System.Drawing.Size(152, 106);
            this.introContainer.TabIndex = 2;
            // 
            // DataType
            // 
            this.DataType.Animated = true;
            this.DataType.AnimatedGIF = true;
            this.DataType.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DataType.Checked = true;
            this.DataType.CheckedState.FillColor = System.Drawing.Color.White;
            this.DataType.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.DataType.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.DataType.CheckedState.Image = global::LoginRegister.Properties.Resources.dot;
            this.DataType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DataType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DataType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DataType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DataType.FillColor = System.Drawing.Color.White;
            this.DataType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.DataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.DataType.HoverState.FillColor = System.Drawing.Color.White;
            this.DataType.Image = global::LoginRegister.Properties.Resources.gray_dot;
            this.DataType.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DataType.ImageOffset = new System.Drawing.Point(20, 0);
            this.DataType.ImageSize = new System.Drawing.Size(10, 10);
            this.DataType.Location = new System.Drawing.Point(0, 43);
            this.DataType.Margin = new System.Windows.Forms.Padding(0);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(152, 43);
            this.DataType.TabIndex = 0;
            this.DataType.Text = "Data Type";
            this.DataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DataType.TextOffset = new System.Drawing.Point(40, 0);
            this.DataType.Click += new System.EventHandler(this.DataType_Click);
            // 
            // Intro
            // 
            this.Intro.Animated = true;
            this.Intro.AnimatedGIF = true;
            this.Intro.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Intro.Checked = true;
            this.Intro.CheckedState.FillColor = System.Drawing.Color.White;
            this.Intro.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Intro.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Intro.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Intro.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Intro.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Intro.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Intro.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Intro.FillColor = System.Drawing.Color.White;
            this.Intro.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Intro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Intro.HoverState.FillColor = System.Drawing.Color.White;
            this.Intro.Image = ((System.Drawing.Image)(resources.GetObject("Intro.Image")));
            this.Intro.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Intro.ImageOffset = new System.Drawing.Point(15, 0);
            this.Intro.Location = new System.Drawing.Point(0, 0);
            this.Intro.Margin = new System.Windows.Forms.Padding(0);
            this.Intro.Name = "Intro";
            this.Intro.Size = new System.Drawing.Size(152, 43);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Intro";
            this.Intro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Intro.TextOffset = new System.Drawing.Point(40, 0);
            this.Intro.Click += new System.EventHandler(this.Intro_Click);
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.BackColor = System.Drawing.Color.White;
            this.guna2Separator2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Separator2.FillThickness = 3;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 44);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(182, 8);
            this.guna2Separator2.TabIndex = 17;
            // 
            // GlobalSettings
            // 
            this.GlobalSettings.AutoSize = true;
            this.GlobalSettings.BackColor = System.Drawing.Color.White;
            this.GlobalSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GlobalSettings.ForeColor = System.Drawing.Color.Black;
            this.GlobalSettings.Location = new System.Drawing.Point(14, 20);
            this.GlobalSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GlobalSettings.Name = "GlobalSettings";
            this.GlobalSettings.Size = new System.Drawing.Size(123, 19);
            this.GlobalSettings.TabIndex = 13;
            this.GlobalSettings.Text = "Global Settings";
            // 
            // back
            // 
            this.back.Animated = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.back.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.back.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Image = global::LoginRegister.Properties.Resources.back1;
            this.back.ImageSize = new System.Drawing.Size(25, 25);
            this.back.Location = new System.Drawing.Point(19, 20);
            this.back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.back.Name = "back";
            this.back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.back.Size = new System.Drawing.Size(26, 32);
            this.back.TabIndex = 37;
            this.back.UseTransparentBackground = true;
            // 
            // Learningg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.pnList);
            this.Controls.Add(this.pnLearning);
            this.Controls.Add(this.back);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Learningg";
            this.Size = new System.Drawing.Size(613, 392);
            this.Load += new System.EventHandler(this.Learningg_Load);
            this.pnList.ResumeLayout(false);
            this.pnList.PerformLayout();
            this.introContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button DataType;
        private Guna.UI2.WinForms.Guna2Button Intro;
        private System.Windows.Forms.Timer MenuTransition;
        private Guna.UI2.WinForms.Guna2CircleButton back;
        private Guna.UI2.WinForms.Guna2Panel pnLearning;
        private Guna.UI2.WinForms.Guna2Panel pnList;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private System.Windows.Forms.Label GlobalSettings;
        private Guna.UI2.WinForms.Guna2Panel introContainer;
    }
}
