namespace Lista_Estudo_4
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtBits = new System.Windows.Forms.TextBox();
            this.txtBytes = new System.Windows.Forms.TextBox();
            this.txtKbytes = new System.Windows.Forms.TextBox();
            this.txtMegabytes = new System.Windows.Forms.TextBox();
            this.txtTerabytes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bytes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "KBytes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Megabytes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Terabytes";
            // 
            // txtBits
            // 
            this.txtBits.Location = new System.Drawing.Point(114, 12);
            this.txtBits.Name = "txtBits";
            this.txtBits.Size = new System.Drawing.Size(100, 20);
            this.txtBits.TabIndex = 5;
            this.txtBits.TextChanged += new System.EventHandler(this.txtBits_TextChanged);
            // 
            // txtBytes
            // 
            this.txtBytes.Location = new System.Drawing.Point(114, 50);
            this.txtBytes.Name = "txtBytes";
            this.txtBytes.ReadOnly = true;
            this.txtBytes.Size = new System.Drawing.Size(100, 20);
            this.txtBytes.TabIndex = 6;
            // 
            // txtKbytes
            // 
            this.txtKbytes.Location = new System.Drawing.Point(114, 82);
            this.txtKbytes.Name = "txtKbytes";
            this.txtKbytes.ReadOnly = true;
            this.txtKbytes.Size = new System.Drawing.Size(100, 20);
            this.txtKbytes.TabIndex = 7;
            // 
            // txtMegabytes
            // 
            this.txtMegabytes.Location = new System.Drawing.Point(114, 112);
            this.txtMegabytes.Name = "txtMegabytes";
            this.txtMegabytes.ReadOnly = true;
            this.txtMegabytes.Size = new System.Drawing.Size(100, 20);
            this.txtMegabytes.TabIndex = 8;
            // 
            // txtTerabytes
            // 
            this.txtTerabytes.Location = new System.Drawing.Point(114, 145);
            this.txtTerabytes.Name = "txtTerabytes";
            this.txtTerabytes.ReadOnly = true;
            this.txtTerabytes.Size = new System.Drawing.Size(100, 20);
            this.txtTerabytes.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 177);
            this.Controls.Add(this.txtTerabytes);
            this.Controls.Add(this.txtMegabytes);
            this.Controls.Add(this.txtKbytes);
            this.Controls.Add(this.txtBytes);
            this.Controls.Add(this.txtBits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ex4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBits;
        private System.Windows.Forms.TextBox txtBytes;
        private System.Windows.Forms.TextBox txtKbytes;
        private System.Windows.Forms.TextBox txtMegabytes;
        private System.Windows.Forms.TextBox txtTerabytes;
    }
}

