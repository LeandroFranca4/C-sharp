namespace c__A1;

public class OperadoresRelacionais
{

    static void Main1(){
        //double nota =10;
        Console.Write("Digite sua nota:");
        double.TryParse(Console.ReadLine(), out double nota);
        double notaDeCorte = 7.0;
        Console.WriteLine($"Nota inválida? (maior que 10) {nota > 10.0}");
        Console.WriteLine($"Nota iválida?(menor que 0) {nota < 0}");
        Console.WriteLine($"nota máxima {nota == 10}");
        Console.WriteLine($"Passou {nota>notaDeCorte}");
        Console.WriteLine($"Recuperação {nota < notaDeCorte}");
        Console.WriteLine($"Tem como melhorar?{nota!=10}");
        
        
    }

}
