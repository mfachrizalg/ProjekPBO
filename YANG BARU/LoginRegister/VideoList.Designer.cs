namespace LoginRegister
{
    partial class VideoList
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
            this.refresh_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(44, 22);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(75, 23);
            this.refresh_btn.TabIndex = 0;
            this.refresh_btn.Text = "refresh";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // VideoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refresh_btn);
            this.Name = "VideoList";
            this.Size = new System.Drawing.Size(817, 482);
            this.Load += new System.EventHandler(this.VideoList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button refresh_btn;
    }
}
