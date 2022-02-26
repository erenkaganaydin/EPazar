using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class SiparisKargoBilgisi : BaseEntity.BaseEntity
    {
        public long Id { get; set; }
        public long SiparisId { get; set; }
        public long SiparisDetayId { get; set; }
        public int KargoFirmaId { get; set; }
        public string KargoTakipKodu { get; set; }
        public double KargoTutari { get; set; }
    }
}
