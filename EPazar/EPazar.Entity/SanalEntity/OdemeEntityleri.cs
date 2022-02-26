using EPazar.Entity.Entity;
using EPazar.Entity.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class OdemeEntityleri
    {
        public Siparis Siparis { get; set; }
        public List<ViewSepet> ViewSepet { get; set; }
        public List<KullaniciAdresleri> KullaniciAdresleri { get; set; }
        public KullaniciAdresleri SeciliKullaniciAdresi { get; set; }
    }
}
