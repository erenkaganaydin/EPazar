using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace EPazarXmlOkuyucu
{
    public class OrnekXml
    {
        public void Reader()
        {
            //Buradaki adres kısmını istersek bir Web URL olarak da verebiliriz. Tercih tamamen sizin...
            string xmlAddress = "https://pamukcucicekcilik.xmlbankasi.com/image/data/xml/hipatu.xml";

            //Xml tanımlama işlemimizi yapıyoruz. Bundan sonra tüm işimiz XmlTextReader ile olacak...
            XmlTextReader XMLDosyam = new XmlTextReader(xmlAddress);

            string author = string.Empty,
            title = string.Empty,
            genre = string.Empty,
            price = string.Empty,
            publish_date = string.Empty,
            description = string.Empty;

            while (XMLDosyam.Read())
            {
                if (XMLDosyam.NodeType == XmlNodeType.Element)
                {
                    //Node Element'imizin adını kontrol ediyoruz. (Örn: &amp;lt;author&amp;gt; için "author" kullanıyoruz...)
                    switch (XMLDosyam.Name)
                    {
                        case "Product_code":
                            //Eğer istediğimiz ise o zaman okuyalım...
                            XMLDosyam.Read();
                            //Bulduğumuz değişkenin değerini string'e atayalım...
                            //Urun. = XMLDosyam.Value;
                            break;
                        case "title":
                            XMLDosyam.Read();
                            title = XMLDosyam.Value;
                            break;
                        case "genre":
                            XMLDosyam.Read();
                            genre = XMLDosyam.Value;
                            break;
                        case "price":
                            XMLDosyam.Read();
                            price = XMLDosyam.Value;
                            break;
                        case "publish_date":
                            XMLDosyam.Read();
                            publish_date = XMLDosyam.Value;
                            break;
                        case "description":
                            XMLDosyam.Read();
                            description = XMLDosyam.Value;

                            //Her bloktaki en son node'umuz olduğu için bunu yakalayıp verisini aldığımız anda o satır bitmiş demektir ve toplam değeri yazdıralım...
                            string sonSatir = author + ", " + title + ", " + genre + ", " + price + ", " + publish_date + ", " + description
                            + Environment.NewLine; //Burada da yeni satır ekleyelim ki görüntüde karışmasın...

                            Console.WriteLine(sonSatir); //Şimdi de sonucu ekrana yazdıralım...
                            break;

                        default:
                            break;

                    }
                }
                if (XMLDosyam.NodeType == XmlNodeType.EndElement)
                {
                    switch (XMLDosyam.Name)
                    {
                        case "Product":
                            //Eğer istediğimiz ise o zaman okuyalım...
                            XMLDosyam.Read();
                            //Bulduğumuz değişkenin değerini string'e atayalım...
                            Console.WriteLine();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
