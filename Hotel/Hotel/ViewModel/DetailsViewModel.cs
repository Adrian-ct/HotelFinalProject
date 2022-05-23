using Hotel.Models.BusinessLogicLayer;
using Hotel.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Hotel.ViewModel
{
    internal class DetailsViewModel : ObservableObject
    {
        static RoomBLL room = new RoomBLL();
        static public List<Hotel.Models.Room> roomsList = room.GetAllRooms(new DateTime(2022,05, 01), new DateTime(2022, 06, 01));
        public DetailsViewModel()
        {
            string roomData = roomsList[index].ToString();
            imageSource = roomData.Substring(0, 1);
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
                imageSource = value;
                //if (editMode)
                //{
                //    CanExecuteCommandSignIn = Validators.CanExecutePlay(NameTextBox);
                //}
                //CanExecuteCommandNext = Validators.CanExecuteNext(imageSource, images);
                //CanExecuteCommandPrev = Validators.CanExecutePrev(imageSource, images);
                NotifyPropertyChanged("ImageSource");
            }
        }
        private string features;
        public string Features
        {
            get
            {
                return features;
            }
            set
            {
                features = value;
                //if (editMode)
                //{
                //    CanExecuteCommandSignIn = Validators.CanExecutePlay(NameTextBox);
                //}
                //CanExecuteCommandNext = Validators.CanExecuteNext(imageSource, images);
                //CanExecuteCommandPrev = Validators.CanExecutePrev(imageSource, images);
                NotifyPropertyChanged("ImageSource");
            }
        }
        public int index;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
    }
}