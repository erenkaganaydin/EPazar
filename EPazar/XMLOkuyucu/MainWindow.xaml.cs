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

namespace XMLOkuyucu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public TedarikKategorileri TedarikKategorileri { get; set; }
        public ConUrun ConUrun { get; set; }
        public Urun Urun { get; set; }
        public Ozellik Ozellik { get; set; }
        public ConApiUrl ConApiUrl { get; set; }
        public HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme { get; set; }
        public ConHipatuAnaKategoriEsitleme ConHipatuAnaKategoriEsitleme { get; set; }
        public List<Urun> UrunList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            UrunList = new List<Urun>();

            ConApiUrl = new ConApiUrl();
            TedarikKategorileri = new TedarikKategorileri();
            ConUrun = new ConUrun();
            HipatuAnaKategoriEsitleme = new HipatuAnaKategoriEsitleme();
            ConHipatuAnaKategoriEsitleme = new ConHipatuAnaKategoriEsitleme();
            Urun = new Urun();
            Urun.Resimler = new List<string> { };
            Urun.Ozellik = new List<Ozellik> { };


        }

        public async Task Reader()
        {
           

            //Buradaki adres kısmını istersek bir Web URL olarak da verebiliriz. Tercih tamamen sizin...
            string xmlAddress = "https://pamukcucicekcilik.xmlbankasi.com/image/data/xml/hipatu.xml";

            //Xml tanımlama işlemimizi yapıyoruz. Bundan sonra tüm işimiz XmlTextReader ile olacak...
            XmlTextReader XMLDosyam = new XmlTextReader(xmlAddress);
            bool OzellikOkuyor = false;

            while (XMLDosyam.Read())
            {
                if (XMLDosyam.NodeType == XmlNodeType.Element)
                {
                    if (XMLDosyam.Name == "variants")
                    {
                        OzellikOkuyor = true;
                        Ozellik = new Ozellik();
                        Urun.Ozellik = new List<Ozellik>();
                    }
                    //Node Element'imizin adını kontrol ediyoruz. (Örn: &amp;lt;author&amp;gt; için "author" kullanıyoruz...)
                    if (!OzellikOkuyor)
                    {
                        switch (XMLDosyam.Name)
                        {
                            #region Urun
                            case "Product_code":
                                XMLDosyam.Read();
                                //Bulduğumuz değişkenin değerini string'e atayalım...
                                Urun.TedarikciUrunKod = XMLDosyam.Value;
                                break;

                            case "Product_id":
                                XMLDosyam.Read();
                                Urun.TedarikciUrunId = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "Name":
                                XMLDosyam.Read();
                                Urun.Adi = XMLDosyam.Value;
                                if (Urun.Adi == "Brad Jeans")
                                {
                                    var dur="da";
                                }
                                break;

                            case "mainCategory":
                                XMLDosyam.Read();
                                Urun.TedarikciKategoriBirAdi = XMLDosyam.Value;
                                break;

                            case "mainCategory_id":
                                XMLDosyam.Read();
                                Urun.TedarikciAnaKategoriId = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "category":
                                XMLDosyam.Read();
                                Urun.TedarikciKategoriIkiAdi = XMLDosyam.Value;
                                break;

                            case "subCategory":
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

                            case "Price":
                                XMLDosyam.Read();
                                Urun.TedarikciFiyati = Convert.ToDouble(XMLDosyam.Value.Replace(".", ","));
                                break;

                            case "CurrencyType":
                                XMLDosyam.Read();
                                Urun.ParaBirimiTuru = XMLDosyam.Value;
                                break;

                            case "Tax":
                                XMLDosyam.Read();
                                Urun.KDV = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "Stock":
                                XMLDosyam.Read();
                                Urun.Stok = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "Brand":
                                XMLDosyam.Read();
                                Urun.Marka = XMLDosyam.Value;
                                break;

                            case "Image1":
                            case "Image2":
                            case "Image3":
                            case "Image4":
                            case "Image5":
                                XMLDosyam.Read();
                                if (XMLDosyam.Value.ToString().Length > 0)
                                {
                                    Urun.Resimler.Add(XMLDosyam.Value);
                                    break;
                                }
                                break;

                            case "Description":
                                XMLDosyam.Read();
                                Urun.Aciklama = XMLDosyam.Value;
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
                            case "spec":
                                if(XMLDosyam.GetAttribute("name").ToUpper() == "RENK")
                                {
                                    XMLDosyam.Read();
                                    Ozellik.TedarikciOzellikRengi = XMLDosyam.Value;
                                }
                                else { 
                                    Ozellik.TedarikciOzellikTuru = XMLDosyam.GetAttribute("name");
                                    XMLDosyam.Read();
                                    Ozellik.TedarikciOzellikAdi = XMLDosyam.Value.Replace('/', '-').ToUpper();
                                }
                                break;

                            case "productCode":
                                XMLDosyam.Read();
                                Ozellik.OzellikUrunKodu = XMLDosyam.Value;
                                break;

                            case "barcode":
                                XMLDosyam.Read();
                                Ozellik.TedarikciBarkod = XMLDosyam.Value;
                                break;

                            case "gtin":
                                XMLDosyam.Read();
                                Ozellik.GTIN = XMLDosyam.Value;
                                break;

                            case "quantity":
                                XMLDosyam.Read();
                                Ozellik.OzelikStok = Convert.ToInt32(XMLDosyam.Value);
                                break;

                            case "hbSaticiStokKodu":
                                XMLDosyam.Read();
                                Ozellik.hbSaticiStokKodu = XMLDosyam.Value;
                                break;

                            case "price":
                                XMLDosyam.Read();
                                Ozellik.OzellikFiyati = Convert.ToDouble(XMLDosyam.Value);
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
                        case "Product":
                            XMLDosyam.Read();
                            UrunList.Add(Urun);

                            Urun = new Urun();
                            Urun.Resimler = new List<string> { };

                            break;

                        case "variants":
                            Urun.Ozellik.Add(Ozellik);
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
            buttonYolla.IsEnabled = false;
            await Reader();
            UrunDataGrid.ItemsSource = null;
            UrunDataGrid.ItemsSource = UrunList;

            ToplamUrunSayisi.Text = $"{UrunList.Count + " Ürün Okundu."}";
            Kategoriler.ItemsSource = UrunList.GroupBy(x=> new {x.TedarikciKategoriBirAdi, x.TedarikciKategoriIkiAdi, x.TedarikciKategoriUcAdi }).Select(x=> new TedarikKategorileri { TedarikciKategoriBirAdi = x.Key.TedarikciKategoriBirAdi, TedarikciKategoriIkiAdi = x.Key.TedarikciKategoriIkiAdi, TedarikciKategoriUcAdi = x.Key.TedarikciKategoriUcAdi }).ToList();
            buttonYolla.IsEnabled = true;

        }

        private void OnUrunSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OzelliklerGrid.ItemsSource = (UrunDataGrid.SelectedItem as Urun).Ozellik;
        }

        private async void OnYollaClick(object sender, RoutedEventArgs e)
        {
            var response = await ConUrun.ApiPostList(ConApiUrl.UrlUrunleriGuncelle, UrunList);

            if (response != null)
            {
                _  = MessageBox.Show("İşlem Tamam","Güncelleme Bitti");
            }
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
