using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WinFormsApp1.MVVM.ViewModel.Helpers
{
    public class RelayCommand(Action<object> execute, Func<object, bool> canExecute = null) : ICommand
    {
        private Action<object> _execute = execute ?? throw new ArgumentNullException(nameof(execute));

        public bool CanExecute(object parameter)
        {
            return canExecute == null || canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
