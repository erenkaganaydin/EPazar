using EPazar.Controls.Controls;
using EPazar.Entity.XMLEntity;
using EPazar.APIControls.APIControlBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using APIControls.APIControlBase;
using EPazar.APIController.Controls;
using EPazar.Entity.SanalEntity;
using System.Globalization;

namespace XMLOkuyucu
{
    /// <summary>
    /// AktifBebek.xaml etkileşim mantığı
    /// </summary>
    public partial class AktifBebek : Window
    {
        public TedarikKategorileri TedarikKategorileri { get; set; }
        public ConUrun ConUrun { get; set; }
        public Urun Urun { get; set; }
        public Ozellik Ozellik { get; set; }
        public ConApiUrl ConApiUrl { get; set; }
        public HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme { get; set; }
        public ConHipatuAnaKategoriEsitleme ConHipatuAnaKategoriEsitleme { get; set; }
        public List<Urun> UrunList { get; set; }
        string OzellikTuru;
        public AktifBebek()
        {
            InitializeComponent();
            UrunList = new List<Urun>();

            ConApiUrl = new ConApiUrl();
            TedarikKategorileri = new TedarikKategorileri();
            ConUrun = new ConUrun();
            HipatuAnaKategoriEsitleme = new HipatuAnaKategoriEsitleme();
            ConHipatuAnaKategoriEsitleme = new ConHipatuAnaKategoriEsitleme();
            Urun = new Urun();
            Urun.TedarikciId = 3;
            Urun.Resimler = new List<string> { };
            Urun.Ozellik = new List<Ozellik> { };


        }

        public async Task Reader()
        {

            //Buradaki adres kısmını istersek bir Web URL olarak da verebiliriz. Tercih tamamen sizin...
            string xmlAddress = "https://www.bigtarz.com/aktif/aktif.xml";//"https://www.aktifbebek.com/api/v2/1646218985-917f8da9743cd17e2e13cf868f6b53a3";

            //Xml tanımlama işlemimizi yapıyoruz. Bundan sonra tüm işimiz XmlTextReader ile olacak...
            XmlTextReader XMLDosyam = new XmlTextReader(xmlAddress);
            bool OzellikOkuyor = false;

            while (XMLDosyam.Read())
            {
                if (XMLDosyam.NodeType == XmlNodeType.Element)
                {
                    if (XMLDosyam.Name == "varyasyonlar")
                    {
                        OzellikOkuyor = true;
                        Ozellik = new Ozellik();

                        Urun.Ozellik = new List<Ozellik>();
                    }
                    //Node Element'imizin adını kontrol ediyoruz. (Örn: &amp;lt;author&amp;gt; için "author" kullanıyoruz...)
                    if (!OzellikOkuyor)
                    {
                        OzellikTuru = "";

                        switch (XMLDosyam.Name)
                        {
                            #region Urun
                            case "urun_kodu":
                                XMLDosyam.Read();
                                //Bulduğumuz değişkenin değerini string'e atayalım...
                                Urun.TedarikciUrunKod = XMLDosyam.Value;
                                break;

                            case "urun_id":
                                XMLDosyam.Read();
                                Urun.TedarikciUrunId = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "baslik":
                                XMLDosyam.Read();
                                Urun.Adi = XMLDosyam.Value;
                                if (Urun.Adi == "Hipatu Openet Skınny Likralı Taşlanmış Kot Pantolon - Buz Mavi")
                                {
                                    var dur = "da";
                                }
                                break;

                            case "kategori1":
                                XMLDosyam.Read();
                                Urun.TedarikciKategoriBirAdi = XMLDosyam.Value;
                                break;

                            case "mainCategory_id":
                                XMLDosyam.Read();
                                Urun.TedarikciAnaKategoriId = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "kategori2":
                                XMLDosyam.Read();
                                Urun.TedarikciKategoriIkiAdi = XMLDosyam.Value;
                                break;

                            case "kategori3":
                                XMLDosyam.Read();
                                if (XMLDosyam.Value.ToString().Length > 0)
                                {
                                    Urun.TedarikciKategoriUcAdi = XMLDosyam.Value;
                                }
                                break;

                            case "subCategory_id":
                                XMLDosyam.Read();
                                if (XMLDosyam.Value.ToString().Length > 0)
                                {
                                    Urun.TedarikciAltKategoriId = Convert.ToInt32(XMLDosyam.Value);
                                }
                                break;

                            case "fiyat0":
                                XMLDosyam.Read();
                                Urun.TedarikciFiyati = Convert.ToDouble(XMLDosyam.Value.Replace(".", ","));
                                break;

                            case "para_birimi":
                                XMLDosyam.Read();
                                Urun.ParaBirimiTuru = XMLDosyam.Value;
                                break;

                            case "vergi":
                                XMLDosyam.Read();
                                Urun.KDV = Convert.ToDouble(XMLDosyam.Value.Replace('.',','));
                                break;

                            case "stok":
                                XMLDosyam.Read();
                                Urun.Stok = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "Brand":
                                XMLDosyam.Read();
                                Urun.Marka = XMLDosyam.Value;
                                break;

                            case "resim1":
                            case "resim2":
                            case "resim3":
                            case "resim4":
                            case "resim5":
                                XMLDosyam.Read();
                                if (XMLDosyam.Value.ToString().Length > 0)
                                {
                                    Urun.Resimler.Add(XMLDosyam.Value);
                                    break;
                                }
                                break;

                            case "aciklama":
                                XMLDosyam.Read();
                                Urun.Aciklama = XMLDosyam.Value;
                                break;

                            case "vk1":
                                OzellikTuru = XMLDosyam.Value;
                                break;
                            #endregion

                            default:
                                break;

                        }

                    }
                    if (OzellikOkuyor)
                    {
                        switch (XMLDosyam.Name)
                        {
                            case "resim1":
                                if (Urun.Resimler.Count == 0)
                                {
                                    XMLDosyam.Read();
                                    Urun.Resimler.Add(XMLDosyam.Value);
                                }
                                break;
                            case "vd1":
                                    Ozellik.TedarikciOzellikTuru = OzellikTuru;
                                    TextInfo formatter = new CultureInfo("en-US", false).TextInfo;
                                    XMLDosyam.Read();
                                    Ozellik.TedarikciOzellikAdi = formatter.ToTitleCase(formatter.ToLower(XMLDosyam.Value.Trim().Replace('/', '-')));                           
                                    Ozellik.TedarikciOzellikRengi = formatter.ToTitleCase(formatter.ToLower(XMLDosyam.Value.Trim().Replace('/', '-')));                           
                                break;

                            case "varyasyon_kodu":
                                XMLDosyam.Read();
                                Ozellik.OzellikUrunKodu = XMLDosyam.Value;
                                Ozellik.TedarikciBarkod = XMLDosyam.Value;
                                break;


                            case "stok":
                                XMLDosyam.Read();
                                Ozellik.OzelikStok = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "entegrasyon_kodu":
                                XMLDosyam.Read();
                                Ozellik.hbSaticiStokKodu = XMLDosyam.Value;
                                break;

                            default:
                                break;
                        }
                    }

                }
                if (XMLDosyam.NodeType == XmlNodeType.EndElement)
                {
                    switch (XMLDosyam.Name)
                    {
                        case "node":
                            XMLDosyam.Read();
                            UrunList.Add(Urun);

                            Urun = new Urun();
                            Urun.TedarikciId = 3;
                            Urun.Resimler = new List<string> { };

                            break;

                        case "varyasyon":
                            Urun.Ozellik.Add(Ozellik);
                            Ozellik = new Ozellik();
                            break;
                        case "varyasyonlar":
                            OzellikOkuyor = false;
                            break;
                        default:
                            break;

                    }
                }
            }

        }

        private async void OnOkuClick(object sender, RoutedEventArgs e)
        {
            try
            {
                buttonYolla.IsEnabled = false;
                await Reader();
                UrunDataGrid.ItemsSource = null;
                UrunDataGrid.ItemsSource = UrunList;

                ToplamUrunSayisi.Text = $"{UrunList.Count + " Ürün Okundu."}";
                Kategoriler.ItemsSource = UrunList.GroupBy(x => new { x.TedarikciKategoriBirAdi, x.TedarikciKategoriIkiAdi, x.TedarikciKategoriUcAdi }).Select(x => new TedarikKategorileri { TedarikciKategoriBirAdi = x.Key.TedarikciKategoriBirAdi, TedarikciKategoriIkiAdi = x.Key.TedarikciKategoriIkiAdi, TedarikciKategoriUcAdi = x.Key.TedarikciKategoriUcAdi }).ToList();
                buttonYolla.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "DEneme");
                throw;
            }
            

        }

        private void OnUrunSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OzelliklerGrid.ItemsSource = (UrunDataGrid.SelectedItem as Urun).Ozellik;
        }

        private async void OnYollaClick(object sender, RoutedEventArgs e)
        {
            buttonYolla.IsEnabled = false;
            var response = await ConUrun.ApiPostList(ConApiUrl.UrlUrunleriGuncelle, UrunList);

            if (response != null)
            {
                _ = MessageBox.Show("İşlem Tamam", "Güncelleme Bitti");
            }
            buttonYolla.IsEnabled = true;
        }

        private async void OnAnaKategoriKarsiligiEkleAsync(object sender, RoutedEventArgs e)
        {
            var SeciliKategori = Kategoriler.SelectedItem as TedarikKategorileri;
            HipatuAnaKategoriEsitleme.TedarikciKategoriBirAdi = SeciliKategori.TedarikciKategoriBirAdi;
            HipatuAnaKategoriEsitleme.TedarikciKategoriIkiAdi = SeciliKategori.TedarikciKategoriIkiAdi;
            HipatuAnaKategoriEsitleme.TedarikciKategoriUcAdi = SeciliKategori.TedarikciKategoriUcAdi;
            HipatuAnaKategoriEsitleme.BigtarzAnaKategoriAdi = BigtarzAnaKategoriKarsiligi.Text;
            HipatuAnaKategoriEsitleme.BigtarzKategoriAdi = BigtarzKategoriKarsiligi.Text;
            HipatuAnaKategoriEsitleme.BigtarzAltKategoriAdi = BigtarzAltKategoriKarsiligi.Text;

            var response = await ConHipatuAnaKategoriEsitleme.ApiPostTek(ConApiUrl.HipatuAnaKategoriEsitleme, HipatuAnaKategoriEsitleme);
        }


    }
}
