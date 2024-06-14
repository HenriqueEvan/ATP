using System;

public class Exercicio10
{
  public void Run()
  {
    //declaração da variável
    int[,] m = new int[10,10];
    //chamada dos procedimentos
    PreencheMatriz(m);
    TrocaA(m);
    TrocaB(m);
    TrocaDiagonais(m);
    TrocaLinhaColuna(m);
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
  //função para Troca de posicionamento A de elementos da matriz
  static void TrocaA(int[,] m)
  {
    //declaração da variável
    int[] pos2 = new int[m.GetLength(0)];
    int[] pos8 = new int[m.GetLength(0)];
    Console.WriteLine("Matriz Troca linha 2 com linha 8");
    //estrutura de repetição para armazenar as linhas
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        pos2[j] = m[1,j];
        pos8[j] = m[7,j];
      }
    }
    //estrutura de repetição para trocar as linhas
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        m[1,j] = pos8[j];
        m[7,j] = pos2[j];
        Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
    
    
  }
  //função para Troca de posicionamento B de elementos da matriz
  static void TrocaB(int[,] m)
  {
    //declaração da variável
    int[] pos4 = new int[m.GetLength(1)];
    int[] pos10 = new int[m.GetLength(1)];
    Console.WriteLine("Matriz Troca coluna 4 com coluna 10");
    //estrutura de repetição para armazenar as colunas
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        pos4[j] = m[j,3];
        pos10[j] = m[j,9];
      }
    }
    //estrutura de repetição para trocar as colunas
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        m[j,3] = pos10[j];
        m[j,9] = pos4[j];
        Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
  }
  //função para Troca de posicionamento diagonais dos elementos da matriz
  static void TrocaDiagonais(int[,] m)
  {
    //declaração da variável
    int[] diagP = new int[m.GetLength(0)];
    int[] diagS = new int[m.GetLength(0)];
    int num = m.GetLength(0) - 1;
    Console.WriteLine("Matriz Trocada Diagonais");
    //estrutura de repetição para Trocar as diagonais
    for(int i = 0; i < m.GetLength(0); i++)
    {
      diagP[i] = m[i,i];
      diagS[i] = m[i,num - i];
      m[i,i] = diagS[i];
      m[i,num - i] = diagP[i];
    }
    //estrutura de repetição exibir Matriz
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
         Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
  }
  //função para trocar linha com coluna
  static void TrocaLinhaColuna(int[,] m)
  {
    //declaração da variável
    int[] lin5 = new int[m.GetLength(0)];
    int[] col10 = new int[m.GetLength(0)];
    Console.WriteLine("Matriz Troca Linha 5 pela Coluna 10");
    //estrutura de repetição para armazenar a linha e coluna
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        lin5[j] = m[4,j];
        col10[j] = m[j,9];
      }
    }
    //estrutura de repetição para trocar linha pela coluna
    for(int i = 0; i < m.GetLength(0); i++)
    {
      for(int j = 0; j < m.GetLength(1); j++)
      {
        m[4,j] = col10[j];
        m[j,9] = lin5[j];
        Console.Write(m[i,j]+"\t");
      }
      Console.WriteLine();
    }
  }
}