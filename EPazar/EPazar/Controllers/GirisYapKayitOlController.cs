using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    public class GirisYapKayitOlController : Controller
    {
        private readonly ILogger<GirisYapKayitOlController> _logger;
        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public GirisYapKayitOlController(ILogger<GirisYapKayitOlController> logger)
        {
            _logger = logger;

            Kullanicilar = new Kullanicilar();
            BusKullanicilar = new BusKullanicilar();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult OturumAc()
        {
            return View();
        }
       
        public async Task<IActionResult> OturumAc(Kullanicilar entity)
        {
            var KullaniciBilgileri = await BusKullanicilar.FirstOrDefaultAsync(entity);

            if (KullaniciBilgileri != null)
            {
                var Claims = new List<Claim> { new Claim(ClaimTypes.Email, KullaniciBilgileri.EMail), new Claim(ClaimTypes.Name, KullaniciBilgileri.Ad), new Claim(ClaimTypes.Surname, KullaniciBilgileri.Soyad) };
                var UserIdentity = new ClaimsIdentity(Claims, "Login");
                ClaimsPrincipal Principal = new ClaimsPrincipal(UserIdentity);
                await HttpContext.SignInAsync(Principal);
                return RedirectToAction("Index","Home");
            }

            return View();
        }

    }
}
