﻿namespace c__A1;

public class For
{
    static void Main1(){
        // for(int i = 1; i<=10; i++){
        //     Console.WriteLine($"O valor de i é {i}");
        // }

        double somatorio = 0;
        string entrada;

        Console.WriteLine("informe o tamanho da turma: ");
        entrada =Console.ReadLine();
        int.TryParse(entrada, out int tamanhoTurma);

        for (int i = 1; i <=tamanhoTurma; i ++){
            Console.WriteLine("Informe a nota do aluno {0}", i);
            entrada = Console.ReadLine();
            double.TryParse(entrada,out double notaAtual);

            somatorio += notaAtual;
        }
        double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma:0;
        Console.WriteLine("Media da turma: {0}", media);
    }

}
