using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    [Authorize]
    public class AltKategorilerController : Controller
    {
        public PanelAltKategorilerEntityleri PanelAltKategorilerEntityleri { get; set; }

        public AltKategoriler AltKategoriler { get; set; }
        public BusAltKategoriler BusAltKategoriler { get; set; }
        
        public Kategoriler Kategoriler { get; set; }
        public BusKategoriler BusKategoriler { get; set; }

        public AnaKategoriler AnaKategoriler { get; set; }
        public BusAnaKategoriler BusAnaKategoriler { get; set; }

        public AltKategorilerController()
        {
            PanelAltKategorilerEntityleri = new PanelAltKategorilerEntityleri();

            AltKategoriler = new AltKategoriler();
            BusAltKategoriler = new BusAltKategoriler();

            Kategoriler = new Kategoriler();
            BusKategoriler = new BusKategoriler();

            AnaKategoriler = new AnaKategoriler();
            BusAnaKategoriler = new BusAnaKategoriler();
        }

        public async Task<IActionResult> IndexAsync()
        {
            List<AltKategoriler> AltKategorilerListesi = new List<AltKategoriler>();
            var AltKategoriler = await BusAltKategoriler.GetAllAsync().ConfigureAwait(true);
            foreach (var item in AltKategoriler)
            {
                AnaKategoriler = new AnaKategoriler();
                AnaKategoriler.Id = (int)item.UstKategoriId;

                var AnaKategori = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
                item.AnaKategoriAdi = AnaKategori.Ad;


                Kategoriler = new Kategoriler();
                Kategoriler.Id = (int)item.KategoriId;
                var _Kategori = await BusKategoriler.FirstOrDefaultAsync(Kategoriler).ConfigureAwait(true);
                item.KategoriAdi = _Kategori.Ad;

                AltKategorilerListesi.Add(item);
            }

            var _Kategoriler = await BusKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.Kategoriler = _Kategoriler;

            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;

            AltKategorilerListesi = AltKategorilerListesi.OrderBy(x => x.UstKategoriId).ToList();
            PanelAltKategorilerEntityleri.AltKategoriler = AltKategorilerListesi;

            return View(PanelAltKategorilerEntityleri);
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(AltKategoriler _AltKategoriler)
        {
            List<AltKategoriler> AltKategorilerListesi = new List<AltKategoriler>();
            var AltKategoriler = await BusAltKategoriler.PredicateIncludeAsync(_AltKategoriler).ConfigureAwait(true);
            foreach (var item in AltKategoriler)
            {
                AnaKategoriler = new AnaKategoriler();
                AnaKategoriler.Id = (int)item.UstKategoriId;

                var AnaKategori = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
                item.AnaKategoriAdi = AnaKategori.Ad;


                Kategoriler = new Kategoriler();
                Kategoriler.Id = (int)item.KategoriId;
                var _Kategori = await BusKategoriler.FirstOrDefaultAsync(Kategoriler).ConfigureAwait(true);
                item.KategoriAdi = _Kategori.Ad;

                AltKategorilerListesi.Add(item);
            }

            var _Kategoriler = await BusKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.Kategoriler = _Kategoriler;

            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;

            AltKategorilerListesi = AltKategorilerListesi.OrderBy(x => x.UstKategoriId).ToList();
            PanelAltKategorilerEntityleri.AltKategoriler = AltKategorilerListesi;

            return View(PanelAltKategorilerEntityleri);
        }

        public async Task<IActionResult> AltKategoriSil(int Id)
        {
            AltKategoriler.Id = (int)Id;
            var KullaniciBilgisi = await BusAltKategoriler.FirstOrDefaultAsync(AltKategoriler).ConfigureAwait(true);
            if (KullaniciBilgisi != null)
            {
                var SilmeDurum = await BusAltKategoriler.DeleteAsync(AltKategoriler).ConfigureAwait(true);
                if (SilmeDurum)
                {
                    return RedirectToAction("Index", "AltKategoriler");
                }
                else
                {
                    return Json("AltKategori Silinemedi!! Lütfen geri gidiniz!!!");
                }
            }
            else
            {
                return Json("AltKategori Bulunamadı!! Lütfen geri gidiniz!!!");
            }

        }

        public async Task<IActionResult> AltKategoriDetay(int? Id)
        {
            AltKategoriler.Id = (int)Id;
            var AltKategoriDetay = await BusAltKategoriler.FirstOrDefaultAsync(AltKategoriler).ConfigureAwait(true);
            PanelAltKategorilerEntityleri.AltKategori = AltKategoriDetay;

            var _AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.AnaKategoriler = _AnaKategoriler;
            
            var _Kategoriler = await BusKategoriler.GetAllAsync().ConfigureAwait(true);
            PanelAltKategorilerEntityleri.Kategoriler = _Kategoriler;

            return View(PanelAltKategorilerEntityleri);
        }

        [HttpPost]
        public async Task<IActionResult> AltKategoriDetay(AltKategoriler _AltKategoriler)
        {
            var AnaKategoriDetay = await BusAltKategoriler.FirstOrDefaultAsync(_AltKategoriler).ConfigureAwait(true);

            AnaKategoriDetay.UstKategoriId = _AltKategoriler.UstKategoriId;
            AnaKategoriDetay.Ad = _AltKategoriler.Ad;
            AnaKategoriDetay.Sira = _AltKategoriler.Sira;
            var AnaKategoriDetayKaydet = await BusAltKategoriler.UpdateAsync(AnaKategoriDetay).ConfigureAwait(true);

            AnaKategoriDetay = await BusAltKategoriler.FirstOrDefaultAsync(AnaKategoriDetay).ConfigureAwait(true);
            return RedirectToAction("AltKategoriDetay", "AltKategoriler", new { Id = AnaKategoriDetay.Id });
        }

    }
}
