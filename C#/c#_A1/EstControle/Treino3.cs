namespace c__A1;

public class Treino3
{

    static void Main1(){
        Console.WriteLine("Jogado desafiante");
        Console.WriteLine("Digite um número de 0 a 9: ");
        int numero = int.Parse(Console.ReadLine());
        while (numero > 9){
            Console.WriteLine("Errado, Digite um número de 0 a 9: ");
            numero = int.Parse(Console.ReadLine());
            }

        Console.WriteLine("Jogado desafiado");
        Console.WriteLine("descubra um número de 0 a 9: ");
        int valor = int.Parse(Console.ReadLine());
        while (valor > 9){
            Console.WriteLine("Errado, Digite um número de 0 a 9: ");
            valor = int.Parse(Console.ReadLine());
                    }

            while(valor != numero){
                Console.WriteLine("Informe outro valor: ");
                valor = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("acertou");
    }

}
