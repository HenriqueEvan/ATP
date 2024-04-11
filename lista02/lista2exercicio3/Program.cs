using System;

class Program {
  public static void Main (string[] args) {
    //declaração de váriaveis
    int a = 0, x= 0, b = 0;

    // entrada de dados
    Console.WriteLine("Digite o valor de A: ");
    a = int.Parse(Console.ReadLine());
    // processamento da Raiz
    if(a != 0){
    Console.WriteLine("Digite o valor de B: ");
    b = int.Parse(Console.ReadLine());
    x =  - b / a;
      //saída de dados
    Console.WriteLine("o valor de x é: " + x);
    }
    else{
    Console.WriteLine("A equação não possui raiz");
    }
  }
}