using System;

class Program
{
    static void Main(string[] args)
    {
        //declaração das variáveis
        int n = 0;
        double soma = 0;
        // Solicita o valor de n ao usuário
        Console.Write("Digite o valor de n: ");
        n = int.Parse(Console.ReadLine());


        // Loop para calcular a soma e imprimir cada termo
        for (int i = 1; i <= n; i++)
        {
            // Calcula o termo atual
            double termo = 1.0 / i; 
            // Adiciona o termo à soma
            soma += termo; 
            Console.WriteLine("Termo " + i + ": " + termo);
        }

        // Imprime o valor final da soma
        Console.WriteLine("O valor final da soma é: {0:f2}" , soma);
    }
}
