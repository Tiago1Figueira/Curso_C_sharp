
namespace aula9_ex1
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
            this.cbDependentes = new System.Windows.Forms.ComboBox();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSalarioFinal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbDependentes
            // 
            this.cbDependentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDependentes.FormattingEnabled = true;
            this.cbDependentes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5 ou mais"});
            this.cbDependentes.Location = new System.Drawing.Point(2, 84);
            this.cbDependentes.Name = "cbDependentes";
            this.cbDependentes.Size = new System.Drawing.Size(199, 23);
            this.cbDependentes.TabIndex = 0;
            this.cbDependentes.SelectedIndexChanged += new System.EventHandler(this.cbDependentes_SelectedIndexChanged);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Location = new System.Drawing.Point(2, 31);
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(199, 23);
            this.txtSalarioBruto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salário Bruto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Dependentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salário Final:";
            // 
            // txtSalarioFinal
            // 
            this.txtSalarioFinal.Location = new System.Drawing.Point(3, 143);
            this.txtSalarioFinal.Name = "txtSalarioFinal";
            this.txtSalarioFinal.ReadOnly = true;
            this.txtSalarioFinal.Size = new System.Drawing.Size(199, 23);
            this.txtSalarioFinal.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalarioFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.cbDependentes);
            this.Name = "Form1";
            this.Text = "Calculo abono salarial:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDependentes;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalarioFinal;
    }
}

