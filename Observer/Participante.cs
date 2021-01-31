using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Participante : ParticipanteLeilao
    {
        public Participante(Leiloeiro leiloeiro, decimal lance)
        {
            _leiloeiro = leiloeiro;
            _lance = lance;
        }

        public override void Observar(decimal novoLance)
        {
            _lance = novoLance;
        }

        public void FazerLance()
        {
            Console.WriteLine(_lance);
            _leiloeiro.NovoLance();
        }
    }
}
