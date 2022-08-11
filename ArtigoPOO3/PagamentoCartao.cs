using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO3
{
    public class PagamentoCartao : Pagamento
    {
        public override void valorRecebido(double p_valor)
        {
            double valorComTaxa = (0.03 * p_valor) + p_valor;

            Pagamento.totalRecebido += valorComTaxa;
        }
    }
}
