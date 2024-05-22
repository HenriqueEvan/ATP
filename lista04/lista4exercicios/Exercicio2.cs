using System;

class Exercicio02{

  public static void Exercicio2(){
      //declaração das variáveis
      int numFilhos = 0 , numPessoas = 0 ;
      double salario = 0 , mediaSalario = 0 ;
      
      
      
       //saída de dados
       MediaPoupulacao(salario,numFilhos, ref mediaSalario, ref numPessoas);
       Console.WriteLine("Média salarial da População: " + (mediaSalario / numPessoas).ToString("F2")); 




    
  }
  public static void MediaPoupulacao(double salario, double numFilhos, ref double mediaSalario, ref int numPessoas){
      string flag = "";
      //estrutura de repetição para avaliar os salários
      do {
        
        Console.WriteLine("Digite o salário: ");
        salario = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o número de filhos: ");
        numFilhos = int.Parse(Console.ReadLine());
        Console.WriteLine("Deseja continuar? S/N");
        flag = Console.ReadLine().ToUpper();
        mediaSalario += salario;
        numPessoas++;
      }while(flag != "N");
  }
  
}