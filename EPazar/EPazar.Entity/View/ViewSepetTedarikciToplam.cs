using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.View
{
    public class ViewSepetTedarikciToplam
    {
        public string SepetToken { get; set; }
        public string TedarikciAdi { get; set; }
        public int TedarikciId { get; set; }
        public double Toplam { get; set; }
    }
}
