namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;

            Console.Write("Escolha a 1 nota:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a 2 nota:");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.WriteLine("Media: {0}", media);

        }
    }
}
