using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1,int n2); // metodo sem corpo é obrigatório ser implementado na classe
        public int Subtrair(int n1, int n2) //Quando o metodo tem corpo é opcinal implementar na classe
        {
            return n1 - n2;
        }
        int Multiplicar(int n1,int n2);
        int Dividir(int n1,int n2);
    }
}