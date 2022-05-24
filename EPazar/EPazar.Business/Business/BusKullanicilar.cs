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
    public class BusKullanicilar : BaseBusiness<Kullanicilar>, ICrud<Kullanicilar>
    {
        public Task<bool> AddRangeAsync(List<Kullanicilar> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Kullanicilar entity)
        {
            var Result = await Query.DeleteAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Kullanicilar> FirstOrDefaultAsync(Kullanicilar entity)
        {
            var Result = await Query.GetAll().Where(x => x.EMail == entity.EMail && x.Sifre == entity.Sifre).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<Kullanicilar> FirstOrDefaultPanelAsync(Kullanicilar entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).FirstOrDefaultAsync().ConfigureAwait(true);
            return Result;
        }

        public async Task<Kullanicilar> FirstOrDefaultEmailAsync(Kullanicilar entity)
        {
            var Result = await Query.GetAll().Where(x => x.EMail == entity.EMail).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<Kullanicilar>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Kullanicilar>> GetAllPanelAsync()
        {
            var Result = await Query.GetAll()
                .OrderByDescending(x => x.Id)
                .ToListAsync();

            return Result;
        }

        public async Task<bool> InsertAsync(Kullanicilar entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<Kullanicilar>> PredicateAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Kullanicilar>> PredicateIncludePanelAsync(Kullanicilar Entity)
        {
            IQueryable<Kullanicilar> query = Query.GetAll();

            if (Entity.Ad != null)
            {
                query = query.Where(x => x.Ad.Contains(Entity.Ad));
            }
            else if (Entity.Soyad != null)
            {
                query = query.Where(x => x.Soyad.Contains(Entity.Soyad));
            }
            else if (Entity.Telefon != null)
            {
                query = query.Where(x => x.Telefon.Contains(Entity.Telefon));
            }
            else if (Entity.Cinsiyet != null)
            {
                query = query.Where(x => x.Cinsiyet.Contains(Entity.Cinsiyet));
            }

            return query.ToList();
        }

        public Task<bool> RemoveRangeAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Kullanicilar entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }
    }
}
