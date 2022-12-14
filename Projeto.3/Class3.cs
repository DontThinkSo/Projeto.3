using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto._3
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.autor = autor;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            {
                Console.WriteLine("não é possivel dar entrada em um e-book, pois é um produto digital.");
                Console.ReadLine();
            }

        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar vendas no e-book do produto {nome} ");
            Console.WriteLine("Digite a quantidade de vendas que você quer dar entrada");
            int entrada = int.Parse(Console.ReadLine());
            // estoque = estoque = entrada;
            vendas += entrada;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("================================");
        }
    }
}
