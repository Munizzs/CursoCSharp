using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }

        public Vendas(int id, string produto, decimal preco, DateTime data)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = data;
        }
    }
}