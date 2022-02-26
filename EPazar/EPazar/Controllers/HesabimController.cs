using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using EPazar.Entity.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    [Authorize]
    public class HesabimController : Controller
    {
        public HesabimEntityleri HesabimEntityleri { get; set; }
        public SiparisBilgisiEntityleri SiparisBilgisiEntityleri { get; set; }

        public ViewSiparisDetay ViewSiparisDetay { get; set; }
        public BusViewSiparisDetay BusViewSiparisDetay { get; set; }

        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public UrunResimleri UrunResimleri { get; set; }
        public BusUrunResimleri BusUrunResimleri { get; set; }

        public Siparis Siparis { get; set; }
        public BusSiparis BusSiparis { get; set; }

        public SiparisDetay SiparisDetay { get; set; }
        public BusSiparisDetay BusSiparisDetay { get; set; }

        public HesabimController()
        {
            HesabimEntityleri = new HesabimEntityleri();

            SiparisBilgisiEntityleri = new SiparisBilgisiEntityleri();

            UrunResimleri = new UrunResimleri();
            BusUrunResimleri = new BusUrunResimleri();

            ViewSiparisDetay = new ViewSiparisDetay();
            BusViewSiparisDetay = new BusViewSiparisDetay();

            Kullanicilar = new Kullanicilar();
            BusKullanicilar = new BusKullanicilar();

            Siparis = new Siparis();
            BusSiparis = new BusSiparis();

            SiparisDetay = new SiparisDetay();
            BusSiparisDetay = new BusSiparisDetay();
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Siparislerim()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparisleri = await BusSiparis.PredicateIncludeAsync(Siparis);
            if (UyeSiparisleri.Count <= 0 )
                return BadRequest("Siparis Bulunmuyor");

            HesabimEntityleri.Siparisler = UyeSiparisleri;

            ViewSiparisDetay.UyeId =EmailKontrol.Id;
            var UyeSiparisDetay = await BusViewSiparisDetay.PredicateAsync(ViewSiparisDetay);

            List<ViewSiparisDetay> ViewSiparisDetayList = new List<ViewSiparisDetay>();
            foreach (var item in UyeSiparisDetay)
            {
                UrunResimleri.UrunId = item.UrunId;
                var Link = await BusUrunResimleri.FirstOrDefaultAsync(UrunResimleri);
                item.ResimLink = Link.ResimLink;
                ViewSiparisDetayList.Add(item);
            }  

            HesabimEntityleri.ViewSiparisDetay = ViewSiparisDetayList;


            return View(HesabimEntityleri);
        }
        [Route("/SiparisBilgisi/{SiparisId?}")]
        public async Task<IActionResult> SiparisBilgisi(long? SiparisId)
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparisleri = await BusSiparis.FirstOrDefaultUyeIdAsync(Siparis);
            if (UyeSiparisleri == null)
                return BadRequest("Siparis Bulunmuyor");


            SiparisBilgisiEntityleri.Siparis = UyeSiparisleri;

            ViewSiparisDetay.UyeId = EmailKontrol.Id;
            var UyeSiparisDetay = await BusViewSiparisDetay.PredicateAsync(ViewSiparisDetay);

            List<ViewSiparisDetay> ViewSiparisDetayList = new List<ViewSiparisDetay>();
            foreach (var item in UyeSiparisDetay)
            {
                UrunResimleri.UrunId = item.UrunId;
                var Link = await BusUrunResimleri.FirstOrDefaultAsync(UrunResimleri);
                item.ResimLink = Link.ResimLink;
                ViewSiparisDetayList.Add(item);
            }

            SiparisBilgisiEntityleri.ViewSiparisDetay = ViewSiparisDetayList;

            return View(SiparisBilgisiEntityleri);
        }
    }
}
