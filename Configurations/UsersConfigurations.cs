using Hotel_Proj.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Configurations
{
    public class UsersConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Password).HasMaxLength(16);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasKey(x => x.PhoneNumber);
        }
    }
}
