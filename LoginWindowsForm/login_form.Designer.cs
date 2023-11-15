namespace LoginWindowsForm
{
    partial class login_form
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            text_username = new TextBox();
            text_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 88);
            label1.Name = "label1";
            label1.Size = new Size(180, 46);
            label1.TabIndex = 0;
            label1.Text = "WELCOME";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 184);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 1;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 256);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // text_username
            // 
            text_username.Location = new Point(211, 184);
            text_username.Name = "text_username";
            text_username.Size = new Size(288, 27);
            text_username.TabIndex = 3;
            text_username.TextChanged += text_username_TextChanged;
            // 
            // text_password
            // 
            text_password.Location = new Point(211, 249);
            text_password.Name = "text_password";
            text_password.Size = new Size(288, 27);
            text_password.TabIndex = 4;
            text_password.TextChanged += text_password_TextChanged;
            // 
            // button_login
            // 
            button_login.BackColor = SystemColors.ActiveBorder;
            button_login.ForeColor = SystemColors.ActiveCaptionText;
            button_login.Location = new Point(405, 299);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 5;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = false;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.BackColor = SystemColors.ActiveBorder;
            button_clear.ForeColor = SystemColors.ActiveCaptionText;
            button_clear.Location = new Point(280, 299);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            button_clear.Click += button_clear_Click;
            // 
            // login_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "login_form";
            Text = "login_form";
            Load += login_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_username;
        private TextBox text_password;
        private Button button_login;
        private Button button_clear;
    }
}