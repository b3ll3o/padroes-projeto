using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Inicial : Status
    {
        public override void Handle(IControladorStatus controlador)
        {
            controlador.SetNewStatus(new Medio());
            Console.WriteLine("Inicial");
        }
    }
}
