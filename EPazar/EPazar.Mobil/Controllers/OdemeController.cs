using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using EPazar.Entity.View;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Mobil.Controllers
{
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

        public ViewSiparisTedarikciToplam ViewSiparisTedarikciToplam { get; set; }
        public BusViewSiparisTedarikciToplam BusViewSiparisTedarikciToplam { get; set; }

        public SiparisKargoBilgisi SiparisKargoBilgisi { get; set; }
        public BusSiparisKargoBilgisi BusSiparisKargoBilgisi { get; set; }

        public ViewSepetTedarikciToplam ViewSepetTedarikciToplam { get; set; }
        public BusViewSepetTedarikciToplam BusViewSepetTedarikciToplam { get; set; }


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

            ViewSiparisTedarikciToplam = new ViewSiparisTedarikciToplam();
            BusViewSiparisTedarikciToplam = new BusViewSiparisTedarikciToplam();

            BusSiparisKargoBilgisi = new BusSiparisKargoBilgisi();

            ViewSepetTedarikciToplam = new ViewSepetTedarikciToplam();
            BusViewSepetTedarikciToplam = new BusViewSepetTedarikciToplam();
        }
        #endregion

        #region SiparisOlustur
        public async Task<IActionResult> SiparisOlustur()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
                if (Siparis.UyeId == null)
                {
                    return Redirect("/GirisYapKayitOl/OturumAc");
                }
            }
            else
            {
                return Redirect("/GirisYapKayitOl/OturumAc");
            }

            var SiparisIslemSonucu = await SiparisIslemleri().ConfigureAwait(true);
            if (!SiparisIslemSonucu)
                return BadRequest("Siparis İslem Sonucu Olumsuz Döndü");

            var SiparisDetayIslemSonucu = await SiparisDetayIslemleri().ConfigureAwait(true);
            if (!SiparisIslemSonucu)
                return BadRequest("Siparis Detay İslem Sonucu Olumsuz Döndü");

            var UyeSiparis = await BusSiparis.FirstOrDefaultJustUyeIdAsync(Siparis).ConfigureAwait(true);
            if (UyeSiparis == null)
                return Redirect("/Hesabim?ReturnUrl=/Odeme/SiparisOlustur");

            Siparis = UyeSiparis;
            ViewSiparisTedarikciToplam.SiparisId = Siparis.Id;
            var SiparisToplam = await BusViewSiparisTedarikciToplam.PredicateAsync(ViewSiparisTedarikciToplam);

            foreach (var item in SiparisToplam)
            {
                SiparisKargoBilgisi = new SiparisKargoBilgisi();
                SiparisKargoBilgisi.SiparisId = item.SiparisId;
                SiparisKargoBilgisi.KargoFirmaId = 1;
                SiparisKargoBilgisi.KargoTakipKodu = "Oluşturulmamış";
                SiparisKargoBilgisi.KargoTutari = 0;
                if (item.Toplam < 60) //TODO: Kargo Limiti
                {
                    SiparisKargoBilgisi.KargoTutari = 14.99;
                }
                var Ekle = await BusSiparisKargoBilgisi.InsertAsync(SiparisKargoBilgisi, false);
            }

            return RedirectToAction("Index", "Odeme");
        }
        #endregion

        #region Index
        [Authorize]
        public async Task<IActionResult> Index()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            else
            {
                Redirect("/GirisYapKayitOl/OturumAc");
            }
            var UyeSiparis = await BusSiparis.FirstOrDefaultJustUyeIdAsync(Siparis);
            if (UyeSiparis == null)
                return BadRequest("Siparis Bulunmuyor");
            Siparis = UyeSiparis;

            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            OdemeEntityleri.ViewSepet = viewSepets;
            OdemeEntityleri.Siparis = Siparis;

            KullaniciAdresleri.UyeId = (long)Siparis.UyeId;
            OdemeEntityleri.KullaniciAdresleri = await BusKullaniciAdresleri.PredicateAsync(KullaniciAdresleri);

            if (Siparis.AdresId != null)
            {
                KullaniciAdresleri.Id = (long)Siparis.AdresId;
                OdemeEntityleri.SeciliKullaniciAdresi = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);
            }

            return View(OdemeEntityleri);
        }
        #endregion

        #region AdresGuncelle
        [Route("/Odeme/AdresGuncelle/{AdresId?}")]
        [Authorize]
        public async Task<IActionResult> AdresGuncelle(long? AdresId)
        {
            #region  Siparis.UyeId
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparisBilgisi = await BusSiparis.FirstOrDefaultJustUyeIdAsync(Siparis);
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

        public async Task<IActionResult> OdemeBasarili(string? oid)
        {
            Siparis.SiparisNumarasi = oid;
            var SiparisBilgisi = await BusSiparis.FirstOrDefaultSiparisNumarasiAsync(Siparis);

            SiparisBilgisi.OdemeDurumId = 2;

            var OdemeDurumuUpdate = await BusSiparis.UpdateAsync(SiparisBilgisi);
            return View();
        }

        public async Task<IActionResult> OdemeBasarisiz(string? oid)
        {
            Siparis.SiparisNumarasi = oid;

            return View();
        }

        #region OdemeBilgileri
        [Authorize]
        public async Task<IActionResult> OdemeBilgileri()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparis = await BusSiparis.FirstOrDefaultOdenmediUyeIdAsync(Siparis);
            if (UyeSiparis == null)
                return BadRequest("Siparis Bulunmuyor");
            Siparis = UyeSiparis;

            if (Siparis.AdresId == 0)
                return Redirect("/Odeme?Hata=Adres bilgisi seçmelisiniz...");
            else if (Siparis.AdresId == null)
                return Redirect("/Odeme?Hata=Adres bilgisi seçmelisiniz...");

            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            OdemeEntityleri.ViewSepet = viewSepets;
            OdemeEntityleri.Siparis = Siparis;

            KullaniciAdresleri.UyeId = (long)Siparis.UyeId;
            OdemeEntityleri.KullaniciAdresleri = await BusKullaniciAdresleri.PredicateAsync(KullaniciAdresleri);

            KullaniciAdresleri.Id = (long)Siparis.AdresId;
            OdemeEntityleri.SeciliKullaniciAdresi = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);

            return View(OdemeEntityleri);
        }
        #endregion

        #region SiparisDetayIslemleri
        private async Task<bool> SiparisDetayIslemleri()
        {
            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var ViewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            bool HataYok = true;
            foreach (var item in ViewSepets)
            {
                if (item.OzellikId != null)
                {
                    SiparisDetay.OzellikId = (long)item.OzellikId;
                }
                if (item.OzellikAdi != null)
                {
                    SiparisDetay.OzellikAdi = item.OzellikAdi;
                }


                SiparisDetay.SiparisId = Siparis.Id;
                SiparisDetay.Adet = item.Adet;
                SiparisDetay.UrunId = item.UrunId;
                SiparisDetay.UrunTedarikciAdi = item.TedarikciAdi;
                SiparisDetay.UrunAdi = item.UrunAdi;
                SiparisDetay.UrunFiyati = item.Fiyat;
                SiparisDetay.UrunKDV = item.KDV;

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
            Siparis.ToplamTutar = Math.Round(Toplam, 2);

            ViewSepetTedarikciToplam.SepetToken = ViewSepet.SepetToken;
            var SiparisToplam = await BusViewSepetTedarikciToplam.PredicateAsync(ViewSepetTedarikciToplam);

            foreach (var item in SiparisToplam)
            {
                if (item.Toplam < 60) //TODO: Kargo Limiti
                {
                    Siparis.ToplamTutar += 14.99;
                }
            }


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

        public async Task<IActionResult> MesafeliSatisSozlesmesi()
        {
            Kullanicilar.EMail = HttpContext.User.FindFirstValue(ClaimTypes.Email) != null ? HttpContext.User.FindFirstValue(ClaimTypes.Email) : null;
            var EmailKontrol = await BusKullanicilar.FirstOrDefaultEmailAsync(Kullanicilar);
            if (EmailKontrol != null)
            {
                Siparis.UyeId = EmailKontrol.Id;
            }
            var UyeSiparis = await BusSiparis.FirstOrDefaultOdenmediUyeIdAsync(Siparis);
            if (UyeSiparis == null)
                return BadRequest("Siparis Bulunmuyor");
            Siparis = UyeSiparis;

            if (Siparis.AdresId == 0)
                return Redirect("/Odeme?Hata=Adres bilgisi seçmelisiniz...");

            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateIncludeAsync(ViewSepet);

            OdemeEntityleri.ViewSepet = viewSepets;
            OdemeEntityleri.Siparis = Siparis;

            KullaniciAdresleri.UyeId = (long)Siparis.UyeId;
            OdemeEntityleri.KullaniciAdresleri = await BusKullaniciAdresleri.PredicateAsync(KullaniciAdresleri);

            KullaniciAdresleri.Id = (long)Siparis.AdresId;
            OdemeEntityleri.SeciliKullaniciAdresi = await BusKullaniciAdresleri.FirstOrDefaultAsync(KullaniciAdresleri);

            return View(OdemeEntityleri);
        }

        public IActionResult GizlilikSozlesmesi()
        {
            return View();
        }
    }
}
