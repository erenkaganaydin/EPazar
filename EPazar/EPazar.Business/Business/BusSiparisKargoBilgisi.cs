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
    public class BusSiparisKargoBilgisi : BaseBusiness<SiparisKargoBilgisi>, ICrud<SiparisKargoBilgisi>
    {
        public Task<bool> AddRangeAsync(List<SiparisKargoBilgisi> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(SiparisKargoBilgisi entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(SiparisKargoBilgisi entity)
        {
            throw new NotImplementedException();
        }

        public Task<SiparisKargoBilgisi> FirstOrDefaultAsync(SiparisKargoBilgisi entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<SiparisKargoBilgisi>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(SiparisKargoBilgisi entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity,setIdentity);
            return Result;
        }

        public async Task<List<SiparisKargoBilgisi>> PredicateAsync(SiparisKargoBilgisi entity)
        {
            var Result = await Query.GetAll().Where(x=> x.SiparisId == entity.SiparisId).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(SiparisKargoBilgisi entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(SiparisKargoBilgisi entity)
        {
            throw new NotImplementedException();
        }
    }
}
