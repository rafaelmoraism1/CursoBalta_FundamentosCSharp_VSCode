namespace ManipulandoMoedas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Trabalhando com tratamento e formatação de valores monetários
            Console.Clear();
            decimal converterParaReal = 50567.50m;
            decimal converterParaDollar = 50.50m;
            decimal converterParaEuro = 50.50m;

            // Utilizando "C" de Currency - Moeda em Inglês
            Console.WriteLine("Real - " + converterParaReal.ToString(
                "C", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine("---------------");

            Console.WriteLine("Dóllar - " + converterParaDollar.ToString(
                "C", System.Globalization.CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine("---------------");

            Console.WriteLine("Euro - " + converterParaEuro.ToString(
                "C", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES")));
            Console.WriteLine("---------------");

            // Utilizando "P" para Porcentagem
            Console.WriteLine("Real - " + converterParaReal.ToString(
                "P", System.Globalization.CultureInfo.CreateSpecificCulture("pt-BR")));
            Console.WriteLine("---------------");

            // Utilizando "Ceiling e Floor" Teto e Chão em Inglês para arredondar
            Console.WriteLine(Math.Ceiling(converterParaReal));
            Console.WriteLine("---------------");

            Console.WriteLine(Math.Floor(converterParaReal));
            Console.WriteLine("---------------");
        }


    }
}