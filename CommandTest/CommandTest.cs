using System;
using Xunit;
using Command;

namespace CommandTest
{
    public class CommandTest
    {
        [Fact]
        public void DeveDesligarALuz()
        {
            var luz = new Luz();

            var command = new DesligaLuzCommand(luz);

            Assert.Equal("Desliga", command.Execute());
        }

        [Fact]
        public void DeveLigarALuz()
        {
            var luz = new Luz();

            var command = new LigaLuzCommand(luz);

            Assert.Equal("Liga", command.Execute());
        }
    }
}
