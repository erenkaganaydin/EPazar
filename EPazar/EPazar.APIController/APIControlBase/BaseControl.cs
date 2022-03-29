using EPazar.APIControls.APIControlInterface;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.APIControls.APIControlBase
{
    public class BaseControl 
    {
        #region Prop

        public static HttpClient HttpClient { get; set; }

        #endregion

        #region Const

        public BaseControl()
        {
            HttpClient = Starter();
        }

        public static HttpClient Starter()
        {
            HttpClient = new HttpClient();

            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
            HttpClient = new HttpClient(handler);
            HttpClient.Timeout = TimeSpan.FromMinutes(20);

            return HttpClient;
        }

        #endregion Const

        #region HttpContent
        public static HttpContent HttpContent(string data)
        {
            HttpContent content = new StringContent(data, Encoding.UTF8, "application/json");
            return content;
        }
        #endregion HttpContent

        #region ResponseAsync
        public static async Task<string> ResponseAsync(string Url, HttpContent HttpContent)
        {
            var response = await HttpClient.PostAsync(Url, HttpContent);

            var read = await response.Content
                                      .ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return read;

            }
            return null;
        } 
        #endregion

    }
}
