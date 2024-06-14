using System;

public class Exercicio9
{
  public void Run()
  {
    //declaração das variáveis
    int[,] a = new int[4,6];
    int[,] b = new int[4,6];
    int[,] s = new int[4,6];
    int[,] d = new int[4,6];
    //chamada de procedimento e exibição da Matriz para conferir
    Console.WriteLine("Matriz A");
    PreencheMatriz(a);
    Console.WriteLine("Matriz B");
    PreencheMatriz(b);
    //chamada de função de soma das matrizes
    Console.WriteLine("Matriz S");
    SomaMatriz(a,b);
    //chamada de função de diferença das matrizes
    Console.WriteLine("Matriz D");
    DiferencaMatriz(a,b);
    
  }
  //procedimento para preencher a matriz
  static void PreencheMatriz(int[,] m)
  {
    //instancia de objeto para sortear numeros
    Random r = new Random();
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
  //função para somar as matrizes A e B guardando em S
  static int[,] SomaMatriz(int[,] a, int[,] b)
  {
    //declaração das variáveis
    int[,] s = new int[4,6];
    //estrutura de repetição para matriz
    for(int i = 0; i < s.GetLength(0); i++)
    {
      for(int j = 0; j < s.GetLength(1); j++)
      {
        s[i,j] = a[i,j] + b[i,j];
        Console.Write(s[i,j]+"\t");
      }
      Console.WriteLine();
    }
    return s;
  }
  //função de diferença das matrizes A e B guardando em D
  static int[,] DiferencaMatriz(int[,] a, int[,] b)
  {
    //declaração das variáveis
    int[,] d = new int[4,6];
    for(int i = 0; i < d.GetLength(0); i++)
    {
      for(int j = 0; j < d.GetLength(1); j++)
      {
        d[i,j] = a[i,j] - b[i,j];
        Console.Write(d[i,j]+"\t");
      }
      Console.WriteLine();
    }
    return d;
  }
}