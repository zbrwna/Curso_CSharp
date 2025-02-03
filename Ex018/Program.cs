namespace teste_senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhadigitada;
            int tentativas = 0;

            do
            {
                Console.Clear();
                Console.Write("Digite a senha: ");
                senhadigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3) { break; }

            } while (senha != senhadigitada);

            if (senha != senhadigitada)
            {
                Console.Clear();
                Console.WriteLine("Senha incorreta! Tentativas: " + tentativas);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha correta! Tentativas: " + tentativas);
            }
        }
    }
}
