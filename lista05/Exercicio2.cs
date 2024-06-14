using System;

public class Exercicio2
{
    public void Run()
    {
        //declaração das variáveis
        double[] vet = new double[10];
        double media = 0;
        int qtd = 0;
        //estrutura para preecher o vetor com notas
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("Digite a {0}º nota do aluno ", (i + 1));
            vet[i] = double.Parse(Console.ReadLine());
        }
        //chamada do procedimento
        Media(vet, ref qtd, ref media);

    }
    //procediemnto para verificar qual a média
    static void Media(double[] vet, ref int qtd, ref double media)
    {
        for (int i = 0; i < vet.Length; i++)
        {
            media += vet[i];
        }
        media = media / vet.Length;
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] > media)
            {
                qtd++;
            }
        }
      //exibição do resultado
        Console.WriteLine("Média da Turma: {0:F2}, Quantidade de aluno que tirou nota acima da média: {1}", media, qtd);
    }
}