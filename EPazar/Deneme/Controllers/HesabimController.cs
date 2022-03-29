using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using EPazar.Entity.View;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public SiparisKargoBilgisi SiparisKargoBilgisi { get; set; }
        public BusSiparisKargoBilgisi BusSiparisKargoBilgisi { get; set; }

        public Favoriler Favoriler { get; set; }
        public BusFavoriler BusFavoriler { get; set; }

        public KullaniciAdresleri KullaniciAdresleri { get; set; }
        public BusKullaniciAdresleri BusKullaniciAdresleri { get; set; }

        ~HesabimController()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        public HesabimController()
        {
            HesabimEntityleri = new HesabimEntityleri();

            SiparisBilgisiEntityleri = new SiparisBilgisiEntityleri();

            KullaniciAdresleri = new KullaniciAdresleri();
            BusKullaniciAdresleri = new BusKullaniciAdresleri();

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

            SiparisKargoBilgisi = new SiparisKargoBilgisi();
            BusSiparisKargoBilgisi = new BusSiparisKargoBilgisi();

            Favoriler = new Favoriler();
            BusFavoriler = new BusFavoriler();
        }

        public IActionResult Index()
        {
            var ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("Siparislerim", "Hesabim");
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
           

            HesabimEntityleri.Siparisler = UyeSiparisleri;

            ViewSiparisDetay.UyeId = Siparis.UyeId;
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

            var ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }

            return View(HesabimEntityleri);
        }
        [Route("/Hesabim/SiparisBilgisi/{SiparisId?}")]

        public async Task<IActionResult> SiparisBilgisi(long? SiparisId)
        { 
            if (SiparisId == null)
	        {
                return RedirectToAction("Siparislerim", "Hesabim");
            }
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            Siparis.Id = (long)SiparisId;
            var UyeSiparisleri = await BusSiparis.FirstOrDefaultUyeIdSiparisIdAsync(Siparis);
            if (UyeSiparisleri == null)
                return BadRequest("Siparis Bulunmuyor");


            SiparisBilgisiEntityleri.Siparis = UyeSiparisleri;

            ViewSiparisDetay.UyeId = EmailKontrol.Id;
            ViewSiparisDetay.SiparisId = SiparisBilgisiEntityleri.Siparis.Id;
            var UyeSiparisDetay = await BusViewSiparisDetay.PredicateUyeSiparisAsync(ViewSiparisDetay);

            List<ViewSiparisDetay> ViewSiparisDetayList = new List<ViewSiparisDetay>();
            foreach (var item in UyeSiparisDetay)
            {
                UrunResimleri.UrunId = item.UrunId;
                var Link = await BusUrunResimleri.FirstOrDefaultAsync(UrunResimleri);
                item.ResimLink = Link.ResimLink;
                ViewSiparisDetayList.Add(item);
            }

            SiparisBilgisiEntityleri.ViewSiparisDetay = ViewSiparisDetayList;

            SiparisKargoBilgisi.SiparisId = SiparisBilgisiEntityleri.Siparis.Id;
            var SiparisKargoBilgisiSorgu = await BusSiparisKargoBilgisi.PredicateAsync(SiparisKargoBilgisi);

            SiparisBilgisiEntityleri.SiparisKargoBilgisi = SiparisKargoBilgisiSorgu;

            return View(SiparisBilgisiEntityleri);
        }

        public async Task<IActionResult> HesapBilgileri()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol == null)
            {
                return RedirectToAction("Siparislerim", "Hesabim");
            }
            return View(EmailKontrol);
        }

        [HttpPost]
        public async Task<IActionResult> HesapBilgileri(Kullanicilar kullanicilar)
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol == null)
            {
                return RedirectToAction("Siparislerim", "Hesabim");
            }
            kullanicilar.Id = EmailKontrol.Id;
            kullanicilar.Sifre = EmailKontrol.Sifre;
            var KullaniciGunceleme = await BusKullanicilar.UpdateAsync(kullanicilar);

            return View(kullanicilar);
        }

        public async Task<IActionResult> Favorilerim()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;

            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);

            if (EmailKontrol == null)
            {
                return RedirectToAction("Index", "Hesabim");
            }

            Favoriler.KullaniciId = EmailKontrol.Id;
            var MusteriFavorileri = await BusFavoriler.PredicateAsync(Favoriler);

            List<Favoriler> FavorilerListesi = new List<Favoriler>();
            foreach (var item in MusteriFavorileri)
            {
                UrunResimleri.UrunId = item.UrunId;
                var Link = await BusUrunResimleri.FirstOrDefaultAsync(UrunResimleri);
                if (Link != null)
                {
                    item.ResimLink = Link.ResimLink;
                }
                FavorilerListesi.Add(item);
            }

            var ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }

            return View(FavorilerListesi);
        }


        [Route("/Hesabim/Favorilerim/FavoriEkle/{UrunId?}")]
        public async Task<IActionResult> FavoriEkle(long? UrunId)
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;

            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);

            if (EmailKontrol == null)
            {
                return RedirectToAction("Index", "Hesabim");
            }
            Favoriler.UrunId = (long)UrunId;
            Favoriler.KullaniciId = EmailKontrol.Id;

            var UrunVarMi = await BusFavoriler.FirstOrDefaultAsync(Favoriler);
            if (UrunVarMi != null)
            {
                return RedirectToAction("Favorilerim", "Hesabim");
            }

            var Ekle = await BusFavoriler.InsertAsync(Favoriler, false);

            return RedirectToAction("Favorilerim", "Hesabim");
        }

        [Route("/Hesabim/Favorilerim/FavoriKaldir/{UrunId?}")]
        public async Task<IActionResult> FavoriKaldir(long? UrunId)
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;

            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);

            if (EmailKontrol == null)
            {
                return RedirectToAction("Index", "Hesabim");
            }
            Favoriler.UrunId = (long)UrunId;
            Favoriler.KullaniciId = EmailKontrol.Id;

            var FavoriVarMi = await BusFavoriler.FirstOrDefaultAsync(Favoriler);
            if (FavoriVarMi != null)
            {
                Favoriler.Id = FavoriVarMi.Id;
                var Sil = await BusFavoriler.DeleteAsync(Favoriler);
            }


            return RedirectToAction("Favorilerim", "Hesabim");
        }


        public async Task<IActionResult> AdresEkle()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol == null)
            {
                return RedirectToAction("Siparislerim", "Hesabim");
            }
            return View(EmailKontrol);
        }

        [HttpPost]
        public async Task<IActionResult> AdresEkle(KullaniciAdresleri Gelen)
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol == null)
            {
                return RedirectToAction("Siparislerim", "Hesabim");
            }
            Gelen.UyeId = EmailKontrol.Id;
            var AdresEkle = await BusKullaniciAdresleri.InsertAsync(Gelen,false);

            var ReturnUrl = HttpContext.Request.Query["ReturnUrl"];
            if (!string.IsNullOrEmpty(ReturnUrl))
            {
                return Redirect(ReturnUrl);
            }

            return RedirectToAction("Index", "Hesabim");
        } 
        
        public async Task<IActionResult> CikisYap()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }
    }
}
