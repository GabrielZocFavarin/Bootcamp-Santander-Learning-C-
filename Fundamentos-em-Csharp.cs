// Bootcamp Santander Learning - Fundamentos de C#
// Autor: Gabriel Fava
// Propósito: Relembrar e praticar conceitos fundamentais do C#

using System;
using System.Collections.Generic;
using Bootcamp_Santander_Learning_C_.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Iniciando o programa ===\n");

        // ---------------------------
        // VARIÁVEIS E TIPOS BÁSICOS
        // ---------------------------
        string nome = "Gabriel Fava";
        int idade = 25;
        double altura = 1.75;
        bool ativo = true;

        Console.WriteLine($"Nome: {nome}, Idade: {idade}, Altura: {altura}, Ativo: {ativo}\n");

        // ---------------------------
        // LOOP WHILE
        // ---------------------------
        int quantidade = 5;
        Console.WriteLine("Contagem regressiva:");
        while (quantidade > 0)
        {
            Console.WriteLine(quantidade);
            quantidade--;
        }

        // ---------------------------
        // DATA E HORA
        // ---------------------------
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"Data Atual: {dataAtual}\n");

        // ---------------------------
        // CONVERSÕES
        // ---------------------------
        string numeroString = "15";
        int usoConvert = Convert.ToInt32(numeroString);
        int usoParse = int.Parse(numeroString);

        Console.WriteLine($"Número Convertido: {usoConvert}");
        Console.WriteLine($"Número Parseado: {usoParse}\n");

        // Conversão segura com TryParse
        string x = "15";
        if (int.TryParse(x, out int y))
        {
            Console.WriteLine($"Conversão com TryParse bem-sucedida! Valor: {y}");
        }
        else
        {
            Console.WriteLine("Falha na conversão com TryParse!");
        }

        // ---------------------------
        // CAST IMPLÍCITO E EXPLÍCITO
        // ---------------------------
        int inteiro = 5;
        double real = inteiro; // implícito
        Console.WriteLine($"Cast Implícito: int -> double = {real}");

        double valorDecimal = 10.8;
        int valorInteiro = (int)valorDecimal; // explícito (perde a parte decimal)
        Console.WriteLine($"Cast Explícito: double -> int = {valorInteiro}\n");

        // Ou seja, o explicito ocorre quando há perdas para a conversão, e Implícito vice-versa.

        // ---------------------------
        // CONDICIONAIS
        // ---------------------------
        int numero = 8;
        if (numero % 2 == 0)
            Console.WriteLine($"{numero} é par!");
        else
            Console.WriteLine($"{numero} é ímpar!");


        // ---------------------------
        // LISTAS
        // ---------------------------
        List<string> frutas = new List<string> { "Maçã", "Banana", "Laranja" };
        frutas.Add("Abacaxi");
        frutas.Remove("Banana");

        Console.WriteLine("Lista de Frutas:");
        foreach (var fruta in frutas)
        {
            Console.WriteLine($"- {fruta}");
        }

        // ---------------------------
        // MÉTODOS
        // ---------------------------
        int soma = Somar(10, 5);
        int subtracao = Subtrair(20, 8);

        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {subtracao}");

        // ---------------------------
        // CLASSES E OBJETOS
        // ---------------------------
        Pessoa p = new Pessoa("Gabriel") { Idade = 25 };
        Pessoa p1 = new Pessoa("Ana Maria") { Idade = 30 };
        Pessoa p2 = new Pessoa("João do TEF") { Idade = 28 };

        p.Apresentar();
        p1.Apresentar();
        p2.Apresentar();
    }

    // ---------------------------
    // MÉTODOS AUXILIARES
    // ---------------------------
    static int Somar(int a, int b)
    {
        return a + b;
    }

    static int Subtrair(int a, int b)
    {
        return a - b;
    }
}
