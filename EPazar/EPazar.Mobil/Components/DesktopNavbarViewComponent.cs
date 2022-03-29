using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EPazar.Entity.Entity;
using EPazar.Business.Business;
using System.Threading.Tasks;
using EPazar.Entity.SanalEntity;

namespace EPazar.Mobil.Components
{
    public class DesktopNavbarViewComponent : ViewComponent
    {
        #region Prop
        public NavbarEntityleri NavbarEntityleri { get; set; }
        public BusAnaKategoriler BusAnaKategoriler { get; set; }
        public BusKategoriler BusKategoriler { get; set; }
        public BusAltKategoriler BusAltKategoriler { get; set; }

        #endregion

        #region Const
        public DesktopNavbarViewComponent()
        {
            NavbarEntityleri = new NavbarEntityleri();
            BusAnaKategoriler = new BusAnaKategoriler();
            BusKategoriler = new BusKategoriler();
            BusAltKategoriler = new BusAltKategoriler();
        } 
        #endregion

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
