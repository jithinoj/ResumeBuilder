using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ResumeBuilder.Domain.Entities
{
    //public class PersonalDetailModel { }

    public class PersonalDetail : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string address;
        private string email;
        private string phoneNumber;
        private DateTime dateOfBirth;
        private BloodGroup bloodGroupName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {

                if (firstName != value)
                {
                    firstName = value;
                    RaisePropertyChanged("FirstName");
                    RaisePropertyChanged("FullName");
                }
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (lastName != value)
                {
                    lastName = value;
                    RaisePropertyChanged("LastName");
                    RaisePropertyChanged("FullName");
                }
            }
        }
        public string FullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {

                if (address != value)
                {
                    address = value;
                    RaisePropertyChanged("Address");                    
                }
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    RaisePropertyChanged("Email");
                }
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                if (phoneNumber != value)
                {
                    phoneNumber = value;
                    RaisePropertyChanged("PhoneNumber");
                }
            }
        }
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set
            {
                if (dateOfBirth != value)
                {
                    dateOfBirth = value;
                    RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        public BloodGroup BloodGroupName
        {
            get { return bloodGroupName; }
            set
            {
                if (bloodGroupName != value)
                {
                    bloodGroupName = value;
                    RaisePropertyChanged("BloodGroupName");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}

