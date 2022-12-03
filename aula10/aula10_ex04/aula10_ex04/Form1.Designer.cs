
namespace aula10_ex04
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorVista = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProcessador = new System.Windows.Forms.ComboBox();
            this.cbMemoriaRam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTamanhoTela = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPagamentoVista = new System.Windows.Forms.ComboBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 35;
            this.label7.Text = "Memória Ram:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Processador:";
            // 
            // txtValorVista
            // 
            this.txtValorVista.Location = new System.Drawing.Point(12, 258);
            this.txtValorVista.Name = "txtValorVista";
            this.txtValorVista.ReadOnly = true;
            this.txtValorVista.Size = new System.Drawing.Size(180, 23);
            this.txtValorVista.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Valor à vista:";
            // 
            // cbProcessador
            // 
            this.cbProcessador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProcessador.FormattingEnabled = true;
            this.cbProcessador.Items.AddRange(new object[] {
            "I3 - 400,00",
            "I5 - 700,00",
            "I7 - 1049,00"});
            this.cbProcessador.Location = new System.Drawing.Point(12, 81);
            this.cbProcessador.Name = "cbProcessador";
            this.cbProcessador.Size = new System.Drawing.Size(268, 23);
            this.cbProcessador.TabIndex = 31;
            // 
            // cbMemoriaRam
            // 
            this.cbMemoriaRam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMemoriaRam.FormattingEnabled = true;
            this.cbMemoriaRam.Items.AddRange(new object[] {
            "4GB - 250,00",
            "8GB - 350,00",
            "16GB - 599,00"});
            this.cbMemoriaRam.Location = new System.Drawing.Point(12, 27);
            this.cbMemoriaRam.Name = "cbMemoriaRam";
            this.cbMemoriaRam.Size = new System.Drawing.Size(268, 23);
            this.cbMemoriaRam.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tamanho da Tela:";
            // 
            // cbTamanhoTela
            // 
            this.cbTamanhoTela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTamanhoTela.FormattingEnabled = true;
            this.cbTamanhoTela.Items.AddRange(new object[] {
            "13 - 300,00",
            "14 - 650,00",
            "15 - 999,00"});
            this.cbTamanhoTela.Location = new System.Drawing.Point(12, 138);
            this.cbTamanhoTela.Name = "cbTamanhoTela";
            this.cbTamanhoTela.Size = new System.Drawing.Size(268, 23);
            this.cbTamanhoTela.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "Pagamento à vista ?";
            // 
            // cbPagamentoVista
            // 
            this.cbPagamentoVista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagamentoVista.FormattingEnabled = true;
            this.cbPagamentoVista.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.cbPagamentoVista.Location = new System.Drawing.Point(12, 201);
            this.cbPagamentoVista.Name = "cbPagamentoVista";
            this.cbPagamentoVista.Size = new System.Drawing.Size(268, 23);
            this.cbPagamentoVista.TabIndex = 38;
            this.cbPagamentoVista.SelectedIndexChanged += new System.EventHandler(this.cbPagamentoVista_SelectedIndexChanged);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(12, 311);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(180, 23);
            this.txtValorFinal.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Valor Final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 352);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPagamentoVista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTamanhoTela);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtValorVista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProcessador);
            this.Controls.Add(this.cbMemoriaRam);
            this.Name = "Form1";
            this.Text = "Cálculo Valor Computador:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorVista;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProcessador;
        private System.Windows.Forms.ComboBox cbMemoriaRam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTamanhoTela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPagamentoVista;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label4;
    }
}

