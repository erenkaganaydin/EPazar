using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPazar.Entity.Entity
{
    public partial class VergiDairleri
    {
        [JsonProperty("il")]
        public Dictionary<string, List<Il>> Il { get; set; }
    }

    public partial class Il
    {
        [JsonProperty("kod")]
        public string Kod { get; set; }

        [JsonProperty("vdadi")]
        public string Vdadi { get; set; }
    }
}
