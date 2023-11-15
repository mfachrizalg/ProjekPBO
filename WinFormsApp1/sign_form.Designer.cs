namespace WinFormsApp1
{
    partial class sign_form
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
            text_username = new TextBox();
            text_password = new TextBox();
            button_create = new Button();
            button1 = new Button();
            label3 = new Label();
            text_confirm = new TextBox();
            label4 = new Label();
            button_login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 190);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 234);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "password";
            // 
            // text_username
            // 
            text_username.Location = new Point(280, 183);
            text_username.Name = "text_username";
            text_username.Size = new Size(254, 27);
            text_username.TabIndex = 2;
            text_username.TextChanged += text_username_TextChanged;
            // 
            // text_password
            // 
            text_password.Location = new Point(280, 227);
            text_password.Name = "text_password";
            text_password.Size = new Size(254, 27);
            text_password.TabIndex = 3;
            // 
            // button_create
            // 
            button_create.Location = new Point(301, 306);
            button_create.Name = "button_create";
            button_create.Size = new Size(233, 29);
            button_create.TabIndex = 4;
            button_create.Text = "Create Account";
            button_create.UseVisualStyleBackColor = true;
            button_create.Click += button_create_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(254, 94);
            label3.Name = "label3";
            label3.Size = new Size(295, 46);
            label3.TabIndex = 6;
            label3.Text = "CREATE ACCOUNT";
            // 
            // text_confirm
            // 
            text_confirm.Location = new Point(280, 273);
            text_confirm.Name = "text_confirm";
            text_confirm.Size = new Size(254, 27);
            text_confirm.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 280);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 9;
            label4.Text = "confirm password";
            // 
            // button_login
            // 
            button_login.Location = new Point(301, 341);
            button_login.Name = "button_login";
            button_login.Size = new Size(233, 29);
            button_login.TabIndex = 10;
            button_login.Text = "Already have account? Login";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // sign_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(label4);
            Controls.Add(text_confirm);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(button_create);
            Controls.Add(text_password);
            Controls.Add(text_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "sign_form";
            Text = "sign_form";
            Load += sign_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_username;
        private TextBox text_password;
        private Button button_create;
        private Button button1;
        private Label label3;
        private TextBox text_confirm;
        private Label label4;
        private Button button_login;
    }
}