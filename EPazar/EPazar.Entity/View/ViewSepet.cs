using EPazar.Entity.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.View
{
    public class ViewSepet
    {
        public string SepetToken { get; set; }
        public string TedarikciAdi { get; set; }
        public long UrunId { get; set; }
        public string UrunAdi { get; set; }
        public double? EskiFiyat { get; set; }
        public double Fiyat { get; set; }
        public double KDV { get; set; }
        public long? OzellikId { get; set; }
        public string? OzellikTuru { get; set; }
        public string? OzellikAdi { get; set; }
        public int Adet { get; set; }

        [NotMapped]
        public string UrunResmi { get; set; }
    }
}
