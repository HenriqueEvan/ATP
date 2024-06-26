﻿using System;

class Program
{
    static void Main(string[] args)
    {   
        //declaração de variáveis
        double precoCompra = 0, precoVenda = 0, lucro = 0;
        int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;
        double valorTotalCompra = 0, valorTotalVenda = 0, lucroTotal = 0;

        // Loop para fazer o levantamento do lucro das mercadorias
        do{
            Console.Write("Informe o preço de compra da mercadoria (ou 0 para encerrar): ");
            precoCompra = double.Parse(Console.ReadLine());

            // Se o preço de compra for 0, encerra o loop
            if (precoCompra != 0){
            
            Console.Write("Informe o preço de venda da mercadoria: ");
            precoVenda = double.Parse(Console.ReadLine());

            // Calcula o lucro da mercadoria
            lucro = (precoVenda - precoCompra) / precoCompra * 100;

            // Atualiza os totais de compra, venda e lucro
            valorTotalCompra += precoCompra;
            valorTotalVenda += precoVenda;
            lucroTotal += precoVenda - precoCompra;

            // Determina em qual faixa de lucro a mercadoria se encontra
            if (lucro < 10)
                lucroMenor10++;
            else if (lucro <= 20)
                lucroEntre10e20++;
            else
                lucroMaior20++;
         }
        }while (precoCompra != 0);

        // Escreve a quantidade de mercadorias em cada faixa de lucro
        Console.WriteLine("Quantidade de mercadorias com lucro menor que 10%: " + lucroMenor10);
        Console.WriteLine("Quantidade de mercadorias com lucro entre 10% e 20%: " + lucroEntre10e20);
        Console.WriteLine("Quantidade de mercadorias com lucro maior que 20%: " + lucroMaior20);

        // Escreve o valor total de compra, venda e lucro
        Console.WriteLine("Valor total de compra das mercadorias: " + valorTotalCompra.ToString("C2"));
        Console.WriteLine("Valor total de venda das mercadorias: " + valorTotalVenda.ToString("C2"));
        Console.WriteLine("Lucro total: " + lucroTotal.ToString("C2"));

    }
}
