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
    public class BusKullaniciAdresleri : BaseBusiness<KullaniciAdresleri>, ICrud<KullaniciAdresleri>
    {
        public Task<bool> AddRangeAsync(List<KullaniciAdresleri> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.DeleteAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(KullaniciAdresleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<KullaniciAdresleri> FirstOrDefaultAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId && x.Id == entity.Id).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<KullaniciAdresleri> FirstOrDefaultPanelAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<KullaniciAdresleri>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(KullaniciAdresleri entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, false);
            return Result;
        }

        public async Task<List<KullaniciAdresleri>> PredicateAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId).ToListAsync();
            return Result;
        }
        public async Task<List<KullaniciAdresleri>> PredicatePanelAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId).ToListAsync().ConfigureAwait(true);
            return Result;
        }

        public Task<bool> RemoveRangeAsync(KullaniciAdresleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(KullaniciAdresleri entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }
    }
}
