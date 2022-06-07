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
    public class BusViewSepetTedarikciToplam : BaseBusiness<ViewSepetTedarikciToplam>, ICrud<ViewSepetTedarikciToplam>
    {
        public Task<bool> AddRangeAsync(List<ViewSepetTedarikciToplam> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ViewSepetTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(ViewSepetTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<ViewSepetTedarikciToplam> FirstOrDefaultAsync(ViewSepetTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<ViewSepetTedarikciToplam>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(ViewSepetTedarikciToplam entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViewSepetTedarikciToplam>> PredicateAsync(ViewSepetTedarikciToplam entity)
        {
            var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).ToListAsync().ConfigureAwait(true);
            return Result;
        }

        public Task<bool> RemoveRangeAsync(ViewSepetTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ViewSepetTedarikciToplam entity)
        {
            throw new NotImplementedException();
        }
    }
}
