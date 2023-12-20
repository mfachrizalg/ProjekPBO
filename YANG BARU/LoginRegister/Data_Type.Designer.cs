namespace LoginRegister
{
    partial class Data_Type
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
            this.web1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // web1
            // 
            this.web1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.web1.Location = new System.Drawing.Point(37, 42);
            this.web1.MinimumSize = new System.Drawing.Size(20, 20);
            this.web1.Name = "web1";
            this.web1.Size = new System.Drawing.Size(432, 367);
            this.web1.TabIndex = 0;
            // 
            // Data_Type
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.web1);
            this.Name = "Data_Type";
            this.Size = new System.Drawing.Size(496, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser web1;
    }
}
