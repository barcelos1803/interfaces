using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_04
{
    public interface ICalculadora
    {
        double Somar(double a, double b);
        double Subtrair(double a, double b);
        double Multiplicar(double a, double b);
        double Dividir(double a, double b);
    }
}