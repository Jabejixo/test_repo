using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private readonly LoginFormViewModel _viewModel;
        public LoginForm()
        {
            InitializeComponent();
            _viewModel = new LoginFormViewModel();
            LoginBtn.Click += (sender, e) =>
            {
                _viewModel.LoginCommand.Execute(null);
                switch (_viewModel)
                {
                    case { isAuthentificated: true, isAdmin: false }:
                    {
                        var form = new UserForm(_viewModel._access.GetUsers().Where(x => x.Email == _viewModel.Username).ToList()[0].UserId);
                        form.Show();
                        Hide();
                        break;
                    }
                    case { isAuthentificated: true, isAdmin: true }:
                    {
                        var form = new AdminForm();
                        form.Show();
                        Hide();
                        break;
                    }
                }
            };
            UsernameTextBox.DataBindings.Add("Text", _viewModel, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            PasswordTextBox.DataBindings.Add("Text", _viewModel, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            DataContext = _viewModel;
        }

        private void RegisterButton_Click(object? sender, EventArgs e)
        {
            var form = new RegForm();
            form.Show();
            Hide();
        }
    }
}
