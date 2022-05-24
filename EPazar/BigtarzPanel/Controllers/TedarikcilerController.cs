using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BigtarzPanel.Controllers
{
    public class TedarikcilerController : Controller
    {

        public Tedarikciler Tedarikciler { get; set; }
        public BusTedarikciler BusTedarikciler { get; set; }


        public TedarikcilerController()
        {

            Tedarikciler = new Tedarikciler();
            BusTedarikciler = new BusTedarikciler();
        }

        public async Task<IActionResult> IndexAsync()
        {
            var KullaniciListesi = await BusTedarikciler.GetAllPanelAsync().ConfigureAwait(true);
            return View(KullaniciListesi);
        }

        public async Task<IActionResult> TedarikciSil(int Id)
        {
            Tedarikciler.Id = (int)Id;
            var KullaniciBilgisi = await BusTedarikciler.FirstOrDefaultPanelAsync(Tedarikciler).ConfigureAwait(true);
            if (KullaniciBilgisi != null)
            {
                var SilmeDurum = await BusTedarikciler.DeleteAsync(KullaniciBilgisi).ConfigureAwait(true);
                if (SilmeDurum)
                {
                    return RedirectToAction("Index", "Tedarikciler");
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
