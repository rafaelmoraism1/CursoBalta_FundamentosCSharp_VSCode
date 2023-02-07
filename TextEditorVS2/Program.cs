namespace TextEditorVS2;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Digite a opção desejada. Tecle ESC para SAIR.");
        Console.WriteLine("1 - Abrir Arquivo;");
        Console.WriteLine("2 - Criar Novo Arquivo;");
        Console.WriteLine("0 - Sair e Salvar;");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Abrir(); break;
            case 2: Editar(); break;
            case 0: System.Environment.Exit(0); break;
        }
    }

    static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Digite o caminha do arquivo:");
        Console.WriteLine("-----------------------------");

        string path = Console.ReadLine();

        using (var arquivo = new StreamReader(path))
        {
            string texto = arquivo.ReadToEnd();
            Console.Write(texto);
        }
        Console.WriteLine("");
        Console.ReadLine();
        Menu();

    }

    static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto:");
        Console.WriteLine("-------------------------");
        var texto = "";

        do
        {
            texto += Console.ReadLine();
            texto += Environment.NewLine;
        }

        while (Console.ReadKey().Key != ConsoleKey.Escape);

        Salvar(texto);
    }

    static void Salvar(string texto)
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho onde o arquivo será salvo:");
        Console.WriteLine("-----------------------------------------------");

        var path = Console.ReadLine();

        using (var arquivo = new StreamWriter(path))
        {
            arquivo.Write(texto);
        }

        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.WriteLine("Tecle ENTER para retonar ao MENU");
        Console.ReadLine();
        Menu();
    }
}