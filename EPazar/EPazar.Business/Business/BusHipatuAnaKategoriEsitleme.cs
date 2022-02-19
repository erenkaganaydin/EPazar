using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.XMLEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusHipatuAnaKategoriEsitleme : BaseBusiness<HipatuAnaKategoriEsitleme>, ICrud<HipatuAnaKategoriEsitleme>
    {
        public Task<bool> AddRangeAsync(List<HipatuAnaKategoriEsitleme> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(HipatuAnaKategoriEsitleme entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(HipatuAnaKategoriEsitleme entity)
        {
            throw new NotImplementedException();
        }

        public Task<HipatuAnaKategoriEsitleme> FirstOrDefaultAsync(HipatuAnaKategoriEsitleme entity)
        {
            throw new NotImplementedException();
        }
        public async Task<HipatuAnaKategoriEsitleme> VarMi(HipatuAnaKategoriEsitleme entity)
        {
            var Result = await Query.GetAll().Where(x => x.TedarikciKategoriBirAdi == entity.TedarikciKategoriBirAdi
                                                      && x.TedarikciKategoriIkiAdi == entity.TedarikciKategoriIkiAdi
                                                      && x.TedarikciKategoriUcAdi == entity.TedarikciKategoriUcAdi).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<HipatuAnaKategoriEsitleme>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(HipatuAnaKategoriEsitleme entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<HipatuAnaKategoriEsitleme>> PredicateAsync(HipatuAnaKategoriEsitleme entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(HipatuAnaKategoriEsitleme entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(HipatuAnaKategoriEsitleme entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }
    }
}
