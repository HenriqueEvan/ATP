using System;

class Program {
  public static void Main (string[] args) {
    //declaração das variáveis
    char selecao;
    double salario=0, salario_novo=0;
    //entrada de dados
    Console.WriteLine ("Informe a seleção desejada: A , B ou C");
    selecao = char.Parse(Console.ReadLine());
    Console.WriteLine ("Informe o salário: ");
    salario = double.Parse(Console.ReadLine());
    //processamento para verificação da seleção
    switch (selecao){
    case 'a':
        salario_novo = salario + (salario * 0.08);
        break;
    case 'b':
        salario_novo = salario + (salario * 0.11);
        break;
    case 'c':
      //processamento para verificação do salário
        if (salario <= 1000){
          salario_novo = salario + 350;
        }
        else{
          salario_novo = salario + 200;
        }
        break;
    }
    //saída de dados
    Console.WriteLine("O salário atualizado é: R$ {0:f2}", salario_novo);

    
    
    
    
    
    
       
    
  }
}