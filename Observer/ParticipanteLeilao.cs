using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class ParticipanteLeilao : IObserver
    {
        protected Leiloeiro _leiloeiro;
        protected decimal _lance;

        public abstract void Observar(decimal novoLance);
    }
}
