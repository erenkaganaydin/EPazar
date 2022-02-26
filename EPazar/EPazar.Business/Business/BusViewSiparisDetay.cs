using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusViewSiparisDetay : BaseBusiness<ViewSiparisDetay>, ICrud<ViewSiparisDetay>
    {
        public Task<bool> AddRangeAsync(List<ViewSiparisDetay> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ViewSiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(ViewSiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public Task<ViewSiparisDetay> FirstOrDefaultAsync(ViewSiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ViewSiparisDetay>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(ViewSiparisDetay entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViewSiparisDetay>> PredicateAsync(ViewSiparisDetay entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(ViewSiparisDetay entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ViewSiparisDetay entity)
        {
            throw new NotImplementedException();
        }
    }
}
