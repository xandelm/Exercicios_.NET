using System.Dynamic;

namespace stats;
class Dados
{
    // private int[] inputs;
    // public int[] numeros{get; set;}
    public List<int> numeros
    { get; set; }

    public Dados()
    {
        numeros = new List<int>();
    }

    public Dados(List<int> numeros)
    {
        this.numeros = numeros;
    }

    public void AddNumber(int number)
    {
        numeros.Add(number);
    }

    public double Average()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
            return 0;
        }
        double saida;
        saida = numeros.Sum()/(double)numeros.Count;
        return saida;
    }

    public double DesvioPadrao()
    {
        if (numeros.Count == 0)
        {
            Console.WriteLine("A lista está vazia.");
            return 0;
        }
        double avg = this.Average();
        double sum = 0;
        foreach (int number in numeros)
        {
            sum += Math.Pow(Math.Abs(number - avg), 2);
        }

        return Math.Sqrt(sum / numeros.Count);

    }
    public void PrintNumeros()
    {
        Console.WriteLine(String.Join("\n", this.numeros));
    }

    public override string ToString()
    {
        string saida = "";
        for (int i = 0; i < this.numeros.Count; i++)
        {
            saida += String.Join("\n", "numero[" + i + "]" + " = " + this.numeros[i] + "\n");
        }
        return saida;
    }
    public bool Existe(int chave)
    {
        if (this.numeros.Contains(chave)) return true;
        return false;
    }
}