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
    public class BusKategoriler : BaseBusiness<Kategoriler>, ICrud<Kategoriler>
    {
        public async Task<List<Kategoriler>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).OrderBy(x => x.Id).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public async Task<List<Kategoriler>> GetAllUstteAsync(Kategoriler Entity)
        {
            var Result = await Query.GetAll().Where(x=> x.AnaKategoriId == Entity.AnaKategoriId).OrderBy(x => x.Sira).OrderBy(x => x.Id).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public async Task<Kategoriler> AddanId(Kategoriler Entity)
        {
            var Result = await Query.GetAll().Where(x => x.Ad == Entity.Ad && x.AnaKategoriId == Entity.AnaKategoriId).FirstOrDefaultAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> AddRangeAsync(List<Kategoriler> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Kategoriler entity)
        {
            var Result = await Query.DeleteAsync(entity).ConfigureAwait(true);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Kategoriler> FirstOrDefaultAsync(Kategoriler entity)
        {
            var Result = await Query.GetAll().FirstOrDefaultAsync(x=> x.Id == entity.Id).ConfigureAwait(true);
            return Result;
        }

        

        public async Task<bool> InsertAsync(Kategoriler entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity).ConfigureAwait(true);
            return Result;
        }

        public Task<List<Kategoriler>> PredicateAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }
        
        public async Task<List<Kategoriler>> PredicateIncludeAsync(Kategoriler Entity)
        {
            IQueryable<Kategoriler> query = Query.GetAll();

            if (Entity.Ad != null)
            {
                query = query.Where(x => x.Ad.Contains(Entity.Ad));
            }
            else if (Entity.Sira != 0)
            {
                query = query.Where(x => x.Sira== Entity.Sira);
            }
            else if (Entity.AnaKategoriId != 0)
            {
                query = query.Where(x => x.AnaKategoriId == Entity.AnaKategoriId);
            }
           
            return query.ToList();
        }

        public Task<bool> RemoveRangeAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Kategoriler entity)
        {
            var Result = await Query.UpdateAsync(entity).ConfigureAwait(true);
            return Result;
        }
    }
}
