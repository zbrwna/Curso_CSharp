using System;

namespace Ex027Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string calculadora;

            Console.WriteLine("Digite o primeiro numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            soma(num1,num2);
            subtracao(num1, num2);
            multiplicacao(num1, num2);
            divisao(num1, num2);
        }
        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} = {resultado}");
        }
        static void subtracao(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine($"A subtração de {a} - {b} = {resultado}");
        }
        static void multiplicacao(int a, int b)
        {
            int resultado = a * b;
            Console.WriteLine($"A multiplicação de {a} * {b} = {resultado}");
        }
        static void divisao(int a, int b)
        {
            int resultado = a / b;
            Console.WriteLine($"A divisão de {a} / {b} = {resultado}");
        }
    }
}
