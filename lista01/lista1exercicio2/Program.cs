﻿using System;

class Program {
  public static void Main (string[] args) {
    double cat1 =0, cat2 = 0, hipote = 0; 
    Console.WriteLine("insira o valor do cateto 1");
    cat1 = double.Parse(Console.ReadLine());
    Console.WriteLine("insira o valor do cateto 2");
    cat2 = double.Parse(Console.ReadLine());
    hipote = Math.Sqrt(Math.Pow(cat1,2) + Math.Pow(cat2,2));
    Console.WriteLine("O Valor da Hipotenusa {0:0.00} ",hipote);
  }
}