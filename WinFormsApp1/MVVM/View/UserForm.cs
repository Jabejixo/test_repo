using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.MVVM.View;
using WinFormsApp1.MVVM.ViewModel;

namespace WinFormsApp1
{
    public partial class UserForm : Form
    {
        UserFormViewModel _viewModel;
        public UserForm(int userId)
        {
            InitializeComponent();
            _viewModel = new UserFormViewModel(userId);
            DataContext = _viewModel;
            EmailTxtBox.DataBindings.Add("Text", _viewModel, "UserEmail", true, DataSourceUpdateMode.OnPropertyChanged);
            PasswordTxtBox.DataBindings.Add("Text", _viewModel, "Password", true, DataSourceUpdateMode.OnPropertyChanged);
            DateLabel.DataBindings.Add("Text", _viewModel, "Date", true, DataSourceUpdateMode.OnPropertyChanged);
            EmailLabel.DataBindings.Add("Text", _viewModel, "UserEmail", true, DataSourceUpdateMode.OnPropertyChanged);
            MasterNameLabel.DataBindings.Add("Text", _viewModel, "MasterName", true, DataSourceUpdateMode.OnPropertyChanged);
            ServiceLabel.DataBindings.Add("Text", _viewModel, "ServiceName", true, DataSourceUpdateMode.OnPropertyChanged);
            TimeLabel.DataBindings.Add("Text", _viewModel, "Time", true, DataSourceUpdateMode.OnPropertyChanged);
            label5.DataBindings.Add(new Binding("Visible", _viewModel, "IsVisible", true, DataSourceUpdateMode.OnPropertyChanged));
            RecordStatus.DataBindings.Add("Text", _viewModel, "RecordStatus", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void RecordBtn_Click(object sender, EventArgs e)
        {
            UserServiceRecordForm form = new UserServiceRecordForm(_viewModel._currentUser);
            form.Show();
            Hide();
        }

        private void QuestionBtn_Click(object sender, EventArgs e)
        {
            UserQuestionForm form = new UserQuestionForm(_viewModel.UserEmail);
            form.Show();
            Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
        }
    }
}
