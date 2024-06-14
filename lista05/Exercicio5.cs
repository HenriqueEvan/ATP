using System;

public class Exercicio5{
  public void Run(){
    //declaração das variáveis
    int[] vetor = new int[3];
    int tentativa = 0, chance =0;
    //função para sortear numero diferente nas posições do vetor
    PreencheVetor(vetor);
    //condição para verificar se o numero digitado é igual ao sorteado
    while(chance != vetor[0] && chance != vetor[1] && chance != vetor[2])
    {
    Console.WriteLine("Digite um número entre 10 e 49 para tentar acertar: ");
    chance = int.Parse(Console.ReadLine());
      if(chance == vetor[0])
       Console.WriteLine("Você acertou o número: "+vetor[0]+" entre os 3 números sorteados acertou o: 1º");
      else if(chance == vetor[1])
       Console.WriteLine("Você acertou o número: "+vetor[1]+" entre os 3 números sorteados acertou o: 2º");
      else if(chance == vetor[2])
       Console.WriteLine("Você acertou o número: "+vetor[2]+" entre os 3 números sorteados acertou o: 3º");
      //conta o número de tentativas e exibe
      tentativa++;
      Console.WriteLine(" Número de tentativas: "+tentativa);
      }
    
  }
  //Procedimento para preencher o vetor
  static int[] PreencheVetor(int[] vetor)
  {

      Random r = new Random();
      int sor = 0;
      // condição para não repetir os numeros
      for (int i = 0; i < vetor.Length; i++)
      {
          sor = r.Next(10, 50);
          if (!Existe(vetor, sor))
          {
              vetor[i] = sor;
              
          }
          else
              i--;
      }
    return vetor;
  }
  //metodo para sortear numero diferene nas posições do vetor
  static bool Existe(int[] x, int n)
  {
      for (int i = 0; i < x.Length; i++)
      {
          if (x[i] == n) return true;
      }
      return false;

  }
}