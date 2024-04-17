using System.Runtime.InteropServices;

namespace c__A1;

public class NotacaoPonto
{
    static void Main2(){
        var saudacao= "OLÁ ".ToLower().Insert(2, "World").Replace("World","Mundo");
        Console.WriteLine(saudacao);

        Console.WriteLine ("Teste".Length);

        string valorImportante = "Olá"; 
        Console.WriteLine(valorImportante);
    }

}
