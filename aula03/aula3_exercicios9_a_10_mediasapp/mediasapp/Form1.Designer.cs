
namespace mediasapp
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
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.txtnota4 = new System.Windows.Forms.TextBox();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnMediaAritmetica = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnMediaPonderada = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota1";
            // 
            // txtnota1
            // 
            this.txtnota1.Location = new System.Drawing.Point(125, 21);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(180, 23);
            this.txtnota1.TabIndex = 1;
            // 
            // txtnota4
            // 
            this.txtnota4.Location = new System.Drawing.Point(125, 150);
            this.txtnota4.Name = "txtnota4";
            this.txtnota4.Size = new System.Drawing.Size(180, 23);
            this.txtnota4.TabIndex = 2;
            // 
            // txtnota3
            // 
            this.txtnota3.Location = new System.Drawing.Point(125, 106);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(180, 23);
            this.txtnota3.TabIndex = 3;
            // 
            // txtnota2
            // 
            this.txtnota2.Location = new System.Drawing.Point(125, 64);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(180, 23);
            this.txtnota2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nota2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nota4";
            // 
            // txtResultado
            // 
            this.txtResultado.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResultado.Location = new System.Drawing.Point(6, 98);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(287, 61);
            this.txtResultado.TabIndex = 10;
            // 
            // btnMediaAritmetica
            // 
            this.btnMediaAritmetica.Location = new System.Drawing.Point(6, 35);
            this.btnMediaAritmetica.Name = "btnMediaAritmetica";
            this.btnMediaAritmetica.Size = new System.Drawing.Size(121, 44);
            this.btnMediaAritmetica.TabIndex = 11;
            this.btnMediaAritmetica.Text = "Média Aritmética";
            this.btnMediaAritmetica.UseVisualStyleBackColor = true;
            this.btnMediaAritmetica.Click += new System.EventHandler(this.btnMediaAritmetica_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnMediaPonderada);
            this.groupBox1.Controls.Add(this.btnMediaAritmetica);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Location = new System.Drawing.Point(12, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 165);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informe o que quer:";
            // 
            // btnMediaPonderada
            // 
            this.btnMediaPonderada.Location = new System.Drawing.Point(172, 35);
            this.btnMediaPonderada.Name = "btnMediaPonderada";
            this.btnMediaPonderada.Size = new System.Drawing.Size(121, 44);
            this.btnMediaPonderada.TabIndex = 12;
            this.btnMediaPonderada.Text = "Média Ponderada";
            this.btnMediaPonderada.UseVisualStyleBackColor = true;
            this.btnMediaPonderada.Click += new System.EventHandler(this.btnMediaPonderada_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 382);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnota2);
            this.Controls.Add(this.txtnota3);
            this.Controls.Add(this.txtnota4);
            this.Controls.Add(this.txtnota1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cálculo de Médias";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.TextBox txtnota4;
        private System.Windows.Forms.TextBox txtnota3;
        private System.Windows.Forms.TextBox txtnota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnMediaAritmetica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMediaPonderada;
    }
}

