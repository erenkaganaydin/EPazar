using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class KullaniciAdresleri : BaseEntity.BaseEntity
    {
		public long Id { get; set; }
		public long UyeId { get; set; }
		public string Ad { get; set; }
		public string Soyad { get; set; }
		public string Telefon { get; set; }
		public string Sehir { get; set; }
		public string Ilce { get; set; }
		public string Mahalle { get; set; }
		public string Adres { get; set; }
		public string AdresBasligi { get; set; }

	}
}
