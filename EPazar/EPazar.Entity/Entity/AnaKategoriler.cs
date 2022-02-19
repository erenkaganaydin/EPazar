using System;
using System.Collections.Generic;
using System.Text;

namespace EPazar.Entity.Entity
{
    public class AnaKategoriler : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public int Sira { get; set; }
        public string Ad { get; set; }
    }
}
