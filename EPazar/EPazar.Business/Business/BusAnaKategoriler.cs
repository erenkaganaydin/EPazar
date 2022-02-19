using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusAnaKategoriler : BaseBusiness<AnaKategoriler>, ICrud<AnaKategoriler>
    {
        public async Task<List<AnaKategoriler>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }
        public async Task<AnaKategoriler> AddanId(AnaKategoriler Entity)
        {
            var Result = await Query.GetAll().Where(x=>x.Ad == Entity.Ad).FirstOrDefaultAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> AddRangeAsync(List<AnaKategoriler> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<AnaKategoriler> FirstOrDefaultAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        

        public Task<bool> InsertAsync(AnaKategoriler entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnaKategoriler>> PredicateAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }
    }
}
