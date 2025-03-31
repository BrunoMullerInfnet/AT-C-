class Program
{
    static void Main()
    {
        Random gerador = new Random();
        int numero = gerador.Next(1, 51);
        int escolha;
        int tentativas = 0;
        do
        {
            Console.WriteLine("Escolha um número de 1 a 50");
            escolha = int.Parse(Console.ReadLine());

            if (escolha < 1 || escolha > 50)
            {
                Console.WriteLine("ERRO: Escolha um número de 1 a 50");
                tentativas++;
            }

            else if(escolha == numero)
            {
                Console.WriteLine("Você acertou!");
                break;
            }
            else
            {
                Console.WriteLine("Tente novamente!");
                tentativas++;
            }

        }
        while (tentativas < 5);
    }
}