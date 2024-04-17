namespace c__A1;

public class OperadoresLogicos
{
    static void Main1(){
        var executouTrabalho1=true;
        var executouTrabalho2=true;
        //&& "E"
       var comprouTv50= executouTrabalho1 && executouTrabalho2;
       Console.WriteLine($"Comprou a Tv 50 {comprouTv50}");
        //|| "ou"
       var comprouSorvete = executouTrabalho1 || executouTrabalho2;
       Console.WriteLine($"Comprou sorvete {comprouSorvete}");
        //^ "ou" exclusivo, somente true se executou ao menos um dos dois
       var comprouTv32 =executouTrabalho1 ^ executouTrabalho2;
       Console.WriteLine($"ComprouTv de 32 {comprouTv32}");
        
    }

}
