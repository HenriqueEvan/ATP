﻿using System;

class Program
{
    static void Main(string[] args)
    {
        //declaração das variáveis
        int voto;
        // Índices: 0 para votos em branco, 1 a 4 para os candidatos, 5 para votos nulos
        int[] contagemVotos = new int[6];

        // Loop para receber os votos até que seja inserido 0 como finalizador
        do{
            Console.Write("Digite o código do candidato (ou 0 para encerrar): ");
            voto = int.Parse(Console.ReadLine());

            // Se o voto for 0, encerra o loop
            if (voto != 0){

            switch (voto)
            {
                case 1:
                    contagemVotos[1]++;
                    break;
                case 2:
                    contagemVotos[2]++;
                    break;
                case 3:
                    contagemVotos[3]++;
                    break;
                case 4:
                    contagemVotos[4]++;
                    break;
                case 5:
                // Voto nulo
                    contagemVotos[5]++; 
                    break;
                case 6:
                // Voto em branco
                    contagemVotos[0]++; 
                    break;
                default:
                    Console.WriteLine("Código inválido! Voto não computado.");
                    break;
            }
         }
        }while (voto != 0);

        // Escreve o total de votos para cada candidato, votos nulos e votos em branco
        Console.WriteLine("\nTotal de votos para cada candidato:");
        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine("Candidato " + i + ": " + contagemVotos[i]);
        }
        Console.WriteLine("Total de votos nulos: " + contagemVotos[5]);
        Console.WriteLine("Total de votos em branco: " + contagemVotos[0]);

    }
}
