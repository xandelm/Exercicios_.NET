var n = (System.Convert.ToInt32(Console.ReadLine()));
int input;
Random aleatorio = new Random();
int sorteado = aleatorio.Next(n);
int tentativas = Convert.ToInt32(Math.Log2(n));
// Console.WriteLine(n);
// Console.WriteLine(sorteado);
Console.WriteLine("Você tem "+ tentativas+1+" tentativas!");
int contador = 0;
while(int.TryParse(Console.ReadLine(), out input)){
    contador++;
    if(contador>tentativas+1){
        Console.WriteLine("Você atingiu o limite de tentativas.");
    }
    if(input == sorteado){
        Console.WriteLine("Acertou!"); break;
    }
    else if(sorteado > input){
        Console.WriteLine("maior");
        continue;
    }
    else{
        Console.WriteLine("menor");
        continue;
    }
}