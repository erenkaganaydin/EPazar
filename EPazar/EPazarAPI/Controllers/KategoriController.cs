using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.XMLEntity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EPazarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KategoriController : ControllerBase
    {
        public HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme { get; set; }
        public BusHipatuAnaKategoriEsitleme BusHipatuAnaKategoriEsitleme { get; set; }

      

        public KategoriController()
        {
            HipatuAnaKategoriEsitleme = new HipatuAnaKategoriEsitleme();
            BusHipatuAnaKategoriEsitleme = new BusHipatuAnaKategoriEsitleme();          
        }

        [HttpPost("HipatuAnaKategoriEsitleme/Esitle")]
        public async Task<IActionResult> AnaKategoriEsitle(HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme)
        {
            var VarMi = await BusHipatuAnaKategoriEsitleme.VarMi(HipatuAnaKategoriEsitleme);
            if(VarMi != null)
            {
                var Result = await BusHipatuAnaKategoriEsitleme.UpdateAsync(HipatuAnaKategoriEsitleme);
            }
            else
            {
                var Result = await BusHipatuAnaKategoriEsitleme.InsertAsync(HipatuAnaKategoriEsitleme, false);
            }
            var Eklenen = await BusHipatuAnaKategoriEsitleme.VarMi(HipatuAnaKategoriEsitleme);
            return Ok(Eklenen);

          

        }
    }
}
