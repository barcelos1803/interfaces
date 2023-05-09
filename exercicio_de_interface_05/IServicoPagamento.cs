using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_05
{
    public interface IServicoPagamento
    {
    void EfetuarPagamento(double valor);
    void EstornarPagamento(double valor);
    }
}