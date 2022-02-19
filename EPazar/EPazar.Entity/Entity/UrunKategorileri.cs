using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class UrunKategorileri : BaseEntity.BaseEntity
    {
        public long Id { get; set; }

        [ForeignKey(nameof(Urunler))]
        public long UrunId { get; set; }
        public int AnaKategoriId { get; set; }
        public int KategoriId { get; set; }
        public int AltKategoriId { get; set; }

        public Urunler Urunler { get; set; }
    }
}
