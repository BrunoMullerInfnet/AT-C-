using EX12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    public class MarkdownFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            Console.WriteLine("## Lista de contatos");

            foreach(var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.nome}\n");
                Console.WriteLine($"Telefone: {contato.numero}\n");
                Console.WriteLine($"Email: {contato.email}\n");
            }
        }
    }
}
