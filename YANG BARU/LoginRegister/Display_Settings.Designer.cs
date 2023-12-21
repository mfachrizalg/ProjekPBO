namespace LoginRegister
{
    partial class Display_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display_Settings));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.pnDisplay = new Guna.UI2.WinForms.Guna2Panel();
            this.Dark_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Light_btn = new Guna.UI2.WinForms.Guna2Button();
            this.Theme_Style = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.Label();
            this.pnDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pnDisplay
            // 
            this.pnDisplay.Controls.Add(this.Dark_btn);
            this.pnDisplay.Controls.Add(this.Light_btn);
            this.pnDisplay.Controls.Add(this.Theme_Style);
            this.pnDisplay.Controls.Add(this.Display);
            this.pnDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDisplay.Location = new System.Drawing.Point(0, 0);
            this.pnDisplay.Name = "pnDisplay";
            this.pnDisplay.Size = new System.Drawing.Size(467, 413);
            this.pnDisplay.TabIndex = 0;
            // 
            // Dark_btn
            // 
            this.Dark_btn.Animated = true;
            this.Dark_btn.AnimatedGIF = true;
            this.Dark_btn.BackColor = System.Drawing.Color.Transparent;
            this.Dark_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Dark_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.Dark_btn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dark_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.Dark_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.Dark_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Dark_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Dark_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Dark_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Dark_btn.FillColor = System.Drawing.Color.Transparent;
            this.Dark_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Dark_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Dark_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Dark_btn.Image = ((System.Drawing.Image)(resources.GetObject("Dark_btn.Image")));
            this.Dark_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Dark_btn.Location = new System.Drawing.Point(11, 135);
            this.Dark_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Dark_btn.Name = "Dark_btn";
            this.Dark_btn.Size = new System.Drawing.Size(130, 41);
            this.Dark_btn.TabIndex = 25;
            this.Dark_btn.Text = "Dark Mode";
            this.Dark_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Light_btn
            // 
            this.Light_btn.Animated = true;
            this.Light_btn.AnimatedGIF = true;
            this.Light_btn.BackColor = System.Drawing.Color.Transparent;
            this.Light_btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Light_btn.Checked = true;
            this.Light_btn.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Light_btn.CheckedState.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Light_btn.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Light_btn.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.Light_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Light_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Light_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Light_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.Light_btn.FillColor = System.Drawing.Color.Transparent;
            this.Light_btn.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Light_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.Light_btn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.Light_btn.Image = ((System.Drawing.Image)(resources.GetObject("Light_btn.Image")));
            this.Light_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Light_btn.Location = new System.Drawing.Point(11, 91);
            this.Light_btn.Margin = new System.Windows.Forms.Padding(0);
            this.Light_btn.Name = "Light_btn";
            this.Light_btn.Size = new System.Drawing.Size(130, 44);
            this.Light_btn.TabIndex = 24;
            this.Light_btn.Text = "Light Mode";
            this.Light_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Theme_Style
            // 
            this.Theme_Style.AutoSize = true;
            this.Theme_Style.BackColor = System.Drawing.Color.Transparent;
            this.Theme_Style.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Theme_Style.ForeColor = System.Drawing.Color.Black;
            this.Theme_Style.Location = new System.Drawing.Point(17, 72);
            this.Theme_Style.Name = "Theme_Style";
            this.Theme_Style.Size = new System.Drawing.Size(107, 19);
            this.Theme_Style.TabIndex = 23;
            this.Theme_Style.Text = "Theme Style";
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.Gray;
            this.Display.Location = new System.Drawing.Point(17, 29);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(161, 23);
            this.Display.TabIndex = 22;
            this.Display.Text = "Display Settings";
            // 
            // Display_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnDisplay);
            this.Name = "Display_Settings";
            this.Size = new System.Drawing.Size(467, 413);
            this.pnDisplay.ResumeLayout(false);
            this.pnDisplay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel pnDisplay;
        private Guna.UI2.WinForms.Guna2Button Dark_btn;
        private Guna.UI2.WinForms.Guna2Button Light_btn;
        private System.Windows.Forms.Label Theme_Style;
        private System.Windows.Forms.Label Display;
    }
}
