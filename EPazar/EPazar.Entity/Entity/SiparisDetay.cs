using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class SiparisDetay : BaseEntity.BaseEntity
    {
		public long Id { get; set; }

		[ForeignKey(nameof(Siparis))]
		public long SiparisId { get; set; }

		public int? Adet { get; set; }
		public long UrunId { get; set; }
		public string? UrunTedarikciAdi { get; set; }
		public string? UrunAdi { get; set; }
		public double? UrunFiyati { get; set; }
		public double? UrunKDV { get; set; }
		public long? OzellikId { get; set; }
		public string? OzellikAdi { get; set; }

        public Siparis? Siparis { get; set; }
    }
}
