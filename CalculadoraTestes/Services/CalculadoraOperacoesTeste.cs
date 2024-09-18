using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;
using Xunit;

namespace CalculadoraTestes.Services
{
    public class CalculadoraOperacoesTeste
    {
        CalculadoraOperacoes calc = new CalculadoraOperacoes();

        [Fact]
        public void TesteSomar_DoisValoresInteiros_RetornarASoma()
        {
            //Arrange
            int val1 = 20;
            int val2 = 30;

            // Act
            int resultado = calc.Somar(val1, val2);

            // Assert
            Assert.Equal(50, resultado);
        }

        [Fact]
        public void TesteSubitrair_DoisValoresInteiros_RetornarASubitracao()
        {
            //Arrange
            int val1 = 30;
            int val2 = 20;

            // Act
            int resultado = calc.Subitrair(val1, val2);

            // Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void TesteMultiplicar_DoisValoresInteiros_RetornarAMultiplicacao()
        {
            //Arrange
            int val1 = 2;
            int val2 = 3;

            // Act
            int resultado = calc.Multiplicar(val1, val2);

            // Assert
            Assert.Equal(6, resultado);
        }

        [Fact]
        public void TesteDividir_DoisValoresInteiros_RetornarADivisao()
        {
            //Arrange
            int val1 = 20;
            int val2 = 2;

            // Act
            int resultado = calc.Dividir(val1, val2);

            // Assert
            Assert.Equal(10, resultado);
        }

        [Fact]
        public void TesteDividir_ValorePorZero_RetornarADivisao()
        {
            //Arrange
            int val1 = 20;
            int val2 = 0;

            // Act

            // Assert
            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(val1, val2)
            );
        }

        [Fact]
        public void TestePegarOHistorico_DasTresUltimasOperacoe_RetornarOHistorico()
        {
            //Arrange
            // Act
            calc.Somar(1, 2);
            calc.Somar(5, 2);
            calc.Somar(7, 5);
            calc.Somar(8, 1);
            calc.Somar(6, 6);

            var lista = calc.Historico();

            // Assert
            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}