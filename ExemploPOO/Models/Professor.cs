using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.obj;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa //Herança - Professor esta herdando a classe Pessoa
    {
        public decimal Salario { get; set; }

        public override void Apresentar()
        {
            {
                System.Console.WriteLine($"Professor {Nome} de {Idade} anos, tem um salario de {Salario.ToString("C")}");
            }
        }
    }
}