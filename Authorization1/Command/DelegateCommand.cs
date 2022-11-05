using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Authorization1.Command
{
    public class DelegateCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExcute;

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public DelegateCommand(Action<Object> execute, Func<object, bool> canExcute = null)
        {
            _execute = execute;
            _canExcute = canExcute;
        }

        public bool CanExecute(object? parameter)
        {
            return _canExcute is null || _canExcute(parameter);
        }
        public void Execute(object? parameter)
        {
            _execute?.Invoke(parameter);
        }
    }
}
