using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel.Helpers;
using ZstdSharp.Unsafe;


namespace WinFormsApp1.MVVM.ViewModel
{
    internal class UserFormViewModel : ViewModelBase
    {
        private readonly int _userId; 
        private DataAccess _access;
        public User _currentUser;
        private Schedule? _schedule;
        public UserFormViewModel(int userId)
        {
            _userId = userId;
            _access = new DataAccess();
            UpdateData();
            Password = _currentUser.Password;
            _schedule = GetNearestAppointment(_access.GetSchedules());
            if (_schedule != null)
            {
                ServiceName = _schedule.Service.ServiceName;
                MasterName = _schedule.Master.MasterName;
                Date = _schedule.Date.ToString("D");
                Time = _schedule.Time.ToString();
                RecordStatus = "Ближайшая записб";
                IsVisible = true;
            }
            else
            {
                ServiceName = "";
                MasterName = "";
                Date = "";
                Time = "";
                RecordStatus = "Вы еще ни на что не записаны";
                IsVisible = false;
            }
            
        }
        private string _userEmail;
        private string _password;
        private string _serviceName;
        private string _masterName;
        private string _date;
        private string _time;
        private string _recordStatus;
        private bool _isVisible;

        public bool IsVisible
        {
            get => _isVisible;
            set
            {
                if (value == _isVisible) return;
                _isVisible = value;
                OnPropertyChanged();
            }
        }

        private Schedule? GetNearestAppointment(ObservableCollection<Schedule?> schedules)
        {
            DateTime currentDateTime = DateTime.Now;

            Schedule? nearestSchedule = schedules // Filter future appointments
                .FirstOrDefault(s => s.Date >= currentDateTime.Date && s.Time >= currentDateTime.TimeOfDay && s.UserId == _userId);

            return nearestSchedule;
        }
        public string UserEmail
        {
            get => _userEmail;
            set
            {
                if (value == _userEmail) return;
                _userEmail = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (value == _password) return;
                _password = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string ServiceName
        {
            get => _serviceName;
            set
            {
                if (value == _serviceName) return;
                _serviceName = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string MasterName
        {
            get => _masterName;
            set
            {
                if (value == _masterName) return;
                _masterName = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string Date
        {
            get => _date;
            set
            {
                if (value == _date) return;
                _date = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string Time
        {
            get => _time;
            set
            {
                if (value == _time) return;
                _time = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string RecordStatus
        {
            get => _recordStatus;
            set
            {
                if (value == _recordStatus) return;
                _recordStatus = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }


        public void Save()
        {
            int uid = _userId;
            _access.UpdateUser(new User(uid, UserEmail, Password, _currentUser.Role));
            UpdateData();
        }

        private void UpdateData()
        {
            _currentUser = _access.GetUserById(_userId);
            UserEmail = _currentUser.Email;
            Password = _currentUser.Password;
        }

    }
}
