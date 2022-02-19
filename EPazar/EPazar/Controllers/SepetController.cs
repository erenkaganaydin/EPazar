using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    public class SepetController : Controller
    {
        public BusUrunResimleri BusUrunResimleri { get; set; }
        public List<ViewSepet> ViewSepetList { get; set; }
        public ViewSepet ViewSepet { get; set; }
        public BusViewSepet BusViewSepet { get; set; }

        public Sepet Sepet { get; set; }
        public BusSepet BusSepet { get; set; }

        public Urunler Urunler { get; set; }
        public BusUrunler BusUrunler { get; set; }

        public ViewUrunOzellikleriAciklamali ViewUrunOzellikleriAciklamali { get; set; }
        public BusViewUrunOzellikleriAciklamali BusViewUrunOzellikleriAciklamali { get; set; }

        public SepetController()
        {
            BusUrunResimleri = new BusUrunResimleri();

            ViewSepetList = new List <ViewSepet>();
            ViewSepet = new ViewSepet();
            BusViewSepet = new BusViewSepet();

            Sepet = new Sepet();
            BusSepet = new BusSepet();

            Urunler = new Urunler();
            BusUrunler = new BusUrunler();

            ViewUrunOzellikleriAciklamali = new ViewUrunOzellikleriAciklamali();
            BusViewUrunOzellikleriAciklamali = new BusViewUrunOzellikleriAciklamali();
        }

        public async Task<IActionResult> Index()
        {
          
            ViewSepet.SepetToken = HttpContext.Request.Cookies["SepetToken"];
            var viewSepets = await BusViewSepet.PredicateAsync(ViewSepet);

            foreach(var item in viewSepets)
            {
                var resim = await BusUrunResimleri.FirstOrDefaultAsync(item.UrunId);
                item.UrunResmi = resim.ResimLink;
                ViewSepetList.Add(item);
            }

            return View(ViewSepetList);
        }

        [Route("/SepeteEkle/{UrunId?}/{UrunAdi?}/{SeciliRenk?}/{SeciliOzellik?}")]
        public async Task<ActionResult> SepeteEkle(long? UrunId, string? UrunAdi, string? SeciliRenk, string? SeciliOzellik)
        {

            Urunler.Id = (long)UrunId;
            var UrunDetay = await BusUrunler.IdToUrun(Urunler);

            Urunler SepeteEklenecekUrun = new Urunler();
            SepeteEklenecekUrun = UrunDetay;

            ViewUrunOzellikleriAciklamali SepeteEklencekUrunOzelligi = new ViewUrunOzellikleriAciklamali();
            ViewUrunOzellikleriAciklamali.UrunId = UrunDetay.Id;
            ViewUrunOzellikleriAciklamali.OzellikAdi = SeciliOzellik;
            ViewUrunOzellikleriAciklamali.RenkAdi = SeciliRenk;
            


            var UrunOzellikDetay = await BusViewUrunOzellikleriAciklamali.FirstOrDefaultSepetEkleAsync(ViewUrunOzellikleriAciklamali);

            var MevcutSepeToken = HttpContext.Request.Cookies["SepetToken"];
            if (MevcutSepeToken != null)
            {
                Sepet.CookieToken = MevcutSepeToken;
            }
            else
            {
                Sepet.CookieToken = Guid.NewGuid().ToString();
            }

            Sepet.OzellikId = UrunOzellikDetay==null ? null : UrunOzellikDetay.Id;

            Sepet.UrunId = SepeteEklenecekUrun.Id;
            Sepet.UyeId = Convert.ToInt64(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)) == 0 ? null : Convert.ToInt64(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

            var Islem = await BusSepet.InsertAsync(Sepet,false);

            if (Islem)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = new DateTimeOffset(DateTime.Now.AddDays(30));

                HttpContext.Response.Cookies.Append("SepetToken", Sepet.CookieToken, cookieOptions);
            }

            return RedirectToAction("Index");
        }

        [Route("/SepettenKaldir/{UrunId?}/{OzellikId?}")]
        public async Task<ActionResult> SepettenKaldir(long? UrunId, long? OzellikId)
        {
            Sepet.CookieToken = HttpContext.Request.Cookies["SepetToken"];
            Sepet.UrunId    = (long)UrunId;
            Sepet.OzellikId = OzellikId;

            var KaldirilacakUrunler = await BusSepet.PredicateUrunOzellikAsync(Sepet); 

            foreach(var item in KaldirilacakUrunler)
            {
                var SepettenKaldir = await BusSepet.DeleteAsync(item);
            }

            return RedirectToAction("Index");
        }

        [Route("/Sepet/AdetArttir/{UrunId?}/{OzellikId?}")]
        public async Task<ActionResult> AdetArttir(long? UrunId, long? OzellikId)
        {
            Sepet.CookieToken = HttpContext.Request.Cookies["SepetToken"];
            Sepet.UrunId = (long)UrunId;
            Sepet.OzellikId = OzellikId;

            var EklenecekUrunler = await BusSepet.PredicateUrunOzellikAsync(Sepet);
            if (EklenecekUrunler.Count >= 10)
            {
                return Redirect("/Sepet?Hata=Adet 10 dan fazla olamaz");
            }

            var EklenecekUrun = EklenecekUrunler.FirstOrDefault();

            EklenecekUrun.Id = 0;
            var Islem = await BusSepet.InsertAsync(EklenecekUrun, false);

            return RedirectToAction("Index");
        }

        [Route("/Sepet/AdetAzalt/{UrunId?}/{OzellikId?}")]
        public async Task<ActionResult> AdetAzalat(long? UrunId, long? OzellikId)
        {
            Sepet.CookieToken = HttpContext.Request.Cookies["SepetToken"];
            Sepet.UrunId = (long)UrunId;
            Sepet.OzellikId = OzellikId;

            var EklenecekUrunler = await BusSepet.PredicateUrunOzellikAsync(Sepet);
            if (EklenecekUrunler.Count <= 1)
            {
                return Redirect("/Sepet?Hata=Adet 1 den az olamaz");
            }
            var EklenecekUrun = EklenecekUrunler.FirstOrDefault();

            EklenecekUrun.Id = 0;
            var Islem = await BusSepet.InsertAsync(EklenecekUrun, false);

            return RedirectToAction("Index");
        }
    }
}
