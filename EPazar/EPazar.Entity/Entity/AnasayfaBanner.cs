using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class AnasayfaBanner : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public string Image { get; set; }
        public string Aciklama { get; set; }
        public string Link { get; set; }
    }
}
