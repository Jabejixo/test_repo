using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel.Helpers;

namespace WinFormsApp1.MVVM.ViewModel
{
    internal class UserServiceRecordViewModel : ViewModelBase
    {
        private readonly User _user;
        private ObservableCollection<Master> _masters;
        private ObservableCollection<Service> _services;
        private string _masterName;
        private string _serviceName;
        private string _dateUI;
        private string _timeUI;
        private DateTime _date;
        private DateTime _time;
        private DataAccess _dataAccess;
        public UserServiceRecordViewModel(User user)
        {
            _user = user;
            _dataAccess = new DataAccess();
            Masters = _dataAccess.GetMasters();
            Services = _dataAccess.GetServices();
        }
        public User User => _user;
        public int MasterId { get; set; }
        public int ServiceId { get; set; }
        public ObservableCollection<Master> Masters
        {
            get => _masters;
            set
            {
                if (Equals(value, _masters)) return;
                _masters = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Service> Services
        {
            get => _services;
            set
            {
                if (Equals(value, _services)) return;
                _services = value ?? throw new ArgumentNullException(nameof(value));
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

        public string DateUi
        {
            get => _dateUI;
            set
            {
                if (value == _dateUI) return;
                _dateUI = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public string TimeUi
        {
            get => _timeUI;
            set
            {
                if (value == _timeUI) return;
                _timeUI = value ?? throw new ArgumentNullException(nameof(value));
                OnPropertyChanged();
            }
        }

        public DateTime Date
        {
            get => _date;
            set
            {
                if (value.Equals(_date)) return;
                _date = value;
                DateUi = value.ToString("D");
                OnPropertyChanged();
            }
        }

        public DateTime Time
        {
            get => _time;
            set
            {
                if (value.Equals(_time)) return;
                _time = value;
                TimeUi = value.TimeOfDay.ToString("g");
                OnPropertyChanged();
            }
        }

        public void Record()
        {
            if (TimeUi != "" && DateUi != "" && MasterName != "" && ServiceName != "" )
            {
                new DataAccess().CreateSchedule(new Schedule(MasterId, ServiceId, Date, Time.TimeOfDay, User.UserId));
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

    }
}
