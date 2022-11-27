
namespace aula9_ex4
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
            this.txtBits = new System.Windows.Forms.TextBox();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKbytes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTerabytes = new System.Windows.Forms.TextBox();
            this.texto = new System.Windows.Forms.Label();
            this.txtMegabytes = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nº Bits:";
            // 
            // txtBits
            // 
            this.txtBits.Location = new System.Drawing.Point(91, 12);
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(148, 23);
            this.txtBits.TabIndex = 1;
            // 
            // txtBytes
            // 
            this.txtBytes.Location = new System.Drawing.Point(91, 72);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.ReadOnly = true;
            this.txtBytes.Size = new System.Drawing.Size(148, 23);
            this.txtBytes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultados em:";
            // 
            // txtKbytes
            // 
            this.txtKbytes.Location = new System.Drawing.Point(91, 102);
            this.txtKbytes.Name = "txtKbytes";
            this.txtKbytes.ReadOnly = true;
            this.txtKbytes.Size = new System.Drawing.Size(148, 23);
            this.txtKbytes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "KBYTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "BYTES:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "MEGABYTES:";
            // 
            // txtTerabytes
            // 
            this.txtTerabytes.Location = new System.Drawing.Point(91, 164);
            this.txtTerabytes.Name = "txtTerabytes";
            this.txtTerabytes.ReadOnly = true;
            this.txtTerabytes.Size = new System.Drawing.Size(148, 23);
            this.txtTerabytes.TabIndex = 9;
            // 
            // texto
            // 
            this.texto.AutoSize = true;
            this.texto.Location = new System.Drawing.Point(12, 172);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(71, 15);
            this.texto.TabIndex = 8;
            this.texto.Text = "TERABYTES:";
            // 
            // txtMegabytes
            // 
            this.txtMegabytes.Location = new System.Drawing.Point(91, 134);
            this.txtMegabytes.Name = "txtMegabytes";
            this.txtMegabytes.ReadOnly = true;
            this.txtMegabytes.Size = new System.Drawing.Size(148, 23);
            this.txtMegabytes.TabIndex = 7;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(105, 41);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(134, 23);
            this.btnConverter.TabIndex = 11;
            this.btnConverter.Text = "Converter:";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 211);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTerabytes);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.txtMegabytes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKbytes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBits);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKbytes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTerabytes;
        private System.Windows.Forms.Label texto;
        private System.Windows.Forms.TextBox txtMegabytes;
        private System.Windows.Forms.Button btnConverter;
    }
}

