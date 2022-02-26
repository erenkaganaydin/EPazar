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
    public class BusUrunResimleri : BaseBusiness<UrunResimleri>, ICrud<UrunResimleri>
    {
        public async Task<bool> InsertAsync(UrunResimleri entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<UrunResimleri>> PredicateAsync(UrunResimleri entity)
        {
            var Result = Query.GetAll().Where(x => x.UrunId == entity.UrunId).ToListAsync();
            return Result;
        }

        public Task<bool> AddRangeAsync(List<UrunResimleri> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(UrunResimleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(UrunResimleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<UrunResimleri> FirstOrDefaultAsync(UrunResimleri entity)
        {
            var Result = Query.GetAll().Where(x => x.UrunId == entity.UrunId).FirstOrDefault();
            return Result;
        }
   

        public async Task<UrunResimleri> FirstOrDefaultAsync(long urunId)
        {
            var Result = Query.GetAll().Where(x => x.UrunId == urunId).FirstOrDefault();
            return Result;
        }

        public Task<List<UrunResimleri>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

       
        public Task<bool> RemoveRangeAsync(UrunResimleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UrunResimleri entity)
        {
            throw new NotImplementedException();
        }
    }
}
