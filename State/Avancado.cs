using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class Avancado : Status
    {
        public Avancado()
        {
            Nome = "Avancado";
        }

        public override void Handle(IControladorStatus controlador)
        {
            controlador.SetNewStatus(new Inicial());
            Console.WriteLine(Nome);
        }
    }
}
