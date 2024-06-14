using System;

public class Exercicio3
{

    public void Run()
    {
        //declaração das variáveis
        int[] x = new int[10];
        int qtd = 0;
        PreencheVetor(x, ref qtd);
        VetorNegativo(x, qtd);

    }
    //Procedimento para preencher o vetor
    static void PreencheVetor(int[] x, ref int qtd)
    {

        Random r = new Random();
        int sor = 0;
        // condição para não repetir os numeros
        for (int i = 0; i < x.Length; i++)
        {
            sor = r.Next(-9, 9);
            if (!Existe(x, sor))
            {
                x[i] = sor;
                if(x[i] < 0 )
                {
                    qtd++;
                }
                // exibição do vetor para conferir
                Console.WriteLine(x[i]);
                Console.WriteLine();
            }
            else
                i--;
        }
    }
    // função para verificar número negativo no vetor e colocar em outro vetor
    public int[] VetorNegativo(int[] x, int qtd)
    {
        int neg = 0;
        int[] novo = new int[qtd];
        for(int i = 0; i < x.Length; i++)
        {    
            if(x[i] < 0)
            {
                novo[i] = x[i];
                Console.WriteLine(novo[i]);
                Console.WriteLine();        
                neg++;
            }
        }
        return novo;
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