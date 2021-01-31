using System;

namespace Template_Methody
{
    class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario("Funcionario", 100, CargoEnum.FUNCIONARIO);
            var gerente = new Funcionario("Gerente", 100, CargoEnum.GERENTE);

            var aumentarSalario = AumentarSalarioFactory.Create(funcionario);

            Console.WriteLine(aumentarSalario.Aumentar(funcionario));

            Console.WriteLine(aumentarSalario.Aumentar(gerente));

            Console.ReadKey();
        }
    }
}
