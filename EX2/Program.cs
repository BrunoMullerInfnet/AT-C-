class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o seu nome para criptografarmos");
        string nome = Console.ReadLine();

        char[] alfabeto = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        List<char> novoNome = new List<char>();


        for (int i = 0; i < nome.Length; i++)
        {
            char c = nome[i];
            bool maiuscula = char.IsUpper(c);
            char cMinuscula = char.ToLower(c);
            int index = Array.IndexOf(alfabeto, cMinuscula);

            if (index != -1)
            {
                int novoIndex = (index + 2) % alfabeto.Length;
                char novaLetra = alfabeto[novoIndex];

                novoNome.Add(maiuscula ? char.ToUpper(novaLetra) : novaLetra);

            }
            else
            {
                novoNome.Add(c);
            }

        }

        Console.WriteLine("Nome criptografado: " + new string(novoNome.ToArray()));
    }
}