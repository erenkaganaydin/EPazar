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
    public class BusAnasayfaTopBanner : BaseBusiness<AnasayfaTopBanner>, ICrud<AnasayfaTopBanner>
    {
        public Task<bool> AddRangeAsync(List<AnasayfaTopBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<AnasayfaTopBanner> FirstOrDefaultAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnasayfaTopBanner>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(AnasayfaTopBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnasayfaTopBanner>> PredicateAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AnasayfaTopBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
