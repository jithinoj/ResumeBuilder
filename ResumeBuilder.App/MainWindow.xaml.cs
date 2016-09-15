using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ResumeBuilder.App.Views;
using ResumeBuilder.App.ViewModels;

namespace ResumeBuilder.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void PersonalDetailControl_Loaded(object sender, RoutedEventArgs e)
        {
            var studentViewModelObject = new PersonalDetailsViewModel
            {
                Customer = new Domain.Entities.PersonalDetail { FirstName = "Jithin", LastName = "Joy" }
            };

            PersonalDetailControl.DataContext = studentViewModelObject;

        }
    }
}
