using System;

class Program {
  public static void Main (string[] args) {
    //declaração das variáveis
    double diaria =0, diariaPromo=0, totalPromo=0, totalNormal=0, diferenca=0, apartamentos = 75;  
    Console.WriteLine ("informe o valor da diária");
    diaria = double.Parse(Console.ReadLine());
    //calculo da diaria promocional
    diariaPromo = diaria - (diaria * 0.25);
    //saída do valor da diaria promocional
    Console.WriteLine("o valor da diária Promocional é: R$ " +diariaPromo);
    //calculo do total arrecadado com 80% de ocupação e diária promocional
    totalPromo =  (apartamentos * 0.8) * diariaPromo;
    //saída do total arrecadado com 80% de ocupação e diária promocional
    Console.WriteLine("o total arrecadado com 80% de ocupação e diária promocional é de: R$ " + totalPromo);
    //calculo do total arrecadado com 50% de ocupação e diária normal
    totalNormal = (apartamentos * 0.5) * diaria;
    //saída do total arrecadado com 50% de ocupação e diária normal
    Console.WriteLine("o total arrecadado com 50% de ocupação e diária normal é de: R$ " + totalNormal);
    //calculo da diferença entre os dois valores
    diferenca = totalPromo - totalNormal;
    //saída da diferença entre os dois valores
    Console.WriteLine("a diferença entre os dois valores é de: R$ " + diferenca);


    
  }
}