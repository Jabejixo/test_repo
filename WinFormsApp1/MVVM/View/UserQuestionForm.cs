using Catel.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.MVVM.ViewModel;
using WinFormsApp1.MVVM.ViewModel.Helpers;

namespace WinFormsApp1.MVVM.View
{
    public partial class UserQuestionForm : Form
    {
        private UserQuestionFormViewModel _viewModel;
        private string _email;
        public UserQuestionForm(string email)
        {
            InitializeComponent();
            _viewModel = new UserQuestionFormViewModel(email);
            _email = email;
            EmailTxtBox.DataBindings.Add("Text", _viewModel, "Email", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            QuestionTxtBox.DataBindings.Add("Text", _viewModel, "EmailBody", true,
                System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            var form = new UserForm(new DataAccess().GetUsers().Where(x => x.Email == _email).ToList()[0].UserId);
            form.Show();
            Hide();
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            _viewModel.SendMail();
        }
    }
}
