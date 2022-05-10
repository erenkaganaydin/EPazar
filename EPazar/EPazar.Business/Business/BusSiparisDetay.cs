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
    public class BusSiparisDetay : BaseBusiness<SiparisDetay>, ICrud<SiparisDetay>
    {
        public Task<bool> AddRangeAsync(List<SiparisDetay> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(SiparisDetay entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(SiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public async Task<SiparisDetay> FirstOrDefaultAsync(SiparisDetay entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<SiparisDetay>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(SiparisDetay entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public async Task<List<SiparisDetay>> PredicateAsync(SiparisDetay entity)
        {
            var Result = await Query.GetAll()
                .Where(x => x.SiparisId == entity.SiparisId)
                .ToListAsync();
            return Result;
        }
        public async Task<List<SiparisDetay>> PredicatePanelAsync(SiparisDetay entity)
        {
            var Result = await Query.GetAll()
                .Where(x => x.SiparisId == entity.SiparisId)
                .Include(x=> x.Urunler)
                .ToListAsync();

            return Result;
        }

        public Task<bool> RemoveRangeAsync(SiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(SiparisDetay entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }
    }
}
