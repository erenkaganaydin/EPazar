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
    public class BusUrunler : BaseBusiness<Urunler>, ICrud<Urunler>
    {
        public async Task<bool> UpdateAsync(Urunler entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }

        public Task<bool> AddRangeAsync(List<Urunler> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Urunler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(Urunler entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Urunler> IdToUrun(Urunler entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).Include(x => x.UrunResimleri).Include(x=> x.ViewUrunOzellikleriAciklamali).Include(x=> x.Tedarikciler).FirstOrDefaultAsync();

            return Result;
        }

        public async Task<IEnumerable<long>> AdIdList(IEnumerable<long> list, string OzellikList)
        {
            var Result = await Query.GetAll().Where(x => x.Adi.Contains(OzellikList) && list.Contains(x.Id)).Select(x => x.Id).ToListAsync();
            return Result;
        }

        public async Task<List<Urunler>> IdToUrunlerveResimler(IEnumerable<long> list)
        {
            var Result = await Query.GetAll().Where(x=> list.Contains(x.Id)).Include(x => x.UrunResimleri).ToListAsync();

            return Result;
        }

        public async Task<Urunler> FirstOrDefaultAsync(Urunler entity)
        {
            var Result = await Query.GetAll().Where(x=>x.TedarikciId == entity.TedarikciId
                                                    && x.TedarikciUrunId == entity.TedarikciUrunId
                                                    && x.TedarikciUrunKod == entity.TedarikciUrunKod
                                                    && x.Adi == entity.Adi).FirstOrDefaultAsync();

            return Result;
        }
        public async Task<Urunler> FirstOrDefaultTedarikciAsync(Urunler entity)
        {
            var Result = await Query.GetAll().Where(x=>x.TedarikciId == entity.TedarikciId
                                                    && x.TedarikciUrunId == entity.TedarikciUrunId).FirstOrDefaultAsync();

            return Result;
        }
        public async Task<List<Urunler>> UrunIdtoList(IEnumerable<long> list)
        {
            var Result = await Query.GetAll().Where(x => list.Contains(x.Id) && x.Stok > 0 ).Include(x=>x.UrunResimleri).Where(x=> x.UrunResimleri.Count > 0).ToListAsync();
            return Result;
        }

        public async Task<List<Urunler>> BenzerUrunler(Urunler entity)
        {
            var Result = await Query.GetAll().ToListAsync();
            return Result;
        }
        public async Task<List<int>> HipatuTumUrunler()
        {
            var Result = await Query.GetAll().Where(x=> x.TedarikciId == 1).Select(x=> x.TedarikciUrunId).ToListAsync();
            return Result;
        }
        public async Task<List<int>> AkitfBebekTumUrunler()
        {
            var Result = await Query.GetAll().Where(x=> x.TedarikciId == 3).Select(x=> x.TedarikciUrunId).ToListAsync();
            return Result;
        }

        public Task<List<Urunler>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Urunler entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<List<Urunler>> PredicateAsync(Urunler entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(Urunler entity)
        {
            throw new NotImplementedException();
        }

       
    }
}
