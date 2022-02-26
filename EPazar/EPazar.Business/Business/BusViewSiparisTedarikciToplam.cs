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
    public class BusViewSiparisTedarikciToplam : BaseBusiness<ViewSiparisTedarikciToplam>, ICrud<ViewSiparisTedarikciToplam>
    {
        public Task<bool> AddRangeAsync(List<ViewSiparisTedarikciToplam> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ViewSiparisTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(ViewSiparisTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<ViewSiparisTedarikciToplam> FirstOrDefaultAsync(ViewSiparisTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ViewSiparisTedarikciToplam>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(ViewSiparisTedarikciToplam entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViewSiparisTedarikciToplam>> PredicateAsync(ViewSiparisTedarikciToplam entity)
        {
            var Result = await Query.GetAll().Where(x => x.SiparisId == entity.SiparisId).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(ViewSiparisTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ViewSiparisTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }
    }
}
