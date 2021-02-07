using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Lance
    {
        public Lance(Participante participante, decimal valor)
        {
            Participante = participante;
            Valor = valor;
        }

        public Participante Participante { get; private set; }
        public decimal Valor { get; private set; }
    }
}
