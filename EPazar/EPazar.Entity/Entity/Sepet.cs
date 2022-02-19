using EPazar.Entity.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Sepet : BaseEntity.BaseEntity
    {
        public long Id { get; set; }
        public string CookieToken { get; set; }
        public long? UyeId { get; set; }

        [ForeignKey(nameof(Urunler))]
        public long UrunId { get; set; }

        [ForeignKey(nameof(ViewUrunOzellikleriAciklamali))]
        public long? OzellikId { get; set; }


        public Urunler Urunler { get; set; }
        public ViewUrunOzellikleriAciklamali? ViewUrunOzellikleriAciklamali { get; set; }
    }
}
