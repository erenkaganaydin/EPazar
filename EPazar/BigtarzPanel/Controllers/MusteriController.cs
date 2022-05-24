using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    [Authorize]
    public class MusteriController : Controller
    {
        public PanelMusteriDetayEntityleri PanelMusteriDetayEntityleri { get; set; }

        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public KullaniciAdresleri KullaniciAdresleri { get; set; }
        public BusKullaniciAdresleri BusKullaniciAdresleri { get; set; }

        public MusteriController()
        {
            PanelMusteriDetayEntityleri = new PanelMusteriDetayEntityleri();

            Kullanicilar = new Kullanicilar();
            BusKullanicilar = new BusKullanicilar();

            KullaniciAdresleri = new KullaniciAdresleri();
            BusKullaniciAdresleri = new BusKullaniciAdresleri();
        }


        public async Task<IActionResult> IndexAsync()
        {
            var KullaniciListesi = await BusKullanicilar.GetAllPanelAsync().ConfigureAwait(true);
            return View(KullaniciListesi);
        }

        [HttpPost]
        public async Task<IActionResult> Index(Kullanicilar Kullanicilar)
        {
            var Siparisler = await BusKullanicilar.PredicateIncludePanelAsync(Kullanicilar);
            return View(Siparisler);
        }

        public async Task<IActionResult> KullaniciSil(int Id)
        {
            Kullanicilar.Id = (int)Id;
            var KullaniciBilgisi = await BusKullanicilar.FirstOrDefaultPanelAsync(Kullanicilar).ConfigureAwait(true);
            if (KullaniciBilgisi != null)
            {
                var SilmeDurum = await BusKullanicilar.DeleteAsync(KullaniciBilgisi).ConfigureAwait(true);
                if (SilmeDurum)
                {
                    return RedirectToAction("Index", "Musteri");
                }
                else
                {
                    return Json("Kullanici Silinemedi!! Lütfen geri gidiniz!!!");
                }
            }
            else
            {
                return Json("Kullanici Bulunamadı!! Lütfen geri gidiniz!!!");

            }

        }

        public async Task<IActionResult> MusteriDetay(int? Id)
        {
            Kullanicilar.Id = (int)Id;
            var KullaniciBilgisi = await BusKullanicilar.FirstOrDefaultPanelAsync(Kullanicilar).ConfigureAwait(true);

            KullaniciAdresleri.UyeId = KullaniciBilgisi.Id;
            var KullaniciAdersBilgisi = await BusKullaniciAdresleri.PredicatePanelAsync(KullaniciAdresleri).ConfigureAwait(true);

            PanelMusteriDetayEntityleri.Kullanicilar = KullaniciBilgisi;
            PanelMusteriDetayEntityleri.KullaniciAdresleri = KullaniciAdersBilgisi;

            return View(PanelMusteriDetayEntityleri);
        }

        public async Task<IActionResult> KullaniciAdresiSil(int Id)
        {
            KullaniciAdresleri.Id = (int)Id;
            var KullaniciAdresBilgisi = await BusKullaniciAdresleri.FirstOrDefaultPanelAsync(KullaniciAdresleri).ConfigureAwait(true);
            if (KullaniciAdresBilgisi != null)
            {
                var SilmeDurum = await BusKullaniciAdresleri.DeleteAsync(KullaniciAdresBilgisi).ConfigureAwait(true);
                if (SilmeDurum)
                {
                    return Redirect("/Musteri/MusteriDetay?Id=" + KullaniciAdresBilgisi.UyeId.ToString());
                }
                else
                {
                    return Json("Kullanici Silinemedi!! Lütfen geri gidiniz!!!");
                }
            }
            else
            {
                return Json("Kullanici Bulunamadı!! Lütfen geri gidiniz!!!");

            }

        }
    }
}
