namespace MudarCor
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
            this.cbCores = new System.Windows.Forms.ComboBox();
            this.btnMudar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbCores
            // 
            this.cbCores.FormattingEnabled = true;
            this.cbCores.Items.AddRange(new object[] {
            "Azul",
            "Amarelo",
            "Vermelho",
            "Verde",
            "Branco"});
            this.cbCores.Location = new System.Drawing.Point(12, 12);
            this.cbCores.Name = "cbCores";
            this.cbCores.Size = new System.Drawing.Size(121, 21);
            this.cbCores.TabIndex = 0;
            this.cbCores.SelectedIndexChanged += new System.EventHandler(this.cbCores_SelectedIndexChanged);
            // 
            // btnMudar
            // 
            this.btnMudar.Location = new System.Drawing.Point(139, 10);
            this.btnMudar.Name = "btnMudar";
            this.btnMudar.Size = new System.Drawing.Size(75, 23);
            this.btnMudar.TabIndex = 2;
            this.btnMudar.Text = "Reset";
            this.btnMudar.UseVisualStyleBackColor = true;
            this.btnMudar.Click += new System.EventHandler(this.btnMudar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 150);
            this.Controls.Add(this.btnMudar);
            this.Controls.Add(this.cbCores);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCores;
        private System.Windows.Forms.Button btnMudar;
    }
}

