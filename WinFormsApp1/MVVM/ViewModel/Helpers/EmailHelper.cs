using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVVM.ViewModel.Helpers
{
    internal class EmailHelper
    {
        private readonly string _emailTo = "isip_a.v.popova@mpt.ru";
        private readonly string _password = "jnrq madj sdxe nrdt";
        private readonly string _name = "Клиент";
        private readonly string _subject = "Отчисление";
        private readonly string _host = "smtp.google.com";
        private readonly int _smptPort = 587;
        public EmailHelper()
        {

        }
        public MailMessage CreateMail(string emailFrom, string body) //Создаем структуру письма
        {
            var from = new MailAddress(emailFrom, _name); // С какого адреса и какого имени письмо отправляется
            var to = new MailAddress(_emailTo); // Кому письмо отправляется
            var mail = new MailMessage(from, to); // сама отправка (откуда, кому)
            mail.Subject = _subject; // Тема письма
            mail.Body = body; // Тело письма
            mail.IsBodyHtml = true; // Является ли письмо html структурой
            mail.Attachments.Add(new Attachment("Text.txt")); // Приложение к письму (можно картинку, текст и т.д. файл должен быть в папке debug)
            return mail;

        }
        public void SendMail(string emailFrom, MailMessage mail) // Функция отправки письма 
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailFrom, _password),
                EnableSsl = true,
            };
            smtpClient.Send(mail); // Отправка
        }
    }
}
