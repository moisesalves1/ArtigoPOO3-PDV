using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtigoPOO3
{
    public class PDV
    {
        private int codigo_PDV;

        private String nome_usuario_caixa;

        private String turno;

        public Boolean status_PDV;

        public DateTime data_hora_abertura;

        public DateTime data_hora_fechamento;

        public double valor_dinheiro_abertura;

        public int valor_dinheiro_fechamento;

        public int quantidade_vendas;

        private PDV()
        {
        }

        public PDV(int p_codigo_PDV, String p_nome_usuario_caixa, String p_turno)
        {
            //Seta os valores
            codigo_PDV = p_codigo_PDV;
            nome_usuario_caixa = p_nome_usuario_caixa;
            turno = p_turno;
        }

        public int getCodigoPDV() { return codigo_PDV; }
        public string getNomeUsuarioCaixa() { return nome_usuario_caixa; }
        public string getTurno() { return turno; }
    }
}
