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
    public class SiparisController : Controller
    {
        public PanelSiparisDetayEntityleri PanelSiparisDetayEntityleri { get; set; }
        public Siparis Siparis { get; set; }
        public BusSiparis BusSiparis { get; set; }
        public SiparisDetay EntSiparisDetay { get; set; }
        public BusSiparisDetay BusSiparisDetay { get; set; }
        public BusSiparisDurum BusSiparisDurum { get; set; }
        public BusOdemeDurum BusOdemeDurum { get; set; }

        public SiparisController()
        {
            PanelSiparisDetayEntityleri = new PanelSiparisDetayEntityleri();

            Siparis = new Siparis();
            BusSiparis = new BusSiparis();
            BusSiparisDurum = new BusSiparisDurum();
            BusOdemeDurum = new BusOdemeDurum();
            EntSiparisDetay = new SiparisDetay();
            BusSiparisDetay = new BusSiparisDetay();

        }

        public async Task<IActionResult> Index()
        {
            var Siparisler = await BusSiparis.GetAllIncludePanelAsync();
            return View(Siparisler);
        }

        public async Task<IActionResult> SiparisDetay(long? Id)
        {
            Siparis.Id= (long)Id;
            var SiparisBilgisi = await BusSiparis.FirstOrDefaultPanelAsync(Siparis);

            var OdemeDurumlari = await BusOdemeDurum.GetAllAsync();
            var SiparisDurumlari = await BusSiparisDurum.GetAllAsync();

            EntSiparisDetay.SiparisId = SiparisBilgisi.Id;
            var SiparisDetayBilgisi = await BusSiparisDetay.PredicatePanelAsync(EntSiparisDetay);

            PanelSiparisDetayEntityleri.Siparis = SiparisBilgisi;
            PanelSiparisDetayEntityleri.OdemeDurumlari = OdemeDurumlari;
            PanelSiparisDetayEntityleri.SiparisDurumlari = SiparisDurumlari;
            PanelSiparisDetayEntityleri.SiparisDetay = SiparisDetayBilgisi;

            return View(PanelSiparisDetayEntityleri);
        }

        [HttpPost]
        public async Task<IActionResult> SiparisDurumGuncelle(Siparis siparis)
        {
            var SiparisBilgisi = await BusSiparis.FirstOrDefaultAsync(siparis);
            SiparisBilgisi.SiparisDurumId = siparis.SiparisDurumId;
            var SiparisGuncelle = await BusSiparis.UpdateAsync(SiparisBilgisi);

            if (SiparisGuncelle)
            {
                return Redirect("/Siparis/SiparisDetay?Id="+ siparis.Id.ToString());
            }
            else
            {
                return Redirect("/Siparis/SiparisDetay?Id=" + siparis.Id.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> OdemeDurumGuncelle(Siparis siparis)
        {
            var SiparisBilgisi = await BusSiparis.FirstOrDefaultAsync(siparis);
            SiparisBilgisi.OdemeDurumId = siparis.OdemeDurumId;
            var SiparisGuncelle = await BusSiparis.UpdateAsync(SiparisBilgisi);

            if (SiparisGuncelle)
            {
                return Redirect("/Siparis/SiparisDetay?Id=" + siparis.Id.ToString());
            }
            else
            {
                return Redirect("/Siparis/SiparisDetay?Id=" + siparis.Id.ToString());
            }
        }
    }
}
