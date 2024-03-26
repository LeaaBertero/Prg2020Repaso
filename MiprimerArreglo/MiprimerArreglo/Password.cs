using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiprimerArreglo
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txClave.Text == "ingresar")
            {
                Form primerArreglo = new PrimerArreglo();
                primerArreglo.Show();
            }
            else if (txClave.Text == "")
            {
                MessageBox.Show("ingrese la contraseña");
            }
            else
            {
                MessageBox.Show("Clave incorrecta");
            }
        }
    }
}
