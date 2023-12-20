namespace LoginRegister
{
    partial class Profile
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
            this.Exercise = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Exercise
            // 
            this.Exercise.CheckedState.FillColor = System.Drawing.Color.White;
            this.Exercise.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.Exercise.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.Exercise.DisabledState.FillColor = System.Drawing.Color.White;
            this.Exercise.DisabledState.ForeColor = System.Drawing.Color.White;
            this.Exercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exercise.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Exercise.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exercise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Exercise.HoverState.FillColor = System.Drawing.Color.White;
            this.Exercise.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Exercise.Location = new System.Drawing.Point(0, 0);
            this.Exercise.Name = "Exercise";
            this.Exercise.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(38)))), ((int)(((byte)(129)))));
            this.Exercise.Size = new System.Drawing.Size(817, 482);
            this.Exercise.TabIndex = 5;
            this.Exercise.Text = "PROFILE";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.Exercise);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(817, 482);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Exercise;
    }
}
