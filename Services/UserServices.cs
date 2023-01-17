using Hotel_Proj.Data.DbContexts;
using Hotel_Proj.Data.Repositories;
using Hotel_Proj.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Services
{
    public class UserServices
    {
        public Repositories<User> dbset { get; set; }
        public UserServices() 
        {
            AppDbContext appdb = new AppDbContext();
            dbset = new Repositories<User>(appdb);
        }

        public async Task<bool> Register(User user)
        {
            var isuser = dbset.GetAsync(x => x.PhoneNumber== user.PhoneNumber);
            if(isuser == null)
            {
                var result = await dbset.CreateAsync(user);
                return result;
            }
            else
            {
                throw new Exception("User already created");
            }
        }

        public async Task<bool> Login(string userphone, string password)
        {
            var user = await dbset.GetAsync(x => x.PhoneNumber == userphone);
            if(user != null)
            {
                if(user.Password == password)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Incorrect password");
                }
            }
            else
            {
                throw new Exception("User not found");
            }
        }

        public List<User> GetALLUsers() 
        {
            return dbset.GetAllAsync(x => x.Id >0).ToList();
        }

        public async Task<bool> Delete(int Id)
        {
            User user = await dbset.GetAsync(x => x.Id == Id);
            if(user != null)
            {
                return dbset.DeleteAsync(user);
            }
            else
            {
                throw new Exception("User not found");
            }
        }

    }
}
