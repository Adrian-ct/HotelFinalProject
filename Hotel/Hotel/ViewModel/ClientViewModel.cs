using Hotel.Help;
using Hotel.Models;
using Hotel.Models.BusinessLogicLayer;
using Hotel.Utilities;
using Hotel.View;
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
        private ObservableCollection<Room> rooms;
        public ObservableCollection<Room> Rooms { get { return rooms; } set { OnPropertyChanged(ref rooms, value); } }

        private ObservableCollection<string> pictures;
        public ObservableCollection<string> Pictures
        {
            get { return pictures; }
            set { OnPropertyChanged(ref pictures, value); }
        }

        RoomBLL roomBLL = new RoomBLL();
        public ICommand BookCommand { get; set; }
        public ICommand AdminCommand { get; set; }
        public ICommand SearchRooms { get; set; }
        public ClientViewModel()
        {
            
            BookCommand = new RelayCommands(DisplayDate);
            AdminCommand = new RelayCommands(Admin);
            SearchRooms = new RelayCommands(Search);

            checkIn = new DateTime(2022, 05, 20);
            checkOut = new DateTime(2022, 05, 23);


            if (StaticResources.LoggedUser == null)
            {
                IsButtonReservedVisible = false;
                IsButtonAdminVisible = false;
            }
            else if (StaticResources.LoggedUser.role == "admin")
            {
                IsButtonAdminVisible = true;
                IsButtonReservedVisible = false;
            }
            else if (StaticResources.LoggedUser.role == "client")
            {
                IsButtonReservedVisible = true;
                IsButtonAdminVisible = false;
            }

            /*Room room1 = new Room();
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

        private bool isButtonVisible;
        public bool IsButtonVisible
        {
            get { return isButtonVisible; }
            set { OnPropertyChanged(ref isButtonVisible, value); }
        }

        private int index;
        public int Index
        {
            get { return index; }
            set { OnPropertyChanged(ref index, value); }
        }

        private bool isButtonReservedVisible;
        public bool IsButtonReservedVisible
        {
            get { return isButtonReservedVisible; }
            set { OnPropertyChanged(ref isButtonReservedVisible, value); }
        }

        private bool isButtonAdminVisible;
        public bool IsButtonAdminVisible
        {
            get { return isButtonAdminVisible; }
            set { OnPropertyChanged(ref isButtonAdminVisible, value); }
        }
        public void DisplayDate()
        {
            DetailsWindow detailsWindow = new DetailsWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = detailsWindow;
            DetailsViewModel adminViewModel = new DetailsViewModel(Index,RoomNr,checkIn,checkOut);
            detailsWindow.DataContext = adminViewModel;
            detailsWindow.Show();
        }

        public void Admin()
        {
            AdminWindow adminWindow = new AdminWindow();

            App.Current.MainWindow.Close();
            App.Current.MainWindow = adminWindow;
            AdminViewModel adminViewModel = new AdminViewModel(RoomNr);
            adminWindow.DataContext = adminViewModel;
            adminWindow.Show();
        

        }

        public string type;
        public string Type
        {
            get { return Type; }
            set
            {
                OnPropertyChanged(ref type, value);
            }
        }



        public void Search()
        {

            Rooms = new ObservableCollection<Room>(roomBLL.GetAllRooms(checkIn, checkOut));
            Pictures = new ObservableCollection<string>();
            

        }

        private Room roomNr;
        public Room RoomNr
        {
            get { return roomNr; }
            set
            {
                OnPropertyChanged(ref roomNr, value);
            }
        }

    }


}
