using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelviskolaCL.Models
{
    public partial class Tanar
    {
        [JsonProperty("tanar_id")]
        public long TanarId { get; set; }

        [JsonProperty("nev")]
        public string? Nev { get; set; }

        [JsonProperty("nyelv_id")]
        public long NyelvId { get; set; }

        [JsonProperty("oradij")]
        public long Oradij { get; set; }

        [JsonProperty("telefon")]
        public string? Telefon { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("net")]
        public sbyte Net { get; set; }

        public virtual Nyelv? Nyelv { get; set; }

        public virtual ICollection<TanitasiAlkalom> TanitasiAlkalmak { get; set; } = new List<TanitasiAlkalom>();
    }
}
