using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhas, int qtdLinhas) LerArquivo(String conteudo)//Retorna uma tupla.
        {
            try
            {
                string[] linhas = File.ReadAllLines(conteudo);
                return (true,linhas,linhas.Count());
            }catch(Exception x)
            {
                return (false,new string[0],0);
            }
        }
    }
}