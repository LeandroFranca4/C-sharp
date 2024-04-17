 namespace c__A1;

public class OperadoresAritmeticos
{
    static void Main1(){

        //Preço Desconto
        var preco = 1000.0;
        var imposto = 355;
        var desconto = 0.1;

        double total= preco + imposto;
        var totalComDesconto = total - (total * desconto);
        Console.WriteLine($"O valor do desconto é {totalComDesconto}");

        //IMC
        double altura= 1.80;
        double peso= 85.3;
        //Math.Pow é a potência, primeiro a base, depois, expoente
        double imc = peso / Math.Pow(altura,2);
        Console.WriteLine($"Sua altura é :{altura}, seu peso: {peso} e seu imc é {imc}");

        //Número par/Impar
        int par = 22;
        int impar = 55;
        Console.WriteLine($"par= {par%2}");
        Console.WriteLine($"Impar={impar%2}");

        
    }

}
