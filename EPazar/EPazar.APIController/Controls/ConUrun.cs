using EPazar.Entity.XMLEntity;
using EPazar.APIControls.APIControlBase;
using EPazar.APIControls.APIControlInterface;
using EPazar.Entity.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Controls.Controls
{
    public class ConUrun : BaseControl, IApiCon<Urun>
    {
        public Urun Urun { get; set; }

        public ConUrun()
        {
            this.Urun = new Urun();
        }

        public async Task<List<Urun>> ApiPostList(string baseUrl, List<Urun> Entity)
        {
            var stringPayload = JsonConvert.SerializeObject(Entity, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            var Content = HttpContent(stringPayload);
            var response = await ResponseAsync(baseUrl, Content);
            HttpClient = Starter();
            if (response != null)
            {
                var result = JsonConvert.DeserializeObject<List<Urun>>(response);
                return result;
            }

            return null;
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }

        public Task<List<Urun>> ApiPost(string baseUrl, Urun Entity)
        {
            throw new NotImplementedException();
        }
    }
}