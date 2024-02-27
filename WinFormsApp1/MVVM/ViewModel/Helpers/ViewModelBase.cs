using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.MVVM.ViewModel.Helpers
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        protected void Set<T>(ref T field, T value, [CallerMemberName] string propName = "")
        {
            if (field != null)
            {
                if (!field.Equals(value))
                {
                    field = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
                }
            }
        }

        protected void Set<T>(ref T field, T value, params string[] propNames)
        {
            if (!field.Equals(value))
            {
                field = value;
                foreach (var name in propNames)
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        protected void Notify(params string[] names)
        {
            foreach (var name in names)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
