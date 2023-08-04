
string mensagem;
var num1 = Convert.ToInt32(Console.ReadLine());
mensagem = (num1%2) switch
{
    0 => "Par",
    _ => "Impar",
};

// switch(num1){
    //case 0: mensagem = "Par"; break;
    //default: mensagem = "Impar"; break; 
// }

Console.WriteLine(mensagem);
