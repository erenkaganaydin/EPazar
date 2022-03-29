using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EPazar.Components
{
    public class UrunlerKategorilerViewComponent : ViewComponent
    {
        public UrunlerKategorilerEntityleri UrunlerKategorilerEntityleri { get; set; }
        public AnaKategoriler AnaKategoriler { get; set; }
        public Kategoriler Kategoriler { get; set; }
        public AltKategoriler AltKategoriler { get; set; }
        public BusAnaKategoriler BusAnaKategoriler { get; set; }
        public BusKategoriler BusKategoriler { get; set; }
        public BusAltKategoriler BusAltKategoriler { get; set; }

        public UrunlerKategorilerViewComponent()
        {
            UrunlerKategorilerEntityleri = new UrunlerKategorilerEntityleri();
            BusAnaKategoriler = new BusAnaKategoriler();
            BusKategoriler = new BusKategoriler();
            BusAltKategoriler = new BusAltKategoriler();

            AnaKategoriler = new AnaKategoriler();
            Kategoriler = new Kategoriler();
            AltKategoriler = new AltKategoriler();

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var AltKatVarMis = ViewContext.RouteData.Values["AltKategoriId"];
            var OrtaKatVarMis = ViewContext.RouteData.Values["KategoriId"];
            var AnaKatVarMis = ViewContext.RouteData.Values["AnaKategoriId"];
            var KategorilerSon = await BusAnaKategoriler.GetAllAsync();

            if (AltKatVarMis != null)
            {
                AltKategoriler.KategoriId = Convert.ToInt32(OrtaKatVarMis);
                var xKategoriler = await BusAltKategoriler.GetAllOrtaKatIdAsync(AltKategoriler);
                UrunlerKategorilerEntityleri.AltKategoriler = xKategoriler;
                return View(UrunlerKategorilerEntityleri);
            }
            if (OrtaKatVarMis != null)
            {
                AltKategoriler.KategoriId = Convert.ToInt32(OrtaKatVarMis);
                var aKategoriler = await BusAltKategoriler.GetAllOrtaKatIdAsync(AltKategoriler);
                UrunlerKategorilerEntityleri.AltKategoriler = aKategoriler;
                return View(UrunlerKategorilerEntityleri);
            }
            if (AnaKatVarMis != null)
            {
                this.Kategoriler.AnaKategoriId = Convert.ToInt32(AnaKatVarMis);
                var Kategoriler = await BusKategoriler.GetAllUstteAsync(this.Kategoriler);
                UrunlerKategorilerEntityleri.Kategoriler = Kategoriler;
                return View(UrunlerKategorilerEntityleri);
            }

            var Tmu = await BusAnaKategoriler.GetAllAsync();
            UrunlerKategorilerEntityleri.AnaKategoriler = Tmu;

            return View(UrunlerKategorilerEntityleri);
        }
    }
}
