using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(decimal valor)//Como esta abtratic na classe principal essa classe Creditar tem que ser criada obrigatoriamente
        {
            Saldo += valor;
        }
    }
}