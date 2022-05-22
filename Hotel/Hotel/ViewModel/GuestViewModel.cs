using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel.Model;
namespace Hotel.ViewModel
{
    internal class GuestViewModel
    {
        public List<Guest> Guests { get; set; }

        public GuestViewModel()
        {
            Guests = new List<Guest> {
                new Guest
            {
            Username="leobej",
            First_name="Leo",
            Last_name="Bejgu",
            }
            };
        }
    }
}
