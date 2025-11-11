using System;
using System.Collections.Generic;
using Bootcamp_Santander_Learning_C_.Models;
using Microsoft.VisualBasic;

class Program2
{
    static void Main(string[] args)
    {
        Console.WriteLine(" == PROGRAMA PARA VALIDAÇÃO DE ESTOQUE == ");

        Console.WriteLine(" Digite o nome do Produto que seja validar o estoque: ");
        string nomeProduto = Console.ReadLine();

        Console.WriteLine(" Digite a quantidade deste produto em estoque: ");
        int quantidadeProduto = int.Parse(Console.ReadLine());

        Console.WriteLine(" Digite o quanto você deseja desse produto: ");
        int quantidadeDesejada = int.Parse(Console.ReadLine());
        

        if (!string.IsNullOrEmpty(nomeProduto) && quantidadeDesejada <= quantidadeProduto)
        {
            Produto produto = new Produto(nomeProduto, quantidadeProduto);
            produto.ValidarEstoque(quantidadeDesejada);
        }
        else
        {
            Console.WriteLine($"Quantidade solicitada ({quantidadeDesejada}) excede o estoque disponível ({quantidadeProduto}).");
        }


    }
}