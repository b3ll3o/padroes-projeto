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

        public string Movimenta(MovimentaEnum movimento)
        {
            if (IsMovimento(movimento))
                return Acao(movimento);
            
            return _proxima.Movimenta(movimento);
        }

        public abstract bool IsMovimento(MovimentaEnum movimento);

        public abstract string Acao(MovimentaEnum movimento);
            
    }
}
