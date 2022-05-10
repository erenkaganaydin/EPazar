using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusUrunOzellikleri : BaseBusiness<UrunOzellikleri>, ICrud<UrunOzellikleri>
    {
        public async Task<UrunOzellikleri> FirstOrDefaultAsync(UrunOzellikleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.OzellikUrunKodu == entity.OzellikUrunKodu
                                                     && x.OzellikBarkod == entity.OzellikBarkod
                                                     && x.UrunId == entity.UrunId
                                                     && x.OzellikAdi == entity.OzellikAdi).FirstOrDefaultAsync();

            return Result;
        }

        public async Task<UrunOzellikleri> SepetSorgu(UrunOzellikleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.OzellikUrunKodu == entity.OzellikUrunKodu
                                                     && x.OzellikBarkod == entity.OzellikBarkod
                                                     && x.UrunId == entity.UrunId
                                                     && x.OzellikAdi == entity.OzellikAdi).FirstOrDefaultAsync();

            return Result;
        }

        public async Task<IEnumerable<long>> IdList(IEnumerable<long> list, IEnumerable<string> OzellikList)
        {
            var Result = await Query.GetAll().Where(x => OzellikList.Contains(x.OzellikAdi) && list.Contains(x.UrunId) && x.OzellikStok > 0).Select(x => x.UrunId).ToListAsync();
            return Result;
        }



        public async Task<List<string>> UrunOzellikAdlari()
        {
            var Result = await Query.GetAll().Where(x => x.OzellikTurId == 1 || x.OzellikTurId == 2 || x.OzellikTurId == 3).GroupBy(x => x.OzellikAdi).Select(x => x.Key).ToListAsync();

            return Result;
        }
        public async Task<List<string>> UrunOzellikAdlariFiltrele(UrunOzellikleri entity)
        {
            var Result = await Query.GetAll().Where(x => x.OzellikAdi.Contains(entity.OzellikAdi)).GroupBy(x => x.OzellikAdi).Select(x => x.Key).ToListAsync().ConfigureAwait(true);

            return Result;
        }
        public async Task<bool> UpdateAsync(UrunOzellikleri entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }

        public async Task<bool> InsertAsync(UrunOzellikleri entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public Task<bool> AddRangeAsync(List<UrunOzellikleri> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(UrunOzellikleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(UrunOzellikleri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UrunOzellikleri>> GetAllAsync()
        {
            var Result = await Query.GetAll().ToListAsync().ConfigureAwait(true);
            return Result;
        }



        public Task<List<UrunOzellikleri>> PredicateAsync(UrunOzellikleri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveRangeAsync(UrunOzellikleri entity)
        {
            throw new NotImplementedException();
        }


    }
}
