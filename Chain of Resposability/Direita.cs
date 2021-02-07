using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public class Direita : Movimento
    {
        public Direita(IMovimenta movimenta) : base(movimenta)
        {
        }

        public override string Acao(MovimentaEnum movimento)
        {
            return "Direita";
        }

        public override bool IsMovimento(MovimentaEnum movimento)
            => movimento == MovimentaEnum.DIREITA;
    }
}
