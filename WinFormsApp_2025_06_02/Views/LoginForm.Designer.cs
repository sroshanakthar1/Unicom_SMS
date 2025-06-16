namespace WinFormsApp_2025_06_02
{
    partial class LoginForm
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
            userNameLabel = new Label();
            passwordLabel = new Label();
            heading = new Label();
            userNameTxt = new TextBox();
            passwordTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(255, 96);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(69, 15);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username : ";
            userNameLabel.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(255, 147);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(66, 15);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password  :";
            passwordLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI Emoji", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            heading.ForeColor = Color.DarkOliveGreen;
            heading.Location = new Point(305, 43);
            heading.Name = "heading";
            heading.Size = new Size(86, 28);
            heading.TabIndex = 2;
            heading.Text = "LOG IN";
            heading.TextAlign = ContentAlignment.MiddleCenter;
            heading.Click += label4_Click;
            // 
            // userNameTxt
            // 
            userNameTxt.Location = new Point(348, 93);
            userNameTxt.Margin = new Padding(3, 2, 3, 2);
            userNameTxt.Name = "userNameTxt";
            userNameTxt.Size = new Size(110, 23);
            userNameTxt.TabIndex = 3;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(348, 144);
            passwordTxt.Margin = new Padding(3, 2, 3, 2);
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(110, 23);
            passwordTxt.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(308, 203);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnLogin;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(passwordTxt);
            Controls.Add(userNameTxt);
            Controls.Add(heading);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private Label heading;
        private TextBox userNameTxt;
        private TextBox passwordTxt;
        private Button button1;
    }
}