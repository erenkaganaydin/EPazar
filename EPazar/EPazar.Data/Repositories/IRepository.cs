using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace EPazar.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetById(object id);

        IQueryable<T> GetAll();

        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);

        T Get(Expression<Func<T, bool>> predicate);

        Task<bool> InsertAsync(T entity, bool setIdentity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> AddRangeAsync(List<T> entity);

        Task<bool> DeleteSqlRawAsync(T entity);

        Task<bool> DeleteAsync(T entity);
    }
}