using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Soma : ICalcula
    {
        public long Calcula(long numero, long outroNumero)
            => numero + outroNumero;
    }
}
