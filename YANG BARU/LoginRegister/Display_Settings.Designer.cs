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
            this.Display = new System.Windows.Forms.Label();
            this.Theme_Style = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // Display
            // 
            this.Display.AutoSize = true;
            this.Display.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display.ForeColor = System.Drawing.Color.Gray;
            this.Display.Location = new System.Drawing.Point(21, 28);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(161, 23);
            this.Display.TabIndex = 15;
            this.Display.Text = "Display Settings";
            // 
            // Theme_Style
            // 
            this.Theme_Style.AutoSize = true;
            this.Theme_Style.BackColor = System.Drawing.Color.White;
            this.Theme_Style.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.Theme_Style.ForeColor = System.Drawing.Color.Black;
            this.Theme_Style.Location = new System.Drawing.Point(21, 71);
            this.Theme_Style.Name = "Theme_Style";
            this.Theme_Style.Size = new System.Drawing.Size(107, 19);
            this.Theme_Style.TabIndex = 17;
            this.Theme_Style.Text = "Theme Style";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Display_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Theme_Style);
            this.Controls.Add(this.Display);
            this.Name = "Display_Settings";
            this.Size = new System.Drawing.Size(467, 413);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Display;
        private System.Windows.Forms.Label Theme_Style;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
