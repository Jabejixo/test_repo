namespace WinFormsApp1
{
    sealed partial class RegForm
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
            RegisterButton = new Button();
            LoginBtn = new Button();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(310, 297);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 23);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // LoginBtn
            // 
            LoginBtn.Location = new Point(292, 326);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(190, 38);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "авторизация";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += this.LoginBtn_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(310, 82);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(150, 23);
            UsernameTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(310, 126);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(150, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(344, 33);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 5;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 64);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(363, 108);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль";
            // 
            // RegForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(LoginBtn);
            Controls.Add(RegisterButton);
            Name = "RegForm";
            Text = "RegForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegisterButton;
        private Button LoginBtn;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
