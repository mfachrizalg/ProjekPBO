namespace LoginRegister
{
    partial class lvl1
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
            this.lvl1_soal = new System.Windows.Forms.Label();
            this.copy_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvl1_soal
            // 
            this.lvl1_soal.AutoSize = true;
            this.lvl1_soal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lvl1_soal.Location = new System.Drawing.Point(12, 202);
            this.lvl1_soal.Name = "lvl1_soal";
            this.lvl1_soal.Size = new System.Drawing.Size(502, 20);
            this.lvl1_soal.TabIndex = 0;
            this.lvl1_soal.Text = "vhodpdw, ndpx whodk phqbhohvdlndq odwlkdq sbwkrq shuwdpdpx!";
            this.lvl1_soal.Click += new System.EventHandler(this.label1_Click);
            // 
            // copy_button
            // 
            this.copy_button.Location = new System.Drawing.Point(661, 194);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(89, 39);
            this.copy_button.TabIndex = 1;
            this.copy_button.Text = "copy";
            this.copy_button.UseVisualStyleBackColor = true;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(609, 22);
            this.textBox1.TabIndex = 2;
            // 
            // lvl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.lvl1_soal);
            this.Name = "lvl1";
            this.Text = "lvl1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lvl1_soal;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.TextBox textBox1;
    }
}