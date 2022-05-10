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

		[ForeignKey(nameof(SiparisDurum))]
		public int SiparisDurumId { get; set; }

		public string SiparisNumarasi { get; set; }

		[ForeignKey(nameof(Kullanicilar))]
		public int UyeId { get; set; }

		[ForeignKey(nameof(KullaniciAdresleri))]
		public long AdresId { get; set; }
		public double ToplamTutar { get; set; }

		[ForeignKey(nameof(OdemeDurum))]
		public int OdemeDurumId { get; set; }

        public ICollection<SiparisDetay> SiparisDetay { get; set; }
        public KullaniciAdresleri KullaniciAdresleri { get; set; }
        public SiparisDurum SiparisDurum { get; set; }
        public OdemeDurum OdemeDurum { get; set; }
        public Kullanicilar Kullanicilar { get; set; }
        public Siparis()
        {
			SiparisDurumId = 1;
			OdemeDurumId = 1;
			Id = 0;
        }
	}
}
