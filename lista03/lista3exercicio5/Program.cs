using System;

class Program {
    public static void Main(string[] args){
        //declaração das variáveis
        int num =0; 
        double fatorial = 1, e =1;
        //entrada de dados
        Console.WriteLine("Digite um número");
        num = int.Parse(Console.ReadLine());
        if(num >=0){
        //estrutura de repetição para calculo
        for(int i= 1; i <= num; i++){
            //regra de calculo do fatorial
            fatorial *= i;
            //regra de calculo de E
             e += 1.0 / fatorial;
        }
        Console.WriteLine("O valor de {0:f2} é: " , e); 
    }
        else{
        Console.WriteLine("Número é inválido"); 
        }

    }
}