using System;

class Program {
  public static void Main (string[] args) {
    //declaração das variáveis
    double nota;
    //entrada de dados
    Console.WriteLine ("informe a o valor da nota");
    nota = double.Parse(Console.ReadLine());
    //processamento para verificar se a nota é válida
    if(nota < 0) 
    {
    //saída de dados
    Console.WriteLine("nota inválida");
    }
    //processamento para verificar valor da nota
    else if(nota < 5)
      {
    //saída de dados
    Console.WriteLine("Insatisfatório");
      }
    //processamento para verificar valor da nota
    else if((nota >=5) && (nota < 7))
     {
    //saída de dados
    Console.WriteLine("Regular");
     }
    //processamento para verificar valor da nota
    else if((nota >=7) && (nota < 8))
     {
    //saída de dados
    Console.WriteLine("Bom");  
     }
    //processamento para verificar valor da nota
    else if((nota >=8) && (nota <= 10))
    {
    //saída de dados
    Console.WriteLine("Ótimo");
     }
    else
    {
    Console.WriteLine("nota inválida");
    }
    
    
  }
  
}