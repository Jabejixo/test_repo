namespace WinFormsApp1
{
    partial class AdminForm
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
            userPanel = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            RoleCbx = new ComboBox();
            PasswordTxtBox = new TextBox();
            userNameTxtBox = new TextBox();
            MasterPanel = new Panel();
            MasterNameTxtBox = new TextBox();
            label4 = new Label();
            SchedulePanel = new Panel();
            label12 = new Label();
            UserCbx = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            SerciceCbx = new ComboBox();
            MasterCbx = new ComboBox();
            DatePicker = new DateTimePicker();
            TimePicker = new DateTimePicker();
            DataGrid = new DataGridView();
            ServicesPanel = new Panel();
            PriceTxtBox = new TextBox();
            ServiceNameTxtBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label11 = new Label();
            WordBtn = new Button();
            ExcelBtn = new Button();
            PdfBtn = new Button();
            CreateBtn = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            UserDataTableBtn = new Button();
            ServicesDataTableBtn = new Button();
            MastersDataTableBtn = new Button();
            ScheduleDataTableBtn = new Button();
            userPanel.SuspendLayout();
            MasterPanel.SuspendLayout();
            SchedulePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
            ServicesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // userPanel
            // 
            userPanel.Controls.Add(label3);
            userPanel.Controls.Add(label2);
            userPanel.Controls.Add(label1);
            userPanel.Controls.Add(RoleCbx);
            userPanel.Controls.Add(PasswordTxtBox);
            userPanel.Controls.Add(userNameTxtBox);
            userPanel.Location = new Point(609, 12);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(191, 230);
            userPanel.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 91);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 6;
            label3.Text = "Роль";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 47);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 8);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 4;
            label1.Text = "Имя";
            // 
            // RoleCbx
            // 
            RoleCbx.FormattingEnabled = true;
            RoleCbx.Location = new Point(16, 109);
            RoleCbx.Name = "RoleCbx";
            RoleCbx.Size = new Size(162, 23);
            RoleCbx.TabIndex = 3;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.Location = new Point(16, 65);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.Size = new Size(163, 23);
            PasswordTxtBox.TabIndex = 2;
            // 
            // userNameTxtBox
            // 
            userNameTxtBox.Location = new Point(15, 21);
            userNameTxtBox.Name = "userNameTxtBox";
            userNameTxtBox.Size = new Size(163, 23);
            userNameTxtBox.TabIndex = 1;
            // 
            // MasterPanel
            // 
            MasterPanel.Controls.Add(MasterNameTxtBox);
            MasterPanel.Controls.Add(label4);
            MasterPanel.Location = new Point(606, 12);
            MasterPanel.Name = "MasterPanel";
            MasterPanel.Size = new Size(191, 230);
            MasterPanel.TabIndex = 2;
            MasterPanel.Visible = false;
            // 
            // MasterNameTxtBox
            // 
            MasterNameTxtBox.Location = new Point(11, 54);
            MasterNameTxtBox.Name = "MasterNameTxtBox";
            MasterNameTxtBox.Size = new Size(162, 23);
            MasterNameTxtBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 25);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "Имя мастера";
            // 
            // SchedulePanel
            // 
            SchedulePanel.Controls.Add(label12);
            SchedulePanel.Controls.Add(UserCbx);
            SchedulePanel.Controls.Add(label10);
            SchedulePanel.Controls.Add(label9);
            SchedulePanel.Controls.Add(label8);
            SchedulePanel.Controls.Add(label7);
            SchedulePanel.Controls.Add(SerciceCbx);
            SchedulePanel.Controls.Add(MasterCbx);
            SchedulePanel.Controls.Add(DatePicker);
            SchedulePanel.Controls.Add(TimePicker);
            SchedulePanel.Location = new Point(609, 12);
            SchedulePanel.Name = "SchedulePanel";
            SchedulePanel.Size = new Size(191, 230);
            SchedulePanel.TabIndex = 3;
            SchedulePanel.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(53, 188);
            label12.Name = "label12";
            label12.Size = new Size(84, 15);
            label12.TabIndex = 9;
            label12.Text = "Пользователь";
            // 
            // UserCbx
            // 
            UserCbx.FormattingEnabled = true;
            UserCbx.Location = new Point(15, 204);
            UserCbx.Name = "UserCbx";
            UserCbx.Size = new Size(162, 23);
            UserCbx.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(77, 144);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 7;
            label10.Text = "Дата";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(77, 100);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 6;
            label9.Text = "Время";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(77, 52);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 5;
            label8.Text = "Услуга";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(77, 2);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 4;
            label7.Text = "Мастер";
            // 
            // SerciceCbx
            // 
            SerciceCbx.FormattingEnabled = true;
            SerciceCbx.Location = new Point(16, 70);
            SerciceCbx.Name = "SerciceCbx";
            SerciceCbx.Size = new Size(162, 23);
            SerciceCbx.TabIndex = 3;
            // 
            // MasterCbx
            // 
            MasterCbx.FormattingEnabled = true;
            MasterCbx.Location = new Point(16, 21);
            MasterCbx.Name = "MasterCbx";
            MasterCbx.Size = new Size(163, 23);
            MasterCbx.TabIndex = 2;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(16, 162);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(164, 23);
            DatePicker.TabIndex = 1;
            // 
            // TimePicker
            // 
            TimePicker.Format = DateTimePickerFormat.Time;
            TimePicker.Location = new Point(16, 118);
            TimePicker.Name = "TimePicker";
            TimePicker.Size = new Size(164, 23);
            TimePicker.TabIndex = 0;
            // 
            // DataGrid
            // 
            DataGrid.AllowUserToAddRows = false;
            DataGrid.AllowUserToDeleteRows = false;
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(175, 12);
            DataGrid.Name = "DataGrid";
            DataGrid.ReadOnly = true;
            DataGrid.Size = new Size(428, 449);
            DataGrid.TabIndex = 1;
            // 
            // ServicesPanel
            // 
            ServicesPanel.Controls.Add(PriceTxtBox);
            ServicesPanel.Controls.Add(ServiceNameTxtBox);
            ServicesPanel.Controls.Add(label6);
            ServicesPanel.Controls.Add(label5);
            ServicesPanel.Location = new Point(609, 12);
            ServicesPanel.Name = "ServicesPanel";
            ServicesPanel.Size = new Size(191, 230);
            ServicesPanel.TabIndex = 2;
            ServicesPanel.Visible = false;
            // 
            // PriceTxtBox
            // 
            PriceTxtBox.Location = new Point(15, 109);
            PriceTxtBox.Name = "PriceTxtBox";
            PriceTxtBox.Size = new Size(162, 23);
            PriceTxtBox.TabIndex = 3;
            // 
            // ServiceNameTxtBox
            // 
            ServiceNameTxtBox.Location = new Point(16, 36);
            ServiceNameTxtBox.Name = "ServiceNameTxtBox";
            ServiceNameTxtBox.Size = new Size(162, 23);
            ServiceNameTxtBox.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 73);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 1;
            label6.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(76, 8);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 0;
            label5.Text = "Услуга";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(625, 370);
            label11.Name = "label11";
            label11.Size = new Size(146, 15);
            label11.TabIndex = 3;
            label11.Text = "Сформировать документ";
            // 
            // WordBtn
            // 
            WordBtn.Location = new Point(615, 398);
            WordBtn.Name = "WordBtn";
            WordBtn.Size = new Size(60, 23);
            WordBtn.TabIndex = 4;
            WordBtn.Text = "Word";
            WordBtn.UseVisualStyleBackColor = true;
            WordBtn.Click += WordBtn_Click;
            // 
            // ExcelBtn
            // 
            ExcelBtn.Location = new Point(675, 398);
            ExcelBtn.Name = "ExcelBtn";
            ExcelBtn.Size = new Size(59, 23);
            ExcelBtn.TabIndex = 5;
            ExcelBtn.Text = "Excel";
            ExcelBtn.UseVisualStyleBackColor = true;
            ExcelBtn.Click += ExcelBtn_Click;
            // 
            // PdfBtn
            // 
            PdfBtn.Location = new Point(735, 398);
            PdfBtn.Name = "PdfBtn";
            PdfBtn.Size = new Size(65, 23);
            PdfBtn.TabIndex = 6;
            PdfBtn.Text = "PDF";
            PdfBtn.UseVisualStyleBackColor = true;
            PdfBtn.Click += PdfBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Location = new Point(636, 255);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(135, 23);
            CreateBtn.TabIndex = 7;
            CreateBtn.Text = "Создать";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(638, 284);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(133, 23);
            UpdateBtn.TabIndex = 8;
            UpdateBtn.Text = "Изменить";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(638, 313);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(133, 23);
            DeleteBtn.TabIndex = 9;
            DeleteBtn.Text = "Удалить";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // UserDataTableBtn
            // 
            UserDataTableBtn.Location = new Point(10, 25);
            UserDataTableBtn.Name = "UserDataTableBtn";
            UserDataTableBtn.Size = new Size(156, 40);
            UserDataTableBtn.TabIndex = 10;
            UserDataTableBtn.Text = "Пользователи";
            UserDataTableBtn.UseVisualStyleBackColor = true;
            UserDataTableBtn.Click += UserDataTableBtn_Click;
            // 
            // ServicesDataTableBtn
            // 
            ServicesDataTableBtn.Location = new Point(10, 100);
            ServicesDataTableBtn.Name = "ServicesDataTableBtn";
            ServicesDataTableBtn.Size = new Size(156, 40);
            ServicesDataTableBtn.TabIndex = 11;
            ServicesDataTableBtn.Text = "Услуги";
            ServicesDataTableBtn.UseVisualStyleBackColor = true;
            ServicesDataTableBtn.Click += ServicesDataTableBtn_Click;
            // 
            // MastersDataTableBtn
            // 
            MastersDataTableBtn.Location = new Point(10, 174);
            MastersDataTableBtn.Name = "MastersDataTableBtn";
            MastersDataTableBtn.Size = new Size(156, 40);
            MastersDataTableBtn.TabIndex = 12;
            MastersDataTableBtn.Text = "Мастера";
            MastersDataTableBtn.UseVisualStyleBackColor = true;
            MastersDataTableBtn.Click += MastersDataTableBtn_Click;
            // 
            // ScheduleDataTableBtn
            // 
            ScheduleDataTableBtn.Location = new Point(10, 246);
            ScheduleDataTableBtn.Name = "ScheduleDataTableBtn";
            ScheduleDataTableBtn.Size = new Size(156, 40);
            ScheduleDataTableBtn.TabIndex = 13;
            ScheduleDataTableBtn.Text = "Записи";
            ScheduleDataTableBtn.UseVisualStyleBackColor = true;
            ScheduleDataTableBtn.Click += ScheduleDataTableBtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 449);
            Controls.Add(MasterPanel);
            Controls.Add(ScheduleDataTableBtn);
            Controls.Add(SchedulePanel);
            Controls.Add(userPanel);
            Controls.Add(MastersDataTableBtn);
            Controls.Add(ServicesDataTableBtn);
            Controls.Add(ServicesPanel);
            Controls.Add(UserDataTableBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(CreateBtn);
            Controls.Add(PdfBtn);
            Controls.Add(ExcelBtn);
            Controls.Add(WordBtn);
            Controls.Add(label11);
            Controls.Add(DataGrid);
            Name = "AdminForm";
            Text = "AdminForm";
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            MasterPanel.ResumeLayout(false);
            MasterPanel.PerformLayout();
            SchedulePanel.ResumeLayout(false);
            SchedulePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ServicesPanel.ResumeLayout(false);
            ServicesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel userPanel;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox RoleCbx;
        private TextBox PasswordTxtBox;
        private TextBox userNameTxtBox;
        private DataGridView DataGrid;
        private Panel MasterPanel;
        private TextBox MasterNameTxtBox;
        private Label label4;
        private Panel ServicesPanel;
        private Panel SchedulePanel;
        private ComboBox MasterCbx;
        private DateTimePicker DatePicker;
        private DateTimePicker TimePicker;
        private TextBox PriceTxtBox;
        private TextBox ServiceNameTxtBox;
        private Label label6;
        private Label label5;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private ComboBox SerciceCbx;
        private Label label11;
        private Button WordBtn;
        private Button ExcelBtn;
        private Button PdfBtn;
        private Button CreateBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button UserDataTableBtn;
        private Button ServicesDataTableBtn;
        private Button MastersDataTableBtn;
        private Button ScheduleDataTableBtn;
        private Label label12;
        private ComboBox UserCbx;
    }
}