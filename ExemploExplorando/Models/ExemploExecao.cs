using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class ExemploExecao
    {
        public void Metodo1(){
            try
            {
                Metodo2();
            }catch(Exception x)
            {
                Console.WriteLine($"Exeção tratada. {x.StackTrace}");//.StackTrace mostra o caminho 
            }
        }

        public void Metodo2(){
            Metodo3();
        }

        public void Metodo3(){
            Metodo4();
        }

        public void Metodo4(){
            throw new Exception("Ocorreu uma exeção"); //O trhow tenta tratar a exeção de baixo para cima, procurando um catch.
        }
    }
}