using EPazar.Entity.Entity;
using EPazar.Entity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class SiparisBilgisiEntityleri
    {
        public Siparis Siparis { get; set; }
        public List<ViewSiparisDetay> ViewSiparisDetay { get; set; }
        public List<SiparisKargoBilgisi> SiparisKargoBilgisi { get; set; }
    }
}
