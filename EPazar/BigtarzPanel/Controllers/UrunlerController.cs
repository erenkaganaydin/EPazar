using EPazar.Entity.SanalEntity;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPazar.Business.Business;

namespace BigtarzPanel.Controllers
{
    public class UrunlerController : Controller
    {
        public PanelUrunlerEntityleri PanelUrunlerEntityleri { get; set; }
        
        public BusUrunler BusUrunler{ get; set; }


        public UrunlerController()
        {
            BusUrunler = new BusUrunler();
            PanelUrunlerEntityleri = new PanelUrunlerEntityleri();
        }

        public async Task<IActionResult> Index()
        {
            Urunler Urunler = new Urunler();
            var AnasayfaUrunleri = await BusUrunler.PanelGetAll(0).ConfigureAwait(true);
            return View(AnasayfaUrunleri);
        }

        [HttpGet]
        public async Task<IActionResult> UrunYukle(int SayfaSayisi)
        {
            Urunler Urunler = new Urunler();
            var AnasayfaUrunleri = await BusUrunler.PanelGetAll(SayfaSayisi).ConfigureAwait(true);
            return PartialView("_UrunlerPartial", AnasayfaUrunleri);
        }
    }
}
