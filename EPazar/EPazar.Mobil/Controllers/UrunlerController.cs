using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace EPazar.Mobil.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UrunKategorileri UrunKategorileri { get; set; }
        public BusUrunKategorileri BusUrunKategorileri { get; set; }

        public Urunler Urunler { get; set; }
        public BusUrunler BusUrunler { get; set; }
        public UrunlerEntity UrunlerEntity { get; set; }

        public BusViewUrunOzellikleriAciklamali BusViewUrunOzellikleriAciklamali { get; set; }

        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        ~UrunlerController()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
        public UrunlerController(ILogger<HomeController> logger)
        {
            _logger = logger;
            UrunKategorileri = new UrunKategorileri();
            BusUrunKategorileri = new BusUrunKategorileri();

            Urunler = new Urunler();
            BusUrunler = new BusUrunler();
            BusUrunOzellikleri = new BusUrunOzellikleri();

            UrunlerEntity = new UrunlerEntity();

            BusViewUrunOzellikleriAciklamali = new BusViewUrunOzellikleriAciklamali();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Filtre()
        {
            return View();
        }
        public async Task<IActionResult> Liste(int? AnaKategoriId, string? AnaKategoriAd, int? KategoriId, string? KategoriAd, int? AltKategoriId, string? AltKategoriAdi)
        {
            ViewData["Title"] = AnaKategoriAd + " " + KategoriAd + " " + AltKategoriAdi + " Ürünleri | Bigtarz'da ";

            ViewData["MetaDesc"] = AnaKategoriAd + " " + KategoriAd + " " + AltKategoriAdi + " Ürünlerini Bigtarz' ile en uygun fiyata al. Hayalindeki " + AnaKategoriAd + " - " + KategoriAd + " - " + AltKategoriAdi + " Ürünlerin uygun fiyata yüksek kalitede ayağına gelsin. Bigtarz ";

            #region KategoriKontrol
            if (AnaKategoriId != null)
            {
                ViewData["KategoriAdi"] = AnaKategoriAd;
                UrunKategorileri.AnaKategoriId = (int)AnaKategoriId;
            }
            if (KategoriId != null)
            {
                ViewData["KategoriAdi"] = KategoriAd;
                UrunKategorileri.KategoriId = (int)KategoriId;
            }
            if (AltKategoriId != null)
            {
                ViewData["KategoriAdi"] = AltKategoriAdi;
                UrunKategorileri.AltKategoriId = (int)AltKategoriId;
            }
            #endregion

            var UrunIdleri = await BusUrunKategorileri.IdList(UrunKategorileri);
            var BedenBilgisi = HttpContext.Request.Query["Beden"].ToArray();
            if (BedenBilgisi.Length > 0)
                UrunIdleri = await BusUrunOzellikleri.IdList(UrunIdleri, BedenBilgisi);

            var RenkBilgisi = HttpContext.Request.Query["Renk"].ToArray();
            if (RenkBilgisi.Length > 0)
                UrunIdleri = await BusViewUrunOzellikleriAciklamali.RenkIdList(UrunIdleri, RenkBilgisi);

            var AramaBilgisi = HttpContext.Request.Query["Arama"].ToString();
            if (AramaBilgisi.Length > 0)
                UrunIdleri = await BusUrunler.AdIdList(UrunIdleri, AramaBilgisi);

            var Urunler = await BusUrunler.UrunIdtoList(UrunIdleri);

            UrunlerEntity.UrunListesi = Urunler;

            return View(UrunlerEntity);
        }

    }
}
