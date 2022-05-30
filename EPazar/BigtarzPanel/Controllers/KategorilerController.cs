using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    public class KategorilerController : Controller
    {
        public PanelKategorilerEntityleri PanelKategorilerEntityleri { get; set; }

        public Kategoriler Kategoriler { get; set; }
        public BusKategoriler BusKategoriler { get; set; }

        public AnaKategoriler AnaKategoriler { get; set; }

        public BusAnaKategoriler BusAnaKategoriler { get; set; }

        public KategorilerController()
        {
            PanelKategorilerEntityleri = new PanelKategorilerEntityleri();

            Kategoriler = new Kategoriler();
            BusKategoriler = new BusKategoriler();

            AnaKategoriler = new AnaKategoriler();
            BusAnaKategoriler = new BusAnaKategoriler();
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<Kategoriler> KategorilerListesi  = new List<Kategoriler>();
            var Kategoriler = await BusKategoriler.GetAllAsync().ConfigureAwait(true);
            foreach (var item in Kategoriler)
            {
                AnaKategoriler = new AnaKategoriler();
                AnaKategoriler.Id = item.AnaKategoriId;

                var AnaKategori = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
                item.AnaKategoriAdi = AnaKategori.Ad;
                KategorilerListesi.Add(item);
            }
            KategorilerListesi = KategorilerListesi.OrderBy(x => x.AnaKategoriId).ToList();
            PanelKategorilerEntityleri.Kategoriler = KategorilerListesi;

            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;

            return View(PanelKategorilerEntityleri);
        }
        
        [HttpPost]
        public async Task<IActionResult> IndexAsync(Kategoriler _Kategoriler)
        {
            List<Kategoriler> KategorilerListesi  = new List<Kategoriler>();
            var Kategoriler = await BusKategoriler.PredicateIncludeAsync(_Kategoriler).ConfigureAwait(true);
            foreach (var item in Kategoriler)
            {
                AnaKategoriler = new AnaKategoriler();
                AnaKategoriler.Id = item.AnaKategoriId;

                var AnaKategori = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
                item.AnaKategoriAdi = AnaKategori.Ad;
                KategorilerListesi.Add(item);
            }
            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;

            KategorilerListesi = KategorilerListesi.OrderBy(x => x.AnaKategoriId).ToList();
            PanelKategorilerEntityleri.Kategoriler = KategorilerListesi;

            return View(PanelKategorilerEntityleri);
        }

        public async Task<IActionResult> KategoriSil(int Id)
        {
            Kategoriler.Id = (int)Id;
            var KullaniciBilgisi = await BusKategoriler.FirstOrDefaultAsync(Kategoriler).ConfigureAwait(true);
            if (KullaniciBilgisi != null)
            {
                var SilmeDurum = await BusKategoriler.DeleteAsync(Kategoriler).ConfigureAwait(true);
                if (SilmeDurum)
                {
                    return RedirectToAction("Index", "AnaKategoriler");
                }
                else
                {
                    return Json("AnaKategori Silinemedi!! Lütfen geri gidiniz!!!");
                }
            }
            else
            {
                return Json("AnaKategori Bulunamadı!! Lütfen geri gidiniz!!!");
            }

        }

        public async Task<IActionResult> KategoriDetay(int? Id)
        {
            Kategoriler.Id = (int)Id;
            var KategoriDetay = await BusKategoriler.FirstOrDefaultAsync(Kategoriler).ConfigureAwait(true);
            PanelKategorilerEntityleri.Kategori = KategoriDetay;

            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;

            return View(PanelKategorilerEntityleri);
        }

        [HttpPost]
        public async Task<IActionResult> KategoriDetay(Kategoriler _AnaKategoriler)
        {
            var AnaKategoriDetay = await BusKategoriler.FirstOrDefaultAsync(_AnaKategoriler).ConfigureAwait(true);

            AnaKategoriDetay.AnaKategoriId = _AnaKategoriler.AnaKategoriId;
            AnaKategoriDetay.Ad = _AnaKategoriler.Ad;
            AnaKategoriDetay.Sira = _AnaKategoriler.Sira;
            var AnaKategoriDetayKaydet = await BusKategoriler.UpdateAsync(AnaKategoriDetay).ConfigureAwait(true);

            AnaKategoriDetay = await BusKategoriler.FirstOrDefaultAsync(AnaKategoriDetay).ConfigureAwait(true);
            return View(AnaKategoriDetay);
        }

    }
}
