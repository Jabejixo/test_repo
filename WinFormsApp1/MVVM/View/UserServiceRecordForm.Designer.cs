namespace WinFormsApp1
{
    partial class UserServiceRecordForm
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
            MastersListBox = new CheckedListBox();
            ServiseListBox = new CheckedListBox();
            DatePicker = new DateTimePicker();
            TimePicker = new DateTimePicker();
            MasterNameTxtBox = new TextBox();
            BackBtn = new Button();
            RecordBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            ServiceNameTxtBox = new TextBox();
            label3 = new Label();
            DateTxtBox = new TextBox();
            label4 = new Label();
            TimeTxtBox = new TextBox();
            SuspendLayout();
            // 
            // MastersListBox
            // 
            MastersListBox.FormattingEnabled = true;
            MastersListBox.Location = new Point(668, 12);
            MastersListBox.Name = "MastersListBox";
            MastersListBox.Size = new Size(120, 220);
            MastersListBox.TabIndex = 0;
            MastersListBox.SelectedIndexChanged += MastersListBox_SelectedIndexChanged;
            // 
            // ServiseListBox
            // 
            ServiseListBox.FormattingEnabled = true;
            ServiseListBox.Location = new Point(542, 12);
            ServiseListBox.Name = "ServiseListBox";
            ServiseListBox.Size = new Size(120, 220);
            ServiseListBox.TabIndex = 1;
            ServiseListBox.SelectedIndexChanged += ServiseListBox_SelectedIndexChanged;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(300, 12);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 2;
            // 
            // TimePicker
            // 
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.Location = new Point(300, 178);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(200, 23);
            TimePicker.TabIndex = 3;
            // 
            // MasterNameTxtBox
            // 
            MasterNameTxtBox.Location = new Point(12, 26);
            MasterNameTxtBox.Name = "MasterNameTxtBox";
            MasterNameTxtBox.Size = new Size(145, 23);
            MasterNameTxtBox.TabIndex = 4;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(12, 275);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(145, 23);
            BackBtn.TabIndex = 8;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // RecordBtn
            // 
            RecordBtn.Location = new Point(660, 275);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(128, 23);
            RecordBtn.TabIndex = 9;
            RecordBtn.Text = "Записаться";
            RecordBtn.UseVisualStyleBackColor = true;
            RecordBtn.Click += RecordBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 8);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 10;
            label1.Text = "Мастер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 68);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 12;
            label2.Text = "Услуга";
            // 
            // ServiceNameTxtBox
            // 
            ServiceNameTxtBox.Location = new Point(12, 86);
            ServiceNameTxtBox.Name = "ServiceNameTxtBox";
            ServiceNameTxtBox.Size = new Size(145, 23);
            ServiceNameTxtBox.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 132);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 14;
            label3.Text = "Дата";
            // 
            // DateTxtBox
            // 
            DateTxtBox.Location = new Point(12, 150);
            DateTxtBox.Name = "DateTxtBox";
            DateTxtBox.Size = new Size(145, 23);
            DateTxtBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 191);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 16;
            label4.Text = "Время";
            // 
            // TimeTxtBox
            // 
            TimeTxtBox.Location = new Point(12, 209);
            TimeTxtBox.Name = "TimeTxtBox";
            TimeTxtBox.Size = new Size(145, 23);
            TimeTxtBox.TabIndex = 15;
            // 
            // UserServiceRecordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 321);
            Controls.Add(label4);
            Controls.Add(TimeTxtBox);
            Controls.Add(label3);
            Controls.Add(DateTxtBox);
            Controls.Add(label2);
            Controls.Add(ServiceNameTxtBox);
            Controls.Add(label1);
            Controls.Add(RecordBtn);
            Controls.Add(BackBtn);
            Controls.Add(MasterNameTxtBox);
            Controls.Add(TimePicker);
            Controls.Add(DatePicker);
            Controls.Add(ServiseListBox);
            Controls.Add(MastersListBox);
            Name = "UserServiceRecordForm";
            Text = "UserServiceRecordViewModel";
            Load += UserServiceRecordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private CheckedListBox MastersListBox;
        private CheckedListBox ServiseListBox;
        private DateTimePicker DatePicker;
        private DateTimePicker TimePicker;
        private TextBox MasterNameTxtBox;
        private Button BackBtn;
        private Button RecordBtn;
        private Label label1;
        private Label label2;
        private TextBox ServiceNameTxtBox;
        private Label label3;
        private TextBox DateTxtBox;
        private Label label4;
        private TextBox TimeTxtBox;
    }
}