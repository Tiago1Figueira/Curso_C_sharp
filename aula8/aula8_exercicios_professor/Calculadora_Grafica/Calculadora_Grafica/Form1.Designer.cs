namespace Calculadora_Grafica
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.grpOperacoes = new System.Windows.Forms.GroupBox();
            this.rbSoma = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.rbSubtracao = new System.Windows.Forms.RadioButton();
            this.rbMultiplicacao = new System.Windows.Forms.RadioButton();
            this.rbDivisao = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpOperacoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(12, 12);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(157, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(12, 38);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(157, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // grpOperacoes
            // 
            this.grpOperacoes.Controls.Add(this.rbDivisao);
            this.grpOperacoes.Controls.Add(this.rbMultiplicacao);
            this.grpOperacoes.Controls.Add(this.rbSubtracao);
            this.grpOperacoes.Controls.Add(this.rbSoma);
            this.grpOperacoes.Location = new System.Drawing.Point(12, 64);
            this.grpOperacoes.Name = "grpOperacoes";
            this.grpOperacoes.Size = new System.Drawing.Size(157, 51);
            this.grpOperacoes.TabIndex = 2;
            this.grpOperacoes.TabStop = false;
            // 
            // rbSoma
            // 
            this.rbSoma.AutoSize = true;
            this.rbSoma.Location = new System.Drawing.Point(9, 19);
            this.rbSoma.Name = "rbSoma";
            this.rbSoma.Size = new System.Drawing.Size(31, 17);
            this.rbSoma.TabIndex = 0;
            this.rbSoma.TabStop = true;
            this.rbSoma.Text = "+";
            this.rbSoma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(12, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 150);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(157, 20);
            this.txtResultado.TabIndex = 4;
            // 
            // rbSubtracao
            // 
            this.rbSubtracao.AutoSize = true;
            this.rbSubtracao.Location = new System.Drawing.Point(46, 19);
            this.rbSubtracao.Name = "rbSubtracao";
            this.rbSubtracao.Size = new System.Drawing.Size(28, 17);
            this.rbSubtracao.TabIndex = 1;
            this.rbSubtracao.TabStop = true;
            this.rbSubtracao.Text = "-";
            this.rbSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbMultiplicacao
            // 
            this.rbMultiplicacao.AutoSize = true;
            this.rbMultiplicacao.Location = new System.Drawing.Point(83, 19);
            this.rbMultiplicacao.Name = "rbMultiplicacao";
            this.rbMultiplicacao.Size = new System.Drawing.Size(29, 17);
            this.rbMultiplicacao.TabIndex = 2;
            this.rbMultiplicacao.TabStop = true;
            this.rbMultiplicacao.Text = "*";
            this.rbMultiplicacao.UseVisualStyleBackColor = true;
            // 
            // rbDivisao
            // 
            this.rbDivisao.AutoSize = true;
            this.rbDivisao.Location = new System.Drawing.Point(120, 19);
            this.rbDivisao.Name = "rbDivisao";
            this.rbDivisao.Size = new System.Drawing.Size(30, 17);
            this.rbDivisao.TabIndex = 3;
            this.rbDivisao.TabStop = true;
            this.rbDivisao.Text = "/";
            this.rbDivisao.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(19, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(19, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(85, 17);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(175, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(175, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 229);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpOperacoes);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Calc!";
            this.grpOperacoes.ResumeLayout(false);
            this.grpOperacoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.GroupBox grpOperacoes;
        private System.Windows.Forms.RadioButton rbDivisao;
        private System.Windows.Forms.RadioButton rbMultiplicacao;
        private System.Windows.Forms.RadioButton rbSubtracao;
        private System.Windows.Forms.RadioButton rbSoma;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

