using System;

class Exercicio01 {

    public static void Exercicio1(){
      // declaração de variavéis 
      string param;
      double n1 =0, n2 =0, n3 =0, alun = 0, resultado = 0;
      // entrada de dados para número de alunos
      Console.WriteLine("Digite um número de alunos a serem avaliados: ");
      alun = double.Parse(Console.ReadLine());
      //estrutura de repetição para avaliar os alunos
      for(int i =0; i < alun; i++){
      //entrada de dados para parâmetro de avaliação  
      Console.WriteLine("Escolha o parametro para avaliação: A= Média, P= Média Ponderada");
      param = Console.ReadLine().ToUpper();
      Console.WriteLine("Digite o valor das 3 notas: ");
      n1 = double.Parse(Console.ReadLine());
      n2 = double.Parse(Console.ReadLine());
      n3 = double.Parse(Console.ReadLine());
      //regra de parâmetro
      if(param == "A"){
        //chamada de parâmetro
        Media(n1, n2, n3, ref resultado);
        Console.WriteLine(" Aluno:{0}, Média: {1:f2}",i+1, resultado);
      }else if(param == "P"){
        //chamada de parâmetro 2
        MediaP( n1, n2, n3, ref resultado);
        Console.WriteLine(" Aluno:{0}, Média Ponderada: {1:f2}",i+1, resultado);
      }
    }

  }
  //procedimento media para avaliar os alunos
  public static void Media(double n1, double n2, double n3, ref double resultado){
    resultado =  (n1 + n2 + n3) / 3;
  }
  //procedimento média ponderada para avaliar os alunos
  public static void MediaP(double n1, double n2, double n3, ref double resultado){
    resultado =  (n1 * 5 + n2 * 3 + n3 * 2) / 10;
  }



}