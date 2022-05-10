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
    public class BusOdemeDurum : BaseBusiness<OdemeDurum>, ICrud<OdemeDurum>
    {
        public Task<bool> AddRangeAsync(List<OdemeDurum> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<OdemeDurum> FirstOrDefaultAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OdemeDurum>> GetAllAsync()
        {
            var Result = await Query.GetAll()
                .OrderBy(x => x.Id)
                .ToListAsync();

            return Result;
        }

        public Task<bool> InsertAsync(OdemeDurum entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<OdemeDurum>> PredicateAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(OdemeDurum entity)
        {
            throw new NotImplementedException();
        }
    }
}
