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
    public class BusFavoriler : BaseBusiness<Favoriler>, ICrud<Favoriler>
    {
        public Task<bool> AddRangeAsync(List<Favoriler> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Favoriler entity)
        {
            var Result = Query.DeleteAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Favoriler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Favoriler> FirstOrDefaultAsync(Favoriler entity)
        {
            var Resut = await Query.GetAll().Where(x => x.KullaniciId == entity.KullaniciId && x.UrunId == entity.UrunId).FirstOrDefaultAsync();
            return Resut;
        }

        public Task<List<Favoriler>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Favoriler entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result =await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public async Task<List<Favoriler>> PredicateAsync(Favoriler entity)
        {
            var Result = await Query.GetAll().Where(x => x.KullaniciId == entity.KullaniciId).Include(x=> x.Urunler).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(Favoriler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Favoriler entity)
        {
            throw new NotImplementedException();
        }
    }
}
