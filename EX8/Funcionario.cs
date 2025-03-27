using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    public class Funcionario
    {
        protected string nome;
        protected string cargo;
        protected double _salario;

        public Funcionario(string nome, string cargo, double salario)
        {
            this.nome = nome;
            this.cargo = cargo;
            _salario = salario;
        }

        public virtual void getSalario()
        {
            Console.WriteLine($"Seu salário é: {_salario}");
        }
    }
}
