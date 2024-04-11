using System;

class Program {
  public static void Main (string[] args) {
    int dias = 0;
    int meses = 0;
    int anos = 0;
    Console.WriteLine("informe numero de dias sem acidentes");
    dias = int.Parse(Console.ReadLine());
    anos = dias / 365;
    meses = dias % 365 / 30;
    dias = dias % 365 % 30;
    Console.WriteLine("{0} anos, {1} meses, {2} dias", anos, meses, dias);
    
  }
}