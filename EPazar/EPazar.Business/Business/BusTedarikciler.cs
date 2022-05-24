using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusTedarikciler : BaseBusiness<Tedarikciler>, ICrud<Tedarikciler>
    {
        public Task<bool> AddRangeAsync(List<Tedarikciler> entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Tedarikciler entity)
        {
            var Result = await Query.DeleteAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Tedarikciler entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<Tedarikciler> FirstOrDefaultAsync(Tedarikciler entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Tedarikciler>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<Tedarikciler>> GetAllPanelAsync()
        {
            var Result = await Query.GetAll()
                .OrderByDescending(x => x.Id)
                .ToListAsync();

            return Result;
        }

        public async Task<Tedarikciler> FirstOrDefaultPanelAsync(Tedarikciler entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).FirstOrDefaultAsync().ConfigureAwait(true);
            return Result;
        }

        public Task<bool> InsertAsync(Tedarikciler entity, bool setIdentity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Tedarikciler>> PredicateAsync(Tedarikciler entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(Tedarikciler entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Tedarikciler entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }
    }
}
