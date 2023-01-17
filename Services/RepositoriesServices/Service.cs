using Hotel_Proj.Data.DbContexts;
using Hotel_Proj.Domain.AbstractForCRUDs;
using Hotel_Proj.Services.DTOs.Abstract_Dtos;
using Hotel_Proj.Services.IRepositoriesServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Services.RepositoriesServices
{
    public class Service : IRepositoryService
    {
        //private readonly IUserRepository userRepository_;
        private readonly AppDbContext _dbcontext;

        public Service()
        {
            _dbcontext= new AppDbContext();
        }
        public async Task<bool> CreateAsync(AbstractDto dto)
        {
            
        }

        public Task<bool> DeleteAsync(Expression<Func<AbstractDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AbstractForCrud>> GetAllAsync(Expression<Func<AbstractDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<AbstractForCrud> GetAsync(Expression<Func<AbstractDto, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, AbstractDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
