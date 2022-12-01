namespace Ex3_Prova
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBranco = new System.Windows.Forms.TextBox();
            this.txtValidos = new System.Windows.Forms.TextBox();
            this.txtNulos = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblBranco = new System.Windows.Forms.Label();
            this.lblNulos = new System.Windows.Forms.Label();
            this.lblValidos = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total de Eleitores";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nulos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Brancos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Válidos";
            // 
            // txtBranco
            // 
            this.txtBranco.Location = new System.Drawing.Point(122, 43);
            this.txtBranco.Name = "txtBranco";
            this.txtBranco.Size = new System.Drawing.Size(100, 20);
            this.txtBranco.TabIndex = 4;
            // 
            // txtValidos
            // 
            this.txtValidos.Location = new System.Drawing.Point(122, 95);
            this.txtValidos.Name = "txtValidos";
            this.txtValidos.Size = new System.Drawing.Size(100, 20);
            this.txtValidos.TabIndex = 6;
            // 
            // txtNulos
            // 
            this.txtNulos.Location = new System.Drawing.Point(122, 69);
            this.txtNulos.Name = "txtNulos";
            this.txtNulos.Size = new System.Drawing.Size(100, 20);
            this.txtNulos.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(122, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // lblBranco
            // 
            this.lblBranco.AutoSize = true;
            this.lblBranco.Location = new System.Drawing.Point(228, 46);
            this.lblBranco.Name = "lblBranco";
            this.lblBranco.Size = new System.Drawing.Size(0, 13);
            this.lblBranco.TabIndex = 9;
            // 
            // lblNulos
            // 
            this.lblNulos.AutoSize = true;
            this.lblNulos.Location = new System.Drawing.Point(228, 69);
            this.lblNulos.Name = "lblNulos";
            this.lblNulos.Size = new System.Drawing.Size(0, 13);
            this.lblNulos.TabIndex = 10;
            // 
            // lblValidos
            // 
            this.lblValidos.AutoSize = true;
            this.lblValidos.Location = new System.Drawing.Point(228, 98);
            this.lblValidos.Name = "lblValidos";
            this.lblValidos.Size = new System.Drawing.Size(0, 13);
            this.lblValidos.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(122, 121);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 23);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(30, 121);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 167);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblValidos);
            this.Controls.Add(this.lblNulos);
            this.Controls.Add(this.lblBranco);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtNulos);
            this.Controls.Add(this.txtValidos);
            this.Controls.Add(this.txtBranco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Votos!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBranco;
        private System.Windows.Forms.TextBox txtValidos;
        private System.Windows.Forms.TextBox txtNulos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblBranco;
        private System.Windows.Forms.Label lblNulos;
        private System.Windows.Forms.Label lblValidos;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
    }
}

