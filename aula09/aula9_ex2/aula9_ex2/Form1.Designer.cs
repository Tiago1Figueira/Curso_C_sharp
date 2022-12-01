
namespace aula9_ex2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeVendida = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEmbalagemEspecial = new System.Windows.Forms.ComboBox();
            this.txtValorBruto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAcrescimo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorLiquido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor do Produto:";
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Location = new System.Drawing.Point(129, 17);
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(151, 23);
            this.txtValorProduto.TabIndex = 1;
            // 
            // cbOrigem
            // 
            this.cbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Items.AddRange(new object[] {
            "Animal - acréscimo de 15%",
            "Vegetal - acréscimo de 10%",
            "Outros - acréscimo de  4.3%"});
            this.cbOrigem.Location = new System.Drawing.Point(12, 99);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(268, 23);
            this.cbOrigem.TabIndex = 2;
            this.cbOrigem.SelectedIndexChanged += new System.EventHandler(this.cbOrigem_SelectedIndexChanged);
            // 
            // txtQuantidadeVendida
            // 
            this.txtQuantidadeVendida.Location = new System.Drawing.Point(129, 49);
            this.txtQuantidadeVendida.Name = "txtQuantidadeVendida";
            this.txtQuantidadeVendida.Size = new System.Drawing.Size(151, 23);
            this.txtQuantidadeVendida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade Vendida:";
            // 
            // cbEmbalagemEspecial
            // 
            this.cbEmbalagemEspecial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmbalagemEspecial.FormattingEnabled = true;
            this.cbEmbalagemEspecial.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbEmbalagemEspecial.Location = new System.Drawing.Point(12, 153);
            this.cbEmbalagemEspecial.Name = "cbEmbalagemEspecial";
            this.cbEmbalagemEspecial.Size = new System.Drawing.Size(268, 23);
            this.cbEmbalagemEspecial.TabIndex = 5;
            this.cbEmbalagemEspecial.SelectedIndexChanged += new System.EventHandler(this.cbEmbalagemEspecial_SelectedIndexChanged);
            // 
            // txtValorBruto
            // 
            this.txtValorBruto.Location = new System.Drawing.Point(129, 190);
            this.txtValorBruto.Name = "txtValorBruto";
            this.txtValorBruto.ReadOnly = true;
            this.txtValorBruto.Size = new System.Drawing.Size(151, 23);
            this.txtValorBruto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Bruto:";
            // 
            // txtAcrescimo
            // 
            this.txtAcrescimo.Location = new System.Drawing.Point(129, 224);
            this.txtAcrescimo.Name = "txtAcrescimo";
            this.txtAcrescimo.ReadOnly = true;
            this.txtAcrescimo.Size = new System.Drawing.Size(151, 23);
            this.txtAcrescimo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Acréscimos: ";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(129, 303);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(151, 23);
            this.txtValorFinal.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Valor Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Embalagem Especial:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Origem:";
            // 
            // txtValorLiquido
            // 
            this.txtValorLiquido.Location = new System.Drawing.Point(129, 265);
            this.txtValorLiquido.Name = "txtValorLiquido";
            this.txtValorLiquido.ReadOnly = true;
            this.txtValorLiquido.Size = new System.Drawing.Size(151, 23);
            this.txtValorLiquido.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor do Líquido:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 339);
            this.Controls.Add(this.txtValorLiquido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAcrescimo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorBruto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEmbalagemEspecial);
            this.Controls.Add(this.txtQuantidadeVendida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.txtValorProduto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo do Imposto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.TextBox txtQuantidadeVendida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEmbalagemEspecial;
        private System.Windows.Forms.TextBox txtValorBruto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAcrescimo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorLiquido;
        private System.Windows.Forms.Label label8;
    }
}

