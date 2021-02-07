using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Medio : Status
    {
        public Medio()
        {
            Nome = "Medio";
        }

        public override void Handle(IControladorStatus controlador)
        {
            controlador.SetNewStatus(new Avancado());
            Console.WriteLine(Nome);
        }
    }
}
