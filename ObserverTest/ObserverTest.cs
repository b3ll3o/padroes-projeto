using System;
using Xunit;
using Observer;

namespace ObserverTest
{
    public class ObserverTest
    {
        [Fact]
        public void DeveTerUmGanhadorLeilao()
        {
            var leiloeiro = new Leiloeiro();

            var leo = new Participante("leo");
            var pedro = new Participante("pedro");
            var joao = new Participante("joão");

            leiloeiro.AdicionarParticipante(leo);
            leiloeiro.AdicionarParticipante(pedro);
            leiloeiro.AdicionarParticipante(joao);

            leiloeiro.RecebeLance(leo.FazerLance(10));
            leiloeiro.RecebeLance(pedro.FazerLance(20));
            leiloeiro.RecebeLance(joao.FazerLance(30));
            leiloeiro.RecebeLance(pedro.FazerLance(40));

            Assert.Equal("pedro", leiloeiro.Vencedor.Nome);
        }
    }
}
