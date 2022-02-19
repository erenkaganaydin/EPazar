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
    public class BusAnasayfaSagBanner : BaseBusiness<AnasayfaSagBanner>, ICrud<AnasayfaSagBanner>
    {
        public Task<bool> AddRangeAsync(List<AnasayfaSagBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<AnasayfaSagBanner> FirstOrDefaultAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnasayfaSagBanner>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(AnasayfaSagBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnasayfaSagBanner>> PredicateAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AnasayfaSagBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
