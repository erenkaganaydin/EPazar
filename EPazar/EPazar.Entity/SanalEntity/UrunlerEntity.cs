using EPazar.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class UrunlerEntity 
    {
        public List<Urunler> UrunListesi { get; set; }
        public List<object> Kategori { get; set; }
    }
}
