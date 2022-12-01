
namespace aula9_ex6
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
            this.txtCustoFabrica = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorConsumidor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custo de Fábrica:";
            // 
            // txtCustoFabrica
            // 
            this.txtCustoFabrica.Location = new System.Drawing.Point(13, 27);
            this.txtCustoFabrica.Name = "txtCustoFabrica";
            this.txtCustoFabrica.Size = new System.Drawing.Size(153, 23);
            this.txtCustoFabrica.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(154, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular:";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorConsumidor
            // 
            this.txtValorConsumidor.Location = new System.Drawing.Point(13, 121);
            this.txtValorConsumidor.Name = "txtValorConsumidor";
            this.txtValorConsumidor.ReadOnly = true;
            this.txtValorConsumidor.Size = new System.Drawing.Size(154, 23);
            this.txtValorConsumidor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor para o consumidor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 163);
            this.Controls.Add(this.txtValorConsumidor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtCustoFabrica);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calc.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustoFabrica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorConsumidor;
        private System.Windows.Forms.Label label2;
    }
}

