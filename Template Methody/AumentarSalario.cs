using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Methody
{
    public abstract class AumentarSalario
    {
        public Decimal Aumentar(Funcionario funcionario)
        {
            if (IsValidParaAumentarSalario(funcionario))
                return Action(funcionario);

            return funcionario.Salario;
        }

        protected abstract decimal Action(Funcionario funcionario);

        protected abstract bool IsValidParaAumentarSalario(Funcionario funcionario);
    }
}
