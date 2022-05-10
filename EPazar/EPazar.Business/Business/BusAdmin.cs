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
    public class BusAdmin : BaseBusiness<Admin>, ICrud<Admin>
    {
        public Task<bool> AddRangeAsync(List<Admin> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Admin> FirstOrDefaultAsync(Admin entity)
        {
            var Result = await Query.GetAll()
                                    .Where(x => x.KullaniciAdi == entity.KullaniciAdi && x.Sifre == entity.Sifre)
                                    .FirstOrDefaultAsync();

            return Result;
        }

        public Task<List<Admin>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(Admin entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Admin>> PredicateAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(Admin entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Admin entity)
        {
            throw new NotImplementedException();
        }
    }
}
