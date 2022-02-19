using EPazar.APIControls.APIControlBaseUrl;
using EPazar.APIControls.APIControlInterface;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIControls.APIControlBase
{
    public class ConApiUrl : IApiUrl
    {
        public string UrlUrunleriGuncelle => BaseUrl.BaseHosting + "Urunler/Guncelle";
        public string HipatuAnaKategoriEsitleme => BaseUrl.BaseHosting + "api/Kategori/HipatuAnaKategoriEsitleme/Esitle";
       
    }
}
