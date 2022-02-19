using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.XMLEntity
{
    public class Ozellik : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string TedarikciOzellikRengi { get; set; }
        public string TedarikciOzellikTuru { get; set; }
        public string TedarikciOzellikAdi { get; set; }
        public string OzellikUrunKodu { get; set; } //Urunden bağımsız bir barkoddur
        public string TedarikciBarkod { get; set; } //Urunden bağımsız bir barkoddur
        public string GTIN { get; set; } // Global Trade Item Number-Küresel Ticaret Ürün Numarası
        public int OzelikStok { get; set; }
        public double OzellikFiyati { get; set; }
        public string hbSaticiStokKodu { get; set; } //hepsi buradaStok kodu galiba
    }
}
