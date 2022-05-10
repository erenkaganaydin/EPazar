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
    public class BusAltKategoriler : BaseBusiness<AltKategoriler>, ICrud<AltKategoriler>
    {
        public async Task<AltKategoriler> AddanId(AltKategoriler Entity)
        {
            var Result = await Query.GetAll().Where(x => x.Ad == Entity.Ad && x.KategoriId == Entity.KategoriId && x.UstKategoriId == Entity.UstKategoriId).FirstOrDefaultAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> AddRangeAsync(List<AltKategoriler> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<AltKategoriler> FirstOrDefaultAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AltKategoriler>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public async Task<List<AltKategoriler>> GetAllOrtaKatIdAsync(AltKategoriler entity)
        {
            var Result = await Query.GetAll().Where(x=> x.KategoriId == entity.KategoriId).OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(AltKategoriler entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AltKategoriler>> PredicateAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }
    }
}
