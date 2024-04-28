using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    public class ContaCorrente
    {
        public int NumeroConta { get; set; }
        private decimal Saldo;

        public ContaCorrente(int nc,decimal saldIni)
        {
            NumeroConta = nc;
            Saldo = saldIni;
        }

        public void SacarValor(decimal valor)
        {
            if(Saldo>=valor)
            {
                Saldo -= valor;
                Console.WriteLine("Saldo realizado com sucesso.");
            }else{
                Console.WriteLine("Saldo Insuficiente.");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponivel: {Saldo.ToString("C")}");
        }
    }
}