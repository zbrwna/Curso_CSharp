namespace Ex026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*--*-*-*");
            Console.WriteLine("Cálcular a área do triangulo: ");
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*--*-*-*");

            Console.Write("Digite a base do triagulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura do triagulo: ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            area(b, c);
        }

        static void area(double bas, double altura)
        {
            double a = (bas * altura) / 2;
            Console.WriteLine($"A área do triagulo é : {a}");
        }
        }
    }
}
