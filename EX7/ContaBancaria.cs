namespace EX7
{
    public class ContaBancaria
    {
        public string titular;
        private double _saldo;

        public double GetSaldo()
        {
            return _saldo;
        }

        public ContaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            _saldo = saldo;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("O valor do depósito deve ser positivo!");
            }
            else
            {
                Console.WriteLine($"Depósito de R$ {valor} realizado com sucesso!");
                _saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > _saldo)
            {
                Console.WriteLine($"Tentativa de saque: R$ {valor}\nSaldo insuficiente para realizar o saque!");
            }
            else
            {
                Console.WriteLine($"Saque de R$ {valor} realizado com sucesso!");
                _saldo -= valor;
            }
        }
    }
}
