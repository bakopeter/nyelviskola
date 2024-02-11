using NyelviskolaCL.Models;

namespace NyelviskolaCL
{
    public class DBExporterService
    {
        private static NyelviskolaContext ctx = new();
        public static string[,] Export(List<object> list)
        {
            string[,] messages = new string[2, 100];

            if (list != null && list.Exists(obj => obj.GetType() == typeof(Nyelv)))
            { return UploadNyelv(list); }

            if (list != null && list.Exists(obj => obj.GetType() == typeof(Tanar)))
            {  return UploadTanar(list); }

            if (list != null && list.Exists(obj => obj.GetType() == typeof(Tanitvany)))
            { return UploadTanitvany(list); }

            if (list != null && list.Exists(obj => obj.GetType() == typeof(TanitasiAlkalom)))
            { return UploadTanitasiAlkalom(list); }

            return messages;
        }

        public static string[,] UploadNyelv(List<object> list)
        {
            var nyelvek = ctx.Nyelvek;
            string[,] messages = new string[2, 100];
            int i = 0; int j = 0;

            foreach (Nyelv obj in list.Cast<Nyelv>())
            {
                if (!nyelvek.ToList().Exists(ny => ny.Nyelvnev == obj.Nyelvnev))
                {
                    nyelvek.Add(obj);
                    messages[0, i] = $"{obj.Nyelvnev}"; i++;
                }
                else { messages[1, j] = $"{obj.Nyelvnev}"; j++; }
            }
            ctx.SaveChanges();
            return messages;
        }

        public static string[,] UploadTanar(List<object> list)
        {
            var tanarok = ctx.Tanarok;
            string[,] messages = new string[2, 200];
            int i = 0; int j = 0;

            foreach (Tanar obj in list.Cast<Tanar>())

            {
                if (!tanarok.ToList().Exists(ny => ny.Email == obj.Email))
                {
                    tanarok.Add(obj);
                    messages[0, i] = $"{obj.Email}"; i++;
                }
                else { messages[1, j] = $"{obj.Email}"; j++; }
            }
            ctx.SaveChanges();
            return messages;
        }

        public static string[,] UploadTanitvany(List<object> list)
        {
            var tanitvanyok = ctx.Tanitvanyok;
            string[,] messages = new string[2, 300];
            int i = 0; int j = 0;

            foreach (Tanitvany obj in list.Cast<Tanitvany>())
            {
                if (!tanitvanyok.ToList().Exists(ny => ny.Email == obj.Email))
                {
                    tanitvanyok.Add(obj);
                    messages[0, i] = $"{obj.Email}"; i++;
                }
                else { messages[1, j] = $"{obj.Email}"; j++; }
            }
            ctx.SaveChanges();
            return messages;
        }

        public static string[,] UploadTanitasiAlkalom(List<object> list)
        {
            var tanitasiAlkalmak = ctx.TanitasiAlkalmak;
            string[,] messages = new string[2, 600];
            int i = 0; int j = 0;

            foreach (TanitasiAlkalom obj in list.Cast<TanitasiAlkalom>())
            {
                if (!tanitasiAlkalmak.ToList().Exists(ny => 
                    ny.TanarId == obj.TanarId && ny.TanitvanyId == obj.TanitvanyId 
                    && ny.Datum == obj.Datum && ny.Kezdesido == obj.Kezdesido))
                {
                    tanitasiAlkalmak.Add(obj);
                    messages[0, i] = $"{obj.Datum}. {obj.Kezdesido}"; i++;
                }
                else { messages[1, j] = $"{obj.Datum}. {obj.Kezdesido}"; j++; }
            }
            ctx.SaveChanges();
            return messages;
        }
    }
}
