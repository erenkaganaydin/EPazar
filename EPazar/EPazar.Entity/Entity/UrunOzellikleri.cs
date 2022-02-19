using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class UrunOzellikleri : BaseEntity.BaseEntity
    {
		public long Id { get; set; }

		[ForeignKey(nameof(Urunler))]
		public long UrunId { get; set; }
		public int OzellikRenkId { get; set; }
		public int OzellikTurId { get; set; }
		public string OzellikAdi { get; set; }
		public string OzellikUrunKodu { get; set; }
		public string OzellikBarkod { get; set; }
		public string OzellikGTIN { get; set; }
		public int OzellikStok { get; set; }
		public double OzellikFiyati { get; set; }
		public string hbSaticiKodu { get; set; }

		public Urunler Urunler { get; set; }
	}
}
