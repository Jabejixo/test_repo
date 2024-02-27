using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel.Helpers;

namespace WinFormsApp1.MVVM.ViewModel
{
    internal class RegFormViewModel : ViewModelBase
    {
        public DataAccess _access;
        public RegFormViewModel()
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

        private RelayCommand _registerCommand;
        public RelayCommand RegisterCommand
        {
            get
            {
                return _registerCommand ??= new RelayCommand(obj =>
                    {
                        if (CanRegister()) Register();
                    }
                );
            }
        }

        public bool CanTransition { get; set; } = false;

        private bool CanRegister()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void Register()
        {
            var newUser = new User
            {
                Email = Username,
                Password = Password,
                Role = "User"
            };
            string pattern = @"^[a-zA-Z0-9_.+-]+@gmail+\.com+$";
            Regex.IsMatch(Username, pattern);
            if (Regex.IsMatch(Username, pattern))
            {
                foreach (var u in _access.GetUsers())
                {
                    if (u.Email == newUser.Email)
                    {
                        MessageBox.Show("Такой пользователь уже существует");
                        return;
                    }
                }
                _access.CreateUser(newUser);
                MessageBox.Show("Регистрация успешна!");
                CanTransition = true;
            }
            else
            {
                MessageBox.Show("Email не соотвествует формату");
            }

        }
    }
}
