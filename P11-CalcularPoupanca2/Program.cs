using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 11 - Calcular Poupança");


        double investimento = 1000;

        for (int mes = 1; mes <= 12; mes++)
{
            investimento *= investimento * 1.005;
            Console.WriteLine("No mes " + mes + " voce tem: R$" + investimento);
        }


        Console.WriteLine("O valor total dos seus investimentos apos um ano e de: R$" + investimento);
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}