using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_de_interface_05
{
    public class PagamentoPaypal : IServicoPagamento
    {
        public void EfetuarPagamento(double valor)
        {
            Console.WriteLine($"Pagamento de R${valor} efetuado com Paypal.");
        }

        public void EstornarPagamento(double valor)
        {
            Console.WriteLine($"Estorno de pagamento de R${valor} efetuado no Paypal.");
        }
    }
}