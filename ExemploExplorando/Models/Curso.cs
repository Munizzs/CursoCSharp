using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int QuantidadeAluno()
        {
            return Alunos.Count;
        }

        public bool Remover(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void Listar()
        {
            foreach(Pessoa show in Alunos)
            {
                Console.WriteLine($"|{show.NomeCompleto}|");
            }
        }
     }
}