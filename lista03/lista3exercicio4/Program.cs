using System;

class Program {
    public static void Main(string[] args){
        //declaração das variáveis
        int num =0 , fatorial = 1;
        //entrada de dados
        Console.WriteLine("Digite um número");
        num = int.Parse(Console.ReadLine());
        if(num >=0){
        //estrutura de repetição para calculo
        for(int i= num; i>= 1; i--){
            fatorial *= i;
        }
        Console.WriteLine("Fatorial de {0}: é {1}", num, fatorial); 
    }
        else{
        Console.WriteLine("Número é inválido"); 
        }


    }
}

