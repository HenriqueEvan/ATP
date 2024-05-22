using System;

class Exercicio07 {
  public static void Exercicio7() {
      //declaração das variáveis
      int qtd = 0;
      //entrada de dados
      Console.WriteLine("Digite a quantidade de alunos: ");
      qtd = int.Parse(Console.ReadLine());
      //estrutura de repetição para ler as notas
      Nota(qtd);
    }

    public static void Nota(int qtd){
      //vetor para armazenar as notas
      double[] notas = new double[qtd];
      for (int i = 0; i < notas.Length; i++){
          Console.WriteLine("Digite a nota do {0} aluno: ", i + 1);
          notas[i] = double.Parse(Console.ReadLine());
          if(notas[i] <= 39){
            Console.WriteLine("Aluno {0}: F ", i + 1);
          }
          else if(notas[i] <= 59){
            Console.WriteLine("Aluno {0}: E ", i + 1);
          }
          else if(notas[i] <= 69){
            Console.WriteLine("Aluno {0}: D ", i + 1);
          }
          else if(notas[i] <= 79){
            Console.WriteLine("Aluno {0}: C ", i + 1);
          }
          else if(notas[i] <= 89){
             Console.WriteLine("Aluno {0}: B ", i + 1);
          }else{
             Console.WriteLine("Aluno {0}: A ", i + 1);
          }
        }
      
    }

    
}
