namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("s = segundos (10s -> 10 segundos)");
            Console.WriteLine("m = minutos (1m -> 1 minuto)");
            Console.WriteLine("Quanto tempo de desejar contar?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            //criou um tipo único e utilizou o Substring para selecionar oq o usuário digitou.
            //data.length pega o último caracter que o usuário digitou.       

            int multiplicador = 1;

            if (type == 'm')
                multiplicador = 60;

            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplicador);

        }

        static void PreStart(int time)
        {
            Console.WriteLine("Already...");
            Thread.Sleep(1500);
            Console.WriteLine("Set...");
            Thread.Sleep(1500);
            Console.WriteLine("Gooooo...");
            Thread.Sleep(1500);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            //Versão Crescente
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            //Versão Descrescente
            // while (time != currentTime)
            // {
            //     Console.Clear();
            //     Console.WriteLine(time);
            //     time--;
            //     Thread.Sleep(1000);
            // }

            Console.Clear();
            Console.WriteLine("Finalizando StopWatch");
            Thread.Sleep(2500);
            Menu();
        }

    }
}