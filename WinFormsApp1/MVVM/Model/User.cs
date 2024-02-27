using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.ComponentModel;

namespace WinFormsApp1.MVVM.Model
{
    public class User 
    {
        [DisplayName("ID")]
        public int UserId { get; set; }
        [DisplayName("Email")]
        public string? Email { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Роль")]
        public string Role { get; set; }
        public User() {}

        public User(string? email, string password, string role)
        {
            Email = email;
            Password = password;
            Role = role;
        }
        public User(int userId,string? email, string password, string role)
        {
            UserId = userId;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
