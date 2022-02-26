using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class SiparisDurum : BaseEntity.BaseEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }

        public Siparis Siparis { get; set; }
    }
}
