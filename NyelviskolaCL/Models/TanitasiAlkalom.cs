using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyelviskolaCL.Models
{
    public partial class TanitasiAlkalom
    {
        [JsonProperty("alkalom_id")]
        public long? AlkalomId { get; set; }

        [JsonProperty("tanar_id")]
        public long? TanarId { get; set; }

        [JsonProperty("tanitvany_id")]
        public long? TanitvanyId { get; set; }

        [JsonProperty("datum")]
        public DateTimeOffset? Datum { get; set; }

        [JsonProperty("kezdesido")]
        public DateTimeOffset? Kezdesido { get; set; }

        [JsonProperty("orak_szama")]
        public long? OrakSzama { get; set; }

        public virtual Tanar? Tanar { get; set; }
        public virtual Tanitvany? Tanitvany { get; set; }
    }
}
