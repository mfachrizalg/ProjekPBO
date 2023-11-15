namespace WinFormsApp1
{
    partial class Form_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            text_username = new TextBox();
            text_password = new TextBox();
            button_login = new Button();
            button_clear = new Button();
            button_sign = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 156);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 200);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "password";
            label2.Click += label2_Click;
            // 
            // text_username
            // 
            text_username.Location = new Point(223, 156);
            text_username.Name = "text_username";
            text_username.Size = new Size(273, 27);
            text_username.TabIndex = 2;
            // 
            // text_password
            // 
            text_password.Location = new Point(223, 197);
            text_password.Name = "text_password";
            text_password.Size = new Size(273, 27);
            text_password.TabIndex = 3;
            // 
            // button_login
            // 
            button_login.Location = new Point(402, 239);
            button_login.Name = "button_login";
            button_login.Size = new Size(94, 29);
            button_login.TabIndex = 4;
            button_login.Text = "Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(279, 239);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 5;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // button_sign
            // 
            button_sign.Location = new Point(279, 276);
            button_sign.Name = "button_sign";
            button_sign.Size = new Size(217, 29);
            button_sign.TabIndex = 6;
            button_sign.Text = "Sign Up";
            button_sign.UseVisualStyleBackColor = true;
            button_sign.Click += button_sign_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(110, 280);
            label3.Name = "label3";
            label3.Size = new Size(163, 20);
            label3.TabIndex = 7;
            label3.Text = "Don't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button_sign);
            Controls.Add(button_clear);
            Controls.Add(button_login);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_username;
        private TextBox text_password;
        private Button button_login;
        private Button button_clear;
        private Button button_sign;
        private Label label3;
    }
}