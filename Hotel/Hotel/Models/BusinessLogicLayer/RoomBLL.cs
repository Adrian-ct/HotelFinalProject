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

        public List<Room> GetAllRooms()
        {
            List<Room> rooms = new List<Room>();    
            foreach (GetAllRooms_Result room in context.GetAllRooms())
            {
                Room roomDefault = new Room();
                roomDefault.price = room.price;
                roomDefault.type = room.type;
                roomDefault.number = room.number;

                rooms.Add(roomDefault);
            }

            foreach (GetRoomPictures_Result pictures in context.GetRoomPictures())
            {
                Picture picture = new Picture();
                picture.url = pictures.url;

                foreach(Room room in rooms)
                {
                    if (room.number == pictures.room_number)
                    {
                        room.Pictures.Add(picture);
                    }
                }
            }

            return rooms;

        }

       
        public User RegisterMethod(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();

            return user;
        }
    }
}
