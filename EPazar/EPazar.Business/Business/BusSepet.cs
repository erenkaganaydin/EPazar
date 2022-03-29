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
    public class BusSepet : BaseBusiness<Sepet>, ICrud<Sepet>
    {
        public Task<bool> AddRangeAsync(List<Sepet> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Sepet entity)
        {
            var Result = Query.DeleteAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Sepet entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Sepet> FirstOrDefaultAsync(Sepet entity)
        {
            var Result = await Query.GetAll().Where(x => x.CookieToken == entity.CookieToken).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<Sepet>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Sepet entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public async Task<List<Sepet>> PredicateAsync(Sepet entity)
        {
            try
            {
                var Result = await Query.GetAll().Where(x => x.CookieToken == entity.CookieToken).Include(x => x.Urunler).Include(x=> x.ViewUrunOzellikleriAciklamali).ToListAsync();
                return Result;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                var Result = await Query.GetAll().Where(x => x.CookieToken == entity.CookieToken).Include(x => x.Urunler).ToListAsync();
                return Result;
            }
        }
        public async Task<List<Sepet>> PredicateUrunOzellikAsync(Sepet entity)
        {
            IQueryable<Sepet> query = Query.GetAll();

            if (entity.OzellikId != null)
            {
                query = query.Where(x => x.OzellikId == entity.OzellikId);
            }

            query = query.Where(x => x.CookieToken == entity.CookieToken
                                                        && x.UrunId == entity.UrunId);

            return await query.ToListAsync();
        }

        public Task<bool> RemoveRangeAsync(Sepet entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Sepet entity)
        {
            throw new NotImplementedException();
        }
    }
}
