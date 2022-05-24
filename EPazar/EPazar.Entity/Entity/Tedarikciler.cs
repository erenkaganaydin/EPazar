using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Tedarikciler : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Sifre { get; set; }
        public string? Ad { get; set; }
        public string? Unvan { get; set; }
        public string? Adres { get; set; }
        public string? Telefon { get; set; }

        public ICollection<Urunler> Urunler { get; set; }
    }
}
