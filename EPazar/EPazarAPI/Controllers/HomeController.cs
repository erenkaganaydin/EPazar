using EPazar.Business.Business;
using EPazar.Entity.Entity;
using EPazar.Entity.XMLEntity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EPazarAPI.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        #region Prop
        public HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme { get; set; }
        public BusHipatuAnaKategoriEsitleme BusHipatuAnaKategoriEsitleme { get; set; }

        public BusAnaKategoriler BusAnaKategoriler { get; set; }
        public AnaKategoriler AnaKategoriler { get; set; }

        public BusKategoriler BusKategoriler { get; set; }
        public Kategoriler Kategoriler { get; set; }

        public BusAltKategoriler BusAltKategoriler { get; set; }
        public AltKategoriler AltKategoriler { get; set; }

        public Urunler Urunler { get; set; }
        public BusUrunler BusUrunler { get; set; }

        public UrunResimleri UrunResimleri { get; set; }
        public BusUrunResimleri BusUrunResimleri { get; set; }

        public UrunOzellikleri UrunOzellikleri { get; set; }
        public BusUrunOzellikleri BusUrunOzellikleri { get; set; }

        public OzellikRenkleri OzellikRenkleri { get; set; }
        public BusOzellikRenkleri BusOzellikRenkleri { get; set; }

        public OzellikTur OzellikTur { get; set; }
        public BusOzellikTur BusOzellikTur { get; set; }

        public UrunKategorileri UrunKategorileri { get; set; }
        public BusUrunKategorileri BusUrunKategorileri { get; set; }

        public Random random;
        #endregion

        #region Const
        public HomeController()
        {
            random = new Random();


            HipatuAnaKategoriEsitleme = new HipatuAnaKategoriEsitleme();
            BusHipatuAnaKategoriEsitleme = new BusHipatuAnaKategoriEsitleme();

            BusAnaKategoriler = new BusAnaKategoriler();
            AnaKategoriler = new AnaKategoriler();

            BusKategoriler = new BusKategoriler();
            Kategoriler = new Kategoriler();

            BusAltKategoriler = new BusAltKategoriler();
            AltKategoriler = new AltKategoriler();

            BusUrunler = new BusUrunler();
            BusUrunResimleri = new BusUrunResimleri();

            BusUrunOzellikleri = new BusUrunOzellikleri();

            BusOzellikRenkleri = new BusOzellikRenkleri();

            BusOzellikTur = new BusOzellikTur();

            BusUrunKategorileri = new BusUrunKategorileri();
        }
        #endregion

        [HttpPost("Urunler/Guncelle")]
        public async Task<ActionResult> UrunleriGuncelle(List<Urun> Urun)
        {
            try
            {
                foreach (Urun urun in Urun)
                {
                    #region Urun Ekleme ve Kontrol

                    Urunler = new Urunler();

                    Urunler.TedarikciId = urun.TedarikciId; //Hipatu
                    Urunler.TedarikciUrunId = urun.TedarikciUrunId;
                    Urunler.TedarikciUrunKod = urun.TedarikciUrunKod;
                    Urunler.Adi = urun.Adi;
                    Urunler.KDV = urun.KDV;
                    Urunler.Stok = urun.Stok;
                    Urunler.Aciklama = urun.Aciklama;
                    Urunler.TedarikciFiyat = urun.TedarikciFiyati;

                    var YeniFiyat = ((urun.TedarikciFiyati * 20) / 100) + urun.TedarikciFiyati;
                    var ArtiKargo = YeniFiyat + 14.99;
                    var Yuzde = random.Next(40, 55);
                    Urunler.EskiFiyat = Math.Round(((ArtiKargo * Yuzde) / 100) + ArtiKargo, 2);
                    Urunler.Fiyat = Math.Round(ArtiKargo, 2);


                    var UrunVarMi = await BusUrunler.FirstOrDefaultAsync(Urunler);
                    if (UrunVarMi == null)
                    {
                        var UrunEkleme = await BusUrunler.InsertAsync(Urunler, false);
                    }
                    else
                    {
                        Urunler.Id = UrunVarMi.Id;
                        var Update = await BusUrunler.UpdateAsync(Urunler);
                    }
                    #endregion

                    #region Urun Resim İşlemleri
                    try
                    {
                        UrunResimleri = new UrunResimleri();
                        UrunResimleri.UrunId = Urunler.Id;
                        var ResimVarMi = await BusUrunResimleri.PredicateAsync(UrunResimleri);
                        if (ResimVarMi.Count == 0)
                        {
                            foreach (var item in urun.Resimler)
                            {
                                UrunResimleri.ResimLink = item;
                                var ResimEkle = await BusUrunResimleri.InsertAsync(UrunResimleri, false);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var exe = ex.Message;
                    }

                    #endregion

                    #region Urun Ozellik İşlemleri
                    try
                    {
                        if (urun.Ozellik != null)
                        {
                            foreach (var item in urun.Ozellik)
                            {
                                #region OzellikRenkleri İşlemleri

                                UrunOzellikleri = new UrunOzellikleri();
                                UrunOzellikleri.UrunId = Urunler.Id;
                                OzellikRenkleri = new OzellikRenkleri();
                                OzellikRenkleri.Ad = item.TedarikciOzellikRengi;

                                var OzellikRengi = await BusOzellikRenkleri.FirstOrDefaultAsync(OzellikRenkleri);
                                if (OzellikRengi == null)
                                {
                                    var OzellikRengiEkle = await BusOzellikRenkleri.InsertAsync(OzellikRenkleri, false);
                                }
                                else
                                {
                                    OzellikRenkleri.Id = OzellikRengi.Id;
                                }

                                UrunOzellikleri.OzellikRenkId = OzellikRenkleri.Id;

                                #endregion

                                #region Ozellik Tur İşlemleri
                                OzellikTur = new OzellikTur();

                                #region OzellikTurSınıflama
                                if (item.TedarikciOzellikTuru == "KADIN BEDENLERİ")
                                {
                                    item.TedarikciOzellikTuru = "Beden";
                                }
                                if (item.TedarikciOzellikTuru == "ÇOCUK BEDENLERİ 1")
                                {
                                    item.TedarikciOzellikTuru = "Çocuk Beden";
                                }
                                if (item.TedarikciOzellikTuru == "BEDENLER 3")
                                {
                                    item.TedarikciOzellikTuru = "Beden";
                                }
                                if (item.TedarikciOzellikTuru == "BEDENLER 2")
                                {
                                    item.TedarikciOzellikTuru = "Beden";
                                }
                                if (item.TedarikciOzellikTuru == "ÇOCUK BEDENLERİ 2")
                                {
                                    item.TedarikciOzellikTuru = "Çocuk Beden";
                                }
                                if (item.TedarikciOzellikTuru == "AYAKKABI")
                                {
                                    item.TedarikciOzellikTuru = "Ayakkabı Numarası";
                                }
                                if (item.TedarikciOzellikTuru == "BEDEN 5")
                                {
                                    item.TedarikciOzellikTuru = "Beden";
                                }
                                #endregion

                                if (item.TedarikciOzellikAdi == "2XL")
                                {
                                    item.TedarikciOzellikAdi = "XXL";
                                }
                                if (item.TedarikciOzellikAdi == "3XL")
                                {
                                    item.TedarikciOzellikAdi = "XXXL";
                                }

                                OzellikTur.TurAdi = item.TedarikciOzellikTuru;
                                var OzellikTurVarMi = await BusOzellikTur.FirstOrDefaultAsync(OzellikTur);
                                if (OzellikTurVarMi == null)
                                {
                                    var OzellikTurEkle = await BusOzellikTur.InsertAsync(this.OzellikTur, false);
                                }
                                else
                                {
                                    OzellikTur.Id = OzellikTurVarMi.Id;
                                }
                                UrunOzellikleri.OzellikTurId = OzellikTur.Id;
                                #endregion

                                UrunOzellikleri.OzellikAdi = item.TedarikciOzellikAdi;
                                UrunOzellikleri.OzellikUrunKodu = item.OzellikUrunKodu;
                                UrunOzellikleri.OzellikBarkod = item.TedarikciBarkod;
                                UrunOzellikleri.OzellikGTIN = item.GTIN;
                                UrunOzellikleri.OzellikStok = item.OzelikStok;
                                UrunOzellikleri.OzellikFiyati = item.OzellikFiyati;
                                UrunOzellikleri.hbSaticiKodu = item.hbSaticiStokKodu;

                                var UrunOzellikVarMi = await BusUrunOzellikleri.FirstOrDefaultAsync(UrunOzellikleri);
                                if (UrunOzellikVarMi == null)
                                {
                                    var UrunOzellikEkle = await BusUrunOzellikleri.InsertAsync(UrunOzellikleri, false);
                                }
                                else
                                {
                                    UrunOzellikleri.Id = UrunOzellikVarMi.Id;
                                    var UrunOzellikGuncelle = await BusUrunOzellikleri.UpdateAsync(UrunOzellikleri);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        var exe = ex.Message;
                    }

                    #endregion

                    #region KategoriIslemleri
                    try
                    {
                        #region Hipatu Kategori Esitleme
                        HipatuAnaKategoriEsitleme.TedarikciKategoriBirAdi = urun.TedarikciKategoriBirAdi;
                        HipatuAnaKategoriEsitleme.TedarikciKategoriIkiAdi = urun.TedarikciKategoriIkiAdi;
                        HipatuAnaKategoriEsitleme.TedarikciKategoriUcAdi = urun.TedarikciKategoriUcAdi;
                        #endregion

                        if (urun.TedarikciKategoriIkiAdi == "Pantolon")
                        {
                            var x = 21;
                        }
                        var VarMi = await BusHipatuAnaKategoriEsitleme.VarMi(HipatuAnaKategoriEsitleme);
                        if (VarMi != null)
                        {
                            UrunKategorileri = new UrunKategorileri();
                            UrunKategorileri.UrunId = Urunler.Id;
                            AnaKategoriler.Ad = VarMi.BigtarzAnaKategoriAdi;
                            var AnaKategoriId = await BusAnaKategoriler.AddanId(AnaKategoriler);

                            Kategoriler.Ad = VarMi.BigtarzKategoriAdi;
                            Kategoriler.AnaKategoriId = AnaKategoriId.Id;
                            var KategoriId = await BusKategoriler.AddanId(Kategoriler);

                            AltKategoriler.Ad = VarMi.BigtarzAltKategoriAdi;
                            AltKategoriler.UstKategoriId = AnaKategoriId.Id;
                            if (KategoriId != null)
                            {
                                AltKategoriler.KategoriId = KategoriId.Id;
                            }
                            var AltKategoriId = await BusAltKategoriler.AddanId(AltKategoriler);

                            UrunKategorileri.AnaKategoriId = AnaKategoriId.Id;
                            if (KategoriId != null)
                            {
                                UrunKategorileri.KategoriId = KategoriId.Id;
                            }
                            if (AltKategoriId != null)
                            {
                                UrunKategorileri.AltKategoriId = AltKategoriId.Id;
                            }

                            var UrunKategoriKayitliMi = await BusUrunKategorileri.FirstOrDefaultAsync(UrunKategorileri);
                            if (UrunKategoriKayitliMi == null)
                            {
                                var UrunKategoriekle = await BusUrunKategorileri.InsertAsync(UrunKategorileri, false);
                            }
                            else
                            {
                                UrunKategoriKayitliMi.AnaKategoriId = UrunKategorileri.AnaKategoriId;
                                UrunKategoriKayitliMi.KategoriId = UrunKategorileri.KategoriId;
                                UrunKategoriKayitliMi.AltKategoriId = UrunKategorileri.AltKategoriId;
                                var KategoriGuncelleme = await BusUrunKategorileri.UpdateAsync(UrunKategoriKayitliMi);
                            }
                        }
                        else
                        {
                            var x = "Hp Patladı";

                        }
                    }
                    catch (Exception ex)
                    {
                        var exep = ex.Message;
                    }

                    #endregion
                }
            }
            catch (Exception ex)
            {
                var exep = ex;
            }

            if (Urunler.TedarikciId == 1)
            {
                var HipatuTumUrunlerId = await BusUrunler.HipatuTumUrunler();
                var OnlardanGelen = Urun.Select(x => x.TedarikciUrunId);
                // A listesinde olup B'de olmayanları
                var BizdeVarOnlardaYok = HipatuTumUrunlerId.Except(OnlardanGelen).ToList(); //Çıktısı 1

                foreach (var item in BizdeVarOnlardaYok)
                {
                    Urunler = new Urunler();

                    Urunler.TedarikciUrunId = item;
                    Urunler.TedarikciId = 1;

                    var UrunSorgu = await BusUrunler.FirstOrDefaultTedarikciAsync(Urunler);
                    UrunSorgu.Stok = 0;
                    var Result = await BusUrunler.UpdateAsync(UrunSorgu);
                }
            }

            else
            {
                var HipatuTumUrunlerId = await BusUrunler.AkitfBebekTumUrunler();
                var OnlardanGelen = Urun.Select(x => x.TedarikciUrunId);
                // A listesinde olup B'de olmayanları
                var BizdeVarOnlardaYok = HipatuTumUrunlerId.Except(OnlardanGelen).ToList(); //Çıktısı 1

                foreach (var item in BizdeVarOnlardaYok)
                {
                    Urunler = new Urunler();

                    Urunler.TedarikciUrunId = item;
                    Urunler.TedarikciId = 3;

                    var UrunSorgu = await BusUrunler.FirstOrDefaultTedarikciAsync(Urunler);
                    UrunSorgu.Stok = 0;
                    var Result = await BusUrunler.UpdateAsync(UrunSorgu);
                }
            }

            return Ok(Urun);
        }

        #region Deneme
        [HttpGet("Anasayfa/deneme/{id?}")]
        public ActionResult<IEnumerable<Urun>> GetAll(int? id)
        {
            if (id == null)
                id = 0;
            else if (id == 0)
                id = 1;
            return new[]
            {
                new Urun { Adi = "Ana" },
                new Urun { Adi = "Felipe" },
                new Urun { Adi = "Emillia" },
                new Urun { Id = (int)id }
            };
        }
        #endregion

    }
}
