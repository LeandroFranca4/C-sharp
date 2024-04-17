namespace c__A1;

public class ElseIf
{
    static void Main1()
    {

        Console.Write("Digite a nota do aluno ");
        string entrada = Console.ReadLine();
        double.TryParse(entrada, out double nota);

        if (nota >= 9)
        {
            Console.WriteLine("Quadro de honra!");
        }
        else 
        if (nota >= 7 )
        {
            Console.WriteLine("aprovado");
        }
        else 
        if (nota <= 6 && nota >=5 )
        {
            Console.WriteLine("Foi por pouco, precisa melhorar");
        }
        else {
            Console.WriteLine("Repetiu KJJAJAJAJAHAHHAHA");
        }
    }
}







