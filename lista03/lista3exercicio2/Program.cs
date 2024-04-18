using System;

class Program {
    public static void Main(string[] args){
        //declaração de variáveis
        int num = 0, pos=0, neg=0, zeros=0;
        //entrada de dados e estrutura de repetição para calculos
        do {
            Console.WriteLine("Digite numeros Positivos ou negativos ou zeros abaixo de 1000 ou digite 1000 para fazer contagem");
            num = int.Parse(Console.ReadLine());
            if(num!= 1000){
            if(num > 0 && num < 1000 ){
                pos++;
            }
            else if(num < 0 ){
                neg++;
            }
            else {
                zeros++;
            }
            }
        }while(num != 1000);
        //saída de dados
            Console.WriteLine("Final da contagem");
            Console.WriteLine("Números de valores Positivos: {0}, Negativos: {1} e Zeros: {2}", pos, neg, zeros);


    }
}