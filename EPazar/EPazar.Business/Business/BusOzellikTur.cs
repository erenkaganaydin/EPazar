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
    public class BusOzellikTur : BaseBusiness<OzellikTur>, ICrud<OzellikTur>
    {
        public Task<bool> AddRangeAsync(List<OzellikTur> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(OzellikTur entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(OzellikTur entity)
        {
            throw new NotImplementedException();
        }

        public async Task<OzellikTur> FirstOrDefaultAsync(OzellikTur entity)
        {
            var Result = await Query.GetAll().Where(x => x.TurAdi.ToUpper() == entity.TurAdi.ToUpper()).FirstOrDefaultAsync();

            return Result;
        }

        public Task<List<OzellikTur>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(OzellikTur entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<OzellikTur>> PredicateAsync(OzellikTur entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(OzellikTur entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(OzellikTur entity)
        {
            throw new NotImplementedException();
        }
    }
}
