using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var reguladorStatus = new ReguladorStatus();

            while (true)
            {
                reguladorStatus.Handle();
                Console.ReadKey();
            }
        }
    }
}
