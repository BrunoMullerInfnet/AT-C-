using EX8;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        Produto[] produtos = new Produto[5];
        int contador = 0;

        while (true)
        {
            Console.WriteLine("Controle de estoque\n");
            Console.WriteLine("1- Inserir produto\n");
            Console.WriteLine("2- Listar Produtos\n");
            Console.WriteLine("3- Sair\n");
            string escolha = Console.ReadLine();

            if (escolha == "1")
            {
                if (contador >= 5)
                {
                    Console.WriteLine("Limite de produtos atingido!");
                    continue;
                }
                Console.Clear();
                Console.WriteLine("Nome produto: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Quantidade em estoque: ");
                int quantidade;
                while(!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0)
                {
                    Console.WriteLine("Quantidade inválida, digite novamente!");
                }
                Console.WriteLine("Preço do produto: ");
                double preco;
                while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0)
                {
                    Console.WriteLine("Preço inválido, digite novamente!");
                }

                produtos[contador] = new Produto(nome, quantidade, preco);
                contador++;
                Console.WriteLine("Produto cadastrado!");
                Console.Clear();
            }
            else if (escolha == "2")
            {
                if (contador == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado");
                }
                else
                {
                    Console.Clear ();
                    Console.WriteLine("Lista Produtos\n");
                    for (int i = 0; i < contador; i++)
                    {
                        produtos[i].Exibir();
                    }
                }
            }
            else if (escolha == "3")
            {
                Console.WriteLine("Fim do programa");
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Opção inválida, digite novamente");
            }

        }
    }
}