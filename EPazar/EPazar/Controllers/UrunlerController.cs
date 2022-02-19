using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using EPazar.Entity.XMLEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    public class UrunlerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public UrunKategorileri UrunKategorileri { get; set; }
        public BusUrunKategorileri BusUrunKategorileri { get; set; }

        public Urunler Urunler { get; set; }
        public BusUrunler BusUrunler { get; set; }
        public UrunlerEntity UrunlerEntity { get; set; }

        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        public UrunlerController(ILogger<HomeController> logger)
        {
            _logger = logger;
            UrunKategorileri = new UrunKategorileri();
            BusUrunKategorileri = new BusUrunKategorileri();

            Urunler = new Urunler();
            BusUrunler = new BusUrunler();
            BusUrunOzellikleri = new BusUrunOzellikleri();

            UrunlerEntity = new UrunlerEntity();
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Liste(int? AnaKategoriId,string? AnaKategoriAd, int? KategoriId,string? KategoriAd,int? AltKategoriId,string? AltKategoriAdi)
        {
            ViewData["Title"] = AnaKategoriAd +" "+ KategoriAd + " "+ AltKategoriAdi+" Ürünleri | Bigtarz'da ";

            ViewData["MetaDesc"] = AnaKategoriAd + " " + KategoriAd + " " + AltKategoriAdi + " Ürünlerini Bigtarz' ile en uygun fiyata al. Hayalindeki "+ AnaKategoriAd + " - " + KategoriAd + " - " + AltKategoriAdi + " Ürünlerin uygun fiyata yüksek kalitede ayağına gelsin. Bigtarz ";

            #region KategoriKontrol
            if (AnaKategoriId != null)
            {
                UrunKategorileri.AnaKategoriId = (int)AnaKategoriId;
            }
            if (KategoriId != null)
            {
                UrunKategorileri.KategoriId = (int)KategoriId;
            }
            if (AltKategoriId != null)
            {
                UrunKategorileri.AltKategoriId = (int)AltKategoriId;
            } 
            #endregion

            var UrunIdleri = await BusUrunKategorileri.IdList(UrunKategorileri);
            var BedenBilgisi = HttpContext.Request.Query["Beden"].ToArray();
            if (BedenBilgisi.Length > 0 )
                UrunIdleri = await BusUrunOzellikleri.IdList(UrunIdleri, BedenBilgisi);
            var Urunler = await BusUrunler.UrunIdtoList(UrunIdleri);

            UrunlerEntity.UrunListesi = Urunler;

            return View(UrunlerEntity);
        }

    }
}
