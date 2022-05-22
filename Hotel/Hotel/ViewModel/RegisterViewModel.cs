using Hotel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Hotel.ViewModel
{
    internal class RegisterViewModel
    {
        public ICommand BackCommand { get; }

        public List<UserM> Users { get; set; }

        public RegisterViewModel()
        {

            Users = new List<UserM> {
                new UserM
            {
            Username="leobej",
            First_name="Leo",
            Last_name="Bejgu",
            }
            };

        }
        public void Back()
        {
            MainWindow mainWindow = new MainWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }
    }
}
