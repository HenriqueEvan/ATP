using System;

class Program {
  public static void Main (string[] args) {
    double x1 = 0, x2 =0, y1 = 0, y2 = 0, dista = 0;
    Console.WriteLine("Digite os valores do primeiro ponto");
    x1 = double.Parse(Console.ReadLine());
    y1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite os valores do Segundo ponto");
    x2 = double.Parse(Console.ReadLine());
    y2 = double.Parse(Console.ReadLine());
    dista = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine("A distância entre os pontos é: {0:f2} " , dista);
    
  }
}