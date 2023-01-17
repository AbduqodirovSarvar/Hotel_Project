using Hotel_Proj.Data.DbContexts;
using Hotel_Proj.Data.IRepositories;
using Hotel_Proj.Domain.AbstractForCRUDs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Proj.Data.Repositories
{
    public class Repositories<T> : IGenericRepositories<T> where T : AbstractForCrud
    {
        protected readonly AppDbContext _db;
        protected readonly DbSet<T> _dbSet;

        public Repositories(AppDbContext dbcontext)
        {
            _db = dbcontext;
            _dbSet = dbcontext.Set<T>();
        }
        public async Task<bool> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            var res = await _db.SaveChangesAsync();
            return res>0;
        }

        public bool DeleteAsync(T entity)
        {
            //var entity = _dbSet.FirstOrDefault(x => x.Id == id);
            _dbSet.Remove(entity);
            return _db.SaveChanges()>0;
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>> expression)
        {
           return expression is null ? _dbSet : _dbSet.Where(expression);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
           return await _dbSet.FirstOrDefaultAsync(expression);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            var Updaties = _dbSet.Update(entity);
            _db.SaveChanges();
            return Updaties.Entity;
        }
    }
}
