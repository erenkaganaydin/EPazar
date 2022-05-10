using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UrunOzellikleriController : Controller
    {
        public BusOzellikRenkleri BusOzellikRenkleri { get; set; }
        public OzellikRenkleri OzellikRenkleri { get; set; }
        public UrunOzellikleri EntUrunOzellikleri { get; set; }
        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        public UrunOzellikleriController()
        {
            BusOzellikRenkleri = new BusOzellikRenkleri();
            OzellikRenkleri = new OzellikRenkleri();
            EntUrunOzellikleri = new UrunOzellikleri();
            BusUrunOzellikleri = new BusUrunOzellikleri();
        }


        [Route("/UrunOzellikleri/Renkler/{RenkAdi?}")]
        public async Task<IActionResult> UrunRenkleri(string? RenkAdi)
        {
            if (RenkAdi == null)
            {
                var TumRenkler = await BusOzellikRenkleri.GetAllAsync().ConfigureAwait(true);
                TumRenkler.Select(x => x.Ad).ToList();
                return View(TumRenkler);
            }
            OzellikRenkleri.Ad = RenkAdi;
            var RenkAdlari = await BusOzellikRenkleri.OzellikAdlari(OzellikRenkleri).ConfigureAwait(true);
            var RenkAdlariString = RenkAdlari.Select(x => x.Ad).ToList();

            OzellikRenkleri.Ad = RenkAdi.Replace('ı', 'i');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ş', 's');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ü', 'u');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ö', 'o');
            var RenkAdlari2 = await BusOzellikRenkleri.OzellikAdlari(OzellikRenkleri).ConfigureAwait(true);
            var RenkAdlariString2 = RenkAdlari2.Select(x => x.Ad).ToList();
            foreach (var item in RenkAdlariString2)
            {
                if (!RenkAdlariString.Contains(item))
                    RenkAdlariString.Add(item);
            }

            return View(RenkAdlariString);
        }

        [Route("/UrunOzellikleri/UrunBedenleri/{RenkAdi?}")]
        public async Task<IActionResult> UrunBedenleri(string? RenkAdi)
        {
            if (RenkAdi == null)
            {
                var TumRenkler = await BusUrunOzellikleri.GetAllAsync().ConfigureAwait(true);
                TumRenkler.Select(x => x.OzellikAdi).ToList();
                return View(TumRenkler);
            }
            EntUrunOzellikleri.OzellikAdi = RenkAdi;
            var RenkAdlari = await BusUrunOzellikleri.UrunOzellikAdlariFiltrele(EntUrunOzellikleri).ConfigureAwait(true);

            return View(RenkAdlari);
        }

    }
}
