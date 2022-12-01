
namespace aula8_ex2
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
            this.cbButton = new System.Windows.Forms.ComboBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorParcelas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbButton
            // 
            this.cbButton.FormattingEnabled = true;
            this.cbButton.Items.AddRange(new object[] {
            " À vista: Desconto de 7,5%.",
            " 2 vezes: Juros de 5% sobre o total da compra;   ",
            " 3 vezes: Juros de 9,5% sobre o total da compra;",
            " 4 vezes: Juros de 12,5% sobre o total da compra;"});
            this.cbButton.Location = new System.Drawing.Point(15, 68);
            this.cbButton.Name = "cbButton";
            this.cbButton.Size = new System.Drawing.Size(217, 23);
            this.cbButton.TabIndex = 0;
            this.cbButton.SelectedIndexChanged += new System.EventHandler(this.cbButton_SelectedIndexChanged);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(115, 12);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(117, 23);
            this.txtValorTotal.TabIndex = 1;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(115, 100);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(117, 23);
            this.txtValorFinal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor Parcelas:";
            // 
            // txtValorParcelas
            // 
            this.txtValorParcelas.Location = new System.Drawing.Point(115, 132);
            this.txtValorParcelas.Name = "txtValorParcelas";
            this.txtValorParcelas.Size = new System.Drawing.Size(117, 23);
            this.txtValorParcelas.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Formas de Pagamento:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 202);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValorParcelas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.cbButton);
            this.Name = "Form1";
            this.Text = "Verif. de Valor:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbButton;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorParcelas;
        private System.Windows.Forms.Label label4;
    }
}

