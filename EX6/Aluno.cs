using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX6
{
    public class Aluno
    {
        public string nome;
        public int matricula;
        public string curso;
        public double mediaDasNotas;

        public string VerificaAprovacao()
        {
            if(mediaDasNotas >= 7)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}\nMatricula: {matricula}\nCurso: {curso}");
        }
    }
}
