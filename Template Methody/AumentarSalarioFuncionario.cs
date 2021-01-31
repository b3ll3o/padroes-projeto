using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Methody
{
    public class AumentarSalarioFuncionario : AumentarSalario
    {
        protected override decimal Action(Funcionario funcionario)
            => funcionario.Salario += (funcionario.Salario/100) * 5;

        protected override bool IsValidParaAumentarSalario(Funcionario funcionario)
            => funcionario.Cargo == CargoEnum.FUNCIONARIO;
    }
}
