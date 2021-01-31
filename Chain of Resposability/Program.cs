using System;

namespace Chain_of_Resposability
{
    class Program
    {
        static void Main(string[] args)
        {
            var personagem = new Personagem();

            personagem.Anda(MovimentaEnum.ESQUERDA);
            personagem.Anda(MovimentaEnum.DIREITA);

            personagem.Anda(MovimentaEnum.FRENTE);

            Console.ReadKey();
        }
    }
}
