using EPazar.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class UrunlerKategorilerEntityleri
    {
        public List<AltKategoriler> AltKategoriler { get; set; }
        public List<Kategoriler> Kategoriler { get; set; }
        public List<AnaKategoriler> AnaKategoriler { get; set; }
    }
}
