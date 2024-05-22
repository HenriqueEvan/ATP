using System;

class Exercicio09{
  public static void Exercicio9(){
      //declaração das variáveis
      double med = 0;
      int qtd = 0;
      //entrada de dados
      Console.WriteLine("Digite a quantidade de notas: ");
      qtd = int.Parse(Console.ReadLine());
      double [] notas = new double[qtd];
      med = Media(notas);
        if(med >= 6){
          Console.WriteLine("Média: {0:F2} Aprovado", med);
        }
        else {
          Console.WriteLine("Média: {0:F2} Reprovado", med);
        }
      
  }
  public static double Media(double[] notas){
      double media = 0;
      double [] vetor = notas;
      for(int i = 0; i < vetor.Length; i++){
        Console.WriteLine("Digite a {0}ª nota do aluno: ", i + 1);
        notas[i] = double.Parse(Console.ReadLine());
        media += notas[i];
      }
      return media = media / vetor.Length;
  }
}