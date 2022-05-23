using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Models.BusinessLogicLayer
{
    public class RoomBLL
    {
        HotelEntities context = new HotelEntities();

        public List<Room> GetAllRooms(DateTime checkIn, DateTime checkOut)
        {
            

            var list = context.SeeRoomsAvailable(checkIn.Date.ToString("yyyy-MM-dd"), checkOut.Date.ToString("yyyy-MM-dd"));
            List<Room> rooms = new List<Room>();
    
            foreach (var roomAvailable in list.ToList())
            {
                Room room = new Room();
                room.number = roomAvailable.number;
                room.price = roomAvailable.price;
                room.type = roomAvailable.type;

                string[] features = roomAvailable.features.Split(',');

                foreach (var feature in features)
                {
                    Feature roomFeature = new Feature();
                    roomFeature.name = feature;
                    room.Features.Add(roomFeature);
                }

                string[] images = roomAvailable.pictures.Split(',');

                foreach (var image in images)
                {
                    Picture roomPicture = new Picture();
                    roomPicture.url = image;
                    room.Pictures.Add(roomPicture);
                }
                rooms.Add(room);
            }
            return rooms;
        }

        public void GetAllServices()
        {
            var list = context.GetAllServices();
            
        }


        public User RegisterMethod(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }
    }
}
