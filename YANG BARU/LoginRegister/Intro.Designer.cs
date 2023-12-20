namespace LoginRegister
{
    partial class Intro
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
            this.PilihBab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PilihBab
            // 
            this.PilihBab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PilihBab.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PilihBab.ForeColor = System.Drawing.Color.Gray;
            this.PilihBab.Location = new System.Drawing.Point(105, 196);
            this.PilihBab.Name = "PilihBab";
            this.PilihBab.Size = new System.Drawing.Size(300, 23);
            this.PilihBab.TabIndex = 15;
            this.PilihBab.Text = "Pilih Bab Yang Ingin Dipelajari";
            this.PilihBab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Intro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PilihBab);
            this.Name = "Intro";
            this.Size = new System.Drawing.Size(496, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PilihBab;
    }
}
