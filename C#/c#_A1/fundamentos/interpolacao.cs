namespace c__A1;

public class Interpolacao
{
    static void Main1(){
        string nome = "Notebook Gamer";
        string marca = "pichau";
        double valor = 7800.00;
        //Concatenação
        Console.WriteLine("O " + nome + " da marca " + marca + " custa " + valor);
        //Interpolação
        Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, valor);
        //Outra forma de printar código
        Console.WriteLine($"O nome da marca {marca} é muito toperson");
        }
}
