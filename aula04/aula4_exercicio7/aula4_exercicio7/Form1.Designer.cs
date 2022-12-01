
namespace aula4_exercicio7
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnParImparPositivoNegativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(109, 39);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(265, 29);
            this.txtNumero.TabIndex = 1;
            // 
            // btnParImparPositivoNegativo
            // 
            this.btnParImparPositivoNegativo.Location = new System.Drawing.Point(24, 89);
            this.btnParImparPositivoNegativo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParImparPositivoNegativo.Name = "btnParImparPositivoNegativo";
            this.btnParImparPositivoNegativo.Size = new System.Drawing.Size(350, 32);
            this.btnParImparPositivoNegativo.TabIndex = 2;
            this.btnParImparPositivoNegativo.Text = "Par ou Ímpar - positivo ou negativo";
            this.btnParImparPositivoNegativo.UseVisualStyleBackColor = true;
            this.btnParImparPositivoNegativo.Click += new System.EventHandler(this.btnParImparPositivoNegativo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 151);
            this.Controls.Add(this.btnParImparPositivoNegativo);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Número Positivo/Negativo e Impar/Par";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnParImparPositivoNegativo;
    }
}

