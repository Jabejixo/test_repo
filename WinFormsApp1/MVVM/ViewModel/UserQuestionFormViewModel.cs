using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.MVVM.ViewModel.Helpers;

namespace WinFormsApp1.MVVM.ViewModel
{
    public class UserQuestionFormViewModel : ViewModelBase
    {
        public UserQuestionFormViewModel(string Email)
        {
            this.Email = Email;
            EmailBody = "";
        }
        public string EmailBody
        {
            get => _emailBody;
            set
            {
                if (value == _emailBody) return;
                _emailBody = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (value == _email) return;
                _email = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        private string _emailBody;
        private string _email;
        

        public void SendMail()
        {
            EmailHelper helper = new EmailHelper();
            helper.SendMail(Email, helper.CreateMail(Email, EmailBody));
            MessageBox.Show("Письмо отправлено");
        }

    }
}
