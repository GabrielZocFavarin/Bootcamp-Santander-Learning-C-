using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Santander_Learning_C_.Models
{
    public class Produto
    {

        public string Nome { get; set; }
        public int quantidadeEmEstoque { get; set; }

        public Produto(string nome, int quantidade)
        {
            Nome = nome;
            quantidadeEmEstoque = quantidade;
        }

        public void ValidarEstoque(int quantidadeDesejada)
        {
            if (quantidadeEmEstoque > 0)
            {
                if (quantidadeDesejada <= quantidadeEmEstoque)
                {
                    Console.WriteLine($"O produto {Nome} está disponível para compra. Quantidade solicitada: {quantidadeDesejada}");
                }
                else
                {
                    Console.WriteLine($"Quantidade solicitada ({quantidadeDesejada}) excede o estoque disponível ({quantidadeEmEstoque}).");
                }
            }
            else
            {
                Console.WriteLine($"O produto {Nome} está esgotado no estoque.");
            }
        }

    }
}