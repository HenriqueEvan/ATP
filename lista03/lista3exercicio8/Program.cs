using System;

class Program
{
    static void Main(string[] args)
    {   
        //declaração das variáveis
        int l = 0;
        int primeiro = 0;
        int segundo = 1;
        // Solicita ao usuário o número de elementos da sequência
        Console.Write("Digite o número de elementos da sequência de Fibonacci a serem impressos: ");
        l = int.Parse(Console.ReadLine());

        // Imprime os dois primeiros termos
        Console.Write(primeiro + " " + segundo + " ");

        // Calcula e imprime os próximos termos da sequência
        for (int i = 2; i < l; i++)
        {
            int proximo = primeiro + segundo;
            Console.Write(proximo + " ");

            // Atualiza os valores para os próximos cálculos
            primeiro = segundo;
            segundo = proximo;
        }
        // Pula uma linha após imprimir todos os elementos
        Console.WriteLine(); 
        
    }

}