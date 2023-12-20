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
            this.pnRight = new Guna.UI2.WinForms.Guna2Panel();
            this.introContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.MenuTransition = new System.Windows.Forms.Timer(this.components);
            this.back = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DataType = new Guna.UI2.WinForms.Guna2Button();
            this.Intro = new Guna.UI2.WinForms.Guna2Button();
            this.pnRight.SuspendLayout();
            this.introContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.White;
            this.pnRight.BorderThickness = 1;
            this.pnRight.Controls.Add(this.introContainer);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(614, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(203, 482);
            this.pnRight.TabIndex = 3;
            // 
            // introContainer
            // 
            this.introContainer.BackColor = System.Drawing.Color.White;
            this.introContainer.Controls.Add(this.DataType);
            this.introContainer.Controls.Add(this.Intro);
            this.introContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.introContainer.Location = new System.Drawing.Point(0, 0);
            this.introContainer.Name = "introContainer";
            this.introContainer.Size = new System.Drawing.Size(203, 53);
            this.introContainer.TabIndex = 2;
            // 
            // MenuTransition
            // 
            this.MenuTransition.Tick += new System.EventHandler(this.MenuTransition_Tick_1);
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
            this.back.Location = new System.Drawing.Point(25, 24);
            this.back.Name = "back";
            this.back.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.back.Size = new System.Drawing.Size(34, 39);
            this.back.TabIndex = 37;
            this.back.UseTransparentBackground = true;
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
            this.DataType.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataType.FillColor = System.Drawing.Color.White;
            this.DataType.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.DataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(175)))), ((int)(((byte)(203)))));
            this.DataType.HoverState.FillColor = System.Drawing.Color.White;
            this.DataType.Image = global::LoginRegister.Properties.Resources.gray_dot;
            this.DataType.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DataType.ImageOffset = new System.Drawing.Point(20, 0);
            this.DataType.ImageSize = new System.Drawing.Size(10, 10);
            this.DataType.Location = new System.Drawing.Point(0, 53);
            this.DataType.Margin = new System.Windows.Forms.Padding(0);
            this.DataType.Name = "DataType";
            this.DataType.Size = new System.Drawing.Size(203, 53);
            this.DataType.TabIndex = 0;
            this.DataType.Text = "Data Type";
            this.DataType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DataType.TextOffset = new System.Drawing.Point(40, 0);
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
            this.Intro.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.Intro.Size = new System.Drawing.Size(203, 53);
            this.Intro.TabIndex = 1;
            this.Intro.Text = "Intro";
            this.Intro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Intro.TextOffset = new System.Drawing.Point(40, 0);
            this.Intro.Click += new System.EventHandler(this.Intro_Click);
            // 
            // Learningg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.back);
            this.Controls.Add(this.pnRight);
            this.Name = "Learningg";
            this.Size = new System.Drawing.Size(817, 482);
            this.pnRight.ResumeLayout(false);
            this.introContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnRight;
        private Guna.UI2.WinForms.Guna2Panel introContainer;
        private Guna.UI2.WinForms.Guna2Button DataType;
        private Guna.UI2.WinForms.Guna2Button Intro;
        private System.Windows.Forms.Timer MenuTransition;
        private Guna.UI2.WinForms.Guna2CircleButton back;
    }
}
