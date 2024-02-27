using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.MVVM.Converters;
using Catel.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp1.MVVM.Model;
using WinFormsApp1.MVVM.ViewModel.Helpers;
using CollectionType = WinFormsApp1.MVVM.ViewModel.Helpers.CollectionType;
using User = WinFormsApp1.MVVM.Model.User;


namespace WinFormsApp1.MVVM.ViewModel
{
    public class AdminFormViewModel : ViewModelBase
    {
        public DataAccess _access;
        private int _masterId;
        private int _serviceId;
        private string? _userName;
        private string _serviceName;
        private string _masterName;
        private string _password;
        private int _userId;
        private int _price;
        private string _role;
        private DateTime _date;
        private DateTime _time;
        private ObservableCollection<object> currentCollection;
        private BindingList<Service> _services;
        private BindingList<Master> _masters;
        private object? selectedItem;
        private BindingList<User> _users;

        public AdminFormViewModel()
        {
            _access = new DataAccess();
            UserName = "";
            ServiceName = "";
            MasterName = "";
            Password = "";
            Price = 0;
            Role = "";
            SelectedItem = null!;
            Date = DateTime.Today;
            Time = DateTime.Today;
            CurrentCollection = new ObservableCollection<object>(_access.GetUsers());
            Masters = new();
            Services = new();
            Users = new();
        }

        public string? UserName { get => _userName;
            set {  _userName = value; OnPropertyChanged(); } }

        public string ServiceName { get => _serviceName;
            set { _serviceName = value; OnPropertyChanged(); }}
        
        public string MasterName { get => _masterName;
            set { _masterName = value; OnPropertyChanged(); }} 
        
        public string Password { get => _password;
            set { _password = value; OnPropertyChanged();} }
        
        public int Price { get => _price;
            set { _price = value; OnPropertyChanged();} }
        
        public string Role { get => _role;
            set { _role = value; OnPropertyChanged(); }}
        
        public DateTime Date { get => _date;
            set { _date = value; OnPropertyChanged();} }
        
        public DateTime Time { get => _time;
            set { _time = value; OnPropertyChanged(); }
        }
        
        public int ServiceId { get => _serviceId;
            set { _serviceId = value; OnPropertyChanged();} }
        
        public int MasterId { get => _masterId;
            set { _masterId = value; OnPropertyChanged(); }
        }
        public int UserId { get => _userId;
            set { _userId = value; OnPropertyChanged(); }
        }

        public BindingList<Service> Services { get => _services;
            set { _services = value; OnPropertyChanged(); }
        }
        
        public BindingList<Master> Masters { get => _masters;
            set { _masters = value; OnPropertyChanged(); }
        }
        public BindingList<User> Users { get => _users;
            set { _users = value; OnPropertyChanged(); }
        }
        
        public ObservableCollection<object> CurrentCollection
        {
            get => currentCollection;
            set
            {
                if (currentCollection != value)
                {
                    currentCollection = value;
                    OnPropertyChanged();
                }
            }
        }

        public object? SelectedItem
        {
            get => selectedItem;
            set
            {
                if (selectedItem != value)
                {
                    selectedItem = value;
                    OnPropertyChanged();
                }
            }
        }

        public void UpdateCurrentCollection(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.Masters:
                    CurrentCollection = new ObservableCollection<object>(_access.GetMasters());
                    break;
                case CollectionType.Services:
                    CurrentCollection = new ObservableCollection<object>(_access.GetServices());
                    break;
                case CollectionType.Users:
                    CurrentCollection = new ObservableCollection<object>(_access.GetUsers()); 
                    break;
                case CollectionType.Schedules:
                    CurrentCollection = new ObservableCollection<object>(_access.GetSchedules());
                    SetComboBoxes();
                    break;
            }
        }

        private void SetComboBoxes()
        {
            Masters = _access.GetMasters().ToBindingList();
            Services = _access.GetServices().ToBindingList();
            Users = _access.GetUsers().ToBindingList();
        }


        public void SetParam(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.Masters:
                    MasterName = (SelectedItem as Master)!.MasterName;
                    break;
                case CollectionType.Services:
                    ServiceName = (SelectedItem as Service)!.ServiceName;
                    Price = (int)(SelectedItem as Service)!.Price;
                    break;
                case CollectionType.Users:
                    UserName = (SelectedItem as User)!.Email;
                    Role = (SelectedItem as User)!.Role;
                    Password = (SelectedItem as User)!.Password;
                    break;
                case CollectionType.Schedules:
                    var schedule = (SelectedItem as Schedule)!;
                    Date = schedule.Date;
                    Time = new (Date.Year, Date.Month, Date.Day, schedule.Time.Hours, schedule.Time.Minutes, schedule.Time.Seconds);
                    MasterId = schedule.MasterId;
                    ServiceId = schedule.ServiceId;
                    UserId = schedule.UserId;
                    break;
            }
        }

        public void Create(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.Masters:
                    _access.CreateMaster(new Master(MasterName));
                    break;
                case CollectionType.Services:
                    _access.CreateService(new Service(ServiceName, Price));
                    break;
                case CollectionType.Users:
                    _access.CreateUser(new User(UserName, Password, Role));
                    break;
                case CollectionType.Schedules:
                    _access.CreateSchedule(new Schedule(MasterId, ServiceId, Date.Date, Time.TimeOfDay, UserId));
                    break;
            }

            UpdateCurrentCollection(collectionType);
        }
        public void Update(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.Masters:
                    _access.UpdateMaster(new Master((SelectedItem as Master).MasterId ,MasterName));
                    break;
                case CollectionType.Services:
                    _access.UpdateService(new Service((SelectedItem as Service).ServiceId, ServiceName, Price));
                    break;
                case CollectionType.Users:
                    _access.UpdateUser(new User((SelectedItem as User).UserId, UserName, Password, Role));
                    break;
                case CollectionType.Schedules:
                    _access.UpdateSchedule(new Schedule((SelectedItem as Schedule).ScheduleId, MasterId, ServiceId, Date.Date, Time.TimeOfDay, UserId));
                    break;
            }
            UpdateCurrentCollection(collectionType);
        }
        public void Delete(CollectionType collectionType)
        {
            switch (collectionType)
            {
                case CollectionType.Masters:
                    _access.DeleteMaster((SelectedItem as Master)!.MasterId);
                    break;
                case CollectionType.Services:
                    _access.DeleteService((SelectedItem as Service)!.ServiceId);
                    break;
                case CollectionType.Users:
                    _access.DeleteUser((SelectedItem as User)!.UserId);
                    break;
                case CollectionType.Schedules:
                    _access.DeleteSchedule((SelectedItem as Schedule)!.ScheduleId);
                    break;
            }
            UpdateCurrentCollection(collectionType);
        }

    }
}
