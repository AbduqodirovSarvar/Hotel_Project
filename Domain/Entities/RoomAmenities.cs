using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Domain.Entities
{
<<<<<<< HEAD
    internal class RoomAmenities
    {
=======
    public class RoomAmenities
    {
        public int Id { get; set; }
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public int AmenitiesId { get; set; }
        public Amenities Amenities { get; set; }
>>>>>>> master
    }
}
