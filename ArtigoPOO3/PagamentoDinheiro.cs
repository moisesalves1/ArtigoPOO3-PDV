using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO3
{
    public class PagamentoDinheiro : Pagamento
    {
        public override void valorRecebido(double p_valor)
        {
            Pagamento.totalRecebido += p_valor;
        }
    }       
}
