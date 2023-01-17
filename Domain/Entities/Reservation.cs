using Hotel_Proj.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public User user { get; set; }
        public int RoomId { get; set; }
        public Room room { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public bool PaymentStatus { get; set; }
        public Payments Payments { get; set; }
    }
}
