using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var luz = new Luz();

            var command = new DesligaLuzCommand(luz);

            command.Execute();

            Console.ReadKey();
        }
    }
}
