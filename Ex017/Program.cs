namespace Ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0; // Inicializador de variável

            // Enquanto a condição for verdadera, o bloco de código será executado.
            /*
           while (num < 5)
            {
                Console.WriteLine("Curso C#");
            }
            */
            do
            {
                Console.WriteLine("Curso C#");
                num++;
            } while (num < 5);
        }
    }
}
