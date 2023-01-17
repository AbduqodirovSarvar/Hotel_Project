using Hotel_Proj.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public Statuses Status { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}
