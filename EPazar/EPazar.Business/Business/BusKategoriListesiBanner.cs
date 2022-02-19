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
    public class BusKategoriListesiBanner : BaseBusiness<KategoriListesiBanner>, ICrud<KategoriListesiBanner>
    {
        public Task<bool> AddRangeAsync(List<KategoriListesiBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(KategoriListesiBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(KategoriListesiBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<KategoriListesiBanner> FirstOrDefaultAsync(KategoriListesiBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<KategoriListesiBanner>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(KategoriListesiBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KategoriListesiBanner>> PredicateAsync(KategoriListesiBanner entity)
        {
            var Result = await Query.GetAll().Where(x => x.KategoriId == entity.KategoriId).OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> RemoveRangeAsync(KategoriListesiBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(KategoriListesiBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
