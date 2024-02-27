namespace WinFormsApp1
{
    partial class UserForm
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
            RecordStatus = new Label();
            ServiceLabel = new Label();
            DateLabel = new Label();
            TimeLabel = new Label();
            label5 = new Label();
            MasterNameLabel = new Label();
            EmailTxtBox = new TextBox();
            PasswordTxtBox = new TextBox();
            panel1 = new Panel();
            RecordBtn = new Button();
            QuestionBtn = new Button();
            SaveBtn = new Button();
            EmailLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RecordStatus
            // 
            RecordStatus.AutoSize = true;
            RecordStatus.Location = new Point(35, 16);
            RecordStatus.Name = "RecordStatus";
            RecordStatus.Size = new Size(38, 15);
            RecordStatus.TabIndex = 0;
            RecordStatus.Text = "label1";
            // 
            // ServiceLabel
            // 
            ServiceLabel.AutoSize = true;
            ServiceLabel.Location = new Point(23, 42);
            ServiceLabel.Name = "ServiceLabel";
            ServiceLabel.Size = new Size(38, 15);
            ServiceLabel.TabIndex = 1;
            ServiceLabel.Text = "label2";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(23, 66);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(38, 15);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "label3";
            // 
            // TimeLabel
            // 
            TimeLabel.AutoSize = true;
            TimeLabel.Location = new Point(23, 92);
            TimeLabel.Name = "TimeLabel";
            TimeLabel.Size = new Size(38, 15);
            TimeLabel.TabIndex = 3;
            TimeLabel.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 59);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 4;
            label5.Text = "Мастер:\r\n";
            // 
            // MasterNameLabel
            // 
            MasterNameLabel.AutoSize = true;
            MasterNameLabel.Location = new Point(101, 78);
            MasterNameLabel.Name = "MasterNameLabel";
            MasterNameLabel.Size = new Size(38, 15);
            MasterNameLabel.TabIndex = 5;
            MasterNameLabel.Text = "label6";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(261, 49);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(138, 23);
            EmailTxtBox.TabIndex = 6;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(261, 90);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(138, 23);
            PasswordTxtBox.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(ServiceLabel);
            panel1.Controls.Add(DateLabel);
            panel1.Controls.Add(MasterNameLabel);
            panel1.Controls.Add(TimeLabel);
            panel1.Location = new Point(12, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(182, 165);
            panel1.TabIndex = 9;
            // 
            // RecordBtn
            // 
            RecordBtn.Location = new Point(12, 216);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(81, 23);
            RecordBtn.TabIndex = 10;
            RecordBtn.Text = "Записаться";
            RecordBtn.UseVisualStyleBackColor = true;
            RecordBtn.Click += RecordBtn_Click;
            // 
            // QuestionBtn
            // 
            QuestionBtn.Location = new Point(99, 216);
            QuestionBtn.Name = "QuestionBtn";
            QuestionBtn.Size = new Size(95, 23);
            QuestionBtn.TabIndex = 11;
            QuestionBtn.Text = "Задать вопрос";
            QuestionBtn.UseVisualStyleBackColor = true;
            QuestionBtn.Click += QuestionBtn_Click;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(261, 216);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(138, 23);
            SaveBtn.TabIndex = 13;
            SaveBtn.Text = "Сохранить данные";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(336, 9);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(38, 15);
            EmailLabel.TabIndex = 14;
            EmailLabel.Text = "label7";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 279);
            Controls.Add(EmailLabel);
            Controls.Add(RecordStatus);
            Controls.Add(SaveBtn);
            Controls.Add(QuestionBtn);
            Controls.Add(RecordBtn);
            Controls.Add(panel1);
            Controls.Add(PasswordTxtBox);
            Controls.Add(EmailTxtBox);
            Name = "UserForm";
            Text = "UserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RecordStatus;
        private Label ServiceLabel;
        private Label DateLabel;
        private Label TimeLabel;
        private Label label5;
        private Label MasterNameLabel;
        private TextBox EmailTxtBox;
        private TextBox PasswordTxtBox;
        private Panel panel1;
        private Button RecordBtn;
        private Button QuestionBtn;
        private Button SaveBtn;
        private Label EmailLabel;
    }
}