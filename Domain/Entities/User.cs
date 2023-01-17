using Hotel_Proj.Domain.AbstractForCRUDs;
using Hotel_Proj.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Domain.Entities
{
    public class User : AbstractForCrud
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public UserRole UserRole { get; set; }

    }
}
