
namespace aula6_exercicio3
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
            this.texto1 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtCalcularMedia = new System.Windows.Forms.Button();
            this.texto2 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texto1
            // 
            this.texto1.AutoSize = true;
            this.texto1.Location = new System.Drawing.Point(8, 36);
            this.texto1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto1.Name = "texto1";
            this.texto1.Size = new System.Drawing.Size(61, 21);
            this.texto1.TabIndex = 0;
            this.texto1.Text = "NOTA1";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(90, 25);
            this.txtNota1.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(164, 29);
            this.txtNota1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Controls.Add(this.txtCalcularMedia);
            this.groupBox1.Controls.Add(this.texto2);
            this.groupBox1.Controls.Add(this.txtNota2);
            this.groupBox1.Controls.Add(this.texto1);
            this.groupBox1.Controls.Add(this.txtNota1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(264, 354);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira notas:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(8, 292);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(248, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar!";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 244);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(90, 236);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(164, 29);
            this.txtResultado.TabIndex = 6;
            // 
            // txtCalcularMedia
            // 
            this.txtCalcularMedia.Location = new System.Drawing.Point(8, 159);
            this.txtCalcularMedia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalcularMedia.Name = "txtCalcularMedia";
            this.txtCalcularMedia.Size = new System.Drawing.Size(248, 32);
            this.txtCalcularMedia.TabIndex = 4;
            this.txtCalcularMedia.Text = "Calcular Média:";
            this.txtCalcularMedia.UseVisualStyleBackColor = true;
            this.txtCalcularMedia.Click += new System.EventHandler(this.txtCalcularMedia_Click);
            // 
            // texto2
            // 
            this.texto2.AutoSize = true;
            this.texto2.Location = new System.Drawing.Point(8, 106);
            this.texto2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto2.Name = "texto2";
            this.texto2.Size = new System.Drawing.Size(61, 21);
            this.texto2.TabIndex = 2;
            this.texto2.Text = "NOTA2";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(90, 95);
            this.txtNota2.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(164, 29);
            this.txtNota2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 391);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Calcula médias dos alunos:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto1;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button txtCalcularMedia;
        private System.Windows.Forms.Label texto2;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Button btnLimpar;
    }
}

