using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPazar.Components
{
    public class UrunlerRenklerViewComponent : ViewComponent
    {
        public OzellikRenkleri OzellikRenkleri { get; set; }
        public List<OzellikRenkleri> OzellikRenkleriList { get; set; }

        public BusOzellikRenkleri BusOzellikRenkleri { get; set; }


        public UrunOzellikleri UrunOzellikleri { get; set; }
        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        public UrunlerRenklerViewComponent()
        {
            OzellikRenkleri = new OzellikRenkleri();
            OzellikRenkleriList = new List<OzellikRenkleri>();
            BusOzellikRenkleri = new BusOzellikRenkleri();

            UrunOzellikleri = new UrunOzellikleri();
            BusUrunOzellikleri = new BusUrunOzellikleri();
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var UrunOzellikAdlari = await BusOzellikRenkleri.GetAllAdlarAsync();

            return View(UrunOzellikAdlari);
        }
        #endregion


    }
}
