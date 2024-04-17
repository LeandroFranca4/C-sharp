using System.Globalization;

namespace c__A1;

public class Exe1
{
    static void Main1(){
        int dolar = 150;
        Console.WriteLine($"dolar $ {dolar}");
        CultureInfo cultura = new CultureInfo("pt-BR");
        Console.WriteLine(dolar.ToString("C1", cultura));





    }

}
