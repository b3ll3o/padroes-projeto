using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public class Parado : Movimento
    {
        public Parado() : base(null)
        {
        }

        public override string Acao(MovimentaEnum movimento)
        {
            return "Parado";
        }

        public override bool IsMovimento(MovimentaEnum movimento)
            => true;
    }
}
