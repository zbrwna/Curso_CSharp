namespace EX009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o valor do lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os valores informados formam um triangulo.");
                if ((ladoA == ladoB) && (ladoB == ladoC))
                {
                    Console.WriteLine("E Ele é um triangulo equilátero.");
                }
                else if ((ladoA == ladoC) || (ladoB == ladoC) || (ladoA == ladoB))
                {
                    Console.WriteLine("E ele é um triagulo Isósceles.");
                }
                else
                {
                    Console.WriteLine("E ele é um triangulo escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores inforados não forma um triangulo.");

            }




        }
    }
}
