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
    public class BusAnasayfaBanner : BaseBusiness<AnasayfaBanner>, ICrud<AnasayfaBanner>
    {
        public Task<bool> AddRangeAsync(List<AnasayfaBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<AnasayfaBanner> FirstOrDefaultAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnasayfaBanner>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(AnasayfaBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnasayfaBanner>> PredicateAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AnasayfaBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
