using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public abstract class Movimento : IMovimenta
    {
        private IMovimenta _proxima;

        public Movimento(IMovimenta movimenta)
        {
            _proxima = movimenta;
        }

        public void Movimenta(MovimentaEnum movimento)
        {
            if (IsMovimento(movimento))
                Acao(movimento);
            else
                _proxima.Movimenta(movimento);
        }

        public abstract bool IsMovimento(MovimentaEnum movimento);

        public abstract void Acao(MovimentaEnum movimento);
            
    }
}
