using System;

class Program {
  public static void Main (string[] args) {
    double apli = 0, taxa = 0, rend = 0;
    int mes = 0;
    Console.WriteLine("Digite o valor da aplicação mensal:");
    apli = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a taxa de juros:");
    taxa = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o número de meses:");
    mes = int.Parse(Console.ReadLine());
    rend = apli * (Math.Pow(1 + taxa, mes) - 1 )/ taxa;
    Console.WriteLine("O rendimento é de: {0:f2}" , rend);
    
  }
}