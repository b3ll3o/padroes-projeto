using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var leiloeiro = new Leiloeiro();

            var p1 = new Participante(leiloeiro, 10);
            var p2 = new Participante(leiloeiro, 10);
            var p3 = new Participante(leiloeiro, 10);

            leiloeiro.AdicionarParticipante(p1);
            leiloeiro.AdicionarParticipante(p2);
            leiloeiro.AdicionarParticipante(p3);

            p1.FazerLance();
            p2.FazerLance();
            p3.FazerLance();

            p2.FazerLance();

            Console.ReadKey();


        }
    }
}
