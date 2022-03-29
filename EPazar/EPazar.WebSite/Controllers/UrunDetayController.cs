using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    public class UrunDetayController : Controller
    {
        public Urunler Urunler { get; set; }
        public BusUrunler BusUrunler { get; set; }

        ~UrunDetayController()
        {
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }
        public UrunDetayController()
        {
            Urunler = new Urunler();
            BusUrunler = new BusUrunler();
        }

        [Route("/UrunDetay/{UrunId?}/{UrunAdi?}/{SeciliRenk?}/{SeciliOzellik?}")]
        public async Task<IActionResult> Index(long? UrunId, string? UrunAdi, string? SeciliRenk, string? SeciliOzellik)
        {
            string SecilenRenk = null;
            if (UrunId == null)
            {
                UrunId = (long?)HttpContext.Request.RouteValues.FirstOrDefault(x => x.Key == "UrunId").Value;
            }

            Urunler.Id = (long)UrunId;
            var UrunDetay = await BusUrunler.IdToUrun(Urunler);
            ViewData["Title"] = "Bigtarz'da | " + UrunDetay.Adi;

            var UrunOzellikleri = UrunDetay.ViewUrunOzellikleriAciklamali.FirstOrDefault();
            if (UrunOzellikleri != null)
            {
                if (UrunOzellikleri.OzellikStok > 0)
                {
                    if (SeciliRenk == null)
                    {
                        SecilenRenk = UrunOzellikleri.RenkAdi;
                        if (SecilenRenk != null)
                        {
                            return Redirect("/UrunDetay/" + UrunId + "/" + UrunDetay.Adi + "/" + SecilenRenk);
                        }
                    }
                    else
                    {
                        SecilenRenk = SeciliRenk;
                        if (SeciliOzellik == null)
                        {
                            var UrunOzellikAdi = UrunOzellikleri.OzellikAdi;
                            if (UrunOzellikAdi != null)
                            {
                                return Redirect("/UrunDetay/" + UrunId + "/" + UrunDetay.Adi + "/" + SecilenRenk + "/" + UrunOzellikAdi);
                            }
                        }
                    }
                }
            }
            else
            {
                if (UrunAdi == null)
                {
                    return Redirect("/UrunDetay/" + UrunId + "/" + UrunDetay.Adi);
                }
            }

            return View(UrunDetay);
        }
    }
}
