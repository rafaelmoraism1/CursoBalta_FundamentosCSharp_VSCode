namespace TextEditor;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Digite a opção desejada: ");
        Console.WriteLine("0 - Sair");
        Console.WriteLine("1 - Abrir Arquivo");
        Console.WriteLine("2 - Criar Novo Arquivo");
        short option = short.Parse(Console.ReadLine());

        switch (option)
        {
            case 0: System.Environment.Exit(0); break;
            case 1: Abrir(); break;
            case 2: Editar(); break;
        }

    }

    static void Abrir()
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho do arquivo:");

        string path = Console.ReadLine();

        using (var file = new StreamReader(path))
        {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }

        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void Editar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto. Tecle ESC para SAIR.");
        Console.WriteLine("---------------------------");
        string text = "";

        do
        {
            text += Console.ReadLine();   // Concatena o texto
            text += Environment.NewLine;   // Quebra de linha
        }
        while (Console.ReadKey().Key != ConsoleKey.Escape);   // Enquanto o usuário não apertar ESC não sai do laço

        Salvar(text);

    }
    static void Salvar(string text)
    {
        Console.Clear();
        Console.WriteLine("Digite o caminho:");

        var path = Console.ReadLine();

        using (var file = new StreamWriter(path))
        {
            file.Write(text);
        }
        Console.WriteLine($"Arquivo {path} salvo com sucesso!");
        Console.ReadLine();
        Menu();
    }
}