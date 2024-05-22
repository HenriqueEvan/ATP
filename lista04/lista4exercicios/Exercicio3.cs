using System;

class Exercicio03{
    public static void Exercicio3(){
      //declaração da variavel
      int n = 0;

      Console.WriteLine("Digite quantos conjuntos de números serão digitados: ");
      n = int.Parse(Console.ReadLine());
      //estrutura de repetição
      for (int i = 0; i < n; i++){
      
      //declaração das variáveis e entrada de dados
      Console.WriteLine("Digite um número");
      int num1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite um número");
      int num2 = int.Parse(Console.ReadLine());
      Console.WriteLine("Digite um número");
      int num3 = int.Parse(Console.ReadLine());
      int aux = 0;
      Vetor(ref num1, ref num2, ref num3, ref aux);
      Console.WriteLine(num1 + ", " + num2 + ", " + num3);
      }
    }
public static void Vetor(ref int num1, ref int num2, ref int num3, ref int aux) {

  //Assegurar que num1 seja maior que num2:
  if (num1 > num2) {
    aux = num1;
    num1 = num2;
    num2 = aux;
  }

  //Assegurar que num2 seja maior que num3:
  if (num2 > num3) {
    aux = num2;
    num2 = num3;
    num3 = aux;
  }

  //Assegurar novamente que num1 seja maior que num2:
  if (num1 > num2) {
    aux = num1;
    num1 = num2;
    num2 = aux;
  }

  
 }
  
}