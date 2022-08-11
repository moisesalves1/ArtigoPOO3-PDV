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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirCaxia_Click(object sender, EventArgs e)
        {           
            //Criando objetos necessários 
            PDV objPDV = new PDV(10, "DEVMEDIA", "Tarde");

            //Codificando evento
            objPDV.status_PDV = true;
            objPDV.valor_dinheiro_abertura = 200;
            objPDV.data_hora_abertura = DateTime.Now;

            MessageBox.Show("- CÓDIGO PDV: " + objPDV.getCodigoPDV() 
                + "\r- USUÁRIO CAIXA: " + objPDV.getNomeUsuarioCaixa()
                + "\r- TURNO: " + objPDV.getTurno()
                +"\r- STATUS PDV: " + (objPDV.status_PDV == true ? "ABERTO" : "FECHADO") 
                + " \r- DATA/HORA ABERTURA: " + objPDV.data_hora_abertura 
                + " \r- VALOR DINHEIRO INICIAL: R$" + objPDV.valor_dinheiro_abertura);
        }
    }
}
