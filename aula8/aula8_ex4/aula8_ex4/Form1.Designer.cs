
namespace aula8_ex4
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
            this.grpTempInicial = new System.Windows.Forms.ComboBox();
            this.grpTemFinal = new System.Windows.Forms.ComboBox();
            this.txtTempInicial = new System.Windows.Forms.TextBox();
            this.txtTempFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // grpTempInicial
            // 
            this.grpTempInicial.FormattingEnabled = true;
            this.grpTempInicial.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.grpTempInicial.Location = new System.Drawing.Point(202, 12);
            this.grpTempInicial.Name = "grpTempInicial";
            this.grpTempInicial.Size = new System.Drawing.Size(132, 23);
            this.grpTempInicial.TabIndex = 0;
            this.grpTempInicial.SelectedIndexChanged += new System.EventHandler(this.grpTempInicial_SelectedIndexChanged);
            // 
            // grpTemFinal
            // 
            this.grpTemFinal.FormattingEnabled = true;
            this.grpTemFinal.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.grpTemFinal.Location = new System.Drawing.Point(202, 56);
            this.grpTemFinal.Name = "grpTemFinal";
            this.grpTemFinal.Size = new System.Drawing.Size(132, 23);
            this.grpTemFinal.TabIndex = 1;
            // 
            // txtTempInicial
            // 
            this.txtTempInicial.Location = new System.Drawing.Point(87, 12);
            this.txtTempInicial.Name = "txtTempInicial";
            this.txtTempInicial.Size = new System.Drawing.Size(109, 23);
            this.txtTempInicial.TabIndex = 2;
            // 
            // txtTempFinal
            // 
            this.txtTempFinal.Location = new System.Drawing.Point(87, 56);
            this.txtTempFinal.Name = "txtTempFinal";
            this.txtTempFinal.Size = new System.Drawing.Size(109, 23);
            this.txtTempFinal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Temp. Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Temp. Final";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 100);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempFinal);
            this.Controls.Add(this.txtTempInicial);
            this.Controls.Add(this.grpTemFinal);
            this.Controls.Add(this.grpTempInicial);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox grpTempInicial;
        private System.Windows.Forms.ComboBox grpTemFinal;
        private System.Windows.Forms.TextBox txtTempInicial;
        private System.Windows.Forms.TextBox txtTempFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

