﻿using System.ComponentModel.Design;

namespace vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] num = new int[5];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[4]);

            int[] n = new int[3] { 1, 2, 3 };

            Console.WriteLine(n[2]);
            Console.WriteLine();

            int[] numero = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(numero[i] + " " + i);
            }
           

            double[] reais = { 4.5, 3.2, 7.85, 10.64, -5.34, 2.1};

            for (int i = 0; i < reais.Length; i++)
            {
                Console.WriteLine(reais[i] + " " + i);
            }

            double reais_maior = reais.Max(); 
            double reais_menor = reais.Min();

            Console.WriteLine("O maior valor é: " + reais_maior);
            Console.WriteLine("O menor valor é: " + reais_menor);
            */

            string[] nomes = { "Maria", "João", "Pedro", "Carla", "Ana", "José", "Zeferina" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.Write(nomes[i] + ".");
                }
            }

            Console.WriteLine();
            string nome_primeiro = nomes.First();
            string nome_ultimo = nomes.Last();

            Console.WriteLine("O primeiro nome é: " + nome_primeiro);
            Console.WriteLine("O último nome é: " + nome_ultimo);
            Console.WriteLine();
            string nomes_maior = nomes.Max();
            string nomes_menor = nomes.Min();

            Console.WriteLine("O primeiro nome em ordem alfabética é: " + nomes_menor);
            Console.WriteLine("O ultimo nome em ordem alfabética é: " + nomes_maior);
        }

    }
}
