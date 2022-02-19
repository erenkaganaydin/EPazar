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
    public class BusAnasayfaMiniBanner : BaseBusiness<AnasayfaMiniBanner>, ICrud<AnasayfaMiniBanner>
    {
        public Task<bool> AddRangeAsync(List<AnasayfaMiniBanner> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<AnasayfaMiniBanner> FirstOrDefaultAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AnasayfaMiniBanner>> GetAllAsync()
        {
            var Result = await Query.GetAll().OrderBy(x => x.Sira).ToListAsync().ConfigureAwait(true);

            return Result;
        }

        public Task<bool> InsertAsync(AnasayfaMiniBanner entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<AnasayfaMiniBanner>> PredicateAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(AnasayfaMiniBanner entity)
        {
            throw new NotImplementedException();
        }
    }
}
