using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public class Kullanicilar : BaseEntity.BaseEntity
    {
		public int Id { get; set; }
		public string? Ad { get; set; }
		public string? Soyad { get; set; }
		public string? Telefon { get; set; }
		public string? EMail { get; set; }
		public string? Sifre { get; set; }
		public string? Cinsiyet { get; set; }
		public int? DogumGunu { get; set; }
		public int? DogumAyi { get; set; }
		public int? DogumYili { get; set; }

		[NotMapped]
        public string AdSoyad { 
			get { return Ad + " " + Soyad; }
			set { AdSoyad = Ad + " " + Soyad; } 
		}

        public Kullanicilar()
        {
			Telefon = "";
			EMail = "";
			Cinsiyet = "";
			Ad = "";
			Soyad = "";
			
		}
    }
}
