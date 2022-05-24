using EPazar.Entity.SanalEntity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bigtarz.Magaza.Controllers
{
    public class BasvuruController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var Token = VKNSorgulamaToken();
            if (Token != null)
            {
               var resul =  VKNSorgulamaIslemi(Token, "9780516317");
            }
            return View();
        }

        private string? VKNSorgulamaToken()
        {
            try
            {
                WebRequest request = WebRequest.Create("https://ivd.gib.gov.tr/tvd_server/assos-login");
                request.Method = "POST";
                string postData = "assoscmd=cfsession&rtype=json&fskey=intvrg.fix.session&fuserid=INTVRG_FIX&";
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);

                var result = JsonConvert.DeserializeObject<MagazaBasvuruVKNToken>(responseFromServer);

                reader.Close();
                dataStream.Close();
                response.Close();

                return result.token;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }

        private string? VKNSorgulamaIslemi(string Token,string Vkn)
        {
            try
            {
                string jp = "{\"dogrulama\":{\"vkn1\":\"" + Vkn+ "\",\"tckn1\": \"\",\"iller\":\"35\",\"vergidaireleri\":\"035252'}}";

                WebRequest request = WebRequest.Create("https://ivd.gib.gov.tr/tvd_server/dispatch");
                request.Method = "POST";
                string postData = "cmd=vergiNoIslemleri_vergiNumarasiSorgulama&callid=ff81dd010b12d-8&pageName=R_INTVRG_INTVD_VERGINO_DOGRULAMA&token="+Token+"&jp="+jp ;
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);

                var result = JsonConvert.DeserializeObject<MagazaBasvuruVKNToken>(responseFromServer);

                reader.Close();
                dataStream.Close();
                response.Close();

                return result.token;
            }
            catch (Exception e)
            {
                return null;
            }
            
        }
    }


 
}
