using System;
using System.Collections.Generic;
using System.Diagnostics;
using Bootcamp_Santander_Learning_C_.Models;

class Program4
{
    static void Main(string[] args)
    {
        Console.WriteLine(" PROGRAMA PARA APLICAÇÃO DE SWITCH E CASE ");

        Console.WriteLine(" Escolha um número de 1 a 5 ");

        // abaixo a IA me ajudou em uma validação: Validar se a entrada é nula ou vazia
        string? input = Console.ReadLine();
        int numero;
        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out numero))
        {
            numero = -1; // valor inválido
        }

        switch (numero)
        {
            case 1:
                Console.WriteLine(" Você escolheu o número 1 ");
                break;
            case 2:
                Console.WriteLine(" Você escolheu o número 2 ");
                break;
            case 3:
                Console.WriteLine(" Você escolheu o número 3 ");
                break;
            case 4:
                Console.WriteLine(" Você escolheu o número 4 ");
                break;
            case 5:
                Console.WriteLine(" Você escolheu o número 5 ");
                break;
            default:
                Console.WriteLine(" Número inválido! Escolha um número entre 1 e 5. ");
                break;
        }
        ;
    }
}