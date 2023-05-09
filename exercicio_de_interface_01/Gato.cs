using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_01
{
    class Gato : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("O gato está miando.");
        }
    }
}