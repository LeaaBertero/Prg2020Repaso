using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV2
{
    public partial class calculadoraV2 : Form
    {
        public calculadoraV2()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            Form suma = new Suma();
            suma.Show();
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            Form resta = new Resta();
            resta.Show();
        }

        private void btmult_Click(object sender, EventArgs e)
        {
            Form multiplicacion = new multiplicacion();
            multiplicacion.Show();
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            Form division = new division();
            division.Show();
        }
    }
}
