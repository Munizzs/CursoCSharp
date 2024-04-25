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
            int cont=1;
            foreach(Pessoa show in Alunos)
            {
                //string txt = "#"+cont+" |"+show.NomeCompleto+"|"; // Concactenização
                string txt = $"#{cont} |{show.NomeCompleto}|"; //Interpolação
                Console.WriteLine(txt);
                cont++;
            }
        }
     }
}