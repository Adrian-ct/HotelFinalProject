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
    internal class DetailsViewModel : ObservableObject
    {


        public ICommand BackCommand { get; }
        public ICommand NextCommand { get; }
        public ICommand PreviousCommand { get; }
        public ICommand TestCommand { get; }
        static RoomBLL room = new RoomBLL();
        static ServiceBLL serviceBLL = new ServiceBLL();

        private ObservableCollection<Feature> features;
        public ObservableCollection<Feature> Features { get { return features; } set { OnPropertyChanged(ref features, value); } }

        public ObservableCollection<Service> service;
        public ObservableCollection<Service> Service { get { return service; } set { OnPropertyChanged(ref service, value); } }


        List<Hotel.Models.Room> roomsList1;
        int indexOfRoomInList;
        int imageIndex = 0;
        public DetailsViewModel(int index, Room roomNumber, DateTime checkIn, DateTime checkOut)
        {
            BackCommand = new RelayCommands(Back);
            NextCommand = new RelayCommands(Next);
            PreviousCommand = new RelayCommands(Previous);
            TestCommand = new RelayCommands(Testbutton);

            List<Hotel.Models.Room> roomsList = room.GetAllRooms(checkIn, checkOut);

            indexOfRoomInList = index;
            ImageSource = roomsList[index].Pictures.ElementAt(imageIndex).url;
            roomsList1 = roomsList;

            Features = new ObservableCollection<Feature>(roomNumber.Features);

            List<Service> servicesList = serviceBLL.GetAllServicesForRoom();

            Service = new ObservableCollection<Service>(servicesList);



            AllInclusivePrice = (int)Service.ElementAt(0).price;
            BarbequePrice = (int)Service.ElementAt(1).price;
            BreakfastPrice = (int)Service.ElementAt(2).price;
            transportPrice = (int)Service.ElementAt(3).price;

            AllInclusiveLabel = Service.ElementAt(0).name + " -";
            BarbequeLabel = Service.ElementAt(1).name + " -";
            BreakfastLabel = Service.ElementAt(2).name + " -";
            transportLabel = Service.ElementAt(3).name + " -";

        }

        private string imageSource;
        public string ImageSource
        {
            get
            {
                return imageSource;
            }
            set
            {
                OnPropertyChanged(ref imageSource, value);
            }
        }

        //private DateTime roomCheckIn;
        //public DateTime RoomCheckIn
        //{
        //    get { return roomCheckIn; }
        //    set { OnPropertyChanged(ref roomCheckIn, value); }
        //}

        //private DateTime roomCheckOut;
        //public DateTime RoomCheckOut
        //{
        //    get { return roomCheckOut; }
        //    set { OnPropertyChanged(ref roomCheckOut, value); }
        //}



        public void Back()
        {
            ClientWindow clientWindow = new ClientWindow();
            App.Current.MainWindow.Close();
            App.Current.MainWindow = clientWindow;
            clientWindow.Show();
        }

        public void Next()
        {
            if (imageIndex < roomsList1[indexOfRoomInList].Pictures.Count - 1)
                imageIndex++;
        }
        public void Previous()
        {
            if (imageIndex < roomsList1[indexOfRoomInList].Pictures.Count - 1 && imageIndex > 0)
                imageIndex--;
        }

        public void Testbutton()
        {

        }

        private bool allInclusiveBool;
        public bool AllInclusiveBool
        {
            get { return allInclusiveBool; }
            set
            {
                OnPropertyChanged(ref allInclusiveBool, value);
            }
        }

        private bool barbequeBool;
        public bool BarbequeBool
        {
            get
            {
                return barbequeBool;
            }
            set
            {
                OnPropertyChanged(ref barbequeBool, value);
            }
        }

        private bool breakfastBool;
        public bool BreakfastBool
        {
            get
            {
                return breakfastBool;
            }
            set
            {

                OnPropertyChanged(ref breakfastBool, value);
            }
        }


        private bool transportBool;
        public bool TransportBool
        {
            get
            {
                return transportBool;
            }
            set
            {

                OnPropertyChanged(ref transportBool, value);
            }
        }

        private int allInclusivePrice;
        public int AllInclusivePrice
        {
            get
            {
                return allInclusivePrice;
            }
            set
            {
                OnPropertyChanged(ref allInclusivePrice, value);
            }
        }

        private int barbequePrice;
        public int BarbequePrice
        {
            get
            {
                return barbequePrice;
            }
            set
            {
                OnPropertyChanged(ref barbequePrice, value);
            }
        }

        private int breakfastPrice;
        public int BreakfastPrice
        {
            get
            {
                return breakfastPrice;
            }
            set
            {
                OnPropertyChanged(ref breakfastPrice, value);
            }
        }


        private int transportPrice;
        public int TransportPrice
        {
            get
            {
                return transportPrice;
            }
            set
            {
                OnPropertyChanged(ref transportPrice, value);
            }
        }


        private string allInclusiveLabel;
        public string AllInclusiveLabel
        {
            get
            {
                return allInclusiveLabel;
            }
            set
            {
                OnPropertyChanged(ref allInclusiveLabel, value);
            }
        }

        private string barbequeLabel;
        public string BarbequeLabel
        {
            get
            {
                return barbequeLabel;
            }
            set
            {
                OnPropertyChanged(ref barbequeLabel, value);
            }
        }

        private string breakfastLabel;
        public string BreakfastLabel
        {
            get
            {
                return breakfastLabel;
            }
            set
            {
                OnPropertyChanged(ref breakfastLabel, value);
            }
        }


        private string transportLabel;
        public string TransportLabel
        {
            get
            {
                return transportLabel;
            }
            set
            {
                OnPropertyChanged(ref transportLabel, value);
            }

        }



    }
}