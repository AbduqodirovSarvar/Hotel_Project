using Microsoft.EntityFrameworkCore;
using Hotel_Proj.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Proj.Configurations;

namespace Hotel_Proj.Data.DbContexts
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Amenities> Amenities { get; set; }
        public virtual DbSet<RoomAmenities> RoomAmenities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(AppSettingsJson.ConnectionString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomsConfigurations());
            modelBuilder.ApplyConfiguration(new UsersConfigurations());
        }
    }
}
