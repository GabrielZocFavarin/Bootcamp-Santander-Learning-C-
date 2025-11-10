using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp_Santander_Learning_C_.Models
{
    public class Pessoa
    {
        private string NomePrivado { get; set; }


        public Pessoa (string Nome) 
        {
            NomePrivado = Nome;
        }

        public int Idade { get; set; }

        public void Apresentar()
        {   
            Console.WriteLine($"Olá, meu nome é {NomePrivado} e tenho {Idade} anos.");
        }
    }
}