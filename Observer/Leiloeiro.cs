using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Observer
{
    public class Leiloeiro
    {
        private ICollection<Lance> _lances;
        private ICollection<IObserver> _participantes;

        public Leiloeiro()
        {
            _participantes = new List<IObserver>();
            _lances = new List<Lance>();
        }

        public ParticipanteLeilao Vencedor { get; private set; }

        public void AdicionarParticipante(IObserver participante)
        {
            _participantes.Add(participante);
        }


        public void RecebeLance(Lance lance)
        {
            _lances.Add(lance);
            Vencedor = lance.Participante;
            foreach (var participante in _participantes)
            {
                participante.Observar(lance);
            }
        }
    }
}
