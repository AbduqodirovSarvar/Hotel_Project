using Hotel_Proj.Domain.Entities;
using Hotel_Proj.Services.DTOs.Abstract_Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Services.DTOs
{
    public class UsersDto : AbstractDto
    {
        [MaxLength(25), MinLength(2)]
        public string FullName { get; set; } = string.Empty;

        [Required, MaxLength(9), MinLength(15)]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(), MinLength(8)]
        public string Password { get; set; } = string.Empty;

        public static implicit operator User(UsersDto forCreationDto)
        {
            return new User
            {
                FullName = forCreationDto.FullName,
                PhoneNumber = forCreationDto.PhoneNumber,
                Password = forCreationDto.Password
            };
        }
    }
}


