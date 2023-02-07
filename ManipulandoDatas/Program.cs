namespace ManipulandoDatas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            var data = DateTime.Now; // Mostra a data atual
            Console.WriteLine(data);
            Console.WriteLine("");
            // Console.WriteLine(data.Year); // Mostra Ano
            // Console.WriteLine(data.Month); // Mostra Mês
            // Console.WriteLine(data.Day); // Mostra Dia
            // Console.WriteLine(data.Hour); // Mostra Hora
            // Console.WriteLine(data.Minute); // Mostra Minutos
            // Console.WriteLine(data.Second); // Mostra Segundos
            // Console.WriteLine(data.Second); // Mostra Segundos
            // Console.WriteLine(data.DayOfWeek); // Mostra o dia da semana
            // Console.WriteLine(data.DayOfYear); // Mostra o dia do ano

            var dataFormatada1 = string.Format("{0:yyyy/MM/dd}", data); // formatando a data
            Console.WriteLine(dataFormatada1);
            Console.WriteLine("");

            var dataFormatada2 = string.Format("{0:t}", data); // Mostra hora curta
            Console.WriteLine(dataFormatada2);
            Console.WriteLine("");

            var dataFormatada3 = string.Format("{0:T}", data); // Mostra hora completa
            Console.WriteLine(dataFormatada3);
            Console.WriteLine("");

            var dataFormatada4 = string.Format("{0:d}", data); // Mostra data curta
            Console.WriteLine(dataFormatada4);
            Console.WriteLine("");

            var dataFormatada5 = string.Format("{0:D}", data); // Mostra data com definições completas
            Console.WriteLine(dataFormatada5);
            Console.WriteLine("");

            var dataFormatada6 = string.Format("{0:f}", data); // Mostra data e hora completos com definições
            Console.WriteLine(dataFormatada6);
            Console.WriteLine("");

            var dataFormatada7 = string.Format("{0:g}", data); // Mostra data e hora reduzidos
            Console.WriteLine(dataFormatada7);
            Console.WriteLine("");

            var dataFormatada8 = string.Format("{0:r}", data); // Mostra data e hora já no padrão dos sistemas
            Console.WriteLine(dataFormatada8);
            Console.WriteLine("");

            var dataFormatada9 = string.Format("{0:s}", data); // Mostra data e hora. Utilizado em Json e front end
            Console.WriteLine(dataFormatada9);
            Console.WriteLine("");

            var dataFormatada10 = string.Format("{0:u}", data); // Mostra data e hora. Utilizado em MongoDB
            Console.WriteLine(dataFormatada10);
            Console.WriteLine("");
            //
            //

            Console.WriteLine(data.AddDays(5)); // soma dias a data estipulada
            Console.WriteLine(data.AddMonths(2)); // soma meses a data estipulada
            Console.WriteLine(data.AddYears(3)); // soma anos a data estipulada
            Console.WriteLine("");

            //
            //
            // Utilizando CultureInfo
            var portugues = new System.Globalization.CultureInfo("pt-BR");
            var ingles = new System.Globalization.CultureInfo("en-US");
            var dinamarques = new System.Globalization.CultureInfo("de-DE");

            Console.WriteLine(DateTime.Now.ToString("D", portugues));
            Console.WriteLine(DateTime.Now.ToString("D", ingles));
            Console.WriteLine(DateTime.Now.ToString("D", dinamarques));
            Console.WriteLine("");

            //
            //
            //Utilizando Time zone e data Utc
            var dataUtc = DateTime.UtcNow; // Formato puro. Data e hora Global
            Console.WriteLine("UTC - " + " " + dataUtc);
            Console.WriteLine("-------------");

            var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
            Console.WriteLine("Time Zone Austrália -" + " " + timezoneAustralia);
            Console.WriteLine("-------------");

            //
            //
            // Convertendo dateTime
            var converteHora = TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezoneAustralia);
            Console.WriteLine("Time Zone Austrália Convertida - " + " " + converteHora);
            Console.WriteLine("-------------");

            //
            //
            // Listando Todas as TimeZones no sistema

            var timezones = TimeZoneInfo.GetSystemTimeZones();

            foreach (var timezone in timezones)
            {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUtc, timezone));
                Console.WriteLine("-------------");
            }

            //
            //
            // TimeSpan
            // Estudar sobre TimeSpan

        }
    }
}