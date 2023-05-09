using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_03
{
    public class Dog : IAnimalEstimacao
    {
        public string Nome { get; set; }
        public string Dono { get; set; }

        public Dog(string nome, string dono)
        {
            Nome = nome;
            Dono = dono;
        }
    }
}