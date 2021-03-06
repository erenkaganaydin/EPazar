using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusOzellikRenkleri : BaseBusiness<OzellikRenkleri>, ICrud<OzellikRenkleri>
    {
        public Task<bool> AddRangeAsync(List<OzellikRenkleri> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(OzellikRenkleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(OzellikRenkleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<OzellikRenkleri> FirstOrDefaultAsync(OzellikRenkleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.Ad.ToUpper() == entity.Ad.ToUpper()).FirstOrDefaultAsync();

            return Result;
        }

        public async Task<List<OzellikRenkleri>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<string>> GetAllAdlarAsync()
        {
            var Result = await Query.GetAll().GroupBy(x => x.Ad).Select(x => x.Key).ToListAsync();

            return Result;
        }

        public async Task<bool> InsertAsync(OzellikRenkleri entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<OzellikRenkleri>> PredicateAsync(OzellikRenkleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OzellikRenkleri>> OzellikAdlari(OzellikRenkleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.Ad.Contains(entity.Ad)).ToListAsync().ConfigureAwait(true);
            return Result;
        }

        public Task<bool> RemoveRangeAsync(OzellikRenkleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(OzellikRenkleri entity)
        {
            throw new NotImplementedException();
        }
    }
}
