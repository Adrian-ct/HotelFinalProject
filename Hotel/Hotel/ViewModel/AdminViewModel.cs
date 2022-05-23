using Hotel.Models.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.ViewModel
{
    public class AdminViewModel
    {
        RoomBLL roomBLL = new RoomBLL();

        public AdminViewModel()
        {
            roomBLL.GetAllServices();
        }
    }
}
