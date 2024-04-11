using System;

class Program {
  public static void Main (string[] args) {
    double alt=0,bas=0,area=0,dia=0,per=0;
    Console.WriteLine("Digite a altura do retângulo: ");
    alt=double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a base do retângulo: ");
    bas=double.Parse(Console.ReadLine());
    area= Math.Sqrt(Math.Pow(alt,2) * Math.Pow(bas,2));
    Console.WriteLine("A area do retângulo é: "+area);
    dia= Math.Sqrt(Math.Pow(alt,2) + Math.Pow(bas,2));
    Console.WriteLine("O diametro do retângulo é: "+ dia);
    per = (2 * alt) + (2 * bas);
    Console.WriteLine("O perimetro do retângulo é: "+ per);
    
  }
}