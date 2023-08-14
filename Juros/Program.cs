while(!int.TryParse(Console.ReadLine(), out var value))
// while (true)
{
    var numParcelas = Convert.ToDouble(value);
    // Console.WriteLine("Taxa de juros:");
    // Console.WriteLine("Digite sair para sair.");
    // var input = (Console.ReadLine());
    // if (input == "sair") break;
    var taxaJurosMensal = System.Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Num. de parcelas:");
    Console.WriteLine("Valor do bem:");
    var valorBem = Convert.ToDouble(Console.ReadLine());

    taxaJurosMensal /=  100;

    double coeficiente = (taxaJurosMensal) / (1 - Math.Pow(1 + taxaJurosMensal, numParcelas * -1));
    double saida = coeficiente * valorBem * numParcelas;

    Console.WriteLine("Parcela: " + (saida / 4).ToString("F2"));
    Console.WriteLine("O total desse financiamento de " + numParcelas + " parcelas é " + saida.ToString("F2") + " reais, sendo " + (saida - valorBem).ToString("F2") + " de juros");
}