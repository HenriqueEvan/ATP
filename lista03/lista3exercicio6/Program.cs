using System;

class Program
{
    static void Main(string[] args)
    {
        //declaração das variáveis
        double salario = 0;
        int numeroFilhos = 0;
        double somaSalario = 0;
        double maiorSalario = double.MinValue;
        int totalPessoas = 0;
        int totalPessoasAte100 = 0;
        int totalFilhos = 0;

        // Loop para ler os dados dos habitantes
        do
        {
            // Solicita o salário
            Console.Write("Digite o salário do habitante (ou um valor negativo para encerrar): ");
            salario = double.Parse(Console.ReadLine());
            if(salario > 0){
            // Solicita o número de filhos
            Console.Write("Digite o número de filhos do habitante: ");
            numeroFilhos = int.Parse(Console.ReadLine());

            // Calcula a soma dos salários
            somaSalario += salario;

            // Verifica se o salário é o maior até o momento
            if (salario > maiorSalario)
                maiorSalario = salario;

            // Verifica se o salário é até R$100,00
            if (salario <= 100)
                totalPessoasAte100++;

            // Atualiza o total de pessoas e de filhos
            totalPessoas++;
            totalFilhos += numeroFilhos;
        }
        }while (salario > 0);

        // Calcula as médias
        double mediaSalario = somaSalario / totalPessoas;
        double mediaFilhos = (double)totalFilhos / totalPessoas;

        // Calcula o percentual de pessoas com salário até R$100,00
        double percentualAte100 = (double)totalPessoasAte100 / totalPessoas * 100;

        // Imprime os resultados
        Console.WriteLine("Média do salário da população: " + mediaSalario.ToString("C2"));
        Console.WriteLine("Média do número de filhos: " + mediaFilhos.ToString("N2"));
        Console.WriteLine("Maior salário: " + maiorSalario.ToString("C2"));
        Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualAte100.ToString("F2") + "%");
    }
}
