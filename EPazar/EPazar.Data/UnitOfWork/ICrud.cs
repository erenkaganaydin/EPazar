using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPazar.Data.UnitOfWork
{
    public interface ICrud<T> where T : class, new()
    {
        Task<List<T>> GetAllAsync();

        Task<T> FirstOrDefaultAsync(T entity);

        Task<bool> InsertAsync(T entity, bool setIdentity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<bool> AddRangeAsync(List<T> entity);

        Task<bool> RemoveRangeAsync(T entity);

        Task<List<T>> PredicateAsync(T entity);

        Task<bool> DeleteSqlRawAsync(T entity);
    }
}