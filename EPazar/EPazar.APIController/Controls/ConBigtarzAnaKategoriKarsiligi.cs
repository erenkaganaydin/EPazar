using EPazar.APIControls.APIControlBase;
using EPazar.APIControls.APIControlInterface;
using EPazar.Entity.XMLEntity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.APIController.Controls
{
    public class ConHipatuAnaKategoriEsitleme : BaseControl, IApiCon<HipatuAnaKategoriEsitleme>
    {
        public HipatuAnaKategoriEsitleme HipatuAnaKategoriEsitleme { get; set; }

        public ConHipatuAnaKategoriEsitleme()
        {
            this.HipatuAnaKategoriEsitleme = new HipatuAnaKategoriEsitleme();
        }

        public async Task<HipatuAnaKategoriEsitleme> ApiPostTek(string baseUrl, HipatuAnaKategoriEsitleme Entity)
        {
            var stringPayload = JsonConvert.SerializeObject(Entity, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            var Content = HttpContent(stringPayload);
            var response = await ResponseAsync(baseUrl, Content);
            HttpClient = Starter();
            if (response != null)
            {
                var result = JsonConvert.DeserializeObject<HipatuAnaKategoriEsitleme>(response);
                return result;
            }

            return null;
        }

        public void Dispose()
        {
            HttpClient.Dispose();
        }

        Task<List<HipatuAnaKategoriEsitleme>> IApiCon<HipatuAnaKategoriEsitleme>.ApiPost(string baseUrl, HipatuAnaKategoriEsitleme Entity)
        {
            throw new NotImplementedException();
        }
    }
}
