using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Methody
{
    public class AumentarSalarioGerente : AumentarSalario
    {
        protected override decimal Action(Funcionario funcionario)
            => funcionario.Salario += (funcionario.Salario / 100) * 10;

        protected override bool IsValidParaAumentarSalario(Funcionario funcionario)
            => funcionario.Cargo == CargoEnum.GERENTE;
    }
}
