using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    public class AnaKategorilerController : Controller
    {
        public AnaKategoriler AnaKategoriler { get; set; }
        public BusAnaKategoriler BusAnaKategoriler { get; set; }

        public AnaKategorilerController()
        {
            AnaKategoriler = new AnaKategoriler();
            BusAnaKategoriler = new BusAnaKategoriler();
        }

        public async Task<IActionResult> IndexAsync()
        {
            var AnaKategoriler = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            return View(AnaKategoriler);
        }

        [HttpPost]
        public async Task<IActionResult> Index(AnaKategoriler _AnaKategoriler)
        {
            var AnaKategoriler = await BusAnaKategoriler.PredicateIncludePanelAsync(_AnaKategoriler).ConfigureAwait(true);
            return View(AnaKategoriler);
        }

        public async Task<IActionResult> AnaKategoriSil(int Id)
        {
            AnaKategoriler.Id = (int)Id;
            var KullaniciBilgisi = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
            if (KullaniciBilgisi != null)
            {
                var SilmeDurum = await BusAnaKategoriler.DeleteAsync(AnaKategoriler).ConfigureAwait(true);
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

        public async Task<IActionResult> AnaKategoriDetay(int? Id)
        {
            AnaKategoriler.Id = (int)Id;
            var AnaKategoriDetay = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriler).ConfigureAwait(true);
            return View(AnaKategoriDetay);
        }

        [HttpPost]
        public async Task<IActionResult> AnaKategoriDetay(AnaKategoriler _AnaKategoriler)
        {
            var AnaKategoriDetay = await BusAnaKategoriler.FirstOrDefaultAsync(_AnaKategoriler).ConfigureAwait(true);

            AnaKategoriDetay.Ad = _AnaKategoriler.Ad;
            AnaKategoriDetay.Sira = _AnaKategoriler.Sira;
            var AnaKategoriDetayKaydet = await BusAnaKategoriler.UpdateAsync(AnaKategoriDetay).ConfigureAwait(true);

            AnaKategoriDetay = await BusAnaKategoriler.FirstOrDefaultAsync(AnaKategoriDetay).ConfigureAwait(true);
            return RedirectToAction("AnaKategoriDetay", "AnaKategoriler", new { Id = AnaKategoriDetay.Id });
        }

    }
}
