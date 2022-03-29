using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace EPazar.Components
{
    public class UrunViewComponent : ViewComponent
    {
        public UrunComponent UrunComponent { get; set; }
        public UrunResimleri UrunResimleri { get; set; }
        public BusUrunResimleri BusUrunResimleri { get; set; }

   

        public UrunViewComponent(Urunler Urun)
        {
            UrunComponent = new UrunComponent();
            UrunComponent.Urun = Urun;

            UrunResimleri = new UrunResimleri();
            BusUrunResimleri = new BusUrunResimleri();

        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            UrunResimleri.UrunId = UrunComponent.Urun.Id;
            UrunComponent.UrunResimleri = await BusUrunResimleri.FirstOrDefaultAsync(UrunResimleri);

            return View(UrunComponent);
        }
        #endregion

    }
}
