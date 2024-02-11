using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelviskolaCL.Models
{
    public partial class Tanitvany
    {
        [JsonProperty("tanitvany_id")]
        public long? TanitvanyId { get; set; }

        [JsonProperty("nev")]
        public string? Nev { get; set; }

        [JsonProperty("telefon")]
        public string? Telefon { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        public virtual ICollection<TanitasiAlkalom> TanitasiAlkalmak { get; set; } = new List<TanitasiAlkalom>();

    }
}
