using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using EPazar.Entity.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    [Authorize]
    public class OdemeController : Controller
    {
        #region Prop
        public OdemeEntityleri OdemeEntityleri { get; set; }

        public ViewSepet ViewSepet { get; set; }
        public BusViewSepet BusViewSepet { get; set; }

        public Siparis Siparis { get; set; }
        public BusSiparis BusSiparis { get; set; }

        public SiparisDetay SiparisDetay { get; set; }
        public BusSiparisDetay BusSiparisDetay { get; set; }

        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public List<ViewSepet> ViewSepetList { get; set; }

        public Sepet Sepet { get; set; }
        public BusSepet BusSepet { get; set; }

        public KullaniciAdresleri KullaniciAdresleri { get; set; }
        public BusKullaniciAdresleri BusKullaniciAdresleri { get; set; }


        private static Random random = new Random();
        #endregion

        #region Const
        public OdemeController()
        {
            OdemeEntityleri = new OdemeEntityleri();

            ViewSepetList = new List<ViewSepet>();
            ViewSepet = new ViewSepet();
            BusViewSepet = new BusViewSepet();

            Siparis = new Siparis();
            BusSiparis = new BusSiparis();

            SiparisDetay = new SiparisDetay();
            BusSiparisDetay = new BusSiparisDetay();

            Kullanicilar = new Kullanicilar();
            BusKullanicilar = new BusKullanicilar();

            Sepet = new Sepet();
            BusSepet = new BusSepet();

            KullaniciAdresleri = new KullaniciAdresleri();
            BusKullaniciAdresleri = new BusKullaniciAdresleri();
        }
        #endregion

        #region SiparisOlustur
        public async Task<IActionResult> SiparisOlustur()
        {
            var SiparisIslemSonucu = await SiparisIslemleri();
            if (!SiparisIslemSonucu)
                return BadRequest("Siparis İslem Sonucu Olumsuz Döndü");

            var SiparisDetayIslemSonucu = await SiparisDetayIslemleri();
            if (!SiparisIslemSonucu)
                return BadRequest("Siparis Detay İslem Sonucu Olumsuz Döndü");

            return RedirectToAction("Index", "Odeme");
        } 
        #endregion

        #region Index
        public async Task<IActionResult> Index()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparis = await BusSiparis.FirstOrDefaultUyeIdAsync(Siparis);
            if (UyeSiparis == null)
                return BadRequest("Siparis Bulunmuyor");
            Siparis = UyeSiparis;

            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            OdemeEntityleri.ViewSepet = viewSepets;
            OdemeEntityleri.Siparis = Siparis;

            KullaniciAdresleri.UyeId = Siparis.UyeId;
            OdemeEntityleri.KullaniciAdresleri = await BusKullaniciAdresleri.PredicateAsync(KullaniciAdresleri);

            KullaniciAdresleri.Id = Siparis.AdresId;
            OdemeEntityleri.SeciliKullaniciAdresi = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);

            return View(OdemeEntityleri);
        }
        #endregion

        #region AdresGuncelle
        [Route("/Odeme/AdresGuncelle/{AdresId?}")]
        public async Task<IActionResult> AdresGuncelle(long? AdresId)
        {
            #region  Siparis.UyeId
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparisBilgisi = await BusSiparis.FirstOrDefaultUyeIdAsync(Siparis);
            if (UyeSiparisBilgisi == null)
            {
                return BadRequest("Üyeye ait sipariş bulunamadı.");
            } 
            #endregion

            Siparis.Id = (long)UyeSiparisBilgisi.Id;
            var SiparisBilgileri = await BusSiparis.FirstOrDefaultAsync(Siparis);
            if (SiparisBilgileri == null)
                return BadRequest("Siapriş Bilgisi Bulunamadı");

            Siparis = SiparisBilgileri;

            KullaniciAdresleri.Id = (long)AdresId;
            KullaniciAdresleri.UyeId = EmailKontrol.Id;
            var AdresKontrol = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);
            if (AdresKontrol == null)
                return BadRequest("Kullanıcının Böyle bir adresi yok");

            Siparis.AdresId = (long)AdresId;
            var SiparisAdresiGuncelle = await BusSiparis.UpdateAsync(Siparis);
            if (!SiparisAdresiGuncelle)
                return BadRequest("Siapriş Adresi Güncellenemedi");


            return RedirectToAction("Index", "Odeme");
        }
        #endregion

        public async Task<IActionResult> OdemeBilgileri()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparis = await BusSiparis.FirstOrDefaultUyeIdAsync(Siparis);
            if (UyeSiparis == null)
                return BadRequest("Siparis Bulunmuyor");
            Siparis = UyeSiparis;

            if (Siparis.AdresId == 0)
                return Redirect("/Odeme?Hata=Adres bilgisi seçmelisiniz...");

            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            OdemeEntityleri.ViewSepet = viewSepets;
            OdemeEntityleri.Siparis = Siparis;

            KullaniciAdresleri.UyeId = Siparis.UyeId;
            OdemeEntityleri.KullaniciAdresleri = await BusKullaniciAdresleri.PredicateAsync(KullaniciAdresleri);

            KullaniciAdresleri.Id = Siparis.AdresId;
            OdemeEntityleri.SeciliKullaniciAdresi = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);

            return View(OdemeEntityleri);
        }

        #region SiparisDetayIslemleri
            private async Task<bool> SiparisDetayIslemleri()
        {
            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var ViewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            bool HataYok = true;
            foreach (var item in ViewSepets)
            {
                SiparisDetay.SiparisId = Siparis.Id;
                SiparisDetay.Adet = item.Adet;
                SiparisDetay.UrunId = item.UrunId;
                SiparisDetay.UrunTedarikciAdi = item.TedarikciAdi;
                SiparisDetay.UrunAdi = item.UrunAdi;
                SiparisDetay.UrunFiyati = item.Fiyat;
                SiparisDetay.UrunKDV = item.KDV;
                SiparisDetay.OzellikId = (long)item.OzellikId;
                SiparisDetay.OzellikAdi = item.OzellikAdi;

                var SiparisDetayEkle = await BusSiparisDetay.InsertAsync(SiparisDetay, false);
                if (!SiparisDetayEkle)
                {
                    HataYok = false;
                }
            }
            return HataYok;
        } 
        #endregion

        #region SiparisIslemleri
        private async Task<bool> SiparisIslemleri()
        {
            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var ViewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            double Toplam = 0;
            foreach (var item in ViewSepets)
            {
                Toplam += item.Fiyat;
            }
            Siparis.ToplamTutar = Toplam;

            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }

            Siparis.SiparisNumarasi = $"{RandomString(4) + "-" + RandomString(4)}";

            var SiparisEkle = await BusSiparis.InsertAsync(Siparis, false);
            return SiparisEkle;
        } 
        #endregion

        #region RandomString
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        } 
        #endregion
    }
}
