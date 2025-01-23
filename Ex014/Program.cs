namespace Ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um numero e descubra sua tabuada");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
            }
               
        }
    }
}
