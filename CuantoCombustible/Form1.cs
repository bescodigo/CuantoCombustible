using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuantoCombustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Logica operacion = new Logica();


            operacion.Verificar(Convert.ToDouble(txtPrecioCombustible.Text), Convert.ToDouble(txtDistanciaKilometros.Text));


            txtConsumoCombustible.Text = operacion.calculo.combustibleTotal.ToString();
            txtTotal.Text = operacion.calculo.precioTotal.ToString();

        }
    }
}
