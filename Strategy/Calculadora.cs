using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Calculadora
    {
        private readonly long _numero;
        private readonly long _outroNumero;
        public Calculadora(long numero, long outroNumero)
        {
            _numero = numero;
            _outroNumero = outroNumero;
        }

        public long Calcula(ICalcula calculo)
            => calculo.Calcula(_numero, _outroNumero);
    }
}
