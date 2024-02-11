using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelviskolaCL.Models
{
    public partial class Nyelv
    {
        [JsonProperty("nyelv_id")]
        public long NyelvId { get; set; }

        [JsonProperty("nyelvnev")]
        public string? Nyelvnev { get; set; }

        public virtual ICollection<Tanar>? Tanarok { get; set; } = new List<Tanar>();
    }
}
