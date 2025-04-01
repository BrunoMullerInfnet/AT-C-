using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX12
{
    public class RawTextFormatter : ContatoFormatter
    {
        public override void ExibirContatos(List<Contatos> contatos)
        {
            foreach (var contato in contatos)
            {
                Console.WriteLine($"Nome: {contato.nome} | Telefone: {contato.numero} | Email: {contato.email}");
            }
        }
    }
}
