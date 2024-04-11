using System;

class Program {
  public static void Main (string[] args) {
    //declarar variáveis
    int veloMax=0; 
    double veloMotorista=0;
    //Entrada de dados
    Console.WriteLine ("Qual a velocidade máxima permitida? ");
    veloMax = int.Parse(Console.ReadLine());
    Console.WriteLine ("Qual a velocidade do motorista? ");
    veloMotorista = double.Parse(Console.ReadLine());
    //Processamento e saída de dados
    if(veloMotorista<=veloMax){
      Console.WriteLine("Motorista respeitou a lei");
    }
    else if(veloMotorista <= veloMax +10){
      Console.WriteLine("Multa de R$50,00");
    }
    else if(veloMotorista <= veloMax +30){
      Console.WriteLine( "Multa de R$100,00");
    }
    else{
      Console.WriteLine("Multa de R$200,00");
    }
    
  }
}