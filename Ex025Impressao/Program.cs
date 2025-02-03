namespace Ex025Impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Bruna");
            Console.WriteLine();
        }
        static void escreva(string texto)
        {
            char caracter = '='; // caracter de será impresso
            int tamanho = texto.Length + 4; // tamanho da linha
            string linha = new string(caracter, tamanho); // cria uma linha com caracter informado
            string textoCentralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // centraliza o texto
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);

        }


    }
}
