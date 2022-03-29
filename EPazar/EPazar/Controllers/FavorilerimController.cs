using EPazar.Business.Business;
using EPazar.Entity.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace EPazar.Controllers
{
    public class FavorilerimController : Controller
    {
        public Kullanicilar Kullanicilar { get; set; }
        public BusKullanicilar BusKullanicilar { get; set; }

        public Favoriler Favoriler { get; set; }
        public BusFavoriler BusFavoriler { get; set; }

        public FavorilerimController()
        {
            Kullanicilar = new Kullanicilar();
            BusKullanicilar = new BusKullanicilar();

            Favoriler = new Favoriler();
            BusFavoriler = new BusFavoriler();
        }

        
    }
}
