using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPazarAPI.Controllers
{
    public class ResimController : ControllerBase
    {
        public UrunResimleri UrunResimleri { get; set; }
        public List<UrunResimleri> UrunResimleriList { get; set; }
        public BusUrunResimleri BusUrunResimleri { get; set; }

        public ResimController()
        {
            UrunResimleri = new UrunResimleri();
            UrunResimleriList = new List<UrunResimleri>();
            BusUrunResimleri = new BusUrunResimleri();
        }

        [HttpGet("Resimler/HttpToHttps")]
        public async Task<ActionResult> HttpToHttps()
        {
            var HttpImageList = await BusUrunResimleri.PredicateHttpAsync().ConfigureAwait(true);

            foreach (var item in HttpImageList)
            {
                item.ResimLink = item.ResimLink.Replace("http", "https");
                var Update = await BusUrunResimleri.UpdateAsync(item).ConfigureAwait(true);
            }

            return Ok(HttpImageList);
        }
    }
}
