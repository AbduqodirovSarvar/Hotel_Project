using Hotel_Proj.Domain.Entities;
using Hotel_Proj.Domain.Enums;
using Hotel_Proj.Services.DTOs.Abstract_Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Services.DTOs
{
    public class RoomsDto : AbstractDto
    {
        [Required]
        public int RoomNumber { get; set; }
        [Required]
        public int Floor { get; set; }
        [Required]
        public Statuses Status { get; set; }
        [Required]
        public float Price { get; set; }

        [Required, MinLength(20)]
        public string Description { get; set; }        

        public static implicit operator Room(RoomsDto roomdto)
        {
            return new Room
            {
                RoomNumber= roomdto.RoomNumber,
                Floor= roomdto.Floor,
                Status= roomdto.Status,
                Price= roomdto.Price,
                Description= roomdto.Description
            };
        }
    }
}