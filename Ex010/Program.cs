namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, aumento;

            Console.WriteLine("Digite o seu sálario: ");

            salario = double.Parse(Console.ReadLine());

            if (salario > 2500)
            {
                aumento = (salario * 0.05) + salario;
            }
            else if (salario > 1250)
            {
                aumento = (salario * 0.1) + salario;
            }

            else (salario < 1250)
            {
                aumento = salario * 0.15 + salario;
            }

            Console.WriteLine("O salario final será .");





        }
    }
}
