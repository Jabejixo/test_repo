using Catel.MVVM;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel;

namespace WinFormsApp1
{
    public sealed partial class RegForm : Form
    {
        private readonly RegFormViewModel _viewModel;
        public RegForm()
        {
            InitializeComponent();
            _viewModel = new RegFormViewModel();
            RegisterButton.Click += (sender, e) =>
            {
                _viewModel.RegisterCommand.Execute(null);
                if (_viewModel.CanTransition)
                {
                    int userId = _viewModel._access.GetUsers().Where(x => x.Email == _viewModel.Username).ToList()[0].UserId;
                    UserForm userForm = new UserForm(userId);
                    userForm.Show();
                    Hide();
                }
            };
            UsernameTextBox.DataBindings.Add("Text", _viewModel, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            PasswordTextBox.DataBindings.Add("Text", _viewModel, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            DataContext = _viewModel;
        }

        private void LoginBtn_Click(object? sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            Hide();
        }
    }
}
