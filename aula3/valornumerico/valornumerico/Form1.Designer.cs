
namespace valornumerico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntprocessar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdobro = new System.Windows.Forms.TextBox();
            this.txtposterior = new System.Windows.Forms.TextBox();
            this.txtanterior = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt50 = new System.Windows.Forms.TextBox();
            this.txt25 = new System.Windows.Forms.TextBox();
            this.txttriplo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt100 = new System.Windows.Forms.TextBox();
            this.txt150 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt150);
            this.groupBox1.Controls.Add(this.txt100);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txt50);
            this.groupBox1.Controls.Add(this.txt25);
            this.groupBox1.Controls.Add(this.txttriplo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bntprocessar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtanterior);
            this.groupBox1.Controls.Add(this.txtposterior);
            this.groupBox1.Controls.Add(this.txtdobro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 375);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CALCULAR NÚMERO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(74, 34);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(183, 23);
            this.txtnumero.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Anterior";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bntprocessar
            // 
            this.bntprocessar.Location = new System.Drawing.Point(74, 63);
            this.bntprocessar.Name = "bntprocessar";
            this.bntprocessar.Size = new System.Drawing.Size(183, 23);
            this.bntprocessar.TabIndex = 6;
            this.bntprocessar.Text = "Processar";
            this.bntprocessar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Triplo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dobro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Posterior";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtdobro
            // 
            this.txtdobro.Location = new System.Drawing.Point(74, 158);
            this.txtdobro.Name = "txtdobro";
            this.txtdobro.ReadOnly = true;
            this.txtdobro.Size = new System.Drawing.Size(186, 23);
            this.txtdobro.TabIndex = 9;
            // 
            // txtposterior
            // 
            this.txtposterior.Location = new System.Drawing.Point(74, 125);
            this.txtposterior.Name = "txtposterior";
            this.txtposterior.ReadOnly = true;
            this.txtposterior.Size = new System.Drawing.Size(186, 23);
            this.txtposterior.TabIndex = 10;
            // 
            // txtanterior
            // 
            this.txtanterior.Location = new System.Drawing.Point(74, 95);
            this.txtanterior.Name = "txtanterior";
            this.txtanterior.ReadOnly = true;
            this.txtanterior.Size = new System.Drawing.Size(186, 23);
            this.txtanterior.TabIndex = 11;
            this.txtanterior.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "50%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "25%";
            // 
            // txt50
            // 
            this.txt50.Location = new System.Drawing.Point(74, 252);
            this.txt50.Name = "txt50";
            this.txt50.ReadOnly = true;
            this.txt50.Size = new System.Drawing.Size(186, 23);
            this.txt50.TabIndex = 15;
            this.txt50.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt25
            // 
            this.txt25.Location = new System.Drawing.Point(74, 222);
            this.txt25.Name = "txt25";
            this.txt25.ReadOnly = true;
            this.txt25.Size = new System.Drawing.Size(186, 23);
            this.txt25.TabIndex = 16;
            // 
            // txttriplo
            // 
            this.txttriplo.Location = new System.Drawing.Point(74, 191);
            this.txttriplo.Name = "txttriplo";
            this.txttriplo.ReadOnly = true;
            this.txttriplo.Size = new System.Drawing.Size(186, 23);
            this.txttriplo.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 341);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "150%";
            // 
            // txt100
            // 
            this.txt100.Location = new System.Drawing.Point(74, 288);
            this.txt100.Name = "txt100";
            this.txt100.ReadOnly = true;
            this.txt100.Size = new System.Drawing.Size(186, 23);
            this.txt100.TabIndex = 19;
            // 
            // txt150
            // 
            this.txt150.Location = new System.Drawing.Point(74, 333);
            this.txt150.Name = "txt150";
            this.txt150.ReadOnly = true;
            this.txt150.Size = new System.Drawing.Size(186, 23);
            this.txt150.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 483);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cálculo de valores numéricos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntprocessar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtanterior;
        private System.Windows.Forms.TextBox txtposterior;
        private System.Windows.Forms.TextBox txtdobro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt50;
        private System.Windows.Forms.TextBox txt25;
        private System.Windows.Forms.TextBox txttriplo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt150;
        private System.Windows.Forms.TextBox txt100;
        private System.Windows.Forms.Label label9;
    }
}

