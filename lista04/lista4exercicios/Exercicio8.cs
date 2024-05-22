using System;

class Exercicio08{
  
    public static void Exercicio8(){
        //criação das variáveis
        int num = 0;
        double s = 0;
        //entrada de dados
        Console.WriteLine("Digite um número: ");
        num = int.Parse(Console.ReadLine());
        //chamada de função
        s = CalculoS(num);
        //saída dos dados
        Console.WriteLine("O valor de S é: {0:f2}" , s);
    }
        //função para calcular o S
    public static double CalculoS(int num){
        double s = 0;
        s = (2/4) + (5/5) + (10/6) + (17/7) + (26/8) + (Math.Pow(num,2)+1)/(num+3);
        return s;
  }
}