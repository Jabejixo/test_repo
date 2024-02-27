using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel.Helpers;

namespace WinFormsApp1.MVVM.ViewModel
{
    internal class LoginFormViewModel : ViewModelBase
    {
        public readonly DataAccess _access;

        public LoginFormViewModel()
        {
            _access = new DataAccess();
            Username = "";
            Password = "";
        }

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }


        private string _password;
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                Notify("Password");
            }
        }

        private RelayCommand _loginCommand;
        public RelayCommand LoginCommand
        {
            get
            {
                return _loginCommand ??= new RelayCommand(obj =>
                    {
                        if (CanLogin()) Login();
                    }
                );
            }
        }

        public bool isAdmin { get; set; }
        public bool isAuthentificated { get; set; } = false;

        private bool CanLogin()
        {
            // Добавьте здесь логику проверки возможности регистрации (например, проверка заполнения полей)
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void Login()
        {
            // Логика регистрации
            var loginUser = new User
            {
                Email = Username,
                Password = Password,
                Role = ""
            };
            var list = _access.GetUsers();
            bool any = false;
            foreach (var u in list)
            {
                if (u.Email == loginUser.Email && u.Password == loginUser.Password)
                {
                    any = true;
                    loginUser = u;
                    break;
                }
            }

            if (any)
            {
                isAuthentificated = true;
                switch (loginUser.Role)
                {
                    case "User":
                        isAdmin = false;
                        break;
                    case "Admin":
                        isAdmin = true;
                        break;
                }

                MessageBox.Show("Авторизация успешна");
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
    }
}
