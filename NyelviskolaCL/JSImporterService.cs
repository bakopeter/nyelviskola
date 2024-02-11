using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NyelviskolaCL.Models;
using System.Reflection.Metadata.Ecma335;

namespace NyelviskolaCL
{
    public class JSImporterService
    {
        public static List<object> Import(string path)
        {
            List<object> emptyList = new();
            
            if (!File.Exists(path)) { return emptyList; }
            
            StreamReader r = new(path);
            if (r.Read() == -1) { return emptyList; }

            r = new(path);
            string json = r.ReadToEnd();
            JArray? arr = (json != null) ? JArray.Parse(json) : null;l

            if (arr != null) { return emptyList; }

            if (arr.First!.First!.ToString().Contains("nyelv_id"))
            {
                List<object> list = new();

                foreach (JObject obj in arr.Cast<JObject>())
                {
                    //obj.First!.Remove();
                    Nyelv nyelv = JsonConvert.DeserializeObject<Nyelv>(obj.ToString())!;
                    list.Add(nyelv);
                }
                return list;
            }
            
            if (arr.First.First.ToString().Contains("tanar_id"))
            {
                List<object> list = new();

                foreach (JObject obj in arr.Cast<JObject>())
                {
                    //obj.First!.Remove();
                    Tanar tanar = JsonConvert.DeserializeObject<Tanar>(obj.ToString())!;
                    list.Add(tanar); 
                }
                return list;
            }

            if (arr.First.First.ToString().Contains("tanitvany_id"))
            {
                List<object> list = new();

                foreach (JObject obj in arr.Cast<JObject>())
                {
                    //obj.First!.Remove();
                    Tanitvany tanitvany = JsonConvert.DeserializeObject<Tanitvany>(obj.ToString())!;
                    list.Add(tanitvany);
                }
                return list;
            }

            if (arr.First.First.ToString().Contains("alkalom_id"))
            {
                List<object> list = new();

                foreach (JObject obj in arr.Cast<JObject>())
                {
                    //obj.First!.Remove();
                    TanitasiAlkalom tanitasiAlkalom = JsonConvert.DeserializeObject<TanitasiAlkalom>(obj.ToString())!;
                    list.Add(tanitasiAlkalom);
                }
                return list;
            }

            return emptyList;
        }
    }
}
