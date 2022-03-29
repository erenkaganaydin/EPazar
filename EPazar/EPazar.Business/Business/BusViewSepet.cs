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
    public class BusViewSepet : BaseBusiness<ViewSepet>, ICrud<ViewSepet>
    {
        public Task<bool> AddRangeAsync(List<ViewSepet> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ViewSepet entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(ViewSepet entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ViewSepet> FirstOrDefaultAsync(ViewSepet entity)
        {
            var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<ViewSepet>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(ViewSepet entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViewSepet>> PredicateAsync(ViewSepet entity)
        {
            try
            {
                var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).ToListAsync();
                return Result;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).ToListAsync();
                return Result;
            }
        }

        public async Task<List<ViewSepet>> PredicateIncludeAsync(ViewSepet entity)
        {
            try
            {
                var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).Include(x=> x.Tedarikciler).ToListAsync();
                return Result;
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                var Result = await Query.GetAll().Where(x => x.SepetToken == entity.SepetToken).ToListAsync();
                return Result;
            }
        }
        public Task<bool> RemoveRangeAsync(ViewSepet entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ViewSepet entity)
        {
            throw new NotImplementedException();
        }
    }
}
