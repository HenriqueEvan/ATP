using System;

class Program {
  public static void Main (string[] args) {
    // declaração das váriaveis
    int num1 = 0 , num2 = 0;
    // entrada de dados
    Console.WriteLine ("digite o primeiro numero");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine ("digite o segundo numero");
    num2 = int.Parse(Console.ReadLine());
    //estrutura de condição para verificar qual o maior numero 
    if(num1 > num2){
      Console.WriteLine("o maior numero é: "+ num1);   
    }
    else if (num2 > num1) {
      Console.WriteLine("o maior numero é: "+ num2);
    }
    else{
      Console.WriteLine("os numeros são iguais");
    }
  }
}