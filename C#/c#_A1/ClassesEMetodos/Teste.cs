namespace c__A1;

public class EquipeF1{

    public int NumeroP1;
    public int NumeroP2;

    public string? NomeP1;
    public string? NomeP2;


}

class EF1{
    static void Main1(){
        EquipeF1 Ferrari = new EquipeF1();

        Ferrari.NumeroP1= 16;
        Ferrari.NumeroP2= 55;
        Ferrari.NomeP1="Banco do Brasil";
        Ferrari.NomeP2="BRB";

        Console.WriteLine($"Numero do piloto 1: {Ferrari.NumeroP1}");

    
    }
}

