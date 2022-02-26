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
    public class BusKullanicilar : BaseBusiness<Kullanicilar>, ICrud<Kullanicilar>
    {
        public Task<bool> AddRangeAsync(List<Kullanicilar> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
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

        public async Task<Kullanicilar> FirstOrDefaultEmailAsync(Kullanicilar entity)
        {
            var Result = await Query.GetAll().Where(x => x.EMail == entity.EMail ).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<Kullanicilar>> GetAllAsync()
        {
            throw new NotImplementedException();
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

        public Task<bool> RemoveRangeAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Kullanicilar entity)
        {
            throw new NotImplementedException();
        }
    }
}
