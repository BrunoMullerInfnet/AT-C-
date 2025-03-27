using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX8
{
    public class Produto
    {
        public string nome { get; set; }
        public int quantidade { get; set; }
        public double preco { get; set; }

        public Produto(string nome, int quantidade, double preco)
        {
            this.nome = nome;
            this.quantidade = quantidade;
            this.preco = preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Produto: {nome}| Quantidade: {quantidade}| Preço: R$ {preco}\n");
        }
    }


}
