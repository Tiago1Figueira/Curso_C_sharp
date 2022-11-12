namespace Ex5_Prova
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
            this.txtQddPeras = new System.Windows.Forms.TextBox();
            this.btnPreco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Peras";
            // 
            // txtQddPeras
            // 
            this.txtQddPeras.Location = new System.Drawing.Point(125, 12);
            this.txtQddPeras.Name = "txtQddPeras";
            this.txtQddPeras.Size = new System.Drawing.Size(100, 20);
            this.txtQddPeras.TabIndex = 1;
            // 
            // btnPreco
            // 
            this.btnPreco.Location = new System.Drawing.Point(125, 38);
            this.btnPreco.Name = "btnPreco";
            this.btnPreco.Size = new System.Drawing.Size(100, 23);
            this.btnPreco.TabIndex = 2;
            this.btnPreco.Text = "Qual o preço?";
            this.btnPreco.UseVisualStyleBackColor = true;
            this.btnPreco.Click += new System.EventHandler(this.btnPreco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 71);
            this.Controls.Add(this.btnPreco);
            this.Controls.Add(this.txtQddPeras);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Peras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQddPeras;
        private System.Windows.Forms.Button btnPreco;
    }
}

