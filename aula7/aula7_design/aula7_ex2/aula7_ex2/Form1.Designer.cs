
namespace aula7_ex2
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
            this.txtComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorPagamento = new System.Windows.Forms.TextBox();
            this.txtValorParc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtComboBox
            // 
            this.txtComboBox.FormattingEnabled = true;
            this.txtComboBox.Items.AddRange(new object[] {
            " À vista: Desconto de 7,5%",
            " 2 vezes: Juros de 5% sobre o total da compra",
            " 3 vezes: Juros de 9,5% sobre o total da compra",
            " 4 vezes: Juros de 12,5% sobre o total da compra"});
            this.txtComboBox.Location = new System.Drawing.Point(-1, 44);
            this.txtComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.txtComboBox.Name = "txtComboBox";
            this.txtComboBox.Size = new System.Drawing.Size(505, 33);
            this.txtComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor Pagamento:";
            // 
            // txtValorPagamento
            // 
            this.txtValorPagamento.Location = new System.Drawing.Point(206, 2);
            this.txtValorPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorPagamento.Name = "txtValorPagamento";
            this.txtValorPagamento.Size = new System.Drawing.Size(298, 32);
            this.txtValorPagamento.TabIndex = 2;
            // 
            // txtValorParc
            // 
            this.txtValorParc.Location = new System.Drawing.Point(206, 136);
            this.txtValorParc.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorParc.Name = "txtValorParc";
            this.txtValorParc.ReadOnly = true;
            this.txtValorParc.Size = new System.Drawing.Size(298, 32);
            this.txtValorParc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Parcelado:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(11, 209);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(193, 38);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar!!";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(206, 95);
            this.txtValorFinal.Margin = new System.Windows.Forms.Padding(5);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.ReadOnly = true;
            this.txtValorFinal.Size = new System.Drawing.Size(298, 32);
            this.txtValorFinal.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor Final:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 258);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtValorParc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValorPagamento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Calcule forma de pagamento:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValorPagamento;
        private System.Windows.Forms.TextBox txtValorParc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label3;
    }
}

