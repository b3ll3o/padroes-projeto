using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Subtrai : ICalcula
    {
        public long Calcula(long numero, long outroNumero)
            => numero - outroNumero;
    }
}
