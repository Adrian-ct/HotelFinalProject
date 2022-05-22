using Hotel.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.ViewModel
{
    internal class MainViewModel
    {
        private RegisterViewModel Register { get; set; }
        private LoginViewModel Login { get; set; }
        private MenuViewModel Menu { get; set; }
        private GuestViewModel Guest { get; set; }
        private ClientViewModel Client { get; set; }
        public MainViewModel()
        {
            Register = new RegisterViewModel();
            Login = new LoginViewModel();
            Menu = new MenuViewModel();
            Guest = new GuestViewModel();
            Client = new ClientViewModel();
        }
    }
}
