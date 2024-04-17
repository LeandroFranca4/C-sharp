namespace c__A1;

public class DoWhile
{
    static void Main1()
    {
        string entrada;


        do
        {
            Console.WriteLine("Digite um nome:");
            entrada = Console.ReadLine();

            Console.WriteLine($"Bem vindo {entrada}");
            Console.WriteLine("Deseja continuar? s/n ");
            entrada = Console.ReadLine();
        } while (entrada.ToLower()== "s");




}


}
