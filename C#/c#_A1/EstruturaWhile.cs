namespace c__A1;

public class EstruturaWhile
{
    static void Main1(){
        int palpite = 0;
        Random random = new Random();

        int numeroSecreto = random.Next(1,16);
        bool numeroEncontrado = false;
        int tentativasRestantes = 5;
        int tentativas = 0;


        while (tentativasRestantes > 0 && ! numeroEncontrado){
          Console.Write("Digite seu palpite: ");
          string entrada = Console.ReadLine();
          int.TryParse(entrada, out palpite);

          tentativas ++;
          tentativasRestantes--;

            if(numeroSecreto == palpite){
               numeroEncontrado = true;
               Console.WriteLine($"Numero encontrado em {tentativas}"); 
            }
            else if (palpite> numeroSecreto){
                Console.WriteLine("Menor...");
                Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
            }
            else {
                Console.WriteLine("Maior...");
                Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
            }
            

          
        }
        




    }
}
