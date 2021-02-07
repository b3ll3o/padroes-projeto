using System;
using Xunit;
using State;

namespace StateTest
{
    public class StateTest
    {
        [Fact]
        public void DeveComecarNoStatusInicial()
        {
            var regulador = new ReguladorStatus();

            Assert.Equal("Inicial", regulador.Status.Nome);
        }

        [Fact]
        public void DeveEstarNoStatusMedio()
        {
            var regulador = new ReguladorStatus();

            regulador.Handle();

            Assert.Equal("Medio", regulador.Status.Nome);
        }

        [Fact]
        public void DeveEstarNoStatusAvancado()
        {
            var regulador = new ReguladorStatus();

            regulador.Handle();
            regulador.Handle();

            Assert.Equal("Avancado", regulador.Status.Nome);
        }
    }
}
