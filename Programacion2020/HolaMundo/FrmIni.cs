using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class FrmIni : Form
    {
        public FrmIni()
        {
            InitializeComponent();
        }

        private void btsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btini_Click(object sender, EventArgs e)
        {
            lbnombre.Text = "Hola Leann, cómo estas hoy?";
        }

        private void btreestablecer_Click(object sender, EventArgs e)
        {
            lbnombre.Text = ">>> Click en comenzar <<<";
        }

        private void btClick_Click(object sender, EventArgs e)
        {
            if (Txingresar.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                string nombre;
                nombre = Txingresar.Text;
                //lbRes.Text = Txingresar.Text + "Hola " + nombre + " " + " Cómo estas hoy? ";
                lbRes.Text = "Hola" + " " + nombre.ToString() + "," + " " + "cómo estás hoy?";
            }
        }

        private void btlimpiar_Click(object sender, EventArgs e)
        {
            Txingresar.Text = "";
        }
    }
}
