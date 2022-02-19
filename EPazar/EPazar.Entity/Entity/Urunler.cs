using EPazar.Entity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Urunler : BaseEntity.BaseEntity
    {
        public long Id { get; set; }
        public int TedarikciId { get; set; }
        public string TedarikciUrunKod { get; set; }
        public int TedarikciUrunId { get; set; }
        public string Adi { get; set; }
        public double KDV { get; set; }
        public int Stok { get; set; }
        public string Aciklama { get; set; }
        public double TedarikciFiyat { get; set; }
        public double EskiFiyat { get; set; }
        public double Fiyat { get; set; }

        public ICollection<UrunResimleri>? UrunResimleri { get; set; }
        public ICollection<UrunOzellikleri>? UrunOzellikleri { get; set; }
        public ICollection<ViewUrunOzellikleriAciklamali>? ViewUrunOzellikleriAciklamali { get; set; }
    }
}
