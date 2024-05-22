using System;

class Program
{
    public static void Main(string[] args)
    {
        //chamada de procedimento exercicios
        while (true)
        {
            int escolha = 0;

            Console.WriteLine("Informe:");
            Console.WriteLine("1) Para executar o exercício 1.");
            Console.WriteLine("2) Para executar o exercício 2.");
            Console.WriteLine("3) Para executar o exercício 3.");
            Console.WriteLine("4) Para executar o exercício 4.");
            Console.WriteLine("5) Para executar o exercício 5.");
            Console.WriteLine("6) Para executar o exercício 6.");
            Console.WriteLine("7) Para executar o exercício 7.");
            Console.WriteLine("8) Para executar o exercício 8.");
            Console.WriteLine("9) Para executar o exercício 9.");
            Console.WriteLine("10) Para executar o exercício 10.");

            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Exercicio01 exercicio1 = new Exercicio01();
                    Exercicio01.Exercicio1();
                    break;
                case 2:
                    Exercicio02 exercicio2 = new Exercicio02();
                    Exercicio02.Exercicio2();
                    break;
                case 3:
                    Exercicio03 exercicio3 = new Exercicio03();
                    Exercicio03.Exercicio3();
                    break;
                case 4:
                    Exercicio04 exercicio4 = new Exercicio04();
                    Exercicio04.Exercicio4();
                    break;
                case 5:
                    Exercicio05 exercicio5 = new Exercicio05();
                    Exercicio05.Exercicio5();
                    break;
                case 6:
                    Exercicio06 exercicio6 = new Exercicio06();
                    Exercicio06.Exercicio6();
                    break;
                case 7:
                    Exercicio07 exercicio7 = new Exercicio07();
                    Exercicio07.Exercicio7();
                    break;
                case 8:
                    Exercicio08 exercicio8 = new Exercicio08();
                    Exercicio08.Exercicio8();
                    break;
                case 9:
                    Exercicio09 exercicio9 = new Exercicio09();
                    Exercicio09.Exercicio9();
                    break;
                case 10:
                    Exercicio10 exercicio10 = new Exercicio10();
                    Exercicio10.Exercicio010();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }




    }
}