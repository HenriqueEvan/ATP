using System;
class Exercicio10{
  public static void Exercicio010(){
      //declaração das variáveis
      int idade= 0 ;
      string cat = "";
      //entrada de dados
      Console.WriteLine("Digite a idade do nadador: ");
      idade = int.Parse(Console.ReadLine());
      //chamada da Função
      cat = Categoria(idade);
      Console.WriteLine(cat);
  }
  public static string Categoria(int idade){
      string categ = "";
      if(idade >= 5 && idade <= 7){
        categ = "Categoria: F";
      }
      else if(idade >= 8 && idade <= 10){
        categ = "Categoria: E";
      }
      else if(idade >= 11 && idade <= 13){
        categ = "Categoria: D";
      }
      else if(idade >= 14 && idade <= 15){
        categ = "Categoria: C";
      }
      else if(idade >= 16 && idade <= 17){
        categ = "Categoria: B";
      }
      else if(idade >= 18){
        categ = "Categoria: A";
      }
    return categ;
  }
}