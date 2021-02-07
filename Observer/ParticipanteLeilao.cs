using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public abstract class ParticipanteLeilao : IObserver
    {
        protected Lance _ultimoLance;

        public ParticipanteLeilao(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; }

        public abstract void Observar(Lance lance);
    }
}
