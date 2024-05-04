using System;

class Program {
    public static void Main(string[] args){
        //declaração das variáveis
        int num = 0,  p = 0, s = 0, t = 0, q = 0, soma = 0;
        //estrutura repetição para obtenção dos números
        for(int x = 1; x>= 0 ; x--){
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        //dividir as unidades e somar para verificação
       
        p = num % 100 / 10;
        s = num % 100 % 10;
        t = num % 1000 % 100 % 10;
        soma = p + s + t + q;
        Console.WriteLine("soma "+ soma);
       
        
        
        }






    }
}