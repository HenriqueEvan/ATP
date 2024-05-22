using System;

class Exercicio06{
    public static void Exercicio6(){
        // Solicita ao usuário quantos números ele deseja verificar
        Console.Write("Quantos números você deseja verificar? ");
        int qtd = int.Parse(Console.ReadLine());

        // Vetor para armazenar os números
        int[] numeros = new int[qtd];

        // estrutura de repetição para ler números do usuário
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write("Digite um número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        // estrutura de repetição para verificar cada número e exibir a mensagem apropriada
        for (int i = 0; i < numeros.Length; i++)
        {
            bool positivo = VerificarPositivo(numeros[i]);
            if (positivo)
            {
                Console.WriteLine("O número {0} é positivo.", numeros[i]);
            }
            else
            {
                Console.WriteLine("O número {0} é negativo.", numeros[i]);
            }
        }
    }

    // Função que verifica se o número é positivo
    static bool VerificarPositivo(int valor)
    {
        return valor > 0;
    }
}

