using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.obj
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar() //virtual quer dizer que esse metodo pode ser sobreescrito se desejar
        {
            Console.WriteLine($"Olá meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}