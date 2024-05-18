using System;

class Program {
  public static void Main (string[] args) {
    //  Declaração das variaveis
    int qtd = 0, num = 0, u=0, d=0, c=0, m=0, num3e9 = 0, num2 = 0, num5 = 0;
    //estrutura de repetição para coleta dos números
    while (qtd<10){
      Console.WriteLine("Digite um número: ");
      num = int.Parse(Console.ReadLine());
      //Divir o número
      m = num/1000;
      c = (num%1000);
      d = (num%100);
      u = (num%10);
      //Verificão se é divisível por 3 e 9
      if(((m + c + d + u ) % 3 == 0) && ((m + c + d + u ) % 9 == 0)){
        num3e9++;
      }
      //Verificão se é divisível por 2
      if((u == 0) || (u == 2) || (u == 4) || (u == 6) || (u == 8)){
        num2++;
      }
      //Verificão se é divisível por 5
      if ((u == 0)|| (u == 5)){
        num5++;
      }
      qtd++;
    }
    //saída dos dados
    Console.WriteLine("Números divisíveis por 2: " + num2);
    Console.WriteLine ("Números divisíveis por 3 e 9: " + num3e9);
    Console.WriteLine("Números divisíveis por 5: " + num5);
  }
}
