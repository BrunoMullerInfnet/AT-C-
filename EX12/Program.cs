using EX12;

class Program
{
    static void Main()
    {
        string caminho = "contato.txt";
        bool programa = true;

        while (programa == true)
        {
            Console.Clear();
            Console.WriteLine("=== Gerenciador de Contatos ===\n");
            Console.WriteLine("1 - Adicionar novo contato\n2 - Listar contatos cadastrados\n3 - Sair");

            string escolha = Console.ReadLine();

            if (!int.TryParse(escolha, out int resultado) || (resultado > 3 || resultado < 1))
            {
                Console.WriteLine("Escolha inválida");
                Thread.Sleep(2000);

            }
            else
            {
                if (resultado == 1)
                {
                    Console.Clear();
                    Console.WriteLine("=== Gerenciador de contatos ===\n");

                    Console.WriteLine("Qual o nome do contato?");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Qual o número do contato?");
                    string numero = Console.ReadLine();

                    Console.WriteLine("Qual o e-mail do contato?");
                    string email = Console.ReadLine();


                    Contatos contato = new Contatos(nome, numero, email);
                    (bool resultadoNumero, string numeroFormatado) = contato.verificarNumero();

                    if (resultadoNumero && contato.verificarEmail())
                    {
                        using (StreamWriter escritor = new StreamWriter(caminho, true))
                        {
                            escritor.WriteLine($"Nome: {nome} | Telefone: {numeroFormatado} | Email: {email}");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("=== Gerenciador de Contatos ===\n");
                        Console.WriteLine("Erro no cadastro");
                        Thread.Sleep(2000);
                    }
                }
                else if (resultado == 2)
                {
                    Console.Clear();
                    Console.WriteLine("=== Gerenciador de Contatos ===\n");

                    List<Contatos> contatos = new List<Contatos>();

                    using (StreamReader leitor = new StreamReader("contato.txt"))
                    {
                        string linha;
                        while ((linha = leitor.ReadLine()) != null)
                        {
                            try
                            {
                                contatos.Add(Contatos.FromString(linha));
                            }
                            catch (FormatException ex)
                            {
                                Console.WriteLine($"Erro ao processar contato: {ex.Message}");
                            }
                        }
                    }

                if (contatos.Count == 0)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }
                    else
                    {
                        Console.WriteLine("Escolha o formato de exibição:");
                        Console.WriteLine("1 - Markdown");
                        Console.WriteLine("2 - Tabela");
                        Console.WriteLine("3 - Texto Puro");

                        string escolhaFormato = Console.ReadLine();
                        ContatoFormatter formatter = escolhaFormato switch
                        {
                            "1" => new MarkdownFormatter(),
                            "2" => new TabelaFormatter(),
                            "3" => new RawTextFormatter(),
                            _ => null
                        };

                        if (formatter != null)
                        {
                            Console.Clear();
                            formatter.ExibirContatos(contatos);
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                    }

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else if (resultado == 3)
                {
                    programa = false;
                    Console.WriteLine("Encerrando o programa...");
                }
            }
        }
    }
}