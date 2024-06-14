using System;

public class Exercicio1
{
    public void Run()
    {
      //declaração das variáveis
        int[] vet = new int[20];
        int m = 0, p = 0, num = 1, sor = 0;
        Random rand = new Random();
        // estrutra de repetitção para preeencher
        for (int i = 0; i < vet.Length; i++)
        {
            sor = rand.Next(21);
            if (!existe(vet, sor))
            {
                vet[i] = sor;
                // exibição do vetor para conferir
                Console.WriteLine(vet[i]);
                Console.WriteLine();
            }
          else 
          i--;
        }
      //estrutura de repetição para verificar qual conetúdo é menor e sua posição de indice
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] <= num)
            {
                m = vet[i];
                p = i;
            }
        }
        Console.WriteLine("O menor valor é: " + m + " e está na posição: " + (p +1));
    }
  //metodo para sortear numero diferene nas posições do vetor
    static bool existe(int[] v, int n)
    {
        for (int i = 0; i < v.Length; i++)
        {
            if (v[i] == n) return true;
        }
        return false;

    }
}