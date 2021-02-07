using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Inicial : Status
    {
        public Inicial()
        {
            Nome = "Inicial";
        }

        public override void Handle(IControladorStatus controlador)
        {
            controlador.SetNewStatus(new Medio());
            Console.WriteLine(Nome);
        }
    }
}
