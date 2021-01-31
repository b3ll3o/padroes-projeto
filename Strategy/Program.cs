using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora(10, 20);

            Console.WriteLine($"Resultado Soma: {calculadora.Calcula(new Soma())}");
            Console.WriteLine($"Resultado Subtração: {calculadora.Calcula(new Subtrai())}");

            Console.ReadKey();
        }
    }
}
