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
    public class BusKategoriListesiTopBanner : BaseBusiness<KategoriListesiTopBanner>, ICrud<KategoriListesiTopBanner>
    {
        public Task<bool> AddRangeAsync(List<KategoriListesiTopBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(KategoriListesiTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(KategoriListesiTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<KategoriListesiTopBanner> FirstOrDefaultAsync(KategoriListesiTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KategoriListesiTopBanner>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(KategoriListesiTopBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<KategoriListesiTopBanner>> PredicateAsync(KategoriListesiTopBanner entity)
        {
            var Result = await Query.GetAll().Where(x => x.KategoriId == entity.KategoriId).OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> RemoveRangeAsync(KategoriListesiTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(KategoriListesiTopBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
