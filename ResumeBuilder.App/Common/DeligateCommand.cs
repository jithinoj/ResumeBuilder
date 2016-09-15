using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ResumeBuilder.App.Common
{
    public class DeligateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _executeMethod { get; set; }

        public DeligateCommand(Action executeMethod)
        {
            _executeMethod = executeMethod;
        }

        
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _executeMethod.Invoke();
        }
    }
}
