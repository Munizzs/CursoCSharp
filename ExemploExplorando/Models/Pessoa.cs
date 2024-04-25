using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {

        public Pessoa()
        {

        }

        public Pessoa(String nome, string sobre)
        {
            Nome = nome;
            Sobrenome = sobre;
        }
        private string _nome; 

        public string Sobrenome { get; set; }

        public string Nome 
        { 
            get
            {
                return _nome;
            } 

            //get => _nome;    //Body exprecion é uma forma mais resumida.       

            set
            {
                if(value==""){
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            } 

            //set => _nome = value;
        }

        private int _idade;
        public int Idade 
        { 
            get => _idade; 
            
            set{
                if(value<=0)
                {
                    throw new ArgumentException("Idade n~~ao pode ser menor que 0");
                }
                _idade =value;
            }
        }

        public string NomeCompleto => $"{_nome} {Sobrenome}"; //propriedade que só utiliza o get


        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }

    }
}