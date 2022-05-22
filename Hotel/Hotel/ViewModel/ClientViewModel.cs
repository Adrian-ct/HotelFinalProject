using Hotel.Help;
using Hotel.Models;
using Hotel.Models.BusinessLogicLayer;
using Hotel.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Hotel.ViewModel
{
    public class ClientViewModel : ObservableObject
    {
        public ObservableCollection<Room> Rooms { get; set; } = new ObservableCollection<Room>();
        RoomBLL roomBLL = new RoomBLL();
        public ICommand BookCommand { get; set; }

        public ClientViewModel()
        {/*
            Room room1 = new Room();
            room1.number = 1;
            room1.price = 750;
            room1.type = "single";
            Picture picture1 = new Picture();
            picture1.url = "https://www.itstactical.com/wp-content/uploads/2016/10/Hotel-Security-featured.jpg";
            room1.Pictures.Add(picture1);


            Room room2 = new Room();
            Picture picture2 = new Picture();
            room2.number = 2;
            room2.price = 550;
            room2.type = "quad";
            picture2.url = "https://www.itstactical.com/wp-content/uploads/2016/10/Hotel-Security-featured.jpg";
            room2.Pictures.Add(picture2);
            room2.Pictures.Add(picture1);
            //Rooms = new ObservableCollection<Room>();
            Rooms.Add(room1);
            Rooms.Add(room2);*/
            BookCommand = new RelayCommands(DisplayDate);
            Rooms = new ObservableCollection<Room>(roomBLL.GetAllRooms());
        }

        private DateTime checkIn;
        public DateTime CheckIn
        {
            get { return checkIn; }
            set { OnPropertyChanged(ref checkIn, value); }
        }

        private DateTime checkOut;
        public DateTime CheckOut
        {
            get { return checkOut; }
            set { OnPropertyChanged(ref checkOut, value); }
        }
        public void DisplayDate()
        {
            MessageBox.Show(CheckOut.Date.ToString("dd/MM/yyyy"));
        }
    }
   
   
}
