using System;

class Program {
  public static void Main (string[] args) {
    //declaração das variáveis
    double x=0, y=0;

    //Entrada de dados
    Console.WriteLine ("digite o valor de X:");
    x = double.Parse(Console.ReadLine());

    //Processamento formula para calcular o valor de Y
    if(x<=1){
      y=1;
    }
    else if(x<=2){
      y=2;
    }
    else if(x<=3){
      y=Math.Pow(x,2);
    }
    else{
      y=Math.Pow(x,3);
    }

    //Saída de dados
    Console.WriteLine("O valor de Y é: {0:0.00} ", y);
    
  }
}