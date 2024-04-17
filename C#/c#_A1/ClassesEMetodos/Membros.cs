namespace c__A1;




public class House{
   public string? Address;
   public string? Color;

   public int Idade;

   public string Apresentar(){
    return string.Format($"Olá! me chamo {Color} e tenho {Address} anos");
   }
    public void MostraAí(){
        Console.WriteLine(Apresentar());
    }
   }



