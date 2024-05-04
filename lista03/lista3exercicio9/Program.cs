using System;

class Program
{
    static void Main(string[] args)
    {
        //declaração das variáveis
        int l = 0;
        int somaFibonacci = 0;
        int primeiro = 0;
        int segundo = 1;
        int soma = 0;
        int proximo = 0;
        // Solicita ao usuário o valor de L
        Console.Write("Digite o valor de L: ");
        l = int.Parse(Console.ReadLine());

         // Enquanto o próximo termo for menor que L, calcula a soma
        while (segundo < l)
        {
            soma += segundo;

            // Calcula o próximo termo da sequência de Fibonacci
            proximo = primeiro + segundo;

            // Atualiza os valores para os próximos cálculos
            primeiro = segundo;
            segundo = proximo;
        }

        // Calcula e imprime a soma dos elementos da série de Fibonacci menores que L
        somaFibonacci = soma;
        Console.WriteLine("A soma dos elementos da série de Fibonacci menores que " + l + " é: " + somaFibonacci);
    }


}
