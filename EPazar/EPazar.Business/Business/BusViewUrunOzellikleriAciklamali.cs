using EPazar.BaseBusiness.Base;
using EPazar.Data.UnitOfWork;
using EPazar.Entity.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Business.Business
{
    public class BusViewUrunOzellikleriAciklamali : BaseBusiness<ViewUrunOzellikleriAciklamali>, ICrud<ViewUrunOzellikleriAciklamali>
    {
        public Task<bool> AddRangeAsync(List<ViewUrunOzellikleriAciklamali> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(ViewUrunOzellikleriAciklamali entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteSqlRawAsync(ViewUrunOzellikleriAciklamali entity)
        {
            throw new NotImplementedException();
        }

        public Task<ViewUrunOzellikleriAciklamali> FirstOrDefaultAsync(ViewUrunOzellikleriAciklamali entity)
        {
            throw new NotImplementedException();
        }

        public Task<ViewUrunOzellikleriAciklamali> FirstOrDefaultSepetEkleAsync(ViewUrunOzellikleriAciklamali entity)
        {
            var Result = Query.GetAll().Where(x=>  x.UrunId == entity.UrunId
                                                && x.OzellikAdi == entity.OzellikAdi
                                                && x.RenkAdi == entity.RenkAdi).FirstOrDefaultAsync();

            return Result;
        }

        public Task<List<ViewUrunOzellikleriAciklamali>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertAsync(ViewUrunOzellikleriAciklamali entity, bool setIdentity)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ViewUrunOzellikleriAciklamali>> PredicateAsync(ViewUrunOzellikleriAciklamali entity)
        {
            var Result = await Query.GetAll().Where(x => x.RenkAdi == entity.RenkAdi).ToListAsync();
            return Result;
        }

        public async Task<IEnumerable<long>> RenkIdList(IEnumerable<long> list, IEnumerable<string> OzellikList)
        {
            var Result = await Query.GetAll().Where(x => OzellikList.Contains(x.RenkAdi) && list.Contains(x.UrunId) && x.OzellikStok > 0).Select(x => x.UrunId).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(ViewUrunOzellikleriAciklamali entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(ViewUrunOzellikleriAciklamali entity)
        {
            throw new NotImplementedException();
        }
    }
}
