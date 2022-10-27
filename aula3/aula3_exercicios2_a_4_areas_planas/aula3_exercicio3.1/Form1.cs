using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula3_exercicio3._1
{
    public partial class calc1 : Form
    {
        public calc1()
        {
            InitializeComponent();
        }

        private void btnCalculaAreaRetangulo_Click(object sender, EventArgs e)
        {
            double baseRetangulo = Convert.ToDouble(txtBaseRetangulo.Text);
            double alturaRetangulo = Convert.ToDouble(txtAlturaRetangulo.Text);
            double area = baseRetangulo * alturaRetangulo;
            txtResultadoRetangulo.Text = area.ToString();


        }

        private void btnCalculaAreaQuadrado_Click(object sender, EventArgs e)
        {
            double lado = Convert.ToDouble(txtLadoQuadrado.Text);
            double area = lado * lado;
            txtResultadoQuadrado.Text = area.ToString();
        }

        private void btnCalculaAreaTriangulo_Click(object sender, EventArgs e)
        {
            double baseTriangulo = Convert.ToDouble(txtBaseTriangulo.Text);
            double altura = Convert.ToDouble(txtAlturaTriangulo.Text);
            double area = (baseTriangulo * altura) / 2;
            txtResultadoTriangulo.Text = area.ToString();

        }
    }
}
