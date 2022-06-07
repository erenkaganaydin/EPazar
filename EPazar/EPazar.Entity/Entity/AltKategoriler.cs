using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class AltKategoriler : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public int? Sira { get; set; }
        public int? UstKategoriId { get; set; }
        public int? KategoriId { get; set; }
        public string Ad { get; set; }
        public decimal? Kdv { get; set; }
        public decimal? Komisyon { get; set; }
    
        [NotMapped]
        public string AnaKategoriAdi { get; set; }
        [NotMapped]
        public string KategoriAdi { get; set; }
    }
}
