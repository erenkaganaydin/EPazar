using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    [Authorize]
    public class HesabimController : Controller
    {
        public HesabimEntityleri HesabimEntityleri { get; set; }

        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public Siparis Siparis { get; set; }
        public BusSiparis BusSiparis { get; set; }

        public SiparisDetay SiparisDetay { get; set; }
        public BusSiparisDetay BusSiparisDetay { get; set; }

        public HesabimController()
        {
            HesabimEntityleri = new HesabimEntityleri();

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

            return View(HesabimEntityleri);
        }

        public async Task<IActionResult> SiparisBilgisi()
        {

            return View();
        }
    }
}
