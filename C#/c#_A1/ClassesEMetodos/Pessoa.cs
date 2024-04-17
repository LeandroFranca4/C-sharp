using System.Security.Cryptography.X509Certificates;

namespace c__A1;

class Pessoa
{
    static void Main1(){

        House house1 = new House();
        house1.Color= "Verde";
        house1.Address= " Rua vai toma no cu c#";
        house1.Idade = 26;

        //Console.WriteLine($"Cor da casa 1 {house1.Color} endrereço {house1.Address}");

            var fulano= new House();

            fulano.Color="Rosinha";
            fulano.Address="Sei la 2015";
            fulano.Idade=25;

            Console.WriteLine($"Cor do fulano {fulano.Color} e a idade dele é {fulano.Idade} e o outro besta tem {house1.Color} e a idade é {house1.Idade}");  


            

        }
    }





  





