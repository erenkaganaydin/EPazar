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

        public async Task<bool> DeleteAsync(AltKategoriler entity)
        {
            var Result = await Query.DeleteAsync(entity).ConfigureAwait(true);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AltKategoriler>> PredicateIncludeAsync(AltKategoriler Entity)
        {
            IQueryable<AltKategoriler> query = Query.GetAll();

            if (Entity.Ad != null)
            {
                query = query.Where(x => x.Ad.Contains(Entity.Ad));
            }
            else if (Entity.Sira != 0)
            {
                query = query.Where(x => x.Sira == Entity.Sira);
            }
            else if (Entity.UstKategoriId != 0)
            {
                query = query.Where(x => x.UstKategoriId == Entity.UstKategoriId);
            }
            else if (Entity.KategoriId != 0)
            {
                query = query.Where(x => x.KategoriId == Entity.KategoriId);
            }
            

            return query.ToList();
        }

        public async Task<AltKategoriler> FirstOrDefaultAsync(AltKategoriler entity)
        {
            var Result = await Query.GetAll().FirstOrDefaultAsync(x => x.Id == entity.Id).ConfigureAwait(true);
            return Result;
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

        public async Task<bool> InsertAsync(AltKategoriler entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity).ConfigureAwait(true);
            return Result;
        }

        public Task<List<AltKategoriler>> PredicateAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AltKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(AltKategoriler entity)
        {
            var Result = await Query.UpdateAsync(entity).ConfigureAwait(true);
            return Result;
        }
    }
}
