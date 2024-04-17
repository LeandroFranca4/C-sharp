namespace c__A1;

public class Switch
{

    static void Main1(){

        Console.WriteLine("Avalie meu atendimento com uma nota de 0 a 5:");
        int.TryParse(Console.ReadLine(), out int nota);

        switch (nota){
            case 0:
                Console.WriteLine("Péssimo");
                break;
            case 1:
                Console.WriteLine("Ruim");
                break;
            case 2:
                Console.WriteLine("Médio");
                break;
            case 3:
            Console.WriteLine("Bom");
                break;
            case 4:
            Console.WriteLine("Muito bom");
                break;
            case 5:
            Console.WriteLine("Sensacional");
                break;
        }
        Console.WriteLine("Fim!");



    }
    

}
