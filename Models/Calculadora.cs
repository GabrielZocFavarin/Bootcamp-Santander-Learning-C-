using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Santander_Learning_C_.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(int x, int y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(int x, int y)
        {
            Console.WriteLine($"{x} * {y} = {x * y}");
        }

        public void Dividir(int x, int y)
        {
            if (y != 0)
            {
                Console.WriteLine($"{x} / {y} = {x / y}");
            }
            else
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
            }
        }

        public void Potencia(int x, int y)
        {
            double valorPotencia = Math.Pow(x, y);
            Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
            Console.WriteLine($"{x} ^ {y} = {valorPotencia}");
        }

        public void Seno(double angulo)
        {
            double valorSeno = Math.Sin(angulo);
            Console.WriteLine($"Seno de {angulo} = {valorSeno}");
        }

        public void Coseno(double angulo)
        {
            double valorCoseno = Math.Cos(angulo);
            Console.WriteLine($"Cosseno de {angulo} = {valorCoseno}");
        }

        public void Tangente(double angulo)
        {
            double valorTangente = Math.Tan(angulo);
            Console.WriteLine($"Tangente de {angulo} = {valorTangente}");
        }
        
        public void RaizQuadrada(double numero)
        {
            if (numero >= 0)
            {
                double resultado = Math.Sqrt(numero);
                Console.WriteLine($"Raiz quadrada de {numero} = {resultado}");
            }
            else
            {
                Console.WriteLine("Erro não foi possível calcular a Raiz.");
            }
        }
    }
}