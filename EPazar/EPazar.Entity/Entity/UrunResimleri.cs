using EPazar.Entity.View;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class UrunResimleri : BaseEntity.BaseEntity
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Urunler))]
        public long UrunId { get; set; }

        public string ResimLink { get; set; }

        
        public Urunler Urunler { get; set; }
    }
}
