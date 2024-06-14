using System;

public class Exercicio8{
  public void Run(){
    //declaração das variáveis
    int[,] m = new int[4,4];
    //chamada de procedimento e exibição da Matriz para conferir
    PreencheMatriz(m);
    Console.WriteLine("Soma dos elementos abaixo Diagonal Principal de M: "+SomaAbaixoDiagonalPrincipal(m));
  }
  //procedimento para preencher a matriz
  static void PreencheMatriz(int[,] m)
  {
    //instancia de objeto para sortear numeros
    Random r = new Random();
    Console.WriteLine("Matriz M");
    //estrutura de repetição para matriz
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        m[i,j] = r.Next(1,10);
        //Exibição da matriz
        Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
  }
  //procedimento para somar os elementos abaixo da diagonal principal
  static int SomaAbaixoDiagonalPrincipal(int[,] m)
  {
    //declaração das variáveis
    int soma = 0;
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
      if(i>j)
        soma +=m[i,j]; 
      }
    }
    //Saída dos dados
    return soma;
  }
}