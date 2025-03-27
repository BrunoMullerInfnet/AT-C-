using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int numero = random.Next(1, 51);
        
        Console.WriteLine("Adivinhe o número secreto (de 1 a 50): ");
        int escolha = int.Parse(Console.ReadLine());

        int contador = 0;

        while(escolha != numero)
        {
            if (numero < 0 || numero > 50)
            {
                Console.WriteLine("ERRO: número fornecido fora do intervalo");
            }
        }

    }
}
