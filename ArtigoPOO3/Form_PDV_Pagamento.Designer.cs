namespace ArtigoPOO3
{
    partial class Form_PDV_Pagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInformacoesCaixa = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.txtValorDinheiroRecebido = new System.Windows.Forms.TextBox();
            this.btnRealizarPagamento = new System.Windows.Forms.Button();
            this.txtValorCartaoRecebido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Pagamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor recebido em dinheiro:";
            // 
            // lblInformacoesCaixa
            // 
            this.lblInformacoesCaixa.AutoSize = true;
            this.lblInformacoesCaixa.Location = new System.Drawing.Point(12, 137);
            this.lblInformacoesCaixa.Name = "lblInformacoesCaixa";
            this.lblInformacoesCaixa.Size = new System.Drawing.Size(16, 13);
            this.lblInformacoesCaixa.TabIndex = 2;
            this.lblInformacoesCaixa.Text = "...";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Location = new System.Drawing.Point(155, 23);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagamento.TabIndex = 3;
            // 
            // txtValorDinheiroRecebido
            // 
            this.txtValorDinheiroRecebido.Location = new System.Drawing.Point(155, 48);
            this.txtValorDinheiroRecebido.Name = "txtValorDinheiroRecebido";
            this.txtValorDinheiroRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtValorDinheiroRecebido.TabIndex = 4;
            // 
            // btnRealizarPagamento
            // 
            this.btnRealizarPagamento.Location = new System.Drawing.Point(15, 111);
            this.btnRealizarPagamento.Name = "btnRealizarPagamento";
            this.btnRealizarPagamento.Size = new System.Drawing.Size(204, 23);
            this.btnRealizarPagamento.TabIndex = 5;
            this.btnRealizarPagamento.Text = "Realizar Pagamento";
            this.btnRealizarPagamento.UseVisualStyleBackColor = true;
            this.btnRealizarPagamento.Click += new System.EventHandler(this.btnRealizarPagamento_Click);
            // 
            // txtValorCartaoRecebido
            // 
            this.txtValorCartaoRecebido.Location = new System.Drawing.Point(155, 72);
            this.txtValorCartaoRecebido.Name = "txtValorCartaoRecebido";
            this.txtValorCartaoRecebido.Size = new System.Drawing.Size(100, 20);
            this.txtValorCartaoRecebido.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor recebido em cartão:";
            // 
            // Form_PDV_Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 160);
            this.Controls.Add(this.txtValorCartaoRecebido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRealizarPagamento);
            this.Controls.Add(this.txtValorDinheiroRecebido);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.lblInformacoesCaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_PDV_Pagamento";
            this.Text = "Form_PDV_Pagamento";
            this.Load += new System.EventHandler(this.Form_PDV_Pagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInformacoesCaixa;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.TextBox txtValorDinheiroRecebido;
        private System.Windows.Forms.Button btnRealizarPagamento;
        private System.Windows.Forms.TextBox txtValorCartaoRecebido;
        private System.Windows.Forms.Label label3;
    }
}