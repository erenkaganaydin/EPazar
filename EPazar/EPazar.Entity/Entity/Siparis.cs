using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Siparis : BaseEntity.BaseEntity
    {
		public long Id { get; set; }
		public string SiparisNumarasi { get; set; }
		public int UyeId { get; set; }

		[ForeignKey(nameof(KullaniciAdresleri))]
		public long AdresId { get; set; }
		public double ToplamTutar { get; set; }
		public int OdemeDurumId { get; set; }

        public ICollection<SiparisDetay> SiparisDetay { get; set; }
        public KullaniciAdresleri KullaniciAdresleri { get; set; }
        public Siparis()
        {
			OdemeDurumId = 1;
			Id = 0;
        }
	}
}
