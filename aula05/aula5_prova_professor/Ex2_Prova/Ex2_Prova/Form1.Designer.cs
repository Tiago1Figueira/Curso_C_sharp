namespace Ex2_Prova
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
            this.txtNomeTimeA = new System.Windows.Forms.TextBox();
            this.txtNomeTimeB = new System.Windows.Forms.TextBox();
            this.txtGolsTimeA = new System.Windows.Forms.TextBox();
            this.txtGolsTimeB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnQuemGanhou = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Time B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gols Time A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gols Time B";
            // 
            // txtNomeTimeA
            // 
            this.txtNomeTimeA.Location = new System.Drawing.Point(90, 9);
            this.txtNomeTimeA.Name = "txtNomeTimeA";
            this.txtNomeTimeA.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTimeA.TabIndex = 4;
            // 
            // txtNomeTimeB
            // 
            this.txtNomeTimeB.Location = new System.Drawing.Point(216, 9);
            this.txtNomeTimeB.Name = "txtNomeTimeB";
            this.txtNomeTimeB.Size = new System.Drawing.Size(100, 20);
            this.txtNomeTimeB.TabIndex = 5;
            // 
            // txtGolsTimeA
            // 
            this.txtGolsTimeA.Location = new System.Drawing.Point(90, 35);
            this.txtGolsTimeA.Name = "txtGolsTimeA";
            this.txtGolsTimeA.Size = new System.Drawing.Size(100, 20);
            this.txtGolsTimeA.TabIndex = 6;
            // 
            // txtGolsTimeB
            // 
            this.txtGolsTimeB.Location = new System.Drawing.Point(216, 35);
            this.txtGolsTimeB.Name = "txtGolsTimeB";
            this.txtGolsTimeB.Size = new System.Drawing.Size(100, 20);
            this.txtGolsTimeB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(196, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "X";
            // 
            // btnQuemGanhou
            // 
            this.btnQuemGanhou.Location = new System.Drawing.Point(163, 70);
            this.btnQuemGanhou.Name = "btnQuemGanhou";
            this.btnQuemGanhou.Size = new System.Drawing.Size(75, 23);
            this.btnQuemGanhou.TabIndex = 10;
            this.btnQuemGanhou.Text = "Vencedor";
            this.btnQuemGanhou.UseVisualStyleBackColor = true;
            this.btnQuemGanhou.Click += new System.EventHandler(this.btnQuemGanhou_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 105);
            this.Controls.Add(this.btnQuemGanhou);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGolsTimeB);
            this.Controls.Add(this.txtGolsTimeA);
            this.Controls.Add(this.txtNomeTimeB);
            this.Controls.Add(this.txtNomeTimeA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Placar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeTimeA;
        private System.Windows.Forms.TextBox txtNomeTimeB;
        private System.Windows.Forms.TextBox txtGolsTimeA;
        private System.Windows.Forms.TextBox txtGolsTimeB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnQuemGanhou;
    }
}

