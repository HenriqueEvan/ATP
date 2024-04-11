using System;

class Program {
  public static void Main (string[] args) {
    //declaração das variáveis
    char simbolo = 'a';
    Console.WriteLine("informe um dos símbolos a seguir: <, >, = ou !");
    simbolo = char.Parse(Console.ReadLine());
    switch(simbolo){
    case '<' :  
      Console.WriteLine("sinal de menor");
      break;
    case '>' : 
      Console.WriteLine("sinal de maior");
      break;
    case '=' :
      Console.WriteLine("sinal de igual");
      break;
    case '!' :
      Console.WriteLine("Outro sinal");
      break;
    }





    
  }
}