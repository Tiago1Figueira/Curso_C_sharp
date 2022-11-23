
namespace aula7_ex4
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
            this.cbTemperatura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTempInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTempFinal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Temperatura:";
            // 
            // cbTemperatura
            // 
            this.cbTemperatura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTemperatura.FormattingEnabled = true;
            this.cbTemperatura.Items.AddRange(new object[] {
            "Celsius para Fahrenheit:",
            "Celsius para Kelvin:",
            "Fahrenheit para Celsius:",
            "Fahrenheit para Kelvin:",
            "Kelvin para Celsius:",
            "Kelvin para Fahrenheit:"});
            this.cbTemperatura.Location = new System.Drawing.Point(4, 84);
            this.cbTemperatura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTemperatura.Name = "cbTemperatura";
            this.cbTemperatura.Size = new System.Drawing.Size(310, 29);
            this.cbTemperatura.TabIndex = 2;
            this.cbTemperatura.SelectedIndexChanged += new System.EventHandler(this.cbTemperatura_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temperatura Inicial:";
            // 
            // txtTempInicial
            // 
            this.txtTempInicial.Location = new System.Drawing.Point(183, 6);
            this.txtTempInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempInicial.Name = "txtTempInicial";
            this.txtTempInicial.Size = new System.Drawing.Size(131, 29);
            this.txtTempInicial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Temperatura Final:";
            // 
            // txtTempFinal
            // 
            this.txtTempFinal.Location = new System.Drawing.Point(183, 136);
            this.txtTempFinal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTempFinal.Name = "txtTempFinal";
            this.txtTempFinal.Size = new System.Drawing.Size(131, 29);
            this.txtTempFinal.TabIndex = 6;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(12, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(195, 36);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar!";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 228);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTempFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTempInicial);
            this.Controls.Add(this.cbTemperatura);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTemperatura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTempInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTempFinal;
        private System.Windows.Forms.Button btnLimpar;
    }
}

