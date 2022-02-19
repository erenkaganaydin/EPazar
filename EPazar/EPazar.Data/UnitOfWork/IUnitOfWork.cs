using System.Threading.Tasks;
using EPazar.Data.Repositories;

namespace EPazar.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class;

        Task<bool> SaveChangesAsync<T>(T entity, bool setIdentity) where T : class;
    }
}