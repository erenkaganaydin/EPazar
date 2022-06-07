using EPazar.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class PanelSiparisDetayEntityleri
    {
        public Siparis? Siparis{ get; set; }
        public List<SiparisDetay?> SiparisDetay { get; set; }
        public List<OdemeDurum?> OdemeDurumlari { get; set; }
        public List<SiparisDurum?> SiparisDurumlari { get; set; }
    }
}
