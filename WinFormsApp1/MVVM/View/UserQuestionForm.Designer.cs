namespace WinFormsApp1.MVVM.View
{
    partial class UserQuestionForm
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
            BackBtn = new Button();
            SendBtn = new Button();
            EmailTxtBox = new TextBox();
            QuestionTxtBox = new TextBox();
            RecordStatus = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(41, 163);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(110, 23);
            BackBtn.TabIndex = 14;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SendBtn
            // 
            SendBtn.Location = new Point(217, 163);
            SendBtn.Name = "SendBtn";
            SendBtn.Size = new Size(110, 23);
            SendBtn.TabIndex = 15;
            SendBtn.Text = "Отправить";
            SendBtn.UseVisualStyleBackColor = true;
            SendBtn.Click += SendBtn_Click;
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.Location = new Point(41, 50);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(286, 23);
            EmailTxtBox.TabIndex = 16;
            // 
            // QuestionTxtBox
            // 
            QuestionTxtBox.Location = new Point(41, 118);
            QuestionTxtBox.Name = "QuestionTxtBox";
            QuestionTxtBox.Size = new Size(286, 23);
            QuestionTxtBox.TabIndex = 17;
            // 
            // RecordStatus
            // 
            RecordStatus.AutoSize = true;
            RecordStatus.Location = new Point(165, 100);
            RecordStatus.Name = "RecordStatus";
            RecordStatus.Size = new Size(48, 15);
            RecordStatus.TabIndex = 18;
            RecordStatus.Text = "Вопрос";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 32);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 19;
            label1.Text = "Почта";
            // 
            // UserQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 258);
            Controls.Add(label1);
            Controls.Add(RecordStatus);
            Controls.Add(QuestionTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(SendBtn);
            Controls.Add(BackBtn);
            Name = "UserQuestionForm";
            Text = "UserQuestionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button SendBtn;
        private TextBox EmailTxtBox;
        private TextBox QuestionTxtBox;
        private Label RecordStatus;
        private Label label1;
    }
}