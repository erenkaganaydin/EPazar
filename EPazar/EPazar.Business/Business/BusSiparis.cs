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
    public class BusSiparis : BaseBusiness<Siparis>, ICrud<Siparis>
    {
        public Task<bool> AddRangeAsync(List<Siparis> entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(Siparis entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }

        public Task<bool> DeleteSqlRawAsync(Siparis entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Siparis> FirstOrDefaultAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id).FirstOrDefaultAsync();
            return Result;
        }
        public async Task<Siparis> FirstOrDefaultPanelAsync(Siparis entity)
        {
            var Result = await Query.GetAll()
                .Where(x => x.Id == entity.Id)
                .Include(x => x.Kullanicilar)
                .Include(x => x.KullaniciAdresleri)
                .Include(x => x.SiparisDurum)
                .Include(x => x.OdemeDurum)
                .FirstOrDefaultAsync();
            return Result;
        }

        public async Task<Siparis> FirstOrDefaultUyeIdSiparisIdAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.Id == entity.Id && x.UyeId == entity.UyeId && x.OdemeDurumId >= 1).Include(x => x.KullaniciAdresleri).Include(x => x.SiparisDurum).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<Siparis> FirstOrDefaultJustUyeIdAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId && x.OdemeDurumId <= 1).Include(x => x.SiparisDurum).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<Siparis> FirstOrDefaultUyeIdAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId && x.OdemeDurumId >= 1).Include(x => x.KullaniciAdresleri).Include(x => x.SiparisDurum).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return Result;
        }

        public async Task<Siparis> FirstOrDefaultOdenmediUyeIdAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId && x.OdemeDurumId == 1).Include(x => x.SiparisDurum).OrderByDescending(x => x.Id).FirstOrDefaultAsync();
            return Result;
        }


        public async Task<Siparis> FirstOrDefaultSiparisNumarasiAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.SiparisNumarasi == entity.SiparisNumarasi).FirstOrDefaultAsync();
            return Result;
        }

        public Task<List<Siparis>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertAsync(Siparis entity, bool setIdentity)
        {
            var Result = await Query.InsertAsync(entity, setIdentity);
            return Result;
        }

        public async Task<List<Siparis>> PredicateAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.UyeId == entity.UyeId).ToListAsync();
            return Result;
        }

        public async Task<List<Siparis>> PredicateIncludeAsync(Siparis entity)
        {
            var Result = await Query.GetAll().Where(x => x.OdemeDurumId >= 2 && x.UyeId == entity.UyeId).Include(x => x.SiparisDetay).Include(x => x.KullaniciAdresleri).Include(x => x.SiparisDurum).ToListAsync();
            return Result;
        }

        public Task<bool> RemoveRangeAsync(Siparis entity)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Siparis entity)
        {
            var Result = await Query.UpdateAsync(entity);
            return Result;
        }

        public async Task<List<Siparis>> GetAllIncludePanelAsync()
        {
            var Result = await Query.GetAll()
                .Include(x => x.SiparisDetay)
                .Include(x => x.Kullanicilar)
                .Include(x => x.KullaniciAdresleri)
                .Include(x => x.SiparisDurum)
                .Include(x => x.OdemeDurum)
                .OrderByDescending(x => x.Id)
                .ToListAsync();
            return Result;
        }

        public async Task<List<Siparis>> PredicateIncludePanelAsync(Siparis Entity)
        {
            IQueryable<Siparis> query = Query.GetAll()
                .Include(x => x.SiparisDetay)
                .Include(x => x.Kullanicilar)
                .Include(x => x.KullaniciAdresleri)
                .Include(x => x.SiparisDurum)
                .Include(x => x.OdemeDurum);

            if (Entity.SiparisNumarasi != null)
            {
                query = query.Where(x => x.SiparisNumarasi == Entity.SiparisNumarasi);
            }
            else if (Entity.SiparisDurumAdi != null)
            {
                query = query.Where(x => x.SiparisDurum.Ad == Entity.SiparisDurumAdi);
            }
            else if (Entity.MusteriAd != null)
            {
                query = query.Where(x => x.Kullanicilar.Ad.Contains(Entity.MusteriAd));
            }
            else if (Entity.MusteriSoyad != null)
            {
                query = query.Where(x => x.Kullanicilar.Soyad.Contains(Entity.MusteriSoyad));
            }
            else if (Entity.SiparisTarihi != null)
            {
                query = query.Where(x => x.CreateTime.Date == Entity.SiparisTarihi.Value.Date);
            }

            return query.ToList();
        }
    }
}
