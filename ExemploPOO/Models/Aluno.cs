using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploPOO.obj;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //Herança - Aluno esta herdando a classe Pessoa
    {
    
        public Aluno(string nome) : base(nome) //Recebeu o contruto da classe Principal
        {
        }

        public Aluno()
        {
            
        }

        public int Nota { get; set; }

        public override void Apresentar() //Fazendo o polimorfismo do metodo da classe principal/Pai
        {
            {
                System.Console.WriteLine($"Aluno {Nome} de {Idade} anos, tirou a nota {Nota}");
            }
        }

    }
}