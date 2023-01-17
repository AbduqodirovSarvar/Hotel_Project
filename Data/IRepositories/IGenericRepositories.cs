using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Data.IRepositories
{
<<<<<<< HEAD
    public interface IGenericRepositories
    {

=======
    public interface IGenericRepositories<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        void DeleteAsync(Expression<Func<T, bool>> expression);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression);
>>>>>>> 3027ba963c655a1cff78af1f512a4a7a5f4b1e21
    }
}
