using Hotel_Proj.Domain.AbstractForCRUDs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Data.IRepositories
{
    public interface IGenericRepositories<T> where T : AbstractForCrud
    {
        Task<bool> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        bool DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression);
    }
}
