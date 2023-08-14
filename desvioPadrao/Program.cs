namespace stats;
internal class Program
{
    public static void ShowOptions()
    {
        Console.WriteLine("Digite:");
        Console.WriteLine("0 Para finalizar");
        Console.WriteLine("1 Para adicionar novo número");
        Console.WriteLine("2 Para ver a lista dos números");
        Console.WriteLine("3 Para ver a média");
        Console.WriteLine("4 Para ver o desvio padrão");
    }
    private static void Main(string[] args)
    {
        Dados dados = new();
        if (args.Length < 1)
        {
            Console.WriteLine("É possível fornecer um ou mais números ao rodar o programa.");
            Console.WriteLine("Uso: dotnet run <numero1> <numero2> ...");
            // return;
        }
        else
        {
            for (int i = 0; i < args.Length; i++)
            {
                bool teste = int.TryParse(args[i], out var val);
                if (!teste)
                {
                    Console.WriteLine("Por favor forneça apenas valores numéricos na entrada.");
                    return;
                }
                dados.AddNumber(val);
            }
        }
        ShowOptions();
        while (int.TryParse(Console.ReadLine(), out var result))
        {
            switch (result)
            {
                case 0: return;
                case 1:
                    bool sucesso = int.TryParse(Console.ReadLine(), out var num);
                    if (!sucesso)
                    {
                        Console.WriteLine($"Conversão de '{num}' falhou.");
                        continue;
                    }
                    dados.AddNumber(num);
                    break;
                case 2:
                    Console.WriteLine(dados.ToString());
                    break;
                case 3:
                    Console.WriteLine("Média: " + dados.Average().ToString("N2"));
                    break;
                case 4:
                    Console.WriteLine("Desvio Padrão: " + dados.DesvioPadrao());
                    break;
                default: break;
            }
            ShowOptions();
        }
        // Dados dados = new();
        // for(int i = 0; i < 10;i++){
        //     dados.AddNumber(i);
        // }
        // Console.WriteLine(String.Join("\n",dados.numeros));
        //Console.WriteLine(estatistica.get(Entrada));
        // Console.WriteLine(dados.ToString());
    }
}