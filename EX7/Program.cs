using EX7;

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Bruno", 100);

        Console.WriteLine($"Titular: {conta.titular}");
        conta.Depositar(500);
        conta.Sacar(700);
        conta.Sacar(200);
        Console.WriteLine($"Saldo atual: {conta.GetSaldo()}");
    }
}