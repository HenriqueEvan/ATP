using System;

public class Exercicio6{
  public void Run(){
    //declaração das variáveis
    int[] outubro = new int[31];
    double menor =41, maior=14, media=0, soma=0, dias = 0;
    //estrutura de repetição para preencher o vetor com as temperaturas de cada dia
    for(int i = 0; i < outubro.Length; i++){
      Console.WriteLine("Digite a temperatura do dia "+(i+1)+"º: ");
      outubro[i] = int.Parse(Console.ReadLine());
      if(outubro[i] >= 15 && outubro[i] <= 40)
      {
        //verificação qual menor temperatura
        if(menor > outubro[i])
        {
          menor = outubro[i];
        }
        //verificação qual maior temperatura
        if(maior < outubro[i])
        {
        maior = outubro[i];
        }
        soma += outubro[i];
      }
      else
      {
        Console.WriteLine("Temperatura inválida no mês não ocorreu temperatura inferior a 15ºC ou superior a 40ºC");
        i--;
      }
    }
    //calcula a média das temperaturas
    media = soma / outubro.Length;
    for(int i = 0; i < outubro.Length; i++)
    {
      if(outubro[i] < media){
        dias++;
      }
    }
    //saída dos dados
    Console.WriteLine("Minima temperatura ocorrida {0}ºC Máxima temperatura ocorrida {1}ºC ", menor, maior);
    Console.WriteLine("Média das temperaturas: {0:F2}ºC", media);
    Console.WriteLine("Dias com temperatura inferior a média: {0}", dias);
  }
}