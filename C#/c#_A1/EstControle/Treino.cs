namespace c__A1;

public class Treino
{
 static void Main1 (){
    int resultado = 0;
    Console.WriteLine("Digite uma coluna: ");
    int numero = int.Parse(Console.ReadLine());

    while(numero != 0){
        resultado = resultado + numero;
        Console.WriteLine($"{resultado}");

        Console.WriteLine("Digite uma coluna: ");
        numero = int.Parse(Console.ReadLine());
            
    }
    }
 }

