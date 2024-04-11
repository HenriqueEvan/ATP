using System;

class Program {
  public static void Main (string[] args) {
    //entra de dados 
    int nascimento = 0 , ano = 0 ,idade = 0;
    char aniversario = '?';
    Console.WriteLine ("Digite o ano de Nascimento");
    nascimento = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o ano atual");
    ano = int.Parse(Console.ReadLine());
    Console.WriteLine("Já fez aniversário esse ano? (S/N)");
    aniversario = char.Parse(Console.ReadLine());
    //processamento
    switch (aniversario) {
    case 's':
      idade = ano - nascimento;
      break;
    case 'n':
      idade = ano - nascimento - 1;
      break;
      }
    if(idade >= 18){
      //saida	de dados
      Console.WriteLine("Você já pode tirar a carteira de motorista: " + idade );
    }else{
      //saida	de dados
      Console.WriteLine("Você ainda não pode tirar a carteira de motorista: " + idade + " anos" );
    }
    
    
    
  }
}