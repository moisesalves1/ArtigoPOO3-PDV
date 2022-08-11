using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO3
{
    public class Pagamento
    {
        protected static double totalRecebido;

        public virtual void valorRecebido(double p_valor)
        {
            Pagamento.totalRecebido += p_valor;
        }

        public double getTotalRecebido()
        {
            return totalRecebido;
        }
    }
}
