using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using ResumeBuilder.Domain.Entities;
using System.Windows.Input;
using ResumeBuilder.App.Common;

namespace ResumeBuilder.App.ViewModels
{
    public class PersonalDetailsViewModel 
    {
        public ICommand CancelCommand { get; private set; }
        public ICommand SaveCommand { get; private set; }

        public event Action Done = delegate 
        {
            Console.WriteLine("Hit");
        };

        public PersonalDetailsViewModel()
        {
            CancelCommand = new DeligateCommand(OnCancel);
            SaveCommand = new DeligateCommand(OnSave);

            BloodGroups = Enum.GetNames(typeof(BloodGroup));
            
        }
        
        public string[] BloodGroups { get; private set; }

        private PersonalDetail _Customer;
        public PersonalDetail Customer
        {
            get { return _Customer; }
            set { _Customer = value; }
        } 
            

        private void OnCancel()
        {
            Done();
        }

        private async void OnSave()
        {
            Done();
        }
        
    }
}
