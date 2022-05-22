using Hotel.Models;
using Hotel.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.ViewModel
{
    public class ClientViewModel : ObservableObject
    {
        public ObservableCollection<Room> Rooms { get; set; } = new ObservableCollection<Room>();

        public ClientViewModel()
        {
            Room room1 = new Room();
            room1.number = 1;
            room1.price = 750;
            room1.type = "single";
            Picture picture1 = new Picture();
            picture1.url = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fstudioinsign.ro%2Fwp-content%2Fuploads%2F2019%2F03%2Fproiect-camera-hotel.jpg&imgrefurl=https%3A%2F%2Fstudioinsign.ro%2Fproiect%2Fcamera-de-hotel-in-stil-modern-contemporan-cu-accente-luxury%2F&tbnid=4wmX57P5bJ6qiM&vet=12ahUKEwj4pefPl_P3AhVDKewKHY83CMkQMygAegUIARDHAQ..i&docid=NENfVe-_CKCNCM&w=1500&h=831&q=camera%20hotel&client=firefox-b-d&ved=2ahUKEwj4pefPl_P3AhVDKewKHY83CMkQMygAegUIARDHAQ";
            room1.Pictures.Add(picture1);


            Room room2 = new Room();
            Picture picture2 = new Picture();
            room2.number = 2;
            room2.price = 550;
            room2.type = "quad";
            picture2.url = "https://www.google.com/imgres?imgurl=https%3A%2F%2Fcomforty.ro%2Fwp-content%2Fuploads%2F2018%2F10%2Fmobilier-camere-hotel-1024x607.jpg&imgrefurl=https%3A%2F%2Fcomforty.ro%2Fmobilier-camere-hotel%2F&tbnid=S-TrJWWBqvpuuM&vet=12ahUKEwj4pefPl_P3AhVDKewKHY83CMkQMygBegUIARDJAQ..i&docid=nw9LqdmU0y3fHM&w=1024&h=607&q=camera%20hotel&client=firefox-b-d&ved=2ahUKEwj4pefPl_P3AhVDKewKHY83CMkQMygBegUIARDJAQ";
            room2.Pictures.Add(picture2);
            //Rooms = new ObservableCollection<Room>();
            Rooms.Add(room1);
            Rooms.Add(room2);
        }

    }
}
