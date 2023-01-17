using Hotel_Proj.Domain.AbstractForCRUDs;
using Hotel_Proj.Domain.Entities;
using Hotel_Proj.Services.DTOs.Abstract_Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Services.IRepositoriesServices
{
    public interface IRepositoryService
    {
        Task<bool> CreateAsync(AbstractDto dto);
        Task<bool> UpdateAsync(int id, AbstractDto dto);
        Task<bool> DeleteAsync(Expression<Func<AbstractDto, bool>> expression);
        Task<AbstractForCrud> GetAsync(Expression<Func<AbstractDto, bool>> expression);
        Task<IEnumerable<AbstractForCrud>> GetAllAsync(Expression<Func<AbstractDto, bool>> expression);
    }
}
