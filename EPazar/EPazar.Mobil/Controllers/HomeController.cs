using EPazar.Business.Business;
using EPazar.Entity.SanalEntity;
using EPazar.Mobil.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EPazar.Mobil.Controllers
{
    public class HomeController : Controller
    {
        public IndexEntityleri IndexEntityleri { get; set; }
        public BusAnasayfaBanner BusAnasayfaBanner { get; set; }
        public BusAnasayfaTopBanner BusAnasayfaTopBanner { get; set; }
        public BusAnasayfaSagBanner BusAnasayfaSagBanner { get; set; }
        public BusAnasayfaMiniBanner BusAnasayfaMiniBanner { get; set; }

        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            IndexEntityleri = new IndexEntityleri();
            BusAnasayfaBanner = new BusAnasayfaBanner();
            BusAnasayfaTopBanner = new BusAnasayfaTopBanner();
            BusAnasayfaSagBanner = new BusAnasayfaSagBanner();
            BusAnasayfaMiniBanner = new BusAnasayfaMiniBanner();
        }

        public async Task<IActionResult> IndexAsync()
        {
            IndexEntityleri.AnasayfaBannerList = await BusAnasayfaBanner.GetAllAsync().ConfigureAwait(true);
            IndexEntityleri.AnasayfaTopBannerList = await BusAnasayfaTopBanner.GetAllAsync().ConfigureAwait(true);
            IndexEntityleri.AnasayfaSagBannerList = await BusAnasayfaSagBanner.GetAllAsync().ConfigureAwait(true);
            IndexEntityleri.AnasayfaMiniBannerList = await BusAnasayfaMiniBanner.GetAllAsync().ConfigureAwait(true);

            return View(IndexEntityleri);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
