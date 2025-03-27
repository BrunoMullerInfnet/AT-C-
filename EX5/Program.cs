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

        // Cálculo exato da diferença
        int anos = dataFormatura.Year - dataAtual.Year;
        int meses = dataFormatura.Month - dataAtual.Month;
        int dias = dataFormatura.Day - dataAtual.Day;

        if (dias < 0)
        {
            dataFormatura = dataFormatura.AddMonths(-1);
            dias += DateTime.DaysInMonth(dataFormatura.Year, dataFormatura.Month);
            meses--;
        }

        if (meses < 0)
        {
            anos--;
            meses += 12;
        }

        Console.WriteLine($"Faltam {anos} anos, {meses} meses e {dias} dias para sua formatura!");
    }
}
