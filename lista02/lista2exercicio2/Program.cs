using System;

class Program {
  public static void Main (string[] args) {
    //declaração de variaveis
    int num1=0, num2=0, soma=0;

    //entrada de dados
    Console.Write("Digite o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o segundo número: ");
    num2 = int.Parse(Console.ReadLine());
    //verificação de qual valor da váriavel
     soma = num1+ num2;
    if(soma >=10){
      soma = soma + 5;
    }else{
      soma = soma + 7;
    }
    //saida de dados
    Console.WriteLine("O resultado é:" + soma);
    
  }
}