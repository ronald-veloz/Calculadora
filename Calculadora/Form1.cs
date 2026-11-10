using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función auxiliar para leer y validar los números
        private bool ObtenerValores(out double n1, out double n2)
        {
            n1 = 0;
            n2 = 0;

            if (double.TryParse(txtNum1.Text, out n1) && double.TryParse(txtNum2.Text, out n2))
            {
                return true;
            }

            MessageBox.Show("Por favor, ingresa números válidos.", "Error de entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return false;
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                txtResultado.Text = (n1 + n2).ToString();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                txtResultado.Text = (n1 - n2).ToString();
            }
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                txtResultado.Text = (n1 * n2).ToString();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "Error";
                }
                else
                {
                    txtResultado.Text = (n1 / n2).ToString();
                }
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (ObtenerValores(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede calcular el módulo entre cero.", "Error matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "Error";
                }
                else
                {
                    txtResultado.Text = (n1 % n2).ToString();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
            txtNum1.Focus();
        }
    }
}