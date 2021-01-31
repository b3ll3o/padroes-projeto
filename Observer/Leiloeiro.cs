using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Leiloeiro
    {
        private decimal _lance;
        private ICollection<IObserver> _participantes;

        public Leiloeiro()
        {
            _lance = 10;
            _participantes = new List<IObserver>();
        }

        public void AdicionarParticipante(IObserver participante)
        {
            _participantes.Add(participante);
        }


        public void NovoLance()
        {
            _lance += 10;
            foreach (var participante in _participantes)
            {
                participante.Observar(_lance);
            }
        }
    }
}
