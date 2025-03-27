using EX8;

class Program
{
    static void Main()
    {
        Funcionario funcionario = new Funcionario("Bruno","Analista",20000);
        Gerente gerente = new Gerente("Bruno", 20000);

        funcionario.getSalario();
        gerente.getSalario();
    }
}