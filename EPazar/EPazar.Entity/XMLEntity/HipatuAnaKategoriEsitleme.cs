using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.XMLEntity
{
    public class HipatuAnaKategoriEsitleme : BaseEntity.BaseEntity
    {
		public long Id { get; set; }
		public string TedarikciKategoriBirAdi { get; set; }
		public string TedarikciKategoriIkiAdi { get; set; }
		public string? TedarikciKategoriUcAdi { get; set; }
		public string BigtarzAnaKategoriAdi { get; set; }
		public string BigtarzKategoriAdi { get; set; }
		public string BigtarzAltKategoriAdi { get; set; }
	}
}
