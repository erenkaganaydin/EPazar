using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.SanalEntity
{
    public class JSONSehirler
    {
        [JsonProperty("Sehirler")]
        public List<Sehirler> Sehirler { get; set; }
    }

    public partial class Sehirler
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
