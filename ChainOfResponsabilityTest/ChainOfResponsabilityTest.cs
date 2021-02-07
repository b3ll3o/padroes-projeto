using System;
using Xunit;
using Chain_of_Resposability;

namespace ChainOfResponsabilityTest
{
    public class ChainOfResponsabilityTest
    {
        [Fact]
        public void DeveVirarAEsquerda()
        {
            var personagem = new Personagem();

            Assert.Equal("Esquerda", personagem.Anda(MovimentaEnum.ESQUERDA));
        }

        [Fact]
        public void DeveVirarADireita()
        {
            var personagem = new Personagem();

            Assert.Equal("Direita", personagem.Anda(MovimentaEnum.DIREITA));
        }

        [Fact]
        public void DeveFicarParado()
        {
            var personagem = new Personagem();

            Assert.Equal("Parado", personagem.Anda(MovimentaEnum.FRENTE));
        }
    }
}
