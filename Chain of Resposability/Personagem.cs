using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public class Personagem
    {
        public void Anda(MovimentaEnum movimento)
        {
            new Direita(new Esquerda(new Parado())).Movimenta(movimento);
        }
    }
}
