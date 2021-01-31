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

        public override void Acao(MovimentaEnum movimento)
        {
            Console.WriteLine("Direita");
        }

        public override bool IsMovimento(MovimentaEnum movimento)
            => movimento == MovimentaEnum.DIREITA;
    }
}
