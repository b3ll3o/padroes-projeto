using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Methody
{
    public static class AumentarSalarioFactory
    {
        public static AumentarSalario Create(Funcionario funcionario)
        {
            switch (funcionario.Cargo)
            {
                case CargoEnum.FUNCIONARIO:
                    return new AumentarSalarioFuncionario();
                default:
                    return new AumentarSalarioGerente();
            }
        }
    }
}
