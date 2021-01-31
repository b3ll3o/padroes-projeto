using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public class Esquerda : Movimento
    {
        public Esquerda(IMovimenta movimenta) : base(movimenta)
        {
        }

        public override void Acao(MovimentaEnum movimento)
        {
            Console.WriteLine("Esquerda");
        }

        public override bool IsMovimento(MovimentaEnum movimento)
            => movimento == MovimentaEnum.ESQUERDA;
    }
}
