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
            this.pnExercise = new Guna.UI2.WinForms.Guna2Panel();
            this.Exercise = new Guna.UI2.WinForms.Guna2Button();
            this.pnExercise.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnExercise
            // 
            this.pnExercise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.pnExercise.BorderColor = System.Drawing.Color.Transparent;
            this.pnExercise.BorderRadius = 15;
            this.pnExercise.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.pnExercise.BorderThickness = 1;
            this.pnExercise.Controls.Add(this.Exercise);
            this.pnExercise.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnExercise.FillColor = System.Drawing.Color.White;
            this.pnExercise.ForeColor = System.Drawing.Color.Coral;
            this.pnExercise.Location = new System.Drawing.Point(0, 0);
            this.pnExercise.Margin = new System.Windows.Forms.Padding(0);
            this.pnExercise.Name = "pnExercise";
            this.pnExercise.ShadowDecoration.BorderRadius = 20;
            this.pnExercise.Size = new System.Drawing.Size(817, 482);
            this.pnExercise.TabIndex = 11;
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
            this.Exercise.TabIndex = 4;
            this.Exercise.Text = "SETTINGS";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.pnExercise);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(817, 482);
            this.pnExercise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnExercise;
        private Guna.UI2.WinForms.Guna2Button Exercise;
    }
}
