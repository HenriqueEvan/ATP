using System;

class Program {
  public static void Main (string[] args) {
    double a = 0,  b = 0;
    Console.WriteLine("digite o priemiro valor A: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("digite o segundo valor B: ");
    b = double.Parse(Console.ReadLine());
    a = a + b; 
    b = a - b;
    a = a - b;
    Console.WriteLine("o valor de A é {0:0.00} e o valor de B é {1:0.00}" , a, b);
  }
}