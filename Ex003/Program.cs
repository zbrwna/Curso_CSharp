﻿namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, resposta;

            num1 = 45;
            num2 = 35;

            num3 = num1 + num2;

            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, num3);

            num3 = num1 - num2;
            Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;
            Console.WriteLine("A multiplicação de {0} * {1} = {2}", num1, num2, num3);

            resposta = num1 / num2;
            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num2, resposta);

            resposta = num1 % num2;
            Console.WriteLine("O resto da divisão de {0} % {1} = {2}", num1, num2, resposta);

            num4 = 35f;
            resposta = num1 / num4;

            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num4, resposta);




                 
        }
    }
}
