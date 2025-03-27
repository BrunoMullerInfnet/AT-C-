class Program
{
    static void Main()
    {
        Console.Write("Digite a data atual (dd/MM/yyyy): ");
        DateTime dataAtual = DateTime.Parse(Console.ReadLine());

        DateTime dataFormatura = new DateTime(2027, 12, 15);

        if (dataAtual > DateTime.Today)
        {
            Console.WriteLine("Erro: A data informada não pode ser no futuro!");
            return;
        }

        if (dataAtual > dataFormatura)
        {
            Console.WriteLine("Parabéns! Você já deveria estar formado!");
            return;
        }

        int diferencaAnos = dataFormatura.Year - dataAtual.Year;
        int mesesDiferenca = AjustaMesAno(dataFormatura) - AjustaMesAno(dataAtual);
        int diasDiferenca = (dataFormatura - dataAtual).Days;

        if (mesesDiferenca < 6)
        {
            Console.WriteLine($"Faltam {mesesDiferenca} meses e {diasDiferenca} dias para sua formatura!");
            Console.WriteLine("A reta final chegou! Prepare-se para a formatura!");
        }
        else
        {
            Console.WriteLine($"Faltam {diferencaAnos} anos, {mesesDiferenca} meses e {diasDiferenca} dias para sua formatura!");
        }
    }

    static int AjustaMesAno(DateTime d)
    {
        return d.Year * 12 + d.Month;
    }
}
