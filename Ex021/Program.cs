using System;

namespace Ex021
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = {"Morango", "Maça", "Abacaxi", "Maracujá", "Abacate",
                                "Banana","Laranja", "Caju", "Damasco", "Goiaba"};
            double[] reais = { 10.2, 7.5, 9.5, 8.7, 8.5, 12.3, 11.4, 14.2, 20.4, 15.6 };

           
            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine("O valor da fruta " + frutas[i] + " é R$" + reais[i]); 
            }
            double reais_maior = reais.Max();
            double reais_menor = reais.Min();

            Console.WriteLine("O maior valor é: " + reais_maior);
            Console.WriteLine("O menor valor é: " + reais_menor);


            Console.WriteLine();
            string frutas_maior = frutas.Max();
            string frutas_menor = frutas.Min();
            

            Console.WriteLine("A primeira fruta em ordem alfabética é: " + frutas_menor);
            Console.WriteLine("A ultima fruta em ordem alfabética é: " + frutas_maior);

        }

    }
}


