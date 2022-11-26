namespace Lista_Estudo_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.cbEmbalagem = new System.Windows.Forms.ComboBox();
            this.btnCalcularCompra = new System.Windows.Forms.Button();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorAcrescimos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Origem";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Embalagem Especial";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(133, 6);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(83, 20);
            this.txtValorProduto.TabIndex = 4;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(133, 31);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(83, 20);
            this.txtQuantidade.TabIndex = 5;
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Items.AddRange(new object[] {
            "Animal",
            "Vegetal",
            "Outros"});
            this.cbOrigem.Location = new System.Drawing.Point(133, 59);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(83, 21);
            this.cbOrigem.TabIndex = 6;
            // 
            // cbEmbalagem
            // 
            this.cbEmbalagem.FormattingEnabled = true;
            this.cbEmbalagem.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbEmbalagem.Location = new System.Drawing.Point(133, 86);
            this.cbEmbalagem.Name = "cbEmbalagem";
            this.cbEmbalagem.Size = new System.Drawing.Size(83, 21);
            this.cbEmbalagem.TabIndex = 7;
            // 
            // btnCalcularCompra
            // 
            this.btnCalcularCompra.Location = new System.Drawing.Point(12, 122);
            this.btnCalcularCompra.Name = "btnCalcularCompra";
            this.btnCalcularCompra.Size = new System.Drawing.Size(204, 23);
            this.btnCalcularCompra.TabIndex = 8;
            this.btnCalcularCompra.Text = "Calcular Compra";
            this.btnCalcularCompra.UseVisualStyleBackColor = true;
            this.btnCalcularCompra.Click += new System.EventHandler(this.btnCalcularCompra_Click);
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Location = new System.Drawing.Point(133, 162);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.ReadOnly = true;
            this.txtValorLiquido.Size = new System.Drawing.Size(83, 20);
            this.txtValorLiquido.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor Bruto";
            // 
            // txtValorAcrescimos
            // 
            this.txtValorAcrescimos.Location = new System.Drawing.Point(133, 188);
            this.txtValorAcrescimos.Name = "txtValorAcrescimos";
            this.txtValorAcrescimos.ReadOnly = true;
            this.txtValorAcrescimos.Size = new System.Drawing.Size(83, 20);
            this.txtValorAcrescimos.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Acréscimos";
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Location = new System.Drawing.Point(133, 214);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.ReadOnly = true;
            this.txtValorBruto.Size = new System.Drawing.Size(83, 20);
            this.txtValorBruto.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor do Líquido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 243);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorAcrescimos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorLiquido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcularCompra);
            this.Controls.Add(this.cbEmbalagem);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.ComboBox cbEmbalagem;
        private System.Windows.Forms.Button btnCalcularCompra;
        private System.Windows.Forms.TextBox txtValorLiquido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorAcrescimos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.Label label7;
    }
}

