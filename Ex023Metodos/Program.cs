﻿namespace Ex023Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  soma(3, 4);
            saudacao("Bruna");
        }
    
        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("A soma de " + a + " + " + b + " = " + resultado);
        }
    
        static void saudacao(string nome)
        {
            Console.WriteLine(nome + ", Seja Bem Vinda!");
        }
    
    
    
    
    
    
    }

}
