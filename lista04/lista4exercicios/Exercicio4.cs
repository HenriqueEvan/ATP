using System;

class Exercicio04{
  public static void Exercicio4(){
      //declaração das variáveis
      double  x = 0, y = 0, z = 0;
      string resultado = "";
      
      //entrada de dados
      Console.WriteLine("Digite o valor de x: ");
      x = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor de y: ");
      y = double.Parse(Console.ReadLine());
      Console.WriteLine("Digite o valor de z: ");
      z = double.Parse(Console.ReadLine());

      //processamento
      Calcular(x,y,z, ref resultado);
      Console.WriteLine(resultado);
    
  }
  
      //método para calcular o resultado
      public static void Calcular(double x, double y, double z, ref string resultado){
        // regra do exercicio
        if (x < y + z && y < x + z && z < x + y) {
          //verificação de triângulo 
          if(x == y && x == z){
            resultado = "Triângulo Equilátero";
          }
          else if (x == y || x == z){
            resultado = "Triângulo Isósceles";
          }
          else{
            resultado = "Triângulo Escaleno";
          }
            
        }else{
          resultado = "Não foi formado triângulo com os número fornecidos";
        }
    
      }
}