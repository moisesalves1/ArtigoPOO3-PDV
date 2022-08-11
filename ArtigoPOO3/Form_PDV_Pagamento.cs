using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtigoPOO3
{
    public partial class Form_PDV_Pagamento : Form
    {
        //Definição de variáveis
        PDV_Pagamento objPdvPagamento;
        Pagamento objTipoPagamento;
        double valorRecebidoCartao;
        double valorTaxaCartao;
        double valorRecebidoDinheiro;
        double valorPagamento;
        double valorDinheiroRecebido;
        double trocoCliente;
        double valorTotalRecebido;

        public Form_PDV_Pagamento()
        {
            InitializeComponent();
        }

        private void Form_PDV_Pagamento_Load(object sender, EventArgs e)
        {
            //Cria a instância do PDV
            objPdvPagamento = new PDV_Pagamento(10, "DEVMEDIA", "Manhã");

            //Seta valor para abertura do caixa
            objPdvPagamento.status_PDV = true;
            objPdvPagamento.valor_dinheiro_abertura = 100;
            objPdvPagamento.data_hora_abertura = DateTime.Now;

            //Mostra o nome do usário do PDV
            lblInformacoesCaixa.Text = "Usuário: " + objPdvPagamento.getNomeUsuarioCaixa();
        }       

        private void btnRealizarPagamento_Click(object sender, EventArgs e)
        {
            //Processa entrada pagamento cartão de crédito
                objTipoPagamento = new PagamentoCartao();
                valorRecebidoCartao = double.Parse(txtValorCartaoRecebido.Text);
                objTipoPagamento.valorRecebido(valorRecebidoCartao);
                valorTaxaCartao = (objTipoPagamento.getTotalRecebido() - valorRecebidoCartao);          

            //Processa entrada pagamento em dianheiro           
                objTipoPagamento = new PagamentoDinheiro();
                valorRecebidoDinheiro = double.Parse(txtValorDinheiroRecebido.Text);
                objTipoPagamento.valorRecebido(valorRecebidoDinheiro);

            //Recupera o total recebido em dinheiro e cartão
            valorTotalRecebido = objTipoPagamento.getTotalRecebido();            

            //Recupera o valor do pagamento e processa o mesmo
            valorPagamento = double.Parse(txtValorPagamento.Text);            

            //Recebe o troco do cliente
            trocoCliente = (objPdvPagamento.pagarConta(valorPagamento, valorTotalRecebido) - (valorTaxaCartao * 2));

            //Mostra uma mensagem na tela com a conclusão do pagamento
            MessageBox.Show(" - Valor do pagamento : R$" + valorPagamento
            + "\r - Valor taxa cartão: R$" + valorTaxaCartao
            + "\r - Valor recebido em dinheiro : R$" + valorRecebidoDinheiro
            + "\r - Valor recebido em cartão de crédito + Taxa: R$" + (valorRecebidoCartao + valorTaxaCartao)           
            + "\r - Total recebido: R$" + valorTotalRecebido
            +"\r - O troco do cliente é: " + trocoCliente);
        }
    }
}
