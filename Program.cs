using System;
using System.Collections.Generic;
using Bootcamp_Santander_Learning_C_.Models;

Calculadora calc = new Calculadora();

// Console.WriteLine("== PROGRAMA PARA OPERAÇÕES BÁSICAS DE UMA CALCULADORA ==");
// Console.WriteLine("Digite o primeiro número:");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Digite o segundo número:");
// int num2 = int.Parse(Console.ReadLine());

// calc.Somar(num1, num2);
// calc.Subtrair(num1, num2);
// calc.Multiplicar(num1, num2);
// calc.Dividir(num1, num2);
// calc.Potencia(num1, num2);
// calc.Seno(num1);
// calc.Coseno(num1);
// calc.Tangente(num1);

// distrinchando um pouco sobre a biblioteca Math e os operadores. Relembrando.

// Trabalhando com Incremento e Decremento

int numero = 10;
Console.WriteLine($"Valor inicial: {numero}");

for (int i = 0; i < 20; i++)
{
    numero++; // Incremento
    Console.WriteLine($"Após incremento {i + 1}: {numero}");
}

for (int i = 0; i < 15; i++)
{
    numero--; // Decremento
    Console.WriteLine($"Após decremento {i + 1}: {numero}");
}