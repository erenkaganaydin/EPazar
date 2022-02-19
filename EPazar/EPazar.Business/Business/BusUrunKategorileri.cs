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
    public class BusUrunKategorileri : BaseBusiness<UrunKategorileri>, ICrud<UrunKategorileri>
    {
        public Task<bool> AddRangeAsync(List<UrunKategorileri> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(UrunKategorileri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(UrunKategorileri entity)
        {
            throw new NotImplementedException();
        }

        public async Task<UrunKategorileri> FirstOrDefaultAsync(UrunKategorileri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UrunId == entity.UrunId
                                                    && x.AnaKategoriId == entity.AnaKategoriId 
                                                    && x.KategoriId == entity.KategoriId 
                                                    && x.AltKategoriId == entity.AltKategoriId).FirstOrDefaultAsync();

            return Result;
        }

        public async Task<List<UrunKategorileri>> UrunKategorileriListAsync(UrunKategorileri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UrunId == entity.UrunId).ToListAsync();
            return Result;

        }

        public async Task<UrunKategorileri> UrunKategorileriListFirstAsync(UrunKategorileri entity)
        {
            var Result = await Query.GetAll().Where(x => x.UrunId == entity.UrunId).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<List<UrunKategorileri>> AltKategoriUrunListesi(UrunKategorileri entity)
        {
            Random random = new Random();

            var Result = await Query.GetAll().Where(x => x.AltKategoriId == entity.AltKategoriId).OrderByDescending(emp => Guid.NewGuid()).Take(5).Include(x=> x.Urunler).Take(5).ToListAsync();
            return Result;
        }

        public Task<List<UrunKategorileri>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(UrunKategorileri entity, bool setIdentity)
        {
            entity.Id = 0;
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public async Task<IEnumerable<long>> IdList(UrunKategorileri entity)
        {
            IQueryable<UrunKategorileri> query = Query.GetAll();

            if (entity.AnaKategoriId != 0)
            {
                query = query.Where(x => x.AnaKategoriId == entity.AnaKategoriId);
            }
            if (entity.KategoriId != 0)
            {
                query = query.Where(x => x.KategoriId == entity.KategoriId);
            }
            if (entity.AltKategoriId != 0)
            {
                query = query.Where(x => x.AltKategoriId == entity.AltKategoriId);
            }

            return await query.Select(x=> x.UrunId).ToListAsync();
        }

        public Task<bool> RemoveRangeAsync(UrunKategorileri entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(UrunKategorileri entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UrunKategorileri>> PredicateAsync(UrunKategorileri entity)
        {
            throw new NotImplementedException();
        }
    }
}
