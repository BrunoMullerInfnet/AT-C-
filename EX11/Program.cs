using EX11;

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

            if(!int.TryParse(escolha, out int resultado) || (resultado > 3 || resultado < 1))
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
                    Console.WriteLine("Pressione qualquer tecla para sair\n");

                    bool contatosEncontrados = false; 

                    using (StreamReader leitor = new StreamReader(caminho))
                    {
                        string linha;
                        while ((linha = leitor.ReadLine()) != null)
                        {
                            Console.WriteLine(linha);
                            contatosEncontrados = true; 
                        }
                    }

                    if (!contatosEncontrados)
                    {
                        Console.WriteLine("Nenhum contato cadastrado.");
                    }

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