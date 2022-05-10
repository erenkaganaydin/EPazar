using System.ComponentModel.DataAnnotations.Schema;

namespace EPazar.Entity.Entity
{
    public class Favoriler : BaseEntity.BaseEntity
    {
        public long Id { get; set; }

        [ForeignKey(nameof(Urunler))]
        public long UrunId { get; set; }

        public int KullaniciId { get; set; }

        [NotMapped]
        public string ResimLink { get; set; }

        public Urunler Urunler { get; set; }


    }
}
