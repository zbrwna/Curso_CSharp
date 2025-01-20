namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite a velocidade do carro");
            double  velocidade = double.Parse(s: Console.ReadLine());

            if (velocidade > 80)
            {
                double excesso = velocidade - 80;
                double multa = excesso * 7;
                Console.WriteLine("$voce foi multado, o valor da multa R$(multa:f2)");
            }
            else
            {
                Console.WriteLine("você está dentro do limite");
            }
        }
    }
}
