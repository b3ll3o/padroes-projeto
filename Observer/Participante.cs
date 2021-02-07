using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Participante : ParticipanteLeilao
    {
        public Participante(string nome) : base(nome)
        {
        }

        public override void Observar(Lance lance)
        {
            _ultimoLance = lance;
        }

        public Lance FazerLance(decimal valor)
            => new Lance(this, valor);
    }
}
