using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    //Anakategoriden buraya geliniyor.   Ana kategoriye göre bannerlar vb seyler sergileniyor.
    public class KategoriListesiController : Controller
    {
        public KategoriListesiEntityleri KategoriListesiEntityleri { get; set; }
        public BusKategoriListesiBanner BusKategoriListesiBanner { get; set; }
        public BusAnasayfaTopBanner BusAnasayfaTopBanner { get; set; }
        public BusAnasayfaSagBanner BusAnasayfaSagBanner { get; set; }
        public BusAnasayfaMiniBanner BusAnasayfaMiniBanner { get; set; }
        public BusKategoriListesiTopBanner BusKategoriListesiTopBanner { get; set; }
        public KategoriListesiTopBanner KategoriListesiTopBanner { get; set; }
        public KategoriListesiBanner KategoriListesiBanner { get; set; }

        ~KategoriListesiController()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
        public KategoriListesiController()
        {
            KategoriListesiEntityleri = new KategoriListesiEntityleri();
            BusKategoriListesiBanner = new BusKategoriListesiBanner();
            BusAnasayfaSagBanner = new BusAnasayfaSagBanner();
            BusAnasayfaMiniBanner = new BusAnasayfaMiniBanner();
            BusKategoriListesiTopBanner = new BusKategoriListesiTopBanner();
            KategoriListesiTopBanner = new KategoriListesiTopBanner();
            KategoriListesiBanner = new KategoriListesiBanner();
        }

        public IActionResult Index(int? KategoriId, string? kategoriAd)
        {
            return RedirectToAction("Listele");
        }

        public async Task<IActionResult> ListeleAsync(int? AnaKategoriId, string? AnaKategoriAd)
        {
            ViewData["Title"] = AnaKategoriAd + " Ürünleri | Bigtarz'da ";
            ViewBag.Id = AnaKategoriId;
            ViewBag.Ad = AnaKategoriAd;

            KategoriListesiTopBanner.KategoriId = (int)AnaKategoriId;
            KategoriListesiBanner.KategoriId = (int)AnaKategoriId;

            KategoriListesiEntityleri.KategoriListesiBanner = await BusKategoriListesiBanner.PredicateAsync(KategoriListesiBanner).ConfigureAwait(true);
            KategoriListesiEntityleri.KategoriListesiTopBanner = await BusKategoriListesiTopBanner.PredicateAsync(KategoriListesiTopBanner).ConfigureAwait(true);
            KategoriListesiEntityleri.AnasayfaSagBannerList = await BusAnasayfaSagBanner.GetAllAsync().ConfigureAwait(true);
            KategoriListesiEntityleri.AnasayfaMiniBannerList = await BusAnasayfaMiniBanner.GetAllAsync().ConfigureAwait(true);
            return View(KategoriListesiEntityleri);
        }
    }
}
