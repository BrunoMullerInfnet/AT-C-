using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario)
            : base(nome, "Gerente", salario)
        {
        }

        public override void getSalario()
        {
            Console.WriteLine($"Seu salário é: {_salario * 1.2} (20% de bônus de gerência)");
        }
    }
}
