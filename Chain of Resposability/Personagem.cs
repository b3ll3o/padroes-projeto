using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_Resposability
{
    public class Personagem
    {
        public string Anda(MovimentaEnum movimento)
        {
            return new Direita(new Esquerda(new Parado())).Movimenta(movimento);
        }
    }
}
