﻿
namespace aula09_ex7
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
            this.txtCarrosVendidos = new System.Windows.Forms.TextBox();
            this.txtTotalVendas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioFixo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComissaoFixa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº carros vendidos:";
            // 
            // txtCarrosVendidos
            // 
            this.txtCarrosVendidos.Location = new System.Drawing.Point(141, 33);
            this.txtCarrosVendidos.Name = "txtCarrosVendidos";
            this.txtCarrosVendidos.Size = new System.Drawing.Size(100, 23);
            this.txtCarrosVendidos.TabIndex = 1;
            // 
            // txtTotalVendas
            // 
            this.txtTotalVendas.Location = new System.Drawing.Point(141, 65);
            this.txtTotalVendas.Name = "txtTotalVendas";
            this.txtTotalVendas.Size = new System.Drawing.Size(100, 23);
            this.txtTotalVendas.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total das Vendas:";
            // 
            // txtSalarioFixo
            // 
            this.txtSalarioFixo.Location = new System.Drawing.Point(141, 101);
            this.txtSalarioFixo.Name = "txtSalarioFixo";
            this.txtSalarioFixo.Size = new System.Drawing.Size(100, 23);
            this.txtSalarioFixo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário Fixo:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(229, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(141, 207);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.ReadOnly = true;
            this.txtSalarioFinal.Size = new System.Drawing.Size(100, 23);
            this.txtSalarioFinal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salário Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Insira os dados pedidos:";
            // 
            // txtComissaoFixa
            // 
            this.txtComissaoFixa.Location = new System.Drawing.Point(141, 134);
            this.txtComissaoFixa.Name = "txtComissaoFixa";
            this.txtComissaoFixa.Size = new System.Drawing.Size(100, 23);
            this.txtComissaoFixa.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Comissão Fixa:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 238);
            this.Controls.Add(this.txtComissaoFixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtSalarioFixo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalVendas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCarrosVendidos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo de Salário:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarrosVendidos;
        private System.Windows.Forms.TextBox txtTotalVendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSalarioFixo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtSalarioFinal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComissaoFixa;
        private System.Windows.Forms.Label label4;
    }
}

