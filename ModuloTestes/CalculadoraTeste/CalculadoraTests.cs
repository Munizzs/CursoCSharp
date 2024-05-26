using Calculadora.Services;

namespace CalculadoraTeste;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc =  new CalculadoraImp();
    }
    
    [Fact]
    public void DeveSomar5com10eRetornar15()
    {
        //Arrange -cenário
        int num1 = 5;
        int num2 = 10;

        //Act - Ação
        int resultado = _calc.Somar(num1,num2);

        //Assert - Validação
        Assert.Equal(15, resultado);

        //executar os test 'dotnet test'
    }

    [Fact]
    public void CheckIf4IsParAndReturnTrue()
    {
        //Arrange -cenário
        int num = 4;

        //Act - Ação
        bool resultado = _calc.IsPar(num);

        //Assert - Validação
        Assert.True(resultado);

        //executar os test 'dotnet test'
    }

   [Theory]
   [InlineData(2)]
   [InlineData(4)]
   [InlineData(6)]
   [InlineData(8)]
   [InlineData(10)]
    public void CheckIfNumbersIsParAndReturnTrue(int num)
    {

        //Act - Ação
        bool resultado = _calc.IsPar(num);

        //Assert - Validação
        Assert.True(resultado);

        //executar os test 'dotnet test'
    } 

    [Theory]
   [InlineData(new int [] {2, 4})]
   [InlineData(new int [] {6, 8, 10})]
    public void CheckIfNumbersIsParAndReturnTrue2(int[] numeros)
    {

        // Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.IsPar(num)));

        //executar os test 'dotnet test'
    } 
}