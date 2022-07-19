using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 10 - Calcular Poupança");


        double investimento = 1000;


        // Rendimento de 0,5% (0.005) ao mês.

        //mês 1
        //investimento = investimento + investimento * 0.005;

        //mês 2 
        //investimento = investimento + investimento * 0.005;

        //mês 3
        //investimento = investimento + investimento * 0.005;

        //mês 4
        //investimento = investimento + investimento * 0.005;

        int mes = 1;

        while (mes <= 12) {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mes " + mes + " voce tem: R$" + investimento);
            mes ++;
           
        }

        Console.WriteLine("O valor total dos seus investimentos apos um ano e de: R$" + investimento);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}