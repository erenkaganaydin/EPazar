using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.XMLEntity
{
    public class Urun : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string TedarikciUrunKod { get; set; }
        public int TedarikciUrunId { get; set; }
        public string Adi { get; set; }
        public string TedarikciKategoriBirAdi { get; set; }
        public int TedarikciAnaKategoriId { get; set; }
        public string TedarikciKategoriIkiAdi { get; set; }
        public int TedarikciKategoriId { get; set; }
        public string TedarikciKategoriUcAdi { get; set; }
        public int TedarikciAltKategoriId { get; set; }
        public double TedarikciFiyati { get; set; }
        public string ParaBirimiTuru { get; set; }
        public double KDV { get; set; }
        public int Stok { get; set; }
        public string Marka { get; set; }
        public List<string> Resimler { get; set; }
        public string Aciklama { get; set; }

        [NotMapped]
        public int TedarikciId { get; set; }

        public List<Ozellik> Ozellik { get; set; }

    }
}
