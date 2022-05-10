using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Admin : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string? KullaniciAdi { get; set; }
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        public string? EMail { get; set; }
        public string? Sifre { get; set; }
    }
}
