using System;

public class Exercicio4
{
  public void Run()
  {
     //declaração dos vetores
     int[] x = new int[10];
     int[] y = new int[10];
     int[] z = new int[10];
     Console.WriteLine("Vetor X: ");
     PreencheVetor(x);
     Console.WriteLine("Vetor Y: ");
     PreencheVetor(y);
     GeraNovoVetor(x, y, z);
     for(int i = 0; i < z.Length; i++)
    {
      Console.WriteLine("Novo Vetor : "+ z[i]);
    }
  }
  static void GeraNovoVetor(int[] x, int[] y, int[] z)
  {
    
    for(int i = 0; i < z.Length; i++)
    {
      if(i % 2 == 0)
      {
        z[i] = x[i];
      }
      else
      {
        z[i] = y[i];
      }
    }
  }

  //Procedimento para preencher o vetor
  static void PreencheVetor(int[] x)
  {

      Random r = new Random();
      int sor = 0;
      // condição para não repetir os numeros
      for (int i = 0; i < x.Length; i++)
      {
          sor = r.Next(0, 15);
          if (!Existe(x, sor))
          {
              x[i] = sor;
              // exibição do vetor para conferir
              Console.WriteLine(x[i]);
              Console.WriteLine();
          }
          else
              i--;
      }
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