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
    public class BusSiparisDurum : BaseBusiness<SiparisDurum>, ICrud<SiparisDurum>
    {
        public Task<bool> AddRangeAsync(List<SiparisDurum> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<SiparisDurum> FirstOrDefaultAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<SiparisDurum>> GetAllAsync()
        {
            var Result = await Query.GetAll()
                 .OrderBy(x => x.Id)
                 .ToListAsync();

            return Result;
        }

        public Task<bool> InsertAsync(SiparisDurum entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<SiparisDurum>> PredicateAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(SiparisDurum entity)
        {
            throw new NotImplementedException();
        }
    }
}
