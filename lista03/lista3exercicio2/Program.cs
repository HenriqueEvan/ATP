using System;

class Program {
    public static void Main(string[] args){
        //declaração de variáveis
        int num = 0, pos=0, neg=0, zeros=0 , soma=0;
        double perP =0 , perN =0, perZ = 0;
        string opcao;
        //entrada de dados e estrutura de repetição para calculos
        do {
            Console.WriteLine("Digite numeros Positivos ou negativos ou zeros");
            num = int.Parse(Console.ReadLine());

                soma ++ ;
            if(num > 0 && num < 1000 ){
                pos++;
            }
            else if(num < 0 ){
                neg++;
            }
            else {
                zeros++;
            }
            Console.WriteLine("desenha continuar? digite: Sim(s) ou Não(n)");
            opcao = Console.ReadLine();
        }while(opcao.ToLower() == "s");
            perP = (double)(pos * 100) / soma;
            perN = (double)(neg * 100) / soma;
            perZ = (double)(zeros * 100) / soma;

        //saída de dados
            Console.WriteLine("Final da contagem");
            Console.WriteLine("Números de valores Positivos: {0}, Negativos: {1} e Zeros: {2}", pos, neg, zeros);
            Console.WriteLine("porcentagem de positivos: {0:f2} % negativos: {1:f2} % zeros: {2:f2} %", perP,perN,perZ);

    }
}