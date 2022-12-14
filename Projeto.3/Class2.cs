using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto._3
{
    [System.Serializable]
    class ProdutoFisico : Produto, IEstoque


    {
        public float frete;
        private int estoque;

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
            
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar no estoque do produto {nome} ");
            Console.WriteLine("Digite a quantidade ue você quer dar entrada");
            int entrada = int.Parse(Console.ReadLine());
           // estoque = estoque = entrada;
           estoque += entrada;
            Console.WriteLine("Entrada registrada");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar a saida no estoque do produto {nome} ");
            Console.WriteLine("Digite a quantidade ue você quer dar baixa");
            int entrada = int.Parse(Console.ReadLine());
            // estoque = estoque = entrada;
            estoque -= entrada;
            Console.WriteLine("Saida registrada");
            Console.ReadLine();

        }

        public void Exibir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade de Estoque: {estoque}");
            Console.WriteLine("================================");
        }
    }
}
