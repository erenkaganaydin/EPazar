using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Components
{
    public class UrunDetayOneriUrunlerViewComponent : ViewComponent
    {
        public Urunler Urunler { get; set; }
        public List<Urunler> UrunlerList { get; set; }
        public BusUrunler BusUrunler { get; set; }
        public UrunKategorileri UrunKategorileri { get; set; }
        public BusUrunKategorileri BusUrunKategorileri { get; set; }

        public UrunDetayOneriUrunlerViewComponent()
        {
            Urunler = new Urunler();
            UrunlerList = new List<Urunler>();
            BusUrunler = new BusUrunler();
            UrunKategorileri = new UrunKategorileri();
            BusUrunKategorileri = new BusUrunKategorileri();
        }

        #region InvokeAsync
        public async Task<IViewComponentResult> InvokeAsync(Urunler Urun)
        {
            UrunKategorileri.UrunId = Urun.Id;
            var UrunKategoriListesi = await BusUrunKategorileri.UrunKategorileriListFirstAsync(UrunKategorileri);

            if (UrunKategoriListesi != null)
            {
                var X = await BusUrunKategorileri.AltKategoriUrunListesi(UrunKategoriListesi);
                UrunlerList = (List<Urunler>)X.Select(x => x.Urunler).ToList();
                UrunlerList = await BusUrunler.IdToUrunlerveResimler(UrunlerList.Select(x=> x.Id));
            }
            else
            {
                var X = await BusUrunKategorileri.AltKategoriUrunListesi(UrunKategoriListesi);
                UrunlerList = (List<Urunler>)X.Select(x => x.Urunler);
            }
            return View(UrunlerList);
        }
        #endregion
    }
}
