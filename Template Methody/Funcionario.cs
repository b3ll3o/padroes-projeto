using System;
using System.Collections.Generic;
using System.Text;

namespace Template_Methody
{
    public class Funcionario
    {
        public Funcionario(string nome, decimal salario, CargoEnum cargo)
        {
            Nome = nome;
            Salario = salario;
            Cargo = cargo;
        }

        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public CargoEnum Cargo { get; set; }


    }
}
