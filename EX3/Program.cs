class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o primeiro número");
        double numero1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha o segundo número");
        double numero2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Escolha a operação matemática:\n1: Soma\n2: Subtração\n3: Multiplicação\n4: Divisão");
        int escolha = int.Parse(Console.ReadLine());
        
        if (escolha <= 4 && escolha >= 1)
        {
            if (escolha == 1)
            {
                Console.WriteLine(numero1 + numero2);
            }
            else if (escolha == 2)
            {
                Console.WriteLine(numero1 - numero2);
            }
            else if (escolha == 3)
            {
                Console.WriteLine(numero1 * numero2);
            }
            else if (escolha == 4)
            {
                if (numero1 == 0 || numero2 == 0)
                {
                    Console.WriteLine("ERRO: divisão por 0");
                }
                else
                {
                    Console.WriteLine(numero1 / numero2);
                }

            }
        }
        else
        {
            Console.WriteLine("Número inválido");
        }

    }
}