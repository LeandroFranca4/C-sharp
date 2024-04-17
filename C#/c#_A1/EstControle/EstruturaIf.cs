namespace c__A1;

public class EstruturaIf
{
    static void Main1(){
        bool bomComportamento = false;
        string entrada;

        Console.Write("Digite a nota do aluno");
        entrada = Console.ReadLine();
        double.TryParse(entrada, out double nota);

        Console.WriteLine("Possui bom comportamentro?(S/N): ");
        entrada = Console.ReadLine();

        if (entrada =="S" || entrada == "s")
            bomComportamento = true;

        if (nota >= 9.0 && bomComportamento)
        Console.WriteLine("BOOOOOA");
            
            Console.WriteLine(bomComportamento);
            Console.WriteLine($"A nota foi {nota}");
      
            //Estrutura de controle não tem ponto e vírgula
    }



}

