using System;

class Program {
  public static void Main (string[] args) {
    double salaMin = 0, qtdKw = 0, valorKw = 0, valorPago = 0, ValorDesconto = 0;
    
    Console.WriteLine("Digite o valor do salário mínimo:");
    salaMin = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a quantidade de quilowatts gasta: ");
    qtdKw = double.Parse(Console.ReadLine());
    valorKw = salaMin / 7 / 100;
    valorPago = qtdKw * valorKw;
    ValorDesconto = valorPago - valorPago * 0.1;
    Console.WriteLine("Valor de cada quilowatt: R$ {0:f2}" , valorKw);
    Console.WriteLine("Valor a ser pago: R$ {0:f2}" , valorPago);
    Console.WriteLine("Valor com desconto: R$ {0:f2}" , ValorDesconto);  
  }
}