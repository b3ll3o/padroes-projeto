using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public abstract class Status
    {
        public string Nome { get; protected set; }

        public abstract void Handle(IControladorStatus controlador);
    }
}
