using System;
using System.Text;

class Exercicio05{

    public static void Exercicio5(){
        //criação das variáveis
        int a =0, b=0;
        //entrada de dados
        Console.WriteLine("Este programa permite calcular o MDC");
        Console.WriteLine("Informe o primeiro número: ");
        a = int.Parse(Console.ReadLine());
 
        Console.WriteLine("Informe o segundo número: ");
        b = int.Parse(Console.ReadLine());
        //saída dos dados
        Console.WriteLine("O Máximo Divisor Comum de "+ a + " e " + b + " é " + MDC(a,b) );
 
 
    }    
        // função para calcular o MDC
    public static int MDC(int a, int b){
        int resto = 0;
            while(b != 0){
            resto = a % b;
            a = b;
            b = resto;
        }
        return a;
    }

}