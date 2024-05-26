using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3()
        {
            //Arrange -cenário
            string text = "Olá";

            //Act - Ação
            int resultado = _validacoes.ContarCaracteres(text);

            //Assert - Validação
            Assert.Equal(3,resultado);

            //executar os test 'dotnet test'           
        }
    }
}