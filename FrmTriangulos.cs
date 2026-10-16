using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulos
{
    public partial class FrmTriangulos : Form
    {
        public FrmTriangulos()
        {
            InitializeComponent();
        }

        private void FrmTriangulos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nud3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nud1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnlDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // declarar a variavel e passar o valor dela 
            decimal lado1 = nudlado1.Value;
            decimal lado2 = nudlado2.Value;
            decimal lado3 = nudlado3.Value;
            // fazer um if paara verificar o tipo de triangulo
            // o teste lógico do if tem que ficar entre ( )
            // == igualdade != diferente  >= <= > <
            // quando for mais de teste precisamos usar o && ou o ||
            // && = e
            // || = ou 
            if (lado1 == lado2 && lado2 == lado3)
            {
               btnVerificar.Text = "Equalatero";
            }

            else if (lado1 == lado2 && lado2 == lado3)
            {
                btnVerificar.Text = "Escaleno";  
            }
            else
            {
                btnVerificar.Text = "Isosceles";  
            }

        }
    }
}
