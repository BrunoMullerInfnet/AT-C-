using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    public class TabelaFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("| Nome               | Telefone        | Email             |");
            Console.WriteLine("-------------------------------------------------------------");

            foreach(var contato in contatos)
            {
                Console.WriteLine($"| {contato.nome,-18} | {contato.numero,-16} | {contato.email,-17} |");
            }

            Console.WriteLine("-------------------------------------------------------------");
        }
    }
}
