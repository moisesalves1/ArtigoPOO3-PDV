using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO3
{
    public class PDV_Pagamento : PDV
    {
        public PDV_Pagamento(int p_codigo_PDV, String p_nome_usuario_caixa, String p_turno)
            : base(p_codigo_PDV, p_nome_usuario_caixa, p_turno)
        {
        }

        public double pagarConta(double valorPagamento, double valorRecebido)
        {
            double troco = (valorRecebido - valorPagamento);

            return troco;
        }
    }
}
