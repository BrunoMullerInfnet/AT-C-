class Program
{
    static void Main()
    {
        Console.Write("Digite a data do seu aniversário (dd/mm/yyy):");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

        DateTime hoje = DateTime.Today;

        DateTime proximoAniv = new DateTime(hoje.Year, dataNascimento.Month, dataNascimento.Day);

        if (proximoAniv < hoje)
        {
            proximoAniv = proximoAniv.AddYears(1);
        }

        int diasRestantes = (proximoAniv - hoje).Days;

        Console.WriteLine($"Faltam {diasRestantes} dias para o seu próximo aniversário");

        if (diasRestantes < 7)
        {
            Console.WriteLine("Já preparou a sua festa?!");
        }
    }
}