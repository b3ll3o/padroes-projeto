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

        public override void Acao(MovimentaEnum movimento)
        {
            Console.WriteLine("Parado");
        }

        public override bool IsMovimento(MovimentaEnum movimento)
            => true;
    }
}
