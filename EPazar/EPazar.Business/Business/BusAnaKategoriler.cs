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

        public async Task<bool> DeleteAsync(AnaKategoriler entity)
        {
            var Result = await Query.DeleteAsync(entity).ConfigureAwait(true);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<AnaKategoriler> FirstOrDefaultAsync(AnaKategoriler entity)
        {
            var Result = await Query.GetAll().FirstOrDefaultAsync(x => x.Id == entity.Id).ConfigureAwait(true);
            return Result;
        }

        

        public Task<bool> InsertAsync(AnaKategoriler entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnaKategoriler>> PredicateAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnaKategoriler>> PredicateIncludePanelAsync(AnaKategoriler Entity)
        {
            IQueryable<AnaKategoriler> query = Query.GetAll();

            if (Entity.Ad != null)
            {
                query = query.Where(x => x.Ad.Contains(Entity.Ad));
            }
            else if (Entity.Sira != null)
            {
                query = query.Where(x => x.Sira == Entity.Sira);
            }
           
            return query.ToList();
        }

        public Task<bool> RemoveRangeAsync(AnaKategoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(AnaKategoriler entity)
        {
            var Result = await Query.UpdateAsync(entity).ConfigureAwait(true);
            return Result;
        }
    }
}
