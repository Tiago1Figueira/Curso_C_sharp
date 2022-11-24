namespace ConversorTemperatura
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
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.cbOrigem = new System.Windows.Forms.ComboBox();
            this.cbDestino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(85, 6);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(120, 20);
            this.txtTemperatura.TabIndex = 1;
            // 
            // cbOrigem
            // 
            this.cbOrigem.FormattingEnabled = true;
            this.cbOrigem.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cbOrigem.Location = new System.Drawing.Point(209, 6);
            this.cbOrigem.Name = "cbOrigem";
            this.cbOrigem.Size = new System.Drawing.Size(121, 21);
            this.cbOrigem.TabIndex = 2;
            this.cbOrigem.SelectedIndexChanged += new System.EventHandler(this.cbOrigem_SelectedIndexChanged);
            // 
            // cbDestino
            // 
            this.cbDestino.FormattingEnabled = true;
            this.cbDestino.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cbDestino.Location = new System.Drawing.Point(209, 33);
            this.cbDestino.Name = "cbDestino";
            this.cbDestino.Size = new System.Drawing.Size(121, 21);
            this.cbDestino.TabIndex = 3;
            this.cbDestino.SelectedIndexChanged += new System.EventHandler(this.cbDestino_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Destino";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(85, 33);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(120, 20);
            this.txtResultado.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 61);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDestino);
            this.Controls.Add(this.cbOrigem);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.ComboBox cbOrigem;
        private System.Windows.Forms.ComboBox cbDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

