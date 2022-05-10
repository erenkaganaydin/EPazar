using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public UrunOzellikleriController()
        {
            BusOzellikRenkleri = new BusOzellikRenkleri();
            OzellikRenkleri = new OzellikRenkleri();
        }

        ~UrunOzellikleriController()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        [Route("/UrunOzellikleri/Renkler/{RenkAdi?}")]
        public async Task<IActionResult> UrunRenkleri(string? RenkAdi)
        {
            OzellikRenkleri.Ad = RenkAdi;
            var RenkAdlari = await BusOzellikRenkleri.OzellikAdlari(OzellikRenkleri).ConfigureAwait(true);
            var RenkAdlariString = RenkAdlari.Select(x => x.Ad).ToList();

            OzellikRenkleri.Ad = RenkAdi.Replace('ı', 'i');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ş', 's');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ü', 'u');
            OzellikRenkleri.Ad = OzellikRenkleri.Ad.Replace('ö', 'o');
            var RenkAdlari2 = await BusOzellikRenkleri.OzellikAdlari(OzellikRenkleri).ConfigureAwait(true);
            var RenkAdlariString2 = RenkAdlari2.Select(x => x.Ad).ToList();
            RenkAdlariString.AddRange(RenkAdlariString2);
            return View(RenkAdlariString);
        }

    }
}
