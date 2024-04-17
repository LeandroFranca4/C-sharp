using System.Diagnostics.Contracts;
using System.Runtime.InteropServices;

namespace c__A1;

public class a2
{

    static void Main1(){

         Console.WriteLine("Digite cotação dolar: ");
         string ent = Console.ReadLine();
         double.TryParse(ent, out double Cotdolar);
         

         
         Console.WriteLine("Digite dolar: ");
         string entrada = Console.ReadLine();
         double.TryParse(entrada, out double dolar);
         

    
         double real= dolar * Cotdolar;

         Console.WriteLine($" cotação {Cotdolar}, quantos dolares {dolar}, em reais {real}") ;

         if (Cotdolar> 5){
            Console.WriteLine($"dolar alto pra crlh");
         }
         else{
            Console.WriteLine("até que a cotação está média");
         }







        
        
            
    }
        

}


