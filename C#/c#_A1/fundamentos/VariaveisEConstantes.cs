namespace c__A1;

class VariaveisEConstantes
{
        static void Main1(){
        //area da circunferencia
        double raio = 4.0;
        const double PI= 3.14;

        raio=5.5;
        //PI=3.1415;

        double area = PI * raio * raio;
        Console.WriteLine(area);
        Console.WriteLine("Área é  " + area);

        //Tipos internos

        bool estaChovendo= true;
        Console.WriteLine("Está chovendo " + estaChovendo);

        double populacaoBrasil= 220_600_00;
        Console.WriteLine("A população do Brasil é "+ populacaoBrasil);



 
 }
}
