using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EPazar.Components
{
    public class UrunlerFilterViewComponent : ViewComponent
    {
        public OzellikRenkleri OzellikRenkleri { get; set; }
        public OzellikRenkleri OzellikRenkleriList { get; set; }
        public OzellikTur OzellikTur { get; set; }

        public UrunOzellikleri UrunOzellikleri { get; set; }
        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        public UrunlerFilterViewComponent()
        {
            UrunOzellikleri = new UrunOzellikleri();
            BusUrunOzellikleri = new BusUrunOzellikleri();
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var UrunOzellikAdlari = await BusUrunOzellikleri.UrunOzellikAdlari();

            return View(UrunOzellikAdlari);
        }
        #endregion
    }
}
