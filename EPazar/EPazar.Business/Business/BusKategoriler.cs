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

        public async Task<Kategoriler> AddanId(Kategoriler Entity)
        {
            var Result = await Query.GetAll().Where(x => x.Ad == Entity.Ad && x.AnaKategoriId == Entity.AnaKategoriId).FirstOrDefaultAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> AddRangeAsync(List<Kategoriler> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<Kategoriler> FirstOrDefaultAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        

        public Task<bool> InsertAsync(Kategoriler entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Kategoriler>> PredicateAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Kategoriler entity)
        {
            throw new NotImplementedException();
        }
    }
}
