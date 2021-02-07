using System;
using Xunit;
using Strategy;

namespace StrategyTest
{
    public class StrategyTest
    {
        [Fact]
        public void DeveRetornarOResultadoDaSoma()
        {
            var calculadora = new Calculadora(10, 20);

            Assert.Equal(30, calculadora.Calcula(new Soma()));
        }

        [Fact]
        public void DeveRetornarOResultadoDaSubtracao()
        {
            var calculadora = new Calculadora(20, 10);

            Assert.Equal(10, calculadora.Calcula(new Subtrai()));
        }
    }
}
