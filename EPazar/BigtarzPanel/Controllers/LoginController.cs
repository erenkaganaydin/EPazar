using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;

        public Admin Admin { get; set; }
        public BusAdmin BusAdmin { get; set; }

        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;

            Admin = new Admin();
            BusAdmin = new BusAdmin();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GirisYap(Admin entity)
        {
            var KullaniciBilgileri = await BusAdmin.FirstOrDefaultAsync(entity);

            if (KullaniciBilgileri != null)
            {
                var Claims = new List<Claim> { new Claim(ClaimTypes.Email, KullaniciBilgileri.EMail), new Claim(ClaimTypes.Name, KullaniciBilgileri.Ad), new Claim(ClaimTypes.Surname, KullaniciBilgileri.Soyad) };

                var UserIdentity = new ClaimsIdentity(Claims, "Login");

                ClaimsPrincipal Principal = new ClaimsPrincipal(UserIdentity);

                await HttpContext.SignInAsync(Principal);

                var ReturnUrl = HttpContext.Request.Query["ReturnUrl"];

                if (!string.IsNullOrEmpty(ReturnUrl))
                    return Redirect(ReturnUrl);

                return RedirectToAction("Index", "Home");
            }

            return Redirect("/Login/GirisYap?Hata=Bilgilerinizi Kontrol Edin!.");
        }
    }
}
