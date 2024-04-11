using System;

class Program {
  public static void Main (string[] args) {
    int num = 0, novoNum = 0, p = 0, s = 0, t = 0, q = 0, soma = 0;
    Console.WriteLine("Digite um número: ");
    num = int.Parse(Console.ReadLine());
    p =  num / 100;
    s = num % 100 / 10;
    t = num % 100 % 10;
    novoNum = t * 100 + s * 10 + p;
    soma = num + novoNum;
    Console.WriteLine("A) soma de {0} + {1} = {2}",num, novoNum,soma);
    p =  soma / 1000;
    s = soma % 1000 / 100;
    t = soma % 1000 % 100 / 10;
    q = soma % 1000 % 100 % 10;
    p = p*0;
    s = s*1;
    t = t*2;
    q = q*3;
    Console.WriteLine("B) novo número: {0} {1} {2} {3}",p,s,t,q);
    soma = p + s + t + q;
    Console.WriteLine("C) soma das multiplicações é: {0}",soma);
    s = soma % 10;
    Console.WriteLine("D) digito verificador é: {0}",s);
    
  }
}