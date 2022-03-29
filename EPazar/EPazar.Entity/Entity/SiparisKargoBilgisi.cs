using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        [ForeignKey(nameof(KargoFirmalari))]
        public int KargoFirmaId { get; set; }

        public string KargoTakipKodu { get; set; }
        public double KargoTutari { get; set; }

        public KargoFirmalari KargoFirmalari { get; set; }
    }
}
