namespace ArtigoPOO3
{
    partial class Form1
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
            this.btnAbrirCaxia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirCaxia
            // 
            this.btnAbrirCaxia.Location = new System.Drawing.Point(2, 12);
            this.btnAbrirCaxia.Name = "btnAbrirCaxia";
            this.btnAbrirCaxia.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirCaxia.TabIndex = 0;
            this.btnAbrirCaxia.Text = "Abrir Caixa";
            this.btnAbrirCaxia.UseVisualStyleBackColor = true;
            this.btnAbrirCaxia.Click += new System.EventHandler(this.btnAbrirCaxia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.btnAbrirCaxia);
            this.Name = "Form1";
            this.Text = "PDV";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCaxia;
    }
}

