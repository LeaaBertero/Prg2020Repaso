using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borrarRepaso
{
    public partial class pruebaBorrar : Form
    {

        string[] nombres;
        int posicion;

        public pruebaBorrar()
        {
            InitializeComponent();
        }

        private void btdimensionar_Click(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(txDimensionar.Text);
            nombres = new string[cantidad];
        }

        private void btcargar_Click(object sender, EventArgs e)
        {
            nombres[posicion] = txcargar.Text;
            posicion = posicion + 1;
            txcargar.Focus();
            txcargar.SelectAll();
        }

        private void btmostrar_Click(object sender, EventArgs e)
        {
            foreach (string contador in nombres)
            {
                lbresultado.Text = lbresultado.Text + contador + "\r\n";
            }


        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
