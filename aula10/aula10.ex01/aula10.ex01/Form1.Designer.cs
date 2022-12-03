
namespace aula10.ex01
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
            this.label19 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtSomaImpares = new System.Windows.Forms.TextBox();
            this.txtSomaPares = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSomaTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 15);
            this.label19.TabIndex = 69;
            this.label19.Text = "Insira os valores pedidos:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(35, 107);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(238, 23);
            this.btnCalcular.TabIndex = 68;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(12, 153);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 15);
            this.label21.TabIndex = 66;
            this.label21.Text = "Soma Ímpares: ";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(83, 65);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(190, 23);
            this.txtValorFinal.TabIndex = 65;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 73);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 15);
            this.label22.TabIndex = 64;
            this.label22.Text = "Valor Final:";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(83, 33);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(190, 23);
            this.txtValorInicial.TabIndex = 63;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(12, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 15);
            this.label23.TabIndex = 62;
            this.label23.Text = "Valor Inicial:";
            // 
            // txtSomaImpares
            // 
            this.txtSomaImpares.Location = new System.Drawing.Point(106, 145);
            this.txtSomaImpares.Name = "txtSomaImpares";
            this.txtSomaImpares.ReadOnly = true;
            this.txtSomaImpares.Size = new System.Drawing.Size(167, 23);
            this.txtSomaImpares.TabIndex = 70;
            // 
            // txtSomaPares
            // 
            this.txtSomaPares.Location = new System.Drawing.Point(106, 182);
            this.txtSomaPares.Name = "txtSomaPares";
            this.txtSomaPares.ReadOnly = true;
            this.txtSomaPares.Size = new System.Drawing.Size(167, 23);
            this.txtSomaPares.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 71;
            this.label1.Text = "Soma Pares:";
            // 
            // txtSomaTotal
            // 
            this.txtSomaTotal.Location = new System.Drawing.Point(106, 218);
            this.txtSomaTotal.Name = "txtSomaTotal";
            this.txtSomaTotal.ReadOnly = true;
            this.txtSomaTotal.Size = new System.Drawing.Size(167, 23);
            this.txtSomaTotal.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 73;
            this.label2.Text = "Soma Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 279);
            this.Controls.Add(this.txtSomaTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSomaPares);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSomaImpares);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.label23);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtSomaImpares;
        private System.Windows.Forms.TextBox txtSomaPares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSomaTotal;
        private System.Windows.Forms.Label label2;
    }
}

