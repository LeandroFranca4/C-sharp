using System.Globalization;

namespace c__A1;

public class FormatandoNumeros
{
    static void Main1(){
        double valor= 15.175;
        //casa decimal
        Console.WriteLine(valor.ToString("F2"));
        //valor monetário
        Console.WriteLine(valor.ToString("C"));
        //Percentual
        Console.WriteLine(valor.ToString("P"));

        CultureInfo cultura = new CultureInfo("en-US");
        Console.WriteLine(valor.ToString("C0", cultura));
        
        int inteiro= 256;
        Console.WriteLine(inteiro.ToString("D10"));
            }

}
