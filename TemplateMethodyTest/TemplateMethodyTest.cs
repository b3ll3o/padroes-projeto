using System;
using Xunit;
using Template_Methody;

namespace TemplateMethodyTest
{
    public class TemplateMethodyTest
    {
        [Fact]
        public void DeveAumentar10PorCentoDoSalarioGerente()
        {
            var gerente = new Funcionario("Gerente", 100, CargoEnum.GERENTE);

            var aumentarSalario = AumentarSalarioFactory.Create(gerente);

            Assert.Equal(110, aumentarSalario.Aumentar(gerente));
        }

        [Fact]
        public void DeveAumentar5PorCentoDoSalarioFuncionario()
        {
            var funcionario = new Funcionario("Gerente", 100, CargoEnum.FUNCIONARIO);

            var aumentarSalario = AumentarSalarioFactory.Create(funcionario);

            Assert.Equal(105, aumentarSalario.Aumentar(funcionario));
        }
    }
}
