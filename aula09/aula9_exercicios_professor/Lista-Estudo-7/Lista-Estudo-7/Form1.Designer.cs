namespace Lista_Estudo_7
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
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtdCarroVendido = new System.Windows.Forms.TextBox();
            this.txtValorTotalVendas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComissaoFixa = new System.Windows.Forms.TextBox();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salário Fixo";
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(125, 6);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFixo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº Carros Vendidos";
            // 
            // txtQtdCarroVendido
            // 
            this.txtQtdCarroVendido.Location = new System.Drawing.Point(125, 40);
            this.txtQtdCarroVendido.Name = "txtQtdCarroVendido";
            this.txtQtdCarroVendido.Size = new System.Drawing.Size(100, 20);
            this.txtQtdCarroVendido.TabIndex = 3;
            // 
            // txtValorTotalVendas
            // 
            this.txtValorTotalVendas.Location = new System.Drawing.Point(125, 77);
            this.txtValorTotalVendas.Name = "txtValorTotalVendas";
            this.txtValorTotalVendas.Size = new System.Drawing.Size(100, 20);
            this.txtValorTotalVendas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valor Total Vendas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Comissão Fixa";
            // 
            // txtComissaoFixa
            // 
            this.txtComissaoFixa.Location = new System.Drawing.Point(125, 114);
            this.txtComissaoFixa.Name = "txtComissaoFixa";
            this.txtComissaoFixa.Size = new System.Drawing.Size(100, 20);
            this.txtComissaoFixa.TabIndex = 7;
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(125, 177);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.ReadOnly = true;
            this.txtSalarioFinal.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFinal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salário Final";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(15, 142);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(210, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 209);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComissaoFixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorTotalVendas);
            this.Controls.Add(this.txtQtdCarroVendido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtdCarroVendido;
        private System.Windows.Forms.TextBox txtValorTotalVendas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComissaoFixa;
        private System.Windows.Forms.TextBox txtSalarioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcular;
    }
}

