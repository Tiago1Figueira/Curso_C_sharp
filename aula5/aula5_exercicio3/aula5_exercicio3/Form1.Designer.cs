
namespace aula5_exercicio3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValidos1 = new System.Windows.Forms.TextBox();
            this.txtNulos = new System.Windows.Forms.TextBox();
            this.txtValidos = new System.Windows.Forms.TextBox();
            this.txtBrancos = new System.Windows.Forms.TextBox();
            this.txtPopulacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBrancos1 = new System.Windows.Forms.TextBox();
            this.txtNulos1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "População";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Válidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nulos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Brancos: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.Location = new System.Drawing.Point(19, 148);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(249, 35);
            this.btnPorcentagem.TabIndex = 5;
            this.btnPorcentagem.Text = "Qual a porcentagem?";
            this.btnPorcentagem.UseVisualStyleBackColor = true;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNulos1);
            this.groupBox1.Controls.Add(this.txtBrancos1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValidos1);
            this.groupBox1.Controls.Add(this.txtNulos);
            this.groupBox1.Controls.Add(this.txtValidos);
            this.groupBox1.Controls.Add(this.txtBrancos);
            this.groupBox1.Controls.Add(this.txtPopulacao);
            this.groupBox1.Controls.Add(this.btnPorcentagem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 321);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veja as estatísticas:";
            // 
            // txtValidos1
            // 
            this.txtValidos1.Location = new System.Drawing.Point(123, 218);
            this.txtValidos1.Name = "txtValidos1";
            this.txtValidos1.Size = new System.Drawing.Size(145, 26);
            this.txtValidos1.TabIndex = 10;
            // 
            // txtNulos
            // 
            this.txtNulos.Location = new System.Drawing.Point(123, 85);
            this.txtNulos.Name = "txtNulos";
            this.txtNulos.Size = new System.Drawing.Size(145, 26);
            this.txtNulos.TabIndex = 9;
            // 
            // txtValidos
            // 
            this.txtValidos.Location = new System.Drawing.Point(123, 54);
            this.txtValidos.Name = "txtValidos";
            this.txtValidos.Size = new System.Drawing.Size(145, 26);
            this.txtValidos.TabIndex = 8;
            // 
            // txtBrancos
            // 
            this.txtBrancos.Location = new System.Drawing.Point(123, 116);
            this.txtBrancos.Name = "txtBrancos";
            this.txtBrancos.Size = new System.Drawing.Size(145, 26);
            this.txtBrancos.TabIndex = 7;
            // 
            // txtPopulacao
            // 
            this.txtPopulacao.Location = new System.Drawing.Point(123, 23);
            this.txtPopulacao.Name = "txtPopulacao";
            this.txtPopulacao.Size = new System.Drawing.Size(145, 26);
            this.txtPopulacao.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Porcentagens:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Brancos: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Válidos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 13;
            this.label9.Text = "Nulos:";
            // 
            // txtBrancos1
            // 
            this.txtBrancos1.Location = new System.Drawing.Point(123, 281);
            this.txtBrancos1.Name = "txtBrancos1";
            this.txtBrancos1.Size = new System.Drawing.Size(145, 26);
            this.txtBrancos1.TabIndex = 15;
            // 
            // txtNulos1
            // 
            this.txtNulos1.Location = new System.Drawing.Point(123, 249);
            this.txtNulos1.Name = "txtNulos1";
            this.txtNulos1.Size = new System.Drawing.Size(145, 26);
            this.txtNulos1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 361);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Eleições 2022!!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValidos1;
        private System.Windows.Forms.TextBox txtNulos;
        private System.Windows.Forms.TextBox txtValidos;
        private System.Windows.Forms.TextBox txtBrancos;
        private System.Windows.Forms.TextBox txtPopulacao;
        private System.Windows.Forms.TextBox txtNulos1;
        private System.Windows.Forms.TextBox txtBrancos1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}

