using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.obj;

namespace ExemploPOO.Models
{
    public sealed class Professor : Pessoa //Herança - Professor esta herdando a classe Pessoa || sealed em classe quer dizer que não pode ser herdada
    {
        public Professor(string nome) : base(nome)//Recebeu o contruto da classe Principal
        {
        }

        public Professor()
        {
            
        }

        public decimal Salario { get; set; }

        public sealed override void Apresentar() //sealed em metodo não pode ser sobreescrevido
        {
            {
                System.Console.WriteLine($"Professor {Nome} de {Idade} anos, tem um salario de {Salario.ToString("C")}");
            }
        }
    }
}