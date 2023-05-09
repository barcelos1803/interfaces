using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_02
{
    public class FormatadorMinusculo
    {
        public string Formatar(string texto)
        {
            return texto.ToLower();
        }
    }
}