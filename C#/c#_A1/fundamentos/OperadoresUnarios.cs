namespace c__A1;

public class OperadoresUnarios
{
static void Main1(){
    var valorNegativo= -5;
    var numero1 = 2;
    var numero2 = 3;
    var booleano = true;
    Console.WriteLine(-valorNegativo);
    Console.WriteLine(!booleano);

    numero1++;
    Console.WriteLine(numero1);
    numero1--;
    Console.WriteLine(numero1); 

    Console.WriteLine(++numero1 == --numero2);
}
}
