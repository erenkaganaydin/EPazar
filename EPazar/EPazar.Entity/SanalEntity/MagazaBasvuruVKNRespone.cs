using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class MagazaBasvuruVKNRespone
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }
    }
}

public class Data
{
    public string durum { get; set; }
    public string tckn { get; set; }
    public string durum_text { get; set; }
    public string vkn { get; set; }
    public string vdkodu { get; set; }
    public string sorgulayantckimlik { get; set; }
    public string unvan{ get; set; }
}

public partial class Message
{
    [JsonProperty("text")]
    public string Text { get; set; }
    public string type { get; set; }
}