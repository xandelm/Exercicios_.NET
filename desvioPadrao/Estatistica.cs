using System.Dynamic;

namespace stats;
class Estatistica{
    // private int[] inputs;
    // public int[] entrada{get; set;}
    public List<int> Entrada 
        {get;set;}

    public Estatistica(List<int> entrada){
        this.Entrada = entrada;
    }

    public void AddNumber(int number){
        Entrada.Add(number);
    }
    
    public int Average(){
        return Entrada.Sum()/ Entrada.Count;
    }

    public double DesvioPadrao(){
        int avg = this.Average();
        double sum=0;
        foreach(int number in Entrada){
            sum += Math.Pow(Math.Abs(number-avg),2);
        }
        
        return Math.Sqrt(sum/Entrada.Count);

    }




}