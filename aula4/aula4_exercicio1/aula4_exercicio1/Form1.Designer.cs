
namespace aula4_exercicio1
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
            this.btnEpositivo = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // btnEpositivo
            // 
            this.btnEpositivo.Location = new System.Drawing.Point(25, 55);
            this.btnEpositivo.Name = "btnEpositivo";
            this.btnEpositivo.Size = new System.Drawing.Size(254, 25);
            this.btnEpositivo.TabIndex = 2;
            this.btnEpositivo.Text = "É positivo?";
            this.btnEpositivo.UseVisualStyleBackColor = true;
            this.btnEpositivo.Click += new System.EventHandler(this.btnEpositivo_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(97, 25);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(182, 23);
            this.txtNumero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 92);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEpositivo);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Achador de Número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEpositivo;
        private System.Windows.Forms.TextBox txtNumero;
    }
}

