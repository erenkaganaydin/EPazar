using EPazar.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class IndexEntityleri
    {
        public List<AnasayfaBanner> AnasayfaBannerList { get; set; }
        public List<AnasayfaTopBanner> AnasayfaTopBannerList { get; set; }
        public List<AnasayfaSagBanner> AnasayfaSagBannerList { get; set; }
        public List<AnasayfaMiniBanner> AnasayfaMiniBannerList { get; set; }
        public List<KategoriListesiTopBanner> KategoriListesiTopBanner { get; set; }
    }
}
