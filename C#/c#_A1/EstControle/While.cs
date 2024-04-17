namespace c__A1;

public class While
{
    static void Main1()
    {
        int palpite = 0;
        Random random = new Random();

        int numeroSecreto = random.Next(1, 16);
        bool numeroEncontrado = false;
        int tentativasRestantes = 5;
        int tentativas  = 0;

        while (tentativasRestantes > 0 && !numeroEncontrado)
        {
            Console.WriteLine("Insira seu palpite: ");
            string entrada = Console.ReadLine();
            int.TryParse(entrada, out palpite);

            tentativas ++;
            tentativasRestantes --;

            if (numeroSecreto == palpite){
                numeroEncontrado = true;
                Console.WriteLine("Acertou!");}

            
            


        }
    }

}
