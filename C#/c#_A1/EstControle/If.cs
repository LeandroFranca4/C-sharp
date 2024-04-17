namespace c__A1;

public class If
{

    static void Main1()
    {
        string entrada;


        Console.WriteLine("Digite linha excel: ");
        entrada = Console.ReadLine(); // entrada recebe Console.WriteLine("Digite linha excel: "); ^
        int.TryParse(entrada, out int nota);


        Console.WriteLine($"Excel {nota}");

        if (nota>8){
            Console.WriteLine("Uauuuu");
        }
        else{
            Console.WriteLine("Que bosta");
        }



    }

}
