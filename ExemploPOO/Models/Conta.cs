using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public abstract class Conta //abstract quer dizer que a classe não pode ser instanciada na classe Main
    {
        protected decimal Saldo; //protected é protegido contra alterações externas apenas classes filhas podem acessar

        public abstract void Creditar(decimal valor); // abstract no metodo não tem implementação {}

        public void ExibirSaldo()
        {
            Console.WriteLine($"O seu saldo é de {Saldo.ToString("C")}");
        }
    }
}