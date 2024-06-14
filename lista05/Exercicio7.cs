using System;

public class Exercicio7
{
  public void Run()
  {
    //declaração da váriavel
    int[,] m = new int[5,5];
    //chamada de procedimento e exibição da Matriz para conferir
    PreencheMatriz(m);
    //saída dos dados e chamada de função
    Console.WriteLine("soma da Linha 4 de M: "+SomaLinha4(m));
    Console.WriteLine("soma da Coluna 2 de M: "+SomaColuna2(m));
    Console.WriteLine("soma da Diagonal Principal de M: "+SomaDiagonalPrincipal(m));
    Console.WriteLine("soma da Diagonal Secundária de M: "+SomaDiagonalSecundaria(m));
    Console.WriteLine("soma da Matriz M: "+SomaMatriz(m));
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
        Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
  } 
  //função para soma da linha 4 de M
  static int SomaLinha4(int[,] m)
  {
    int soma = 0;
    for(int i = 0; i < m.GetLength(1); i++)
      soma += m[4,i];
    return soma;
  }
  //função para soma da coluna 2 de M 
  static int SomaColuna2(int[,] m)
  {
    int soma = 0;
    for(int i = 0; i < m.GetLength(1); i++)
    soma += m[i,2];
    return soma;
  }
  //função para somar os elementos da diagonal principal 
  static int SomaDiagonalPrincipal(int[,] m)
  {
    int soma = 0;
    for(int i = 0; i < m.GetLength(1); i++)
    soma += m[i,i];
    return soma;
  }
  //função para somar os elementos da diagonal secundaria
  static int SomaDiagonalSecundaria(int[,] m)
  {
    int soma = 0, num = m.GetLength(0) - 1;
    for(int i = 0; i < m.GetLength(0); i++)
    soma += m[i,num - i];
    return soma;
  }
  //função para somar todos os elementos da matriz
  static int SomaMatriz(int[,] m)
  {
    int soma = 0;
    for(int i = 0; i < m.GetLength(0); i++)
    {
    for(int j = 0; j < m.GetLength(1); j++)
    soma += m[i,j];
    }
    return soma;
  }
}