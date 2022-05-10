using EPazar.Business.Business;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bigtarz.Mobil.Components
{
    public class MobilLeftBarViewComponent : ViewComponent
    {
        #region Prop
        public NavbarEntityleri NavbarEntityleri { get; set; }
        public BusAnaKategoriler BusAnaKategoriler { get; set; }
        public BusKategoriler BusKategoriler { get; set; }
        public BusAltKategoriler BusAltKategoriler { get; set; }

        #endregion

        public MobilLeftBarViewComponent()
        {
            NavbarEntityleri = new NavbarEntityleri();
            BusAnaKategoriler = new BusAnaKategoriler();
            BusKategoriler = new BusKategoriler();
            BusAltKategoriler = new BusAltKategoriler();
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            NavbarEntityleri.AnaKategorilerList = await BusAnaKategoriler.GetAllAsync().ConfigureAwait(true);
            NavbarEntityleri.KategorilerList = await BusKategoriler.GetAllAsync().ConfigureAwait(true);
            NavbarEntityleri.AltKategorilerList = await BusAltKategoriler.GetAllAsync().ConfigureAwait(true);

            return View(NavbarEntityleri);
        }
        #endregion
    }
}
